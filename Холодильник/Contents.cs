﻿using System;
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
        private readonly int[] labelsX = new int[4] { 100, 200, 320, 420};

        public Contents()
        {
            InitializeComponent();
        }

        private void Contents_Load(object sender, EventArgs e)
        {
            List<string> products = Program.Select("SELECT Name, DateBegin, LifeTime, Unit, Count FROM Products");

            /*int y = 30;

            Label nameLabel = new Label { Text = "Имя", Location = new Point(labelsX[0], y) };
            Label dateBeginLabel = new Label { Text = "Когда куплены", Location = new Point(labelsX[1], y) };
            Label lifeTimeLabel = new Label { Text = "Срок годности", Location = new Point(labelsX[2], y) };
            Label countLabel = new Label { Text = "Количество", Location = new Point(labelsX[3], y) };

            Controls.AddRange(new Label[4] { nameLabel, dateBeginLabel, lifeTimeLabel, countLabel});
            
            for (int i = 0; i < products.Count; i += 6)
            {
                y += 30;
                Color backColor = DateTime.Parse(products[i + 1]).AddDays(int.Parse(products[i + 2])) > DateTime.Today ? Color.Transparent : Color.FromArgb(192, 128, 128);

                for (int j = 0; j < 4; j ++)
                {
                    if (j == 3)
                    {
                        Label ifLabel = new Label { Text = products[i + j + 1] + " " + products[i + j], Location = new Point(labelsX[j], y), BackColor = backColor };
                        Controls.Add(ifLabel);

                        break;
                    }

                    Label label = new Label { Text = products[i + j], Location = new Point(labelsX[j], y), BackColor = backColor };
                    Controls.Add(label);
                }
            }*/

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
                dataGridView1.Rows[i/5].DefaultCellStyle.BackColor = backColor;
            }
        }
    }
}
