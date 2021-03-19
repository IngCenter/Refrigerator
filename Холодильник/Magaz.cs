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
    public partial class Magaz : UserControl
    {
        public Magaz()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Details f = new Details("Датчики");
            panel1.Controls.Clear();
            panel1.Controls.Add(f);
        }

        private void Magaz_Load(object sender, EventArgs e)
        {

        }


        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            UserControl rf = new Details(e.Node.Text);


            panel1.Controls.Clear();
            panel1.Controls.Add(rf);
        }

        private void HolodilnikiButton_Click(object sender, EventArgs e)
        {
            string category = ((Label)sender).Text;

            panel1.Controls.Clear();
            List<string> Details = Program.Select(
                "SELECT Name, Description FROM Details" +
                " WHERE category ='" + category + "'");
            for (int i = 0; i < Details.Count; i += 2)
            {
                Label labelname = new Label();
                labelname.Location = new Point(100 * i, 0);
                labelname.Size = new Size(180, 40);
                labelname.Margin = new Padding(4, 0, 4, 0);
                labelname.TextAlign = ContentAlignment.MiddleCenter;
                labelname.Text = Details[i];

                panel1.Controls.Add(labelname);

                Label labelDiscription = new Label();
                labelDiscription.Location = new Point(100 * i, 40);
                labelDiscription.Size = new Size(180,180);
                labelDiscription.Margin = new Padding(4, 0, 4, 0);
                labelDiscription.TextAlign = ContentAlignment.MiddleCenter;
                labelDiscription.Text = Details[i + 1];

                panel1.Controls.Add(labelDiscription);
            }

        }

    }
}
