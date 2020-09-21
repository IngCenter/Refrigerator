using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fridgerator
{
    public partial class Main : Form
    {
        public static List<Product> product_list = new List<Product>();

        public Main()
        {
            InitializeComponent();
        }

        private void Главная_Load(object sender, EventArgs e)
        {

        }

        private void CountButton_Click(object sender, EventArgs e)
        {
            int count = 0;

            foreach (var product in product_list)
                count += product.count;

            MessageBox.Show("Количество: " + count, "Количество продуктов");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Просрочка f = new Просрочка();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (product_list.Count == 0)
            {
                MessageBox.Show("НАКОРМИ МЕНЯ", "ХАЧУ ЖАРАТЬ");

                return;
            }

            Содержимое f = new Содержимое();
            f.ShowDialog();
        }

        private void Fridge_Click(object sender, EventArgs e)
        {
            Техсост f = new Техсост();
            f.ShowDialog();
        }

        private void AddProducts_Click(object sender, EventArgs e)
        {
            AddProducts f = new AddProducts();
            f.ShowDialog();
        }

        private void CookingRecipes_Click(object sender, EventArgs e)
        {
            CookingRecipes f = new CookingRecipes();
            f.ShowDialog();
        }
    }

    public struct Product
    {
        public string name;
        public string category;
        public int count;
        public DateTime dateBegin;
        public DateTime dateEnd;

        public Product(string _name, string _category, int _count)
        {
            name = _name;
            category = _category;
            count = _count;
            dateBegin = DateTime.Now;
            dateEnd = dateBegin.AddDays(2);
        }

        public DateTime TimeToDie()
        {
            return DateTime.FromBinary(dateEnd.ToBinary() - dateBegin.ToBinary());
        }
    }
}
