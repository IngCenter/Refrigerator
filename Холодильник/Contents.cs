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
    public partial class Contents : UserControl
    {
        public Contents()
        {
            InitializeComponent();

            List<string> products = Program.Select("SELECT DISTINCT Name FROM Products ORDER BY Name");
            List<string> units = Program.Select("SELECT DISTINCT Unit FROM Products ORDER BY Unit");
            List<string> type = Program.Select("SELECT DISTINCT Type FROM Products ORDER BY Type");

            nameCB.Items.Clear();
            nameCB.Items.Add("");
            nameCB.Items.AddRange(products.ToArray());

            unitCB.Items.Clear();
            unitCB.Items.Add("");
            unitCB.Items.AddRange(units.ToArray());

            typeCB.Items.Clear();
            typeCB.Items.Add("");
            typeCB.Items.AddRange(type.ToArray());
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
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (!string.IsNullOrWhiteSpace(nameCB.Text))
            {
                parameters.Add("name", nameCB.Text);
                command += " AND Name = ?name";
            }

            if (!string.IsNullOrWhiteSpace(unitCB.Text))
            {
                parameters.Add("unit", unitCB.Text);
                command += " AND Unit = ?unit";
            }

            if (!string.IsNullOrWhiteSpace(typeCB.Text))
            {
                parameters.Add("type", typeCB.Text);
                command += " AND Type = ?type";
            }

            if (deadCheckBox.Checked)
                command += " AND DATEDIFF(CURDATE(), DateBegin) > LifeTime";

            List<string> products = Program.Select(command, parameters);

            UpdateTable(products);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
