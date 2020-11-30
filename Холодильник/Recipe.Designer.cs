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
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboRecipe
            // 
            this.comboRecipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRecipe.FormattingEnabled = true;
            this.comboRecipe.Location = new System.Drawing.Point(21, 44);
            this.comboRecipe.Margin = new System.Windows.Forms.Padding(5);
            this.comboRecipe.Name = "comboRecipe";
            this.comboRecipe.Size = new System.Drawing.Size(286, 37);
            this.comboRecipe.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(354, 44);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(82, 34);
            this.numericUpDown1.TabIndex = 1;
            // 
            // cookButton
            // 
            this.cookButton.Location = new System.Drawing.Point(717, 351);
            this.cookButton.Margin = new System.Windows.Forms.Padding(5);
            this.cookButton.Name = "cookButton";
            this.cookButton.Size = new System.Drawing.Size(189, 42);
            this.cookButton.TabIndex = 2;
            this.cookButton.Text = "Приготовить";
            this.cookButton.UseVisualStyleBackColor = true;
            this.cookButton.Click += new System.EventHandler(this.CookButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(799, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Recipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 410);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cookButton);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboRecipe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Recipe";
            this.Text = "Recipe";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboRecipe;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button cookButton;
        private System.Windows.Forms.Button button2;
    }
}