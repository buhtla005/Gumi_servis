namespace WindowsFormsApp1
{
    partial class SkladistenjeUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkladistenjeUC));
            this.pnlUgovori = new System.Windows.Forms.Panel();
            this.natragBtn = new System.Windows.Forms.Button();
            this.dgvUgovori = new System.Windows.Forms.DataGridView();
            this.Br_ugovora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum_sklapanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum_isteka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vozilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klijent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUgovori = new System.Windows.Forms.Button();
            this.sklopiBtn = new System.Windows.Forms.Button();
            this.ugovorPanel = new System.Windows.Forms.Panel();
            this.printUgovorBtn = new System.Windows.Forms.Button();
            this.potpisKlabel = new System.Windows.Forms.Label();
            this.potpisZlabel = new System.Windows.Forms.Label();
            this.ugovorTxtLabel = new System.Windows.Forms.Label();
            this.ugovorBrLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.skladisteCombo = new System.Windows.Forms.ComboBox();
            this.regCombo = new System.Windows.Forms.ComboBox();
            this.klijentCombo = new System.Windows.Forms.ComboBox();
            this.poslovnicaCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datumUgovorCal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ugovorTxt = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pnlUgovori.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovori)).BeginInit();
            this.ugovorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUgovori
            // 
            this.pnlUgovori.Controls.Add(this.natragBtn);
            this.pnlUgovori.Controls.Add(this.dgvUgovori);
            this.pnlUgovori.Location = new System.Drawing.Point(20, 72);
            this.pnlUgovori.Name = "pnlUgovori";
            this.pnlUgovori.Size = new System.Drawing.Size(568, 373);
            this.pnlUgovori.TabIndex = 18;
            // 
            // natragBtn
            // 
            this.natragBtn.Location = new System.Drawing.Point(479, 17);
            this.natragBtn.Name = "natragBtn";
            this.natragBtn.Size = new System.Drawing.Size(75, 23);
            this.natragBtn.TabIndex = 1;
            this.natragBtn.Text = "Natrag";
            this.natragBtn.UseVisualStyleBackColor = true;
            this.natragBtn.Click += new System.EventHandler(this.natragBtn_Click);
            // 
            // dgvUgovori
            // 
            this.dgvUgovori.AllowUserToAddRows = false;
            this.dgvUgovori.AllowUserToDeleteRows = false;
            this.dgvUgovori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUgovori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Br_ugovora,
            this.Datum_sklapanja,
            this.Datum_isteka,
            this.Vozilo,
            this.Klijent});
            this.dgvUgovori.Location = new System.Drawing.Point(10, 46);
            this.dgvUgovori.Name = "dgvUgovori";
            this.dgvUgovori.ReadOnly = true;
            this.dgvUgovori.Size = new System.Drawing.Size(544, 313);
            this.dgvUgovori.TabIndex = 0;
            // 
            // Br_ugovora
            // 
            this.Br_ugovora.DataPropertyName = "Br_ugovora";
            this.Br_ugovora.HeaderText = "Ugovor broj";
            this.Br_ugovora.Name = "Br_ugovora";
            this.Br_ugovora.ReadOnly = true;
            // 
            // Datum_sklapanja
            // 
            this.Datum_sklapanja.DataPropertyName = "Datum_sklapanja";
            this.Datum_sklapanja.HeaderText = "Datum sklapanja";
            this.Datum_sklapanja.Name = "Datum_sklapanja";
            this.Datum_sklapanja.ReadOnly = true;
            // 
            // Datum_isteka
            // 
            this.Datum_isteka.DataPropertyName = "Datum_Isteka";
            this.Datum_isteka.HeaderText = "Datum isteka";
            this.Datum_isteka.Name = "Datum_isteka";
            this.Datum_isteka.ReadOnly = true;
            // 
            // Vozilo
            // 
            this.Vozilo.DataPropertyName = "Vozilo";
            this.Vozilo.HeaderText = "Vozilo";
            this.Vozilo.Name = "Vozilo";
            this.Vozilo.ReadOnly = true;
            // 
            // Klijent
            // 
            this.Klijent.DataPropertyName = "Klijent";
            this.Klijent.HeaderText = "Klijent";
            this.Klijent.Name = "Klijent";
            this.Klijent.ReadOnly = true;
            // 
            // btnUgovori
            // 
            this.btnUgovori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnUgovori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUgovori.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUgovori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.btnUgovori.Location = new System.Drawing.Point(30, 488);
            this.btnUgovori.Name = "btnUgovori";
            this.btnUgovori.Size = new System.Drawing.Size(138, 31);
            this.btnUgovori.TabIndex = 17;
            this.btnUgovori.Text = "Popis ugovora";
            this.btnUgovori.UseVisualStyleBackColor = false;
            this.btnUgovori.Click += new System.EventHandler(this.btnUgovori_Click);
            // 
            // sklopiBtn
            // 
            this.sklopiBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.sklopiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sklopiBtn.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sklopiBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.sklopiBtn.Location = new System.Drawing.Point(416, 488);
            this.sklopiBtn.Name = "sklopiBtn";
            this.sklopiBtn.Size = new System.Drawing.Size(138, 31);
            this.sklopiBtn.TabIndex = 16;
            this.sklopiBtn.Text = "Sklopi ugovor";
            this.sklopiBtn.UseVisualStyleBackColor = false;
            this.sklopiBtn.Click += new System.EventHandler(this.sklopiBtn_Click);
            // 
            // ugovorPanel
            // 
            this.ugovorPanel.BackColor = System.Drawing.Color.White;
            this.ugovorPanel.Controls.Add(this.printUgovorBtn);
            this.ugovorPanel.Controls.Add(this.potpisKlabel);
            this.ugovorPanel.Controls.Add(this.potpisZlabel);
            this.ugovorPanel.Controls.Add(this.ugovorTxtLabel);
            this.ugovorPanel.Controls.Add(this.ugovorBrLabel);
            this.ugovorPanel.Location = new System.Drawing.Point(-7, 0);
            this.ugovorPanel.Name = "ugovorPanel";
            this.ugovorPanel.Size = new System.Drawing.Size(605, 482);
            this.ugovorPanel.TabIndex = 19;
            // 
            // printUgovorBtn
            // 
            this.printUgovorBtn.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.printUgovorBtn.Location = new System.Drawing.Point(450, 434);
            this.printUgovorBtn.Name = "printUgovorBtn";
            this.printUgovorBtn.Size = new System.Drawing.Size(115, 36);
            this.printUgovorBtn.TabIndex = 5;
            this.printUgovorBtn.Text = "Print";
            this.printUgovorBtn.UseVisualStyleBackColor = true;
            this.printUgovorBtn.Click += new System.EventHandler(this.printUgovorBtn_Click);
            // 
            // potpisKlabel
            // 
            this.potpisKlabel.AutoSize = true;
            this.potpisKlabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.potpisKlabel.Location = new System.Drawing.Point(421, 285);
            this.potpisKlabel.Name = "potpisKlabel";
            this.potpisKlabel.Size = new System.Drawing.Size(109, 19);
            this.potpisKlabel.TabIndex = 3;
            this.potpisKlabel.Text = "Potpis klijenta";
            // 
            // potpisZlabel
            // 
            this.potpisZlabel.AutoSize = true;
            this.potpisZlabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.potpisZlabel.Location = new System.Drawing.Point(46, 285);
            this.potpisZlabel.Name = "potpisZlabel";
            this.potpisZlabel.Size = new System.Drawing.Size(143, 19);
            this.potpisZlabel.TabIndex = 2;
            this.potpisZlabel.Text = "Potpis zaposlenika";
            // 
            // ugovorTxtLabel
            // 
            this.ugovorTxtLabel.AutoSize = true;
            this.ugovorTxtLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ugovorTxtLabel.Location = new System.Drawing.Point(55, 97);
            this.ugovorTxtLabel.Name = "ugovorTxtLabel";
            this.ugovorTxtLabel.Size = new System.Drawing.Size(109, 19);
            this.ugovorTxtLabel.TabIndex = 1;
            this.ugovorTxtLabel.Text = "Tekst ugovora";
            // 
            // ugovorBrLabel
            // 
            this.ugovorBrLabel.AutoSize = true;
            this.ugovorBrLabel.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ugovorBrLabel.Location = new System.Drawing.Point(45, 38);
            this.ugovorBrLabel.Name = "ugovorBrLabel";
            this.ugovorBrLabel.Size = new System.Drawing.Size(70, 23);
            this.ugovorBrLabel.TabIndex = 0;
            this.ugovorBrLabel.Text = "Ugovor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(87, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Registracija:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(87, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "Poslovnica:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(87, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Klijent:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(87, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Skladiste:";
            // 
            // skladisteCombo
            // 
            this.skladisteCombo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.skladisteCombo.FormattingEnabled = true;
            this.skladisteCombo.Location = new System.Drawing.Point(298, 380);
            this.skladisteCombo.Name = "skladisteCombo";
            this.skladisteCombo.Size = new System.Drawing.Size(211, 27);
            this.skladisteCombo.TabIndex = 28;
            // 
            // regCombo
            // 
            this.regCombo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.regCombo.FormattingEnabled = true;
            this.regCombo.Location = new System.Drawing.Point(298, 333);
            this.regCombo.Name = "regCombo";
            this.regCombo.Size = new System.Drawing.Size(211, 27);
            this.regCombo.TabIndex = 27;
            // 
            // klijentCombo
            // 
            this.klijentCombo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.klijentCombo.FormattingEnabled = true;
            this.klijentCombo.Location = new System.Drawing.Point(298, 283);
            this.klijentCombo.Name = "klijentCombo";
            this.klijentCombo.Size = new System.Drawing.Size(211, 27);
            this.klijentCombo.TabIndex = 26;
            this.klijentCombo.SelectedIndexChanged += new System.EventHandler(this.klijentCombo_SelectedIndexChanged);
            // 
            // poslovnicaCombo
            // 
            this.poslovnicaCombo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poslovnicaCombo.FormattingEnabled = true;
            this.poslovnicaCombo.Location = new System.Drawing.Point(298, 231);
            this.poslovnicaCombo.Name = "poslovnicaCombo";
            this.poslovnicaCombo.Size = new System.Drawing.Size(211, 27);
            this.poslovnicaCombo.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(87, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ugovor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(87, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Datum sklapanja:";
            // 
            // datumUgovorCal
            // 
            this.datumUgovorCal.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datumUgovorCal.Location = new System.Drawing.Point(298, 181);
            this.datumUgovorCal.Name = "datumUgovorCal";
            this.datumUgovorCal.Size = new System.Drawing.Size(211, 27);
            this.datumUgovorCal.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(87, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ugovor br.";
            // 
            // ugovorTxt
            // 
            this.ugovorTxt.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ugovorTxt.Location = new System.Drawing.Point(298, 131);
            this.ugovorTxt.Name = "ugovorTxt";
            this.ugovorTxt.Size = new System.Drawing.Size(129, 27);
            this.ugovorTxt.TabIndex = 20;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // SkladistenjeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.ugovorPanel);
            this.Controls.Add(this.pnlUgovori);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.skladisteCombo);
            this.Controls.Add(this.regCombo);
            this.Controls.Add(this.klijentCombo);
            this.Controls.Add(this.poslovnicaCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datumUgovorCal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ugovorTxt);
            this.Controls.Add(this.btnUgovori);
            this.Controls.Add(this.sklopiBtn);
            this.Name = "SkladistenjeUC";
            this.Size = new System.Drawing.Size(591, 552);
            this.pnlUgovori.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovori)).EndInit();
            this.ugovorPanel.ResumeLayout(false);
            this.ugovorPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlUgovori;
        private System.Windows.Forms.Button natragBtn;
        private System.Windows.Forms.DataGridView dgvUgovori;
        private System.Windows.Forms.DataGridViewTextBoxColumn Br_ugovora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum_sklapanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum_isteka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vozilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klijent;
        private System.Windows.Forms.Button btnUgovori;
        private System.Windows.Forms.Button sklopiBtn;
        private System.Windows.Forms.Panel ugovorPanel;
        private System.Windows.Forms.Button printUgovorBtn;
        private System.Windows.Forms.Label potpisKlabel;
        private System.Windows.Forms.Label potpisZlabel;
        private System.Windows.Forms.Label ugovorTxtLabel;
        private System.Windows.Forms.Label ugovorBrLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox skladisteCombo;
        private System.Windows.Forms.ComboBox regCombo;
        private System.Windows.Forms.ComboBox klijentCombo;
        private System.Windows.Forms.ComboBox poslovnicaCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datumUgovorCal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ugovorTxt;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}
