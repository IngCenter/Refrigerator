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

            for (int i = 0; i < products.Count; i += 6)
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

        private void DeadProducts_Click(object sender, EventArgs e)
        {
            DeadProducts f = new DeadProducts();
            f.ShowDialog();
        }

        private void Contents_Click(object sender, EventArgs e)
        {
            if (ProductList.Count == 0)
            {
                MessageBox.Show("НАКОРМИ МЕНЯ", "ХАЧУ ЖАРАТЬ");

                return;
            }

            Contents f = new Contents();
            f.ShowDialog();
        }

        private void Fridge_Click(object sender, EventArgs e)
        {
            Condition f = new Condition();
            f.ShowDialog();
        }

        private void AddProducts_Click(object sender, EventArgs e)
        {
            AddProducts f = new AddProducts();
            f.ShowDialog();
        }

        private void CookingRecipes_Click(object sender, EventArgs e)
        {
            Recipe f = new Recipe();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Coments coments = new Coments();
            coments.ShowDialog();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
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
