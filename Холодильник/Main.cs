using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Fridgerator
{
    public partial class Main : Form
    {
        public static List<Product> ProductList = new List<Product>();

        public Main()
        {            
            List<string> products = Program.Select("SELECT * FROM Products");

            for (int i = 0; i < products.Count; i += 7)
                ProductList.Add(new Product(products[i], DateTime.Parse(products[i + 1]), int.Parse(products[i + 2]), products[i + 3], int.Parse(products[i + 4]), products[i + 5]));

            InitializeComponent();
        }

        private void CountButton_Click(object sender, EventArgs e)
        {
            int count = 0;

            foreach (var product in ProductList)
                count += product.Count;

            MessageBox.Show("Количество: " + count, "Количество продуктов");
        }

        private void Contents_Click(object sender, EventArgs e)
        {
            if (ProductList.Count == 0)
            {
                MessageBox.Show("НАКОРМИ МЕНЯ", "ХАЧУ ЖАРАТЬ");

                return;
            }

            Contents f = new Contents();
           
            panel1.Controls.Clear();
            panel1.Controls.Add(f);
        }

        private void Fridge_Click(object sender, EventArgs e)
        {
            Condition f = new Condition();

            panel1.Controls.Clear();
            panel1.Controls.Add(f);
        }

        private void AddProducts_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VisualComents coments = new VisualComents();

            panel1.Controls.Clear();
            panel1.Controls.Add(coments);
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminServices admin = new AdminServices();

            panel1.Controls.Clear();
            panel1.Controls.Add(admin);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Autarization autarization = new Autarization();

            panel1.Controls.Clear();
            panel1.Controls.Add(autarization);
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UserControl rf = new UserControl();

            if (e.Node.Text == "Коментарии")
                rf = new VisualComents();
            else if (e.Node.Text == "Админка")
                rf = new AdminServices();
            else if (e.Node.Text == "Авторизация")
                rf = new Autarization();
            else if (e.Node.Text == "Тех. обслуживание")
                rf = new Condition();
            else if (e.Node.Text == "Содержимое")
                rf = new Contents();
            else if (e.Node.Text == "Добавить продукты")
                rf = new AddProducts();
            else if (e.Node.Text == "Приготовить что-то")
                rf = new Recipe();
            else if (e.Node.Text == "Магазин")
                rf = new Magaz();




            panel1.Controls.Clear();
            panel1.Controls.Add(rf);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

    public struct Product
    {
        public string Name;
        public DateTime DateBegin;
        public int LifeTime;
        public string Unit;
        public int Count;
        public string Type;

        public Product(string name, DateTime dateBegin, int lifeTime, string unit, int count, string type)
        {
            Name = name;
            DateBegin = dateBegin;
            LifeTime = lifeTime;
            Unit = unit;
            Count = count;
            Type = type;
        }
    }
}
