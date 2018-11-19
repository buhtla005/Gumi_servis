namespace WindowsFormsApp1
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelNavigacija = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GornjiPanel = new System.Windows.Forms.Panel();
            this.NaslovnaSlika = new System.Windows.Forms.PictureBox();
            this.imeLabel = new System.Windows.Forms.Label();
            this.skladistenjeUC1 = new WindowsFormsApp1.SkladistenjeUC();
            this.rezervacijaUC1 = new WindowsFormsApp1.RezervacijaUC();
            this.racunUC1 = new WindowsFormsApp1.RacunUC();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelNavigacija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NaslovnaSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNavigacija
            // 
            this.panelNavigacija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelNavigacija.Controls.Add(this.pictureBox1);
            this.panelNavigacija.Controls.Add(this.imeLabel);
            this.panelNavigacija.Controls.Add(this.button5);
            this.panelNavigacija.Controls.Add(this.SidePanel);
            this.panelNavigacija.Controls.Add(this.button4);
            this.panelNavigacija.Controls.Add(this.button3);
            this.panelNavigacija.Controls.Add(this.button2);
            this.panelNavigacija.Controls.Add(this.button1);
            this.panelNavigacija.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigacija.Location = new System.Drawing.Point(0, 0);
            this.panelNavigacija.Name = "panelNavigacija";
            this.panelNavigacija.Size = new System.Drawing.Size(193, 561);
            this.panelNavigacija.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(12, 125);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(183, 61);
            this.button5.TabIndex = 4;
            this.button5.Text = "    Home";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 125);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 61);
            this.SidePanel.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(12, 393);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 61);
            this.button4.TabIndex = 3;
            this.button4.Text = "    Odjava";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(12, 326);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 61);
            this.button3.TabIndex = 2;
            this.button3.Text = "    Skladištenje";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "    Rezervacija";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "    Račun";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GornjiPanel
            // 
            this.GornjiPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.GornjiPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GornjiPanel.Location = new System.Drawing.Point(193, 0);
            this.GornjiPanel.Name = "GornjiPanel";
            this.GornjiPanel.Size = new System.Drawing.Size(591, 10);
            this.GornjiPanel.TabIndex = 1;
            // 
            // NaslovnaSlika
            // 
            this.NaslovnaSlika.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NaslovnaSlika.BackgroundImage")));
            this.NaslovnaSlika.Location = new System.Drawing.Point(193, 9);
            this.NaslovnaSlika.Name = "NaslovnaSlika";
            this.NaslovnaSlika.Size = new System.Drawing.Size(591, 560);
            this.NaslovnaSlika.TabIndex = 2;
            this.NaslovnaSlika.TabStop = false;
            // 
            // imeLabel
            // 
            this.imeLabel.AutoSize = true;
            this.imeLabel.Font = new System.Drawing.Font("Roboto Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.imeLabel.Location = new System.Drawing.Point(56, 96);
            this.imeLabel.Name = "imeLabel";
            this.imeLabel.Size = new System.Drawing.Size(37, 13);
            this.imeLabel.TabIndex = 5;
            this.imeLabel.Text = "label1";
            // 
            // skladistenjeUC1
            // 
            this.skladistenjeUC1.Location = new System.Drawing.Point(193, 9);
            this.skladistenjeUC1.Name = "skladistenjeUC1";
            this.skladistenjeUC1.Size = new System.Drawing.Size(591, 552);
            this.skladistenjeUC1.TabIndex = 5;
            // 
            // rezervacijaUC1
            // 
            this.rezervacijaUC1.Location = new System.Drawing.Point(193, 9);
            this.rezervacijaUC1.Name = "rezervacijaUC1";
            this.rezervacijaUC1.Size = new System.Drawing.Size(591, 552);
            this.rezervacijaUC1.TabIndex = 4;
            // 
            // racunUC1
            // 
            this.racunUC1.Location = new System.Drawing.Point(193, 9);
            this.racunUC1.Name = "racunUC1";
            this.racunUC1.Size = new System.Drawing.Size(591, 552);
            this.racunUC1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(59, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 71);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.NaslovnaSlika);
            this.Controls.Add(this.GornjiPanel);
            this.Controls.Add(this.panelNavigacija);
            this.Controls.Add(this.skladistenjeUC1);
            this.Controls.Add(this.rezervacijaUC1);
            this.Controls.Add(this.racunUC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelNavigacija.ResumeLayout(false);
            this.panelNavigacija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NaslovnaSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavigacija;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel GornjiPanel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox NaslovnaSlika;
        private RacunUC racunUC1;
        private RezervacijaUC rezervacijaUC1;
        private SkladistenjeUC skladistenjeUC1;
        private System.Windows.Forms.Label imeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

