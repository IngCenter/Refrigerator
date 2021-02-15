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
    public partial class Magaz : Form
    {
        public Magaz()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Magaz f = new Magaz();
            f.ShowDialog();
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
    }
}
