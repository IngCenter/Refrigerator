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
    public partial class DeadProducts : Form
    {
        public DeadProducts()
        {
            int x = 10;

            //Все испорченные продукты
            List<string> dead = Program.Select("SELECT * FROM Products" +
                " WHERE DATEDIFF(CURDATE(), DateBegin) > LifeTime");

            //Тут 5 столбцов
            for (int i = 0; i < dead.Count; i += 6)
            {
                //0-Название, 4 - Количество
                Label nameLabel = new Label
                {
                    AutoSize = false,
                    Font = new Font("Arial", 12),
                    Location = new Point(x, 30),
                    Size = new Size(125, 30),
                    Text = dead[i],
                    TextAlign = ContentAlignment.MiddleCenter
                };
                
                Label countLabel = new Label
                {
                    AutoSize = false,
                    Font = new Font("Arial", 12),
                    Location = new Point(x, 100),
                    Size = new Size(125, 30),
                    Text = dead[i + 4] + " шт.",
                    TextAlign = ContentAlignment.MiddleCenter
                };

                Controls.Add(nameLabel);
                Controls.Add(countLabel);

                x += 140;
            }

            InitializeComponent();
        }

        private void DeadProducts_Load(object sender, EventArgs e)
        {
             
        }
    }
}
