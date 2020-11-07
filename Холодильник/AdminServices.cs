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
    public partial class AdminServices : Form
    {
        public AdminServices()
        {
            InitializeComponent();
        }

        private void AdminServices_Load(object sender, EventArgs e)
        {
            List<string> services = Program.Select("SELECT * FROM Services");

            for (int i = 0; i < services.Count; i+= 4)
            {
                string[] row = new string[4];

                for (int j = 0; j < row.Length; j++)
                    row[j] = services[i + j];

                dataGridView1.Rows.Add(row);
            }
        }
    }
}
