namespace Fridgerator
{
    partial class AdminServices
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
            this.FridgeModelCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TroubleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriseCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FridgeModelCol,
            this.CityCol,
            this.TroubleCol,
            this.PriseCol});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(410, 185);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FridgeModelCol
            // 
            this.FridgeModelCol.HeaderText = "Модель холодильника";
            this.FridgeModelCol.MinimumWidth = 6;
            this.FridgeModelCol.Name = "FridgeModelCol";
            this.FridgeModelCol.Width = 125;
            // 
            // CityCol
            // 
            this.CityCol.HeaderText = "Город";
            this.CityCol.MinimumWidth = 6;
            this.CityCol.Name = "CityCol";
            this.CityCol.Width = 125;
            // 
            // TroubleCol
            // 
            this.TroubleCol.HeaderText = "Проблема";
            this.TroubleCol.MinimumWidth = 6;
            this.TroubleCol.Name = "TroubleCol";
            this.TroubleCol.Width = 125;
            // 
            // PriseCol
            // 
            this.PriseCol.HeaderText = "Цена";
            this.PriseCol.MinimumWidth = 6;
            this.PriseCol.Name = "PriseCol";
            this.PriseCol.Width = 125;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(0, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(410, 84);
            this.button1.TabIndex = 1;
            this.button1.Text = "Фильтр использованых продуктов за неделю";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminServices";
            this.Size = new System.Drawing.Size(410, 277);
            this.Load += new System.EventHandler(this.AdminServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FridgeModelCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TroubleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriseCol;
        private System.Windows.Forms.Button button1;
    }
}