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


        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vstavni f = new Vstavni();
            panel1.Controls.Clear();
            panel1.Controls.Add(f);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Kabelya f = new Kabelya();
            panel1.Controls.Clear();
            panel1.Controls.Add(f);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Systemohlad f = new Systemohlad();
            panel1.Controls.Clear();
            panel1.Controls.Add(f);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Datchicki f = new Datchicki();

            panel1.Controls.Clear();
            panel1.Controls.Add(f);
        }

        private void Magaz_Load(object sender, EventArgs e)
        {

        }


        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            UserControl rf = new UserControl();

            if (e.Node.Text == "Холодильники")
                rf = new Holodilnyki();
            else if (e.Node.Text == "Вставни")
                rf = new Vstavni();
            else if (e.Node.Text == "Кабеля")
                rf = new Kabelya();
            else if (e.Node.Text == "Системы охл.")
                rf = new Systemohlad();
            else if (e.Node.Text == "Датчики")
                rf = new Datchicki();




            panel1.Controls.Clear();
            panel1.Controls.Add(rf);
        }

        private void HolodilnikiButton_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            List<string> Details = Program.Select("SELECT Name, Description FROM Details WHERE category ='Холодильники'");
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

        private void VstavniButton_Click(object sender, EventArgs e)
        {
            List<string> Details = Program.Select("SELECT Name, Description FROM Details WHERE category ='Вставни'");
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
                labelDiscription.Size = new Size(180, 180);
                labelDiscription.Margin = new Padding(4, 0, 4, 0);
                labelDiscription.TextAlign = ContentAlignment.MiddleCenter;
                labelDiscription.Text = Details[i + 1];

                panel1.Controls.Add(labelDiscription);
            }
        }

        private void KabelyaButton_Click(object sender, EventArgs e)
        {
            List<string> Details = Program.Select("SELECT * FROM Details WHERE category ='Кабеля'");
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
                labelDiscription.Size = new Size(180, 180);
                labelDiscription.Margin = new Padding(4, 0, 4, 0);
                labelDiscription.TextAlign = ContentAlignment.MiddleCenter;
                labelDiscription.Text = Details[i + 1];

                panel1.Controls.Add(labelDiscription);
            }
        }

        private void OhlasdenieButton_Click(object sender, EventArgs e)
        {
            List<string> Details = Program.Select("SELECT * FROM Details WHERE category ='Системы охлаждения'");

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
                labelDiscription.Size = new Size(180, 180);
                labelDiscription.Margin = new Padding(4, 0, 4, 0);
                labelDiscription.TextAlign = ContentAlignment.MiddleCenter;
                labelDiscription.Text = Details[i + 1];

                panel1.Controls.Add(labelDiscription);
            }
        }

        private void DatchikiButton_Click(object sender, EventArgs e)
        {
            List<string> Details = Program.Select("SELECT * FROM Details WHERE category ='Датчики'");

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
                labelDiscription.Size = new Size(180, 180);
                labelDiscription.Margin = new Padding(4, 0, 4, 0);
                labelDiscription.TextAlign = ContentAlignment.MiddleCenter;
                labelDiscription.Text = Details[i + 1];

                panel1.Controls.Add(labelDiscription);
            }
        }
    }
}
