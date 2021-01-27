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
    public partial class VisualComents : UserControl
    {
        public VisualComents()
        {
            InitializeComponent();
           

            
        }

        private void VisualComents_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 3)
            {
                string id =
                dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                string raiting =
                dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                Program.Insert("UPDATE Comments SET Raiting = " + raiting + " Where Id = " + id);
                MessageBox.Show("Обновлено");
            }
            
            if (e.ColumnIndex == 2)
            {
                string id =
                dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                string CommentText =
                dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                

                Program.Insert("UPDATE Comments SET CommentText = '" + CommentText + "' Where Id = " + id);
                MessageBox.Show("Обновлено");
            }

            if (e.ColumnIndex == 0)
            {
                string id =
                dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                string Product =
                dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();


                Program.Insert("UPDATE Comments SET Product = '" + Product + "' Where Id = " + id);
                MessageBox.Show("Обновлено");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string command = "SELECT * FROM Comments WHERE 1";
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (comboBox1.Text != "")
            {
                parameters.Add("product", comboBox1.Text);
                command += " AND product = ?product";
            }

            if (comboBox2.Text != "")
            {
                parameters.Add("raiting", comboBox2.Text);
                command += " AND Raiting = ?raiting";
            }

            List<string> visualComents = Program.Select(command, parameters);

            dataGridView1.Rows.Clear();
            for (int i = 0; i < visualComents.Count; i += 5)
            {
                string[] row = new string[5];
                row[0] = visualComents[i];
                row[1] = visualComents[i + 1];
                row[2] = visualComents[i + 2];
                row[3] = visualComents[i + 3];
                row[4] = visualComents[i + 4];
                dataGridView1.Rows.Add(row);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Coments coments = new Coments();
            coments.ShowDialog();
        }
    }
}
