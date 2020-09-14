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
    public partial class Главная : Form
    {
        public Главная()
        {
            InitializeComponent();
        }

        private void Главная_Load(object sender, EventArgs e)

        { }

        private void button2_Click(object sender, EventArgs e)
        {
            Колличество f = new Колличество();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Просрочка f = new Просрочка();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Содержимое f = new Содержимое();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Техсост f = new Техсост();
            f.ShowDialog();
        }
    }
}
