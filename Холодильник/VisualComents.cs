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
            Program.Select("SELECT * FROM Comments");

            int x = 55;

            //Все испорченные продукты
            List<string> VisualComents = Program.Select("SELECT * FROM Comments");

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

            InitializeComponent();
        }

        private void VisualComents_Load(object sender, EventArgs e)
        {
            
        }
    }
}
