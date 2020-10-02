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

        private void Главная_Load(object sender, EventArgs e)
        {
            //LoadSave();
        }
        
        private void LoadSave()
        {
            string[] lines = File.ReadAllLines("Save.txt");

            foreach(string line in lines)
            {
                string[] product = line.Split(new string[1] { ", " }, StringSplitOptions.None);
                ProductList.Add(new Product(product[0], product[1], int.Parse(product[2]), DateTime.Parse(product[3])));
            }
        }

        private void SaveSave()
        {
            List<string> lines = new List<string>();

            foreach (Product product in ProductList)
                lines.Add(product.Name + ", " + product.Category + ", " + product.Count + ", " + product.DateBegin.ToString("d"));

            File.WriteAllLines("Save.txt", lines);
        }

        private void CountButton_Click(object sender, EventArgs e)
        {
            int count = 0;

            foreach (var product in ProductList)
                count += product.Count;

            MessageBox.Show("Количество: " + count, "Количество продуктов");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Просрочка f = new Просрочка();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ProductList.Count == 0)
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

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            //SaveSave();
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
