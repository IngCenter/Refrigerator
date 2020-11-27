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
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text + textBox3.Text))
            {
                MessageBox.Show("Не оставляйте пустые поля!");
                return;
            }

            foreach (Control control0 in flowLayoutPanel1.Controls)
            {
                if (control0 is Button)
                {
                    if (control0.Text == "Тип" || string.IsNullOrWhiteSpace(control0.Text))
                        continue;

                    string type = "", count = "", unit = "";

                    foreach (Control control in flowLayoutPanel1.Controls)
                    {
                        if (control.Location.Y == control0.Location.Y && control.Tag != null)
                        {
                            switch (control.Tag.ToString())
                            {
                                case "type":
                                    type = control.Text;
                                    break;

                                case "count":
                                    count = ((NumericUpDown)control).Value.ToString();
                                    break;

                                case "unit":
                                    unit = control.Text;
                                    break;
                            }
                        }
                    }

                    Program.Insert("INSERT INTO RecipesContents (Name, Type, Count, Unit) " +
                                   $"VALUES ('{textBox1.Text}', '{type}', '{count}', '{unit}')");
                }
            }

            Program.Insert("INSERT INTO `Recipes` (`OutName`,Description,Script) VALUES ('" + textBox1.Text + "','"+ textBox2.Text + "','" + textBox3.Text + "')");

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
                FlatStyle = delete.FlatStyle,
            };

            button.Click += Delete_Click;

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

        private void Delete_Click(object sender, EventArgs e)
        {
            Control deleteButton = sender as Control;

            List<Control> controlsToDelete = new List<Control>
            {
                deleteButton
            };

            foreach (Control control1 in flowLayoutPanel1.Controls)
                if (control1 != deleteButton && control1.Location.Y == deleteButton.Location.Y)
                    controlsToDelete.Add(control1);

            foreach (var delete in controlsToDelete)
                flowLayoutPanel1.Controls.Remove(delete);
        }
    }
}
