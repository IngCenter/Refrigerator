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
    public partial class DeadProducts : Form
    {
        public DeadProducts()
        {
            int y = 100;

            foreach (Product product in Main.ProductList)
            {
                Label nameLabel = new Label
                {
                    Location = new Point(100, y),
                    Text = product.Name
                };
                
                Label countLabel = new Label
                {
                    Location = new Point(250, y),
                    Text = product.Count.ToString()
                };

                Controls.Add(nameLabel);
                Controls.Add(countLabel);

                y += 35;
            }

            InitializeComponent();
        }
    }
}
