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
    public partial class AddProducts : Form
    {
        public AddProducts()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int y = 0;

        private void AddLine_Click(object sender, EventArgs e)
        {
            y += 45;

            ComboBox comboBox = new ComboBox
            {
                Location = new Point(units.Location.X, y),
                Size = units.Size,
                Font = units.Font
            };

            NumericUpDown num = new NumericUpDown
            {
                Location = new Point(countNum.Location.X, y),
                Size = countNum.Size,
                Font = countNum.Font
            };

            TextBox tb = new TextBox
            {
                Location = new Point(addTextBox.Location.X, y),
                Size = addTextBox.Size,
                Font = addTextBox.Font
            };

            mainPanel.Controls.AddRange(new Control[3] { comboBox, num, tb });
        }

        private void AddAll_Click(object sender, EventArgs e)
        {
            /*List<string> mass = new List<string>();

            foreach (Control control in mainPanel.Controls)
            {
                if (control is TextBox)
                    mass.Add(control.Text);
            }

            Program.Insert("INSERT INTO 'Products' ('Name', 'DateBegin', 'LifeTime', 'Unit', 'Count') " +
                "VALUES (" + );*/
        }
    }
}
