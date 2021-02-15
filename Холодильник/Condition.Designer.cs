namespace Fridgerator
{
    partial class Condition
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
            this.label2 = new System.Windows.Forms.Label();
            this.services = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(256, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "101%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(110, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(484, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Состояние твоего холодильника";
            // 
            // services
            // 
            this.services.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.services.Location = new System.Drawing.Point(116, 264);
            this.services.Name = "services";
            this.services.Size = new System.Drawing.Size(446, 109);
            this.services.TabIndex = 2;
            this.services.Text = "Тех осмотр";
            this.services.UseVisualStyleBackColor = true;
            this.services.Click += new System.EventHandler(this.Services_Click);
            // 
            // Condition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.services);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(701, 455);
            this.MinimumSize = new System.Drawing.Size(701, 455);
            this.Name = "Condition";
            this.Size = new System.Drawing.Size(701, 455);
            this.Load += new System.EventHandler(this.Condition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button services;
    }
}