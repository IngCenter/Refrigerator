﻿namespace Fridgerator
{
    partial class AddProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.countNum = new System.Windows.Forms.NumericUpDown();
            this.addAll = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.units = new System.Windows.Forms.ComboBox();
            this.delete = new System.Windows.Forms.Button();
            this.dateBeginPicker = new System.Windows.Forms.DateTimePicker();
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.countNum)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addTextBox
            // 
            this.addTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTextBox.Location = new System.Drawing.Point(50, 4);
            this.addTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(278, 32);
            this.addTextBox.TabIndex = 0;
            this.addTextBox.Text = "Название";
            // 
            // countNum
            // 
            this.countNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countNum.Location = new System.Drawing.Point(336, 4);
            this.countNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 5);
            this.countNum.Name = "countNum";
            this.countNum.Size = new System.Drawing.Size(118, 32);
            this.countNum.TabIndex = 12;
            this.countNum.Tag = "count";
            this.countNum.ValueChanged += new System.EventHandler(this.CountNum_ValueChanged);
            // 
            // addAll
            // 
            this.addAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addAll.Location = new System.Drawing.Point(971, 126);
            this.addAll.Margin = new System.Windows.Forms.Padding(4);
            this.addAll.Name = "addAll";
            this.addAll.Size = new System.Drawing.Size(198, 114);
            this.addAll.TabIndex = 24;
            this.addAll.Text = "Добавить всё";
            this.addAll.UseVisualStyleBackColor = true;
            this.addAll.Click += new System.EventHandler(this.AddAll_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(971, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 106);
            this.button2.TabIndex = 25;
            this.button2.Text = "Добавить новую строку";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddLine_Click);
            // 
            // units
            // 
            this.units.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.units.FormattingEnabled = true;
            this.units.Items.AddRange(new object[] {
            "шт",
            "кг",
            "г",
            "л",
            "мл"});
            this.units.Location = new System.Drawing.Point(462, 4);
            this.units.Margin = new System.Windows.Forms.Padding(4);
            this.units.Name = "units";
            this.units.Size = new System.Drawing.Size(114, 33);
            this.units.TabIndex = 26;
            this.units.Tag = "unit";
            this.units.SelectedIndexChanged += new System.EventHandler(this.Units_SelectedIndexChanged);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Maroon;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(4, 4);
            this.delete.Margin = new System.Windows.Forms.Padding(4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(38, 38);
            this.delete.TabIndex = 29;
            this.delete.Text = "-";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // dateBeginPicker
            // 
            this.dateBeginPicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateBeginPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateBeginPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBeginPicker.Location = new System.Drawing.Point(584, 4);
            this.dateBeginPicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateBeginPicker.Name = "dateBeginPicker";
            this.dateBeginPicker.Size = new System.Drawing.Size(151, 32);
            this.dateBeginPicker.TabIndex = 27;
            this.dateBeginPicker.Tag = "dateBegin";
            this.dateBeginPicker.ValueChanged += new System.EventHandler(this.dateBeginPicker_ValueChanged);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Controls.Add(this.delete);
            this.mainPanel.Controls.Add(this.addTextBox);
            this.mainPanel.Controls.Add(this.countNum);
            this.mainPanel.Controls.Add(this.units);
            this.mainPanel.Controls.Add(this.dateBeginPicker);
            this.mainPanel.Controls.Add(this.comboBox1);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(952, 229);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Абстрактное",
            "Животные",
            "Жиры",
            "Зелень",
            "Крупа",
            "Мясо",
            "Напитки",
            "Сыр"});
            this.comboBox1.Location = new System.Drawing.Point(743, 4);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 33);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.Tag = "unit";
            this.comboBox1.Text = "Тип";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AddProducts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1184, 261);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addAll);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1200, 300);
            this.MinimumSize = new System.Drawing.Size(1200, 300);
            this.Name = "AddProducts";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countNum)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.NumericUpDown countNum;
        private System.Windows.Forms.Button addAll;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox units;
        private System.Windows.Forms.DateTimePicker dateBeginPicker;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.FlowLayoutPanel mainPanel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}