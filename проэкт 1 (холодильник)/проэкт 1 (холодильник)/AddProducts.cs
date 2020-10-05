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

        private int y = 60;

        private void AddLine_Click(object sender, EventArgs e)
        {
            y += 35;

          /*
           * Button btn = new Button();
            btn.Location = new Point(353, y);
            btn.Size = new Size(93, 20);
            btn.Text = "Добавить";
            btn.Click += new System.EventHandler(button2_Click);

            Controls.Add(btn);
          */


            NumericUpDown num = new NumericUpDown();
            num.Location = new Point(282, y);
            num.Size = new Size(52, 20);

            Controls.Add(num);


            TextBox tb = new TextBox();
            tb.Location = new Point(89, y);
            tb.Size = new Size(187, 20);

            Controls.Add(tb);
        }
    }
}
