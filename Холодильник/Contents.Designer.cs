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
            this.unitCB = new System.Windows.Forms.ComboBox();
            this.unitLabel = new System.Windows.Forms.Label();
            this.deadCheckBox = new System.Windows.Forms.CheckBox();
            this.nameCB = new System.Windows.Forms.ComboBox();
            this.typeCB = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(730, 327);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Название";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 150;
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
            this.ProductLifetime.ReadOnly = true;
            this.ProductLifetime.Width = 192;
            // 
            // ProductCount
            // 
            this.ProductCount.HeaderText = "Количество";
            this.ProductCount.MinimumWidth = 6;
            this.ProductCount.Name = "ProductCount";
            this.ProductCount.ReadOnly = true;
            this.ProductCount.Width = 160;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(517, 13);
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
            this.nameLabel.Location = new System.Drawing.Point(-3, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(111, 26);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Название";
            // 
            // unitCB
            // 
            this.unitCB.FormattingEnabled = true;
            this.unitCB.Location = new System.Drawing.Point(191, 36);
            this.unitCB.Name = "unitCB";
            this.unitCB.Size = new System.Drawing.Size(121, 33);
            this.unitCB.TabIndex = 4;
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Location = new System.Drawing.Point(186, 0);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(105, 26);
            this.unitLabel.TabIndex = 5;
            this.unitLabel.Text = "Единицы";
            // 
            // deadCheckBox
            // 
            this.deadCheckBox.AutoSize = true;
            this.deadCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deadCheckBox.Location = new System.Drawing.Point(3, 78);
            this.deadCheckBox.Name = "deadCheckBox";
            this.deadCheckBox.Size = new System.Drawing.Size(178, 30);
            this.deadCheckBox.TabIndex = 6;
            this.deadCheckBox.Text = "Проcроченное";
            this.deadCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameCB
            // 
            this.nameCB.FormattingEnabled = true;
            this.nameCB.Location = new System.Drawing.Point(3, 34);
            this.nameCB.Name = "nameCB";
            this.nameCB.Size = new System.Drawing.Size(177, 33);
            this.nameCB.TabIndex = 7;
            // 
            // typeCB
            // 
            this.typeCB.FormattingEnabled = true;
            this.typeCB.Location = new System.Drawing.Point(318, 36);
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(181, 33);
            this.typeCB.TabIndex = 4;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(312, 2);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(48, 26);
            this.typeLabel.TabIndex = 5;
            this.typeLabel.Text = "Тип";
            // 
            // Contents
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.nameCB);
            this.Controls.Add(this.deadCheckBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.typeCB);
            this.Controls.Add(this.unitCB);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(730, 455);
            this.MinimumSize = new System.Drawing.Size(730, 455);
            this.Name = "Contents";
            this.Size = new System.Drawing.Size(730, 455);
            this.Load += new System.EventHandler(this.Contents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox unitCB;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.CheckBox deadCheckBox;
        private System.Windows.Forms.ComboBox nameCB;
        private System.Windows.Forms.ComboBox typeCB;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductBirthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductLifetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCount;
    }
}