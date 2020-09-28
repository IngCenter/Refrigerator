using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace проэкт_1__холодильник_
{
    public partial class Что_я_приготовил : Form
    {
        public Что_я_приготовил()
        {
            InitializeComponent();
        }

        private void Что_я_приготовил_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }



        int y = 15;

        private void button6_Click(object sender, EventArgs e)
        {
            TextBox tb = new TextBox();
            tb.Location = new Point(5, y);
            tb.Size = new Size(120, 20);
            Controls.Add(tb);

            TextBox tb1 = new TextBox();
            tb1.Location = new Point(156, y);
            tb1.Size = new Size(120, 20);
            Controls.Add(tb1);

            TextBox tb2 = new TextBox();
            tb2.Location = new Point(307, y);
            tb2.Size = new Size(120, 20);
            Controls.Add(tb2);

            TextBox tb3 = new TextBox();
            tb3.Location = new Point(458, y);
            tb3.Size = new Size(120, 20);
            Controls.Add(tb3);


            Label lbl = new Label();
            lbl.Location = new Point(131, y);
            lbl.Text = ("+");
            Controls.Add(lbl);

            
            Label lbl1 = new Label();
            lbl1.Location = new Point(282, y);
            lbl1.Text = ("+");
            Controls.Add(lbl1);

            Label lbl3 = new Label();
            lbl3.Location = new Point(433, y);
            lbl3.Text = ("=");
            Controls.Add(lbl3);

            Button btn = new Button();
            btn.Location = new Point(584, y - 8);
            btn.Size = new Size(113, 33);
            btn.Text = ("Приготовить");
            Controls.Add(btn);

            y = y + 33;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
