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
    public partial class AddProducts : Form
    {
        public AddProducts()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int y = 0;

        private void AddLine_Click(object sender, EventArgs e)
        {
            y += 45;

            Button button = new Button
            {
                Location = new Point(delete.Location.X, y),
                Size = delete.Size,
                Font = delete.Font,
                Text = delete.Text,
                ForeColor = delete.ForeColor,
                BackColor = delete.BackColor,
                FlatStyle = delete.FlatStyle
            };

            ComboBox comboBox = new ComboBox
            {
                Location = new Point(units.Location.X, y),
                Size = units.Size,
                Font = units.Font,
                Text = units.Text,
                Tag = "units"
            };

            NumericUpDown num = new NumericUpDown
            {
                Location = new Point(countNum.Location.X, y),
                Size = countNum.Size,
                Font = countNum.Font,
                Tag = "conut"
            };

            TextBox tb = new TextBox
            {
                Location = new Point(addTextBox.Location.X, y),
                Size = addTextBox.Size,
                Font = addTextBox.Font,
                Text = addTextBox.Text
            };

            DateTimePicker dtp = new DateTimePicker
            {
                Location = new Point(dateBeginPicker.Location.X, y),
                Size = dateBeginPicker.Size,
                Font = dateBeginPicker.Font,
                Value = DateTime.Today,
                Format = DateTimePickerFormat.Short,
                Tag = "dateBegin"
            };

            TextBox typeTb = new TextBox
            {
                Location = new Point(typeTextBox.Location.X, y),
                Size = typeTextBox.Size,
                Font = typeTextBox.Font,
                Text = typeTextBox.Text,
                Tag = "type"
            };

            mainPanel.Controls.AddRange(new Control[6] { button, comboBox, num, tb, dtp, typeTb });
        }

        private void AddAll_Click(object sender, EventArgs e)
        {
            foreach(Control control0 in mainPanel.Controls)
            {
                if (control0 is TextBox && control0.Location.X == addTextBox.Location.X)
                {
                    if (control0.Text == "Название")
                        continue;

                    string name = control0.Text, count = "", unit = "", type = "";
                    DateTime dateBegin = DateTime.Today;

                    foreach (Control control1 in mainPanel.Controls)
                    {
                        if(control1.Location.Y == control0.Location.Y && control1.Tag != null)
                        {
                            switch(control1.Tag.ToString())
                            {
                                case "count":
                                    count = ((NumericUpDown)control1).Value.ToString();
                                    break;

                                case "unit":
                                    unit = control1.Text;
                                    break;

                                case "dateBegin":
                                    dateBegin = ((DateTimePicker)control1).Value;
                                    break;

                                case "type":
                                    type = control1.Text;
                                    break;
                            }
                        }
                    }

                    Program.Insert("INSERT INTO Products (Name, Count, Unit, DateBegin, Type) " +
                                   "VALUES (" + name + ", " + count + ", " + unit + ", " +
                                   "STR_TO_DATE('" + dateBegin.ToShortDateString() + "', '%d.%m.%y'))" + ", " + 
                                   type + ")");
                }
            }
        }

        private void CountNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Units_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
