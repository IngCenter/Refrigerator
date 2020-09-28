using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace проэкт_1__холодильник_
{

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
            return
            DateTime.FromBinary(dateEnd.ToBinary() - dateBegin.ToBinary());
        }
    }


    public partial class Главная : Form
    {

        public static List<Product> product_list = new List<Product>();

        public Главная()
        {
            product_list.Add(new Product("Лимонный сок", "Напитки", 1));
            product_list.Add(new Product("Сырокопченая колбаса", "Колбаса", 2));
            product_list.Add(new Product("Сырки ЧУДО", "Глазированные сырки", 7));
            product_list.Add(new Product("Спрайт", "Напитки", 2));
            product_list.Add(new Product("Крабовые палочки", "Морепродукты", 5));
            product_list.Add(new Product("Яйца", "Яйца", 10));
            product_list.Add(new Product("Грудка из курицы", "Мясо", 1));
            product_list.Add(new Product("Фарш из свинины", "Мясо", 2));
            product_list.Add(new Product("Фарш из говядины", "Мясо", 1));
            product_list.Add(new Product("Бекон/полоска", "Мясо", 5));

            InitializeComponent();
        }

        private void Главная_Load(object sender, EventArgs e)

        { }

        private void button2_Click(object sender, EventArgs e)
        {
            Колличество f = new Колличество();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Просрочка f = new Просрочка();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Содержимое f = new Содержимое();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Техсост f = new Техсост();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Что_я_приготовил f = new Что_я_приготовил();
            f.ShowDialog();
        }
    }
}
