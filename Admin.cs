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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();

            List<string> fillbox =
                Program.Select("SELECT DISTINCT product FROM RecipesContents");
            comboBox1.DataSource = fillbox;

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            string dateFrom = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string dateFrom2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            string command = "SELECT RecipesContents.Product," +
                                       " SUM(RecipesHistory.Count * RecipesContents.Count)" +
                                       " FROM RecipesHistory" +
                                       " JOIN RecipesContents ON RecipesContents.RecipeName = RecipesHistory.Recipe" +
                                       " WHERE CookDate < '" + dateFrom2 + "' AND CookDate > '" + dateFrom + "'";

            if (comboBox1.Text != "")
            {
                command = command + " AND RecipesContents.Product = '" + comboBox1.Text + "'";
            }

                command += " GROUP BY RecipesContents.Product";
                List<string> x1 = Program.Select(command);

                for (int i = 0; i < x1.Count; i += 2)
                {
                    string[] row = new string[2];
                    row[0] = x1[i];
                    row[1] = x1[i + 1];

                    dataGridView1.Rows.Add(row);
                }
          


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
