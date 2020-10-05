namespace Fridgerator
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.countButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.addProductsButton = new System.Windows.Forms.Button();
            this.cookButton = new System.Windows.Forms.Button();
            this.fridgeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(352, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 91);
            this.button1.TabIndex = 0;
            this.button1.Text = "Просрочка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // countButton
            // 
            this.countButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countButton.Location = new System.Drawing.Point(352, 112);
            this.countButton.Margin = new System.Windows.Forms.Padding(4);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(190, 91);
            this.countButton.TabIndex = 1;
            this.countButton.Text = "Количество товара";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.CountButton_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(352, 211);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 91);
            this.button3.TabIndex = 2;
            this.button3.Text = "Содержимое";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // addProductsButton
            // 
            this.addProductsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addProductsButton.Location = new System.Drawing.Point(13, 13);
            this.addProductsButton.Margin = new System.Windows.Forms.Padding(4);
            this.addProductsButton.Name = "addProductsButton";
            this.addProductsButton.Size = new System.Drawing.Size(175, 140);
            this.addProductsButton.TabIndex = 4;
            this.addProductsButton.Text = "Добавить продукты";
            this.addProductsButton.UseVisualStyleBackColor = true;
            this.addProductsButton.Click += new System.EventHandler(this.AddProducts_Click);
            // 
            // cookButton
            // 
            this.cookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cookButton.Location = new System.Drawing.Point(13, 161);
            this.cookButton.Margin = new System.Windows.Forms.Padding(4);
            this.cookButton.Name = "cookButton";
            this.cookButton.Size = new System.Drawing.Size(175, 141);
            this.cookButton.TabIndex = 5;
            this.cookButton.Text = "Приготовить что-то";
            this.cookButton.UseVisualStyleBackColor = true;
            this.cookButton.Click += new System.EventHandler(this.CookingRecipes_Click);
            // 
            // fridgeButton
            // 
            //this.fridgeButton.BackgroundImage = global::Fridgerator.Properties.Resources.yctungsypcnnkkqoy8gn_800x;
            this.fridgeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fridgeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fridgeButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.fridgeButton.Location = new System.Drawing.Point(196, 13);
            this.fridgeButton.Margin = new System.Windows.Forms.Padding(4);
            this.fridgeButton.Name = "fridgeButton";
            this.fridgeButton.Size = new System.Drawing.Size(148, 289);
            this.fridgeButton.TabIndex = 3;
            this.fridgeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fridgeButton.UseVisualStyleBackColor = true;
            this.fridgeButton.Click += new System.EventHandler(this.Fridge_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 317);
            this.Controls.Add(this.cookButton);
            this.Controls.Add(this.addProductsButton);
            this.Controls.Add(this.fridgeButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(572, 364);
            this.MinimumSize = new System.Drawing.Size(572, 364);
            this.Name = "Main";
            this.Text = "Опции";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Главная_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button fridgeButton;
        private System.Windows.Forms.Button addProductsButton;
        private System.Windows.Forms.Button cookButton;
    }
}

