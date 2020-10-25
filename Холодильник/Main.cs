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

            for (int i = 0; i < products.Count; i += 5)
                ProductList.Add(new Product(products[i], DateTime.Parse(products[i + 1]), int.Parse(products[i + 2]), products[i + 3], int.Parse(products[i + 4])));

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
            CookingRecipes f = new CookingRecipes();
            f.ShowDialog();
        }        
    }

    public struct Product
    {
        public string Name;
        public DateTime DateBegin;
        public int LifeTime;
        public string Unit;
        public int Count;

        public Product(string name, DateTime dateBegin, int lifeTime, string unit, int count)
        {
            Name = name;
            DateBegin = dateBegin;
            LifeTime = lifeTime;
            Unit = unit;
            Count = count;
        }
    }
}
