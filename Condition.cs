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
    public partial class Condition : UserControl
    {
        public Condition()
        {
            InitializeComponent();
        }

        private void Services_Click(object sender, EventArgs e)
        {
            Services f = new Services();
            f.ShowDialog();
        }

        private void Condition_Load(object sender, EventArgs e)
        {

        }


    }
}
