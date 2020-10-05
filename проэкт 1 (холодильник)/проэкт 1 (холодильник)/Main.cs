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
            InitializeComponent();

            // Connection String.
            string connString = "Server=VH287.spaceweb.ru;" +
                ";Database= beavisabra_holod" +
                ";port=3306;User Id=beavisabra_holod;password=Beavis1989";

            MySqlConnection conn = new MySqlConnection(connString);

            conn.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Product", conn);

            DbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ProductList.Add(new Product(reader.GetString(0), reader.GetString(1), reader.GetInt32(3), reader.GetDateTime(2)));
            }

            conn.Close();
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
        public string Category;
        public int Count;
        public DateTime DateBegin;
        public DateTime DateEnd;

        public Product(string name, string category, int count, DateTime dateBegin)
        {
            Name = name;
            Category = category;
            Count = count;
            DateBegin = dateBegin;
            DateEnd = DateBegin.AddDays(2);
        }

        public DateTime TimeToDie()
        {
            return DateTime.FromBinary(DateEnd.ToBinary() - DateBegin.ToBinary());
        }
    }
}
