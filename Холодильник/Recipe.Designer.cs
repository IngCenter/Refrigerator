namespace Fridgerator
{
    partial class Recipe
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
            this.comboRecipe = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cookButton = new System.Windows.Forms.Button();
            this.addRecipe = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboRecipe
            // 
            this.comboRecipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRecipe.FormattingEnabled = true;
            this.comboRecipe.Location = new System.Drawing.Point(12, 14);
            this.comboRecipe.Margin = new System.Windows.Forms.Padding(5);
            this.comboRecipe.Name = "comboRecipe";
            this.comboRecipe.Size = new System.Drawing.Size(288, 37);
            this.comboRecipe.TabIndex = 0;
            this.comboRecipe.SelectedIndexChanged += new System.EventHandler(this.ComboRecipe_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(310, 17);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(82, 34);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cookButton
            // 
            this.cookButton.Location = new System.Drawing.Point(402, 9);
            this.cookButton.Margin = new System.Windows.Forms.Padding(5);
            this.cookButton.Name = "cookButton";
            this.cookButton.Size = new System.Drawing.Size(194, 42);
            this.cookButton.TabIndex = 2;
            this.cookButton.Text = "Приготовить";
            this.cookButton.UseVisualStyleBackColor = true;
            this.cookButton.Click += new System.EventHandler(this.CookButton_Click);
            // 
            // addRecipe
            // 
            this.addRecipe.Location = new System.Drawing.Point(604, 9);
            this.addRecipe.Name = "addRecipe";
            this.addRecipe.Size = new System.Drawing.Size(241, 42);
            this.addRecipe.TabIndex = 3;
            this.addRecipe.Text = "Добавить рецепт";
            this.addRecipe.UseVisualStyleBackColor = true;
            this.addRecipe.Click += new System.EventHandler(this.AddRecipeButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductType,
            this.ProductCount,
            this.Unit});
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(833, 309);
            this.dataGridView1.TabIndex = 4;
            // 
            // ProductType
            // 
            this.ProductType.HeaderText = "Тип продукта";
            this.ProductType.MinimumWidth = 6;
            this.ProductType.Name = "ProductType";
            this.ProductType.ReadOnly = true;
            this.ProductType.Width = 300;
            // 
            // ProductCount
            // 
            this.ProductCount.HeaderText = "Количество";
            this.ProductCount.MinimumWidth = 6;
            this.ProductCount.Name = "ProductCount";
            this.ProductCount.ReadOnly = true;
            this.ProductCount.Width = 200;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Единицы";
            this.Unit.MinimumWidth = 6;
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            this.Unit.Width = 125;
            // 
            // Recipe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(857, 387);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addRecipe);
            this.Controls.Add(this.cookButton);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboRecipe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Recipe";
            this.Text = "Recipe";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboRecipe;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button cookButton;
        private System.Windows.Forms.Button addRecipe;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
    }
}