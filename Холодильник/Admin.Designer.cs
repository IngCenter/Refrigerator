namespace Fridgerator
{
    partial class Admin
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
            this.adminServicesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminServicesButton
            // 
            this.adminServicesButton.Location = new System.Drawing.Point(44, 28);
            this.adminServicesButton.Name = "adminServicesButton";
            this.adminServicesButton.Size = new System.Drawing.Size(725, 275);
            this.adminServicesButton.TabIndex = 0;
            this.adminServicesButton.Text = "button1";
            this.adminServicesButton.UseVisualStyleBackColor = true;
            this.adminServicesButton.Click += new System.EventHandler(this.AdminServicesButton_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminServicesButton);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adminServicesButton;
    }
}