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

            //tabPage2.Controls.Add(button3);
            //В таком стиле можно че-то из базы пихать на нужную вкладку
        }
        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vstavni f = new Vstavni();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Kabelya f = new Kabelya();
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Systemohlad f = new Systemohlad();
            f.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Datchicki f = new Datchicki();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
