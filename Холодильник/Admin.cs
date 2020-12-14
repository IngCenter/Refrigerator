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
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            string dateFrom = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string dateFrom2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            string command =           "SELECT RecipesContents.Product," +
                                       " SUM(Portions * RecipesContents.Count)" +
                                       " FROM RecipesHistory" +
                                       " JOIN RecipesContents ON RecipesContents.RecipeName = RecipesHistory.Recipe" +
                                       " WHERE CookDate < '" + dateFrom + "' AND CookDate > '" + dateFrom2 + "'";

            if (comboBox1.Text != "")
            {
                ///
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

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
