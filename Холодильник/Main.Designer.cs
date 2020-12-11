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
            this.button2 = new System.Windows.Forms.Button();
            this.contents = new System.Windows.Forms.Button();
            this.cookButton = new System.Windows.Forms.Button();
            this.fridgeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addProductsButton
            // 
            this.addProductsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addProductsButton.Location = new System.Drawing.Point(9, 78);
            this.addProductsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addProductsButton.Name = "addProductsButton";
            this.addProductsButton.Size = new System.Drawing.Size(186, 68);
            this.addProductsButton.TabIndex = 4;
            this.addProductsButton.Text = "Добавить продукты";
            this.addProductsButton.UseVisualStyleBackColor = true;
            this.addProductsButton.Click += new System.EventHandler(this.AddProducts_Click);
            // 
            // adminButton
            // 
            this.adminButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.adminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.adminButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.adminButton.Location = new System.Drawing.Point(9, 224);
            this.adminButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(395, 38);
            this.adminButton.TabIndex = 8;
            this.adminButton.Text = "AdMiN";
            this.adminButton.UseVisualStyleBackColor = false;
            this.adminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(203, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 66);
            this.button1.TabIndex = 7;
            this.button1.TabStop = false;
            this.button1.Text = "Коментарии";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contents
            // 
            this.contents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contents.Location = new System.Drawing.Point(203, 78);
            this.contents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contents.Name = "contents";
            this.contents.Size = new System.Drawing.Size(201, 68);
            this.contents.TabIndex = 2;
            this.contents.Text = "Содержимое";
            this.contents.UseVisualStyleBackColor = true;
            this.contents.Click += new System.EventHandler(this.Contents_Click);
            // 
            // cookButton
            // 
            this.cookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cookButton.Location = new System.Drawing.Point(9, 153);
            this.cookButton.Name = "cookButton";
            this.cookButton.Size = new System.Drawing.Size(189, 66);
            this.cookButton.TabIndex = 5;
            this.cookButton.Text = "Приготовить что-то";
            this.cookButton.UseVisualStyleBackColor = true;
            this.cookButton.Click += new System.EventHandler(this.CookingRecipes_Click);
            // 
            // fridgeButton
            // 
            this.fridgeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fridgeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fridgeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fridgeButton.Location = new System.Drawing.Point(9, 3);
            this.fridgeButton.Name = "fridgeButton";
            this.fridgeButton.Size = new System.Drawing.Size(395, 68);
            this.fridgeButton.TabIndex = 3;
            this.fridgeButton.Text = "Техническое состояние и обслуживание";
            this.fridgeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fridgeButton.UseVisualStyleBackColor = true;
            this.fridgeButton.Click += new System.EventHandler(this.Fridge_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(358, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 97);
            this.button2.TabIndex = 9;
            this.button2.Text = "Авторизация";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cookButton);
            this.Controls.Add(this.addProductsButton);
            this.Controls.Add(this.fridgeButton);
            this.Controls.Add(this.contents);
            this.Controls.Add(this.adminButton);
            this.MaximumSize = new System.Drawing.Size(432, 301);
            this.MinimumSize = new System.Drawing.Size(432, 301);
            this.Name = "Main";
            this.Text = "Панель управления";
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button contents;
        private System.Windows.Forms.Button fridgeButton;
        private System.Windows.Forms.Button addProductsButton;
        private System.Windows.Forms.Button cookButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button button2;
    }
}

