namespace Fridgerator
{
    partial class AddRecipe
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addRecipeButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.delete = new System.Windows.Forms.Button();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.countNum = new System.Windows.Forms.NumericUpDown();
            this.units = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addProduct = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(553, 34);
            this.textBox1.TabIndex = 1;
            // 
            // addRecipeButton
            // 
            this.addRecipeButton.Location = new System.Drawing.Point(564, 579);
            this.addRecipeButton.Name = "addRecipeButton";
            this.addRecipeButton.Size = new System.Drawing.Size(149, 79);
            this.addRecipeButton.TabIndex = 2;
            this.addRecipeButton.Text = "Сохранить";
            this.addRecipeButton.UseVisualStyleBackColor = true;
            this.addRecipeButton.Click += new System.EventHandler(this.AddRecipeButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 53);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(553, 192);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Описание";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(160, 251);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox3.Size = new System.Drawing.Size(553, 79);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(5, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 58);
            this.label3.TabIndex = 6;
            this.label3.Text = "Краткое Описание";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.delete);
            this.flowLayoutPanel1.Controls.Add(this.typeTextBox);
            this.flowLayoutPanel1.Controls.Add(this.countNum);
            this.flowLayoutPanel1.Controls.Add(this.units);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 370);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(546, 288);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Maroon;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(3, 3);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(38, 38);
            this.delete.TabIndex = 29;
            this.delete.Text = "-";
            this.delete.UseVisualStyleBackColor = false;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeTextBox.Location = new System.Drawing.Point(47, 3);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(261, 38);
            this.typeTextBox.TabIndex = 28;
            this.typeTextBox.Tag = "type";
            this.typeTextBox.Text = "Тип";
            // 
            // countNum
            // 
            this.countNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countNum.Location = new System.Drawing.Point(315, 4);
            this.countNum.Margin = new System.Windows.Forms.Padding(4);
            this.countNum.Name = "countNum";
            this.countNum.Size = new System.Drawing.Size(97, 38);
            this.countNum.TabIndex = 12;
            this.countNum.Tag = "count";
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
            this.units.Location = new System.Drawing.Point(419, 3);
            this.units.Name = "units";
            this.units.Size = new System.Drawing.Size(98, 39);
            this.units.TabIndex = 26;
            this.units.Tag = "unit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 338);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Состав";
            // 
            // addProduct
            // 
            this.addProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.addProduct.Location = new System.Drawing.Point(520, 620);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(38, 38);
            this.addProduct.TabIndex = 9;
            this.addProduct.Text = "+";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // AddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 670);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.addRecipeButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddRecipe";
            this.Text = "AddRecipr";
            this.Load += new System.EventHandler(this.AddRecipe_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addRecipeButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.NumericUpDown countNum;
        private System.Windows.Forms.ComboBox units;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addProduct;
    }
}