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
    public partial class VisualComents : Form
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

        private void кноп_Click(object sender, EventArgs e)
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

            if (comboBox1.Text != "")
            {
                command = command + " AND product = '" + comboBox1.Text + "'";
            }

            if (comboBox2.Text != "")
            {
                command = command + " AND Raiting = '" + comboBox2.Text + "'";
            }

            //Все комментарии
            List<string> VisualComents = Program.Select(command);
            dataGridView1.Rows.Clear();
            for (int i = 0; i < VisualComents.Count; i += 5)
            {
                string[] row = new string[5];
                row[0] = VisualComents[i];
                row[1] = VisualComents[i + 1];
                row[2] = VisualComents[i + 2];
                row[3] = VisualComents[i + 3];
                row[4] = VisualComents[i + 4];
                dataGridView1.Rows.Add(row);
            }

        }
    }
}
