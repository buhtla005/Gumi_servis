namespace WindowsFormsApp1
{
    partial class RezervacijaUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezervacijaUC));
            this.regNKbtn = new System.Windows.Forms.Button();
            this.noviKlijentBtn = new System.Windows.Forms.Button();
            this.txtBoks3 = new System.Windows.Forms.TextBox();
            this.txtBoks2 = new System.Windows.Forms.TextBox();
            this.txtBoks1 = new System.Windows.Forms.TextBox();
            this.calBirac = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.ddlMinute = new System.Windows.Forms.ComboBox();
            this.ddlSati = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtBirac = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlVozilo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ddlBoks = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelNK = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.loyaltyNK = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.oibNK = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nazivNK = new System.Windows.Forms.TextBox();
            this.tvrtkaNK = new System.Windows.Forms.CheckBox();
            this.unesiNKbtn = new System.Windows.Forms.Button();
            this.dodajAutoPanel = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.spremiRegBtn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.klijentZaRegCombo = new System.Windows.Forms.ComboBox();
            this.registracijaNK = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.radniNalogPanel = new System.Windows.Forms.Panel();
            this.printBtn = new System.Windows.Forms.Button();
            this.radniNalogTxt = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panelNK.SuspendLayout();
            this.dodajAutoPanel.SuspendLayout();
            this.radniNalogPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // regNKbtn
            // 
            this.regNKbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.regNKbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regNKbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regNKbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.regNKbtn.Location = new System.Drawing.Point(431, 276);
            this.regNKbtn.Name = "regNKbtn";
            this.regNKbtn.Size = new System.Drawing.Size(122, 38);
            this.regNKbtn.TabIndex = 35;
            this.regNKbtn.Text = "Dodaj auto";
            this.regNKbtn.UseVisualStyleBackColor = false;
            this.regNKbtn.Click += new System.EventHandler(this.regNKbtn_Click);
            // 
            // noviKlijentBtn
            // 
            this.noviKlijentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.noviKlijentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noviKlijentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noviKlijentBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.noviKlijentBtn.Location = new System.Drawing.Point(431, 227);
            this.noviKlijentBtn.Name = "noviKlijentBtn";
            this.noviKlijentBtn.Size = new System.Drawing.Size(122, 38);
            this.noviKlijentBtn.TabIndex = 34;
            this.noviKlijentBtn.Text = "Novi klijent";
            this.noviKlijentBtn.UseVisualStyleBackColor = false;
            this.noviKlijentBtn.Click += new System.EventHandler(this.noviKlijentBtn_Click);
            // 
            // txtBoks3
            // 
            this.txtBoks3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoks3.Location = new System.Drawing.Point(259, 31);
            this.txtBoks3.Multiline = true;
            this.txtBoks3.Name = "txtBoks3";
            this.txtBoks3.ReadOnly = true;
            this.txtBoks3.Size = new System.Drawing.Size(110, 301);
            this.txtBoks3.TabIndex = 33;
            // 
            // txtBoks2
            // 
            this.txtBoks2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoks2.Location = new System.Drawing.Point(143, 31);
            this.txtBoks2.Multiline = true;
            this.txtBoks2.Name = "txtBoks2";
            this.txtBoks2.ReadOnly = true;
            this.txtBoks2.Size = new System.Drawing.Size(110, 301);
            this.txtBoks2.TabIndex = 32;
            // 
            // txtBoks1
            // 
            this.txtBoks1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoks1.Location = new System.Drawing.Point(27, 31);
            this.txtBoks1.Multiline = true;
            this.txtBoks1.Name = "txtBoks1";
            this.txtBoks1.ReadOnly = true;
            this.txtBoks1.Size = new System.Drawing.Size(110, 301);
            this.txtBoks1.TabIndex = 31;
            // 
            // calBirac
            // 
            this.calBirac.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.calBirac.Location = new System.Drawing.Point(383, 31);
            this.calBirac.MaxSelectionCount = 1;
            this.calBirac.Name = "calBirac";
            this.calBirac.TabIndex = 30;
            this.calBirac.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calBirac_DateChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(284, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Boks 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(169, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Boks 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Boks 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(37, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 19);
            this.label10.TabIndex = 47;
            this.label10.Text = "Rezerviraj termin";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(-11, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(608, 2);
            this.label9.TabIndex = 46;
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremi.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.btnSpremi.Location = new System.Drawing.Point(401, 499);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(108, 36);
            this.btnSpremi.TabIndex = 45;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // ddlMinute
            // 
            this.ddlMinute.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ddlMinute.FormattingEnabled = true;
            this.ddlMinute.Location = new System.Drawing.Point(449, 451);
            this.ddlMinute.Name = "ddlMinute";
            this.ddlMinute.Size = new System.Drawing.Size(53, 26);
            this.ddlMinute.TabIndex = 44;
            // 
            // ddlSati
            // 
            this.ddlSati.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ddlSati.FormattingEnabled = true;
            this.ddlSati.Location = new System.Drawing.Point(372, 451);
            this.ddlSati.Name = "ddlSati";
            this.ddlSati.Size = new System.Drawing.Size(55, 26);
            this.ddlSati.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(306, 457);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 42;
            this.label7.Text = "Vrijeme:";
            // 
            // dtBirac
            // 
            this.dtBirac.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtBirac.Location = new System.Drawing.Point(371, 411);
            this.dtBirac.Name = "dtBirac";
            this.dtBirac.Size = new System.Drawing.Size(200, 26);
            this.dtBirac.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(309, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 40;
            this.label6.Text = "Datum:";
            // 
            // ddlVozilo
            // 
            this.ddlVozilo.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ddlVozilo.FormattingEnabled = true;
            this.ddlVozilo.Location = new System.Drawing.Point(174, 452);
            this.ddlVozilo.Name = "ddlVozilo";
            this.ddlVozilo.Size = new System.Drawing.Size(121, 26);
            this.ddlVozilo.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(34, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 18);
            this.label5.TabIndex = 38;
            this.label5.Text = "Registracija vozila:";
            // 
            // ddlBoks
            // 
            this.ddlBoks.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ddlBoks.FormattingEnabled = true;
            this.ddlBoks.Location = new System.Drawing.Point(174, 411);
            this.ddlBoks.Name = "ddlBoks";
            this.ddlBoks.Size = new System.Drawing.Size(121, 26);
            this.ddlBoks.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(122, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Boks:";
            // 
            // panelNK
            // 
            this.panelNK.BackColor = System.Drawing.Color.DarkRed;
            this.panelNK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelNK.BackgroundImage")));
            this.panelNK.Controls.Add(this.label15);
            this.panelNK.Controls.Add(this.loyaltyNK);
            this.panelNK.Controls.Add(this.label14);
            this.panelNK.Controls.Add(this.oibNK);
            this.panelNK.Controls.Add(this.label12);
            this.panelNK.Controls.Add(this.label11);
            this.panelNK.Controls.Add(this.nazivNK);
            this.panelNK.Controls.Add(this.tvrtkaNK);
            this.panelNK.Controls.Add(this.unesiNKbtn);
            this.panelNK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelNK.Location = new System.Drawing.Point(27, 3);
            this.panelNK.Name = "panelNK";
            this.panelNK.Size = new System.Drawing.Size(344, 342);
            this.panelNK.TabIndex = 48;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.label15.Location = new System.Drawing.Point(316, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 19);
            this.label15.TabIndex = 35;
            this.label15.Text = "X";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // loyaltyNK
            // 
            this.loyaltyNK.AutoSize = true;
            this.loyaltyNK.BackColor = System.Drawing.Color.Transparent;
            this.loyaltyNK.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loyaltyNK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.loyaltyNK.Location = new System.Drawing.Point(180, 165);
            this.loyaltyNK.Name = "loyaltyNK";
            this.loyaltyNK.Size = new System.Drawing.Size(80, 23);
            this.loyaltyNK.TabIndex = 34;
            this.loyaltyNK.Text = "Loyalty";
            this.loyaltyNK.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.label14.Location = new System.Drawing.Point(64, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(213, 19);
            this.label14.TabIndex = 33;
            this.label14.Text = "Registracija novog korisnika";
            // 
            // oibNK
            // 
            this.oibNK.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oibNK.Location = new System.Drawing.Point(140, 117);
            this.oibNK.Name = "oibNK";
            this.oibNK.Size = new System.Drawing.Size(177, 27);
            this.oibNK.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.label12.Location = new System.Drawing.Point(21, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 19);
            this.label12.TabIndex = 29;
            this.label12.Text = "OIB:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.label11.Location = new System.Drawing.Point(21, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 19);
            this.label11.TabIndex = 28;
            this.label11.Text = "Naziv:";
            // 
            // nazivNK
            // 
            this.nazivNK.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazivNK.Location = new System.Drawing.Point(140, 66);
            this.nazivNK.Name = "nazivNK";
            this.nazivNK.Size = new System.Drawing.Size(177, 27);
            this.nazivNK.TabIndex = 27;
            // 
            // tvrtkaNK
            // 
            this.tvrtkaNK.AutoSize = true;
            this.tvrtkaNK.BackColor = System.Drawing.Color.Transparent;
            this.tvrtkaNK.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tvrtkaNK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.tvrtkaNK.Location = new System.Drawing.Point(64, 165);
            this.tvrtkaNK.Name = "tvrtkaNK";
            this.tvrtkaNK.Size = new System.Drawing.Size(74, 23);
            this.tvrtkaNK.TabIndex = 26;
            this.tvrtkaNK.Text = "Tvrtka";
            this.tvrtkaNK.UseVisualStyleBackColor = false;
            // 
            // unesiNKbtn
            // 
            this.unesiNKbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.unesiNKbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unesiNKbtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unesiNKbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.unesiNKbtn.Location = new System.Drawing.Point(118, 267);
            this.unesiNKbtn.Name = "unesiNKbtn";
            this.unesiNKbtn.Size = new System.Drawing.Size(122, 38);
            this.unesiNKbtn.TabIndex = 25;
            this.unesiNKbtn.Text = "Spremi";
            this.unesiNKbtn.UseVisualStyleBackColor = false;
            this.unesiNKbtn.Click += new System.EventHandler(this.unesiNKbtn_Click);
            // 
            // dodajAutoPanel
            // 
            this.dodajAutoPanel.BackColor = System.Drawing.Color.DarkRed;
            this.dodajAutoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dodajAutoPanel.BackgroundImage")));
            this.dodajAutoPanel.Controls.Add(this.label17);
            this.dodajAutoPanel.Controls.Add(this.spremiRegBtn);
            this.dodajAutoPanel.Controls.Add(this.label16);
            this.dodajAutoPanel.Controls.Add(this.klijentZaRegCombo);
            this.dodajAutoPanel.Controls.Add(this.registracijaNK);
            this.dodajAutoPanel.Controls.Add(this.label13);
            this.dodajAutoPanel.Location = new System.Drawing.Point(27, 354);
            this.dodajAutoPanel.Name = "dodajAutoPanel";
            this.dodajAutoPanel.Size = new System.Drawing.Size(344, 198);
            this.dodajAutoPanel.TabIndex = 49;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.label17.Location = new System.Drawing.Point(318, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 19);
            this.label17.TabIndex = 36;
            this.label17.Text = "X";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // spremiRegBtn
            // 
            this.spremiRegBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.spremiRegBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spremiRegBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.spremiRegBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.spremiRegBtn.Location = new System.Drawing.Point(95, 148);
            this.spremiRegBtn.Name = "spremiRegBtn";
            this.spremiRegBtn.Size = new System.Drawing.Size(161, 38);
            this.spremiRegBtn.TabIndex = 27;
            this.spremiRegBtn.Text = "Spremi registraciju";
            this.spremiRegBtn.UseVisualStyleBackColor = false;
            this.spremiRegBtn.Click += new System.EventHandler(this.spremiRegBtn_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.label16.Location = new System.Drawing.Point(51, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 19);
            this.label16.TabIndex = 34;
            this.label16.Text = "Klijent:";
            // 
            // klijentZaRegCombo
            // 
            this.klijentZaRegCombo.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.klijentZaRegCombo.FormattingEnabled = true;
            this.klijentZaRegCombo.Location = new System.Drawing.Point(164, 43);
            this.klijentZaRegCombo.Name = "klijentZaRegCombo";
            this.klijentZaRegCombo.Size = new System.Drawing.Size(134, 21);
            this.klijentZaRegCombo.TabIndex = 33;
            // 
            // registracijaNK
            // 
            this.registracijaNK.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registracijaNK.Location = new System.Drawing.Point(164, 93);
            this.registracijaNK.Name = "registracijaNK";
            this.registracijaNK.Size = new System.Drawing.Size(134, 27);
            this.registracijaNK.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.label13.Location = new System.Drawing.Point(51, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 19);
            this.label13.TabIndex = 30;
            this.label13.Text = "Registracija:";
            // 
            // radniNalogPanel
            // 
            this.radniNalogPanel.Controls.Add(this.printBtn);
            this.radniNalogPanel.Controls.Add(this.radniNalogTxt);
            this.radniNalogPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.radniNalogPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radniNalogPanel.Location = new System.Drawing.Point(0, 0);
            this.radniNalogPanel.Name = "radniNalogPanel";
            this.radniNalogPanel.Size = new System.Drawing.Size(591, 405);
            this.radniNalogPanel.TabIndex = 50;
            // 
            // printBtn
            // 
            this.printBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.printBtn.Location = new System.Drawing.Point(450, 339);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(129, 33);
            this.printBtn.TabIndex = 3;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // radniNalogTxt
            // 
            this.radniNalogTxt.AutoSize = true;
            this.radniNalogTxt.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radniNalogTxt.Location = new System.Drawing.Point(34, 78);
            this.radniNalogTxt.Name = "radniNalogTxt";
            this.radniNalogTxt.Size = new System.Drawing.Size(153, 19);
            this.radniNalogTxt.TabIndex = 1;
            this.radniNalogTxt.Text = "Ovdje pise obavijest";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // RezervacijaUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.radniNalogPanel);
            this.Controls.Add(this.dodajAutoPanel);
            this.Controls.Add(this.panelNK);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.ddlMinute);
            this.Controls.Add(this.ddlSati);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtBirac);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ddlVozilo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ddlBoks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.regNKbtn);
            this.Controls.Add(this.noviKlijentBtn);
            this.Controls.Add(this.txtBoks3);
            this.Controls.Add(this.txtBoks2);
            this.Controls.Add(this.txtBoks1);
            this.Controls.Add(this.calBirac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RezervacijaUC";
            this.Size = new System.Drawing.Size(591, 552);
            this.panelNK.ResumeLayout(false);
            this.panelNK.PerformLayout();
            this.dodajAutoPanel.ResumeLayout(false);
            this.dodajAutoPanel.PerformLayout();
            this.radniNalogPanel.ResumeLayout(false);
            this.radniNalogPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regNKbtn;
        private System.Windows.Forms.Button noviKlijentBtn;
        private System.Windows.Forms.TextBox txtBoks3;
        private System.Windows.Forms.TextBox txtBoks2;
        private System.Windows.Forms.TextBox txtBoks1;
        private System.Windows.Forms.MonthCalendar calBirac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.ComboBox ddlMinute;
        private System.Windows.Forms.ComboBox ddlSati;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtBirac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddlVozilo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ddlBoks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelNK;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox loyaltyNK;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox oibNK;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox nazivNK;
        private System.Windows.Forms.CheckBox tvrtkaNK;
        private System.Windows.Forms.Button unesiNKbtn;
        private System.Windows.Forms.Panel dodajAutoPanel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button spremiRegBtn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox klijentZaRegCombo;
        private System.Windows.Forms.TextBox registracijaNK;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel radniNalogPanel;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Label radniNalogTxt;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}
