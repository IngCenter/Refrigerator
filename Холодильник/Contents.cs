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
    public partial class Contents : Form
    {
        public Contents()
        {
            InitializeComponent();
        }

        private void Contents_Load(object sender, EventArgs e)
        {
            List<string> products = Program.Select("SELECT Name, DateBegin, LifeTime, Unit, Count FROM Products");

            UpdateTable(products);
        }

        private void UpdateTable(List<string> products)
        {
            dataGridView1.Rows.Clear();

            for (int i = 0; i < products.Count; i += 5)
            {
                string[] row = new string[4];

                Color backColor = DateTime.Parse(products[i + 1]).AddDays(int.Parse(products[i + 2])) > DateTime.Today.AddDays(2) ? Color.White : Color.FromArgb(192, 192, 128);

                if (DateTime.Parse(products[i + 1]).AddDays(int.Parse(products[i + 2])) < DateTime.Today)
                    backColor = Color.FromArgb(192, 128, 128);

                row[0] = products[i];
                row[1] = products[i + 1].Remove(products[i + 1].Length - 8);
                row[2] = products[i + 2] + " дней";
                row[3] = products[i + 4] + " " + products[i + 3];

                dataGridView1.Rows.Add(row);
                dataGridView1.Rows[i / 5].DefaultCellStyle.BackColor = backColor;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string command = "SELECT Name, DateBegin, LifeTime, Unit, Count FROM Products WHERE 1";


            if (!string.IsNullOrWhiteSpace(nameTB.Text))
                command += " AND Name LIKE '%" + nameTB.Text +"%'";

            if (!string.IsNullOrWhiteSpace(unitCB.Text))
                command += " AND Unit = '" + unitCB.Text + "'";

            if (deadCheckBox.Checked)
                command += " AND DATEDIFF(CURDATE(), DateBegin) > LifeTime";

            List<string> products = Program.Select(command);

            UpdateTable(products);
        }
    }
}
