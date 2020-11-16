namespace Fridgerator
{
    partial class Contents
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductBirthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductLifetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.unitCB = new System.Windows.Forms.ComboBox();
            this.unitLabel = new System.Windows.Forms.Label();
            this.deadCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.ProductBirthdate,
            this.ProductLifetime,
            this.ProductCount});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1025, 356);
            this.dataGridView1.TabIndex = 0;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Название";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 320;
            // 
            // ProductBirthdate
            // 
            this.ProductBirthdate.HeaderText = "Дата упаковки";
            this.ProductBirthdate.MinimumWidth = 6;
            this.ProductBirthdate.Name = "ProductBirthdate";
            this.ProductBirthdate.ReadOnly = true;
            this.ProductBirthdate.Width = 192;
            // 
            // ProductLifetime
            // 
            this.ProductLifetime.HeaderText = "Срок годности";
            this.ProductLifetime.MinimumWidth = 6;
            this.ProductLifetime.Name = "ProductLifetime";
            this.ProductLifetime.Width = 192;
            // 
            // ProductCount
            // 
            this.ProductCount.HeaderText = "Количество";
            this.ProductCount.MinimumWidth = 6;
            this.ProductCount.Name = "ProductCount";
            this.ProductCount.Width = 192;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(832, 4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(181, 95);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Найти";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(137, 31);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Название";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(12, 43);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(177, 38);
            this.nameTB.TabIndex = 3;
            // 
            // unitCB
            // 
            this.unitCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitCB.FormattingEnabled = true;
            this.unitCB.Items.AddRange(new object[] {
            "л",
            "кг",
            "шт",
            "г",
            " "});
            this.unitCB.Location = new System.Drawing.Point(224, 43);
            this.unitCB.Name = "unitCB";
            this.unitCB.Size = new System.Drawing.Size(121, 39);
            this.unitCB.TabIndex = 4;
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Location = new System.Drawing.Point(218, 9);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(128, 31);
            this.unitLabel.TabIndex = 5;
            this.unitLabel.Text = "Единицы";
            // 
            // deadCheckBox
            // 
            this.deadCheckBox.AutoSize = true;
            this.deadCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deadCheckBox.Location = new System.Drawing.Point(379, 35);
            this.deadCheckBox.Name = "deadCheckBox";
            this.deadCheckBox.Size = new System.Drawing.Size(205, 35);
            this.deadCheckBox.TabIndex = 6;
            this.deadCheckBox.Text = "Пророченное";
            this.deadCheckBox.UseVisualStyleBackColor = true;
            // 
            // Contents
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1025, 461);
            this.Controls.Add(this.deadCheckBox);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.unitCB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Contents";
            this.Text = "Содержимое";
            this.Load += new System.EventHandler(this.Contents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductBirthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductLifetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCount;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.ComboBox unitCB;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.CheckBox deadCheckBox;
    }
}