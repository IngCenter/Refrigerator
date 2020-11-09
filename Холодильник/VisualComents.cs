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

            int x = 55;

            //Все комментарии
            List<string> VisualComents = Program.Select("SELECT * FROM Comments");
            dataGridView1.Rows.Clear();
            for (int i = 0; i < VisualComents.Count; i += 4)
            {
                string[] row = new string[4];
                row[0] = VisualComents[i];
                row[1] = VisualComents[i + 1];
                row[2] = VisualComents[i + 2];
                row[3] = VisualComents[i + 3];
                dataGridView1.Rows.Add(row);
            }

            //Тут 6 столбцов
            for (int i = 0; i < VisualComents.Count; i += 4)
            {
                //0-Название, 4 - Количество
                TextBox Products = new TextBox
                {
                    AutoSize = false,
                    Font = new Font("Arial", 12),
                    Location = new Point(x, 30),
                    Size = new Size(140, 30),
                    Text = VisualComents[i]
                };

                TextBox b = new TextBox
                {
                    AutoSize = false,
                    Font = new Font("Arial", 12),
                    Location = new Point(x, 120),
                    Size = new Size(140, 30),
                    Text = VisualComents[i + 1]
                };

                TextBox c = new TextBox
                {
                    AutoSize = false,
                    Font = new Font("Arial", 12),
                    Location = new Point(x, 175),
                    Size = new Size(140, 30),
                    Text = VisualComents[i + 2]
                };

                TextBox d = new TextBox
                {
                    AutoSize = false,
                    Font = new Font("Arial", 12),
                    Location = new Point(x, 230),
                    Size = new Size(140, 30),
                    Text = VisualComents[i + 3]
                };

                Controls.Add(Products);
                Controls.Add(b);
                Controls.Add(c);
                Controls.Add(d);

                x += 150;
            }
        }

        private void VisualComents_Load(object sender, EventArgs e)
        {
            
        }
    }
}
