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
            this.addProductsButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contents = new System.Windows.Forms.Button();
            this.cookButton = new System.Windows.Forms.Button();
            this.countButton = new System.Windows.Forms.Button();
            this.deadProducts = new System.Windows.Forms.Button();
            this.fridgeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addProductsButton
            // 
            this.addProductsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addProductsButton.Location = new System.Drawing.Point(17, 16);
            this.addProductsButton.Margin = new System.Windows.Forms.Padding(5);
            this.addProductsButton.Name = "addProductsButton";
            this.addProductsButton.Size = new System.Drawing.Size(142, 108);
            this.addProductsButton.TabIndex = 4;
            this.addProductsButton.Text = "Добавить продукты";
            this.addProductsButton.UseVisualStyleBackColor = true;
            this.addProductsButton.Click += new System.EventHandler(this.AddProducts_Click);
            // 
            // adminButton
            // 
            this.adminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.adminButton.Location = new System.Drawing.Point(382, 112);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(148, 47);
            this.adminButton.TabIndex = 8;
            this.adminButton.Text = "AdMiN";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(354, 166);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 91);
            this.button1.TabIndex = 7;
            this.button1.TabStop = false;
            this.button1.Text = "Коментарии";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contents
            // 
            this.contents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contents.Location = new System.Drawing.Point(196, 268);
            this.contents.Margin = new System.Windows.Forms.Padding(5);
            this.contents.Name = "contents";
            this.contents.Size = new System.Drawing.Size(253, 35);
            this.contents.TabIndex = 2;
            this.contents.Text = "Содержимое";
            this.contents.UseVisualStyleBackColor = true;
            this.contents.Click += new System.EventHandler(this.Contents_Click);
            // 
            // cookButton
            // 
            this.cookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cookButton.Location = new System.Drawing.Point(13, 161);
            this.cookButton.Margin = new System.Windows.Forms.Padding(4);
            this.cookButton.Name = "cookButton";
            this.cookButton.Size = new System.Drawing.Size(175, 142);
            this.cookButton.TabIndex = 5;
            this.cookButton.Text = "Приготовить что-то";
            this.cookButton.UseVisualStyleBackColor = true;
            this.cookButton.Click += new System.EventHandler(this.CookingRecipes_Click);
            // 
            // countButton
            // 
            this.countButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countButton.Location = new System.Drawing.Point(197, 133);
            this.countButton.Margin = new System.Windows.Forms.Padding(5);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(148, 112);
            this.countButton.TabIndex = 1;
            this.countButton.Text = "Количество продуктов";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.CountButton_Click);
            // 
            // deadProducts
            // 
            this.deadProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deadProducts.Location = new System.Drawing.Point(352, 13);
            this.deadProducts.Margin = new System.Windows.Forms.Padding(4);
            this.deadProducts.Name = "deadProducts";
            this.deadProducts.Size = new System.Drawing.Size(190, 91);
            this.deadProducts.TabIndex = 0;
            this.deadProducts.Text = "Просрочка";
            this.deadProducts.UseVisualStyleBackColor = true;
            this.deadProducts.Click += new System.EventHandler(this.DeadProducts_Click);
            // 
            // fridgeButton
            // 
            this.fridgeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fridgeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fridgeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fridgeButton.Location = new System.Drawing.Point(196, 14);
            this.fridgeButton.Margin = new System.Windows.Forms.Padding(4);
            this.fridgeButton.Name = "fridgeButton";
            this.fridgeButton.Size = new System.Drawing.Size(108, 110);
            this.fridgeButton.TabIndex = 3;
            this.fridgeButton.Text = "Техническое состояние и обслуживание";
            this.fridgeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fridgeButton.UseVisualStyleBackColor = true;
            this.fridgeButton.Click += new System.EventHandler(this.Fridge_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 315);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cookButton);
            this.Controls.Add(this.addProductsButton);
            this.Controls.Add(this.fridgeButton);
            this.Controls.Add(this.contents);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.deadProducts);
            this.Controls.Add(this.countButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(571, 362);
            this.MinimumSize = new System.Drawing.Size(571, 362);
            this.Name = "Main";
            this.Text = "Панель управления";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Button contents;
        private System.Windows.Forms.Button fridgeButton;
        private System.Windows.Forms.Button addProductsButton;
        private System.Windows.Forms.Button cookButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button deadProducts;
    }
}

