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

            List<string> x1 = Program.Select("SELECT RecipesContents.Product," +
                                       " SUM(Portions * RecipesContents.Count)" +
                                       " FROM RecipesHistory" +
                                       " JOIN RecipesContents ON RecipesContents.RecipeName = RecipesHistory.Recipe" +
                                       " WHERE CookDate BETWEEN '2020-11-01' AND '2020-11-30'" +
                                       " GROUP BY RecipesContents.Product");

            for (int i = 0; i < x1.Count; i += 2)
            {
                string[] row = new string[2];
                row[0] = x1[i];
                row[1] = x1[i + 1];

                dataGridView1.Rows.Add(row);
            }
        }
    }
}
