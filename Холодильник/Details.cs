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
    public partial class Details : UserControl
    {
        /// <summary>
        /// Форма просмотра деталей по категории
        /// </summary>
        public Details(string category)
        {
            InitializeComponent();

            //if (category == "Холодильники")
            MessageBox.Show(category);
        }

        private void Datchicki_Load(object sender, EventArgs e)
        {

        }
    }
}
