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
    public partial class Техсост : Form
    {
        public Техсост()
        {
            InitializeComponent();
        }

        private void Техсост_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Сервисы f = new Сервисы();
            f.ShowDialog();
        }
    }
}
