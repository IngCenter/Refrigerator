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
    public partial class AddRecipe : Form
    {
        public AddRecipe()
        {
            InitializeComponent();
        }

        private void AddRecipe_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Insert("INSERT INTO `Recipes` (`OutName`,Description,Script) VALUES ('" + textBox1.Text + "','"+ textBox2.Text + "','" + textBox3.Text + "')");
            MessageBox.Show("Сохранено");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
