namespace WindowsFormsApp1
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.userBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.prijavaButton = new System.Windows.Forms.Button();
            this.izlazButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userBox
            // 
            this.userBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userBox.Location = new System.Drawing.Point(129, 245);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(187, 27);
            this.userBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordBox.Location = new System.Drawing.Point(129, 327);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(187, 27);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // prijavaButton
            // 
            this.prijavaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.prijavaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prijavaButton.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prijavaButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.prijavaButton.Location = new System.Drawing.Point(129, 411);
            this.prijavaButton.Name = "prijavaButton";
            this.prijavaButton.Size = new System.Drawing.Size(82, 32);
            this.prijavaButton.TabIndex = 2;
            this.prijavaButton.Text = "Prijava";
            this.prijavaButton.UseVisualStyleBackColor = false;
            this.prijavaButton.Click += new System.EventHandler(this.prijavaButton_Click);
            // 
            // izlazButton
            // 
            this.izlazButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.izlazButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.izlazButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izlazButton.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izlazButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.izlazButton.Location = new System.Drawing.Point(239, 411);
            this.izlazButton.Name = "izlazButton";
            this.izlazButton.Size = new System.Drawing.Size(77, 32);
            this.izlazButton.TabIndex = 3;
            this.izlazButton.Text = "Izlaz";
            this.izlazButton.UseVisualStyleBackColor = false;
            this.izlazButton.Click += new System.EventHandler(this.izlazButton_Click);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.prijavaButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.izlazButton;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.izlazButton);
            this.Controls.Add(this.prijavaButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.userBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button prijavaButton;
        private System.Windows.Forms.Button izlazButton;
    }
}