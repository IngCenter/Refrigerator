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
    public partial class Просрочка : Form
    {
        public Просрочка()
        {
            InitializeComponent();

            
            int y = 100;
            foreach (Product product in Main.ProductList)
            {
                Label lbl = new Label();
                lbl.Location = new Point(100, y);
                lbl.Text = product.Name;
                Controls.Add(lbl);

                Label lbl2 = new Label();
                lbl2.Location = new Point(250, y);
                lbl2.Text = product.Count.ToString();
                Controls.Add(lbl2);

                y = y + 35;
            }
            
        }

        private void Просрочка_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
