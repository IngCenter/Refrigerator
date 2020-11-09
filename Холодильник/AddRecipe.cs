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

        private void AddRecipeButton_Click(object sender, EventArgs e)
        {
            Program.Insert("INSERT INTO `Recipes` (`OutName`,Description,Script) VALUES ('" + textBox1.Text + "','"+ textBox2.Text + "','" + textBox3.Text + "')");
            //Program.Insert("INSERT INTO `RecipesContents` (``, ``)");
            MessageBox.Show("Сохранено");
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            Button button = new Button
            {
                Size = delete.Size,
                Font = delete.Font,
                Text = delete.Text,
                ForeColor = delete.ForeColor,
                BackColor = delete.BackColor,
                FlatStyle = delete.FlatStyle
            };

            ComboBox comboBox = new ComboBox
            {
                Size = units.Size,
                Font = units.Font,
                Text = units.Text,
                Tag = "units"
            };

            NumericUpDown num = new NumericUpDown
            {
                Size = countNum.Size,
                Font = countNum.Font,
                Tag = "conut"
            };

            TextBox typeTb = new TextBox
            {
                Size = typeTextBox.Size,
                Font = typeTextBox.Font,
                Text = typeTextBox.Text,
                Tag = "type"
            };

            flowLayoutPanel1.Controls.AddRange(new Control[4] { button, typeTb, num, comboBox });
        }
    }
}
