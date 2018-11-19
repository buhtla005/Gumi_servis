namespace WindowsFormsApp1
{
    partial class RacunUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RacunUC));
            this.label3 = new System.Windows.Forms.Label();
            this.lblUkupno = new System.Windows.Forms.Label();
            this.printStavkaBtn = new System.Windows.Forms.Button();
            this.stavkaDataGrid = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Količina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaS = new System.Windows.Forms.TextBox();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.stavkaCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.klijentCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelRacun = new System.Windows.Forms.Panel();
            this.racunLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaDataGrid)).BeginInit();
            this.panelRacun.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(355, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ukupna cijena: ";
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.BackColor = System.Drawing.Color.Transparent;
            this.lblUkupno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUkupno.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUkupno.Location = new System.Drawing.Point(479, 464);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(53, 21);
            this.lblUkupno.TabIndex = 18;
            this.lblUkupno.Text = "label3";
            // 
            // printStavkaBtn
            // 
            this.printStavkaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.printStavkaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printStavkaBtn.Font = new System.Drawing.Font("Roboto Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.printStavkaBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.printStavkaBtn.Location = new System.Drawing.Point(455, 487);
            this.printStavkaBtn.Name = "printStavkaBtn";
            this.printStavkaBtn.Size = new System.Drawing.Size(108, 32);
            this.printStavkaBtn.TabIndex = 17;
            this.printStavkaBtn.Text = "Printaj racun";
            this.printStavkaBtn.UseVisualStyleBackColor = false;
            this.printStavkaBtn.Click += new System.EventHandler(this.printStavkaBtn_Click);
            // 
            // stavkaDataGrid
            // 
            this.stavkaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stavkaDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Količina,
            this.Cijena});
            this.stavkaDataGrid.Location = new System.Drawing.Point(63, 158);
            this.stavkaDataGrid.Name = "stavkaDataGrid";
            this.stavkaDataGrid.Size = new System.Drawing.Size(347, 293);
            this.stavkaDataGrid.TabIndex = 16;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Usluga";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            // 
            // Količina
            // 
            this.Količina.DataPropertyName = "Kolicina";
            this.Količina.HeaderText = "Količina";
            this.Količina.Name = "Količina";
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            // 
            // kolicinaS
            // 
            this.kolicinaS.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kolicinaS.Location = new System.Drawing.Point(489, 79);
            this.kolicinaS.Name = "kolicinaS";
            this.kolicinaS.Size = new System.Drawing.Size(44, 29);
            this.kolicinaS.TabIndex = 15;
            // 
            // dodajBtn
            // 
            this.dodajBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dodajBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajBtn.Font = new System.Drawing.Font("Roboto Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.dodajBtn.Location = new System.Drawing.Point(425, 112);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(108, 31);
            this.dodajBtn.TabIndex = 14;
            this.dodajBtn.Text = "Dodaj stavku";
            this.dodajBtn.UseVisualStyleBackColor = false;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(76, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Stavka";
            // 
            // stavkaCombo
            // 
            this.stavkaCombo.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stavkaCombo.FormattingEnabled = true;
            this.stavkaCombo.Location = new System.Drawing.Point(190, 72);
            this.stavkaCombo.Name = "stavkaCombo";
            this.stavkaCombo.Size = new System.Drawing.Size(246, 33);
            this.stavkaCombo.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(31, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Naziv klijenta";
            // 
            // klijentCombo
            // 
            this.klijentCombo.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.klijentCombo.FormattingEnabled = true;
            this.klijentCombo.Location = new System.Drawing.Point(190, 36);
            this.klijentCombo.Name = "klijentCombo";
            this.klijentCombo.Size = new System.Drawing.Size(121, 28);
            this.klijentCombo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(537, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "kn";
            // 
            // panelRacun
            // 
            this.panelRacun.Controls.Add(this.racunLabel);
            this.panelRacun.Location = new System.Drawing.Point(34, 29);
            this.panelRacun.Name = "panelRacun";
            this.panelRacun.Size = new System.Drawing.Size(533, 490);
            this.panelRacun.TabIndex = 21;
            // 
            // racunLabel
            // 
            this.racunLabel.AutoSize = true;
            this.racunLabel.Location = new System.Drawing.Point(26, 43);
            this.racunLabel.Name = "racunLabel";
            this.racunLabel.Size = new System.Drawing.Size(39, 13);
            this.racunLabel.TabIndex = 3;
            this.racunLabel.Text = "Racun";
            // 
            // RacunUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.panelRacun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUkupno);
            this.Controls.Add(this.printStavkaBtn);
            this.Controls.Add(this.stavkaDataGrid);
            this.Controls.Add(this.kolicinaS);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stavkaCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.klijentCombo);
            this.Name = "RacunUC";
            this.Size = new System.Drawing.Size(605, 590);
            ((System.ComponentModel.ISupportInitialize)(this.stavkaDataGrid)).EndInit();
            this.panelRacun.ResumeLayout(false);
            this.panelRacun.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUkupno;
        private System.Windows.Forms.Button printStavkaBtn;
        private System.Windows.Forms.DataGridView stavkaDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Količina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.TextBox kolicinaS;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox stavkaCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox klijentCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelRacun;
        private System.Windows.Forms.Label racunLabel;
    }
}
