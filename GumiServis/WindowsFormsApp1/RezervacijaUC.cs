using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity;

namespace WindowsFormsApp1
{
    public partial class RezervacijaUC : UserControl
    {

        public RezervacijaUC()
        {
            InitializeComponent();
            napuniSateIMinute();
            napuniBoksIVozila();
            refreshBoks();
            panelNK.Hide();
            radniNalogPanel.Hide();
            dodajAutoPanel.Hide();
        }


        private void napuniSateIMinute()
        {
            for (int i = 8; i < 16; i++)
            {
                ddlSati.Items.Add(i);
            }
            ddlMinute.Items.Add(00);
            ddlMinute.Items.Add(30);
            ddlSati.SelectedIndex = 0;
            ddlMinute.SelectedIndex = 0;

        }

        private void napuniBoksIVozila()
        {
            using (GumiServisModelEntities kontekst = new GumiServisModelEntities())
            {
                ddlBoks.DataSource = kontekst.Boks.ToList();
                ddlVozilo.DataSource = kontekst.Voziloes.ToList();
                ddlBoks.ValueMember = "Id";
                ddlBoks.DisplayMember = "Naziv_boksa";
                ddlVozilo.ValueMember = "Id";
                ddlVozilo.DisplayMember = "Reg_oznaka";
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (GumiServisModelEntities kontekst = new GumiServisModelEntities())
            {
                Raspored raspored = new Raspored();
                string datumVrijeme = dtBirac.Value.ToShortDateString() + " " + ddlSati.SelectedItem + ":" + ddlMinute.SelectedItem;
                raspored.DatumVrijeme = Convert.ToDateTime(datumVrijeme);
                raspored.BoksId = (int)ddlBoks.SelectedValue;
                raspored.VoziloId = (int)ddlVozilo.SelectedValue;

                string tempB = ddlBoks.Text;
                string tempR = ddlVozilo.Text;
                string tempDT = dtBirac.Text + " u " + ddlSati.Text + ":" + ddlMinute.Text;

                StvoriRadniNalog(tempB, tempR, tempDT);

                List<Raspored> popunjeniRaspored = kontekst.Rasporeds.ToList();
                bool zauzeto = false;
                if (popunjeniRaspored.Count == 0)
                {
                    kontekst.Rasporeds.Add(raspored);
                    kontekst.SaveChanges();
                    MessageBox.Show("Uspješno spremljeno!");
                    refreshBoks();

                }
                else
                {
                    foreach (Raspored rasp in popunjeniRaspored)
                    {
                        if (raspored.DatumVrijeme == rasp.DatumVrijeme)
                        {
                            if (raspored.BoksId == rasp.BoksId)
                            {
                                MessageBox.Show("Već zauzet termin, izabrati drugi boks");
                                zauzeto = true;
                            }
                            else
                            {
                                zauzeto = false;
                            }
                        }
                    }
                    if (!zauzeto)
                    {
                        kontekst.Rasporeds.Add(raspored);
                        kontekst.SaveChanges();
                        MessageBox.Show("Uspješno spremljeno!");
                        refreshBoks();
                    }
                }
            }
        }

        private void refreshBoks()
        {
            using (GumiServisModelEntities kontekst = new GumiServisModelEntities())
            {
                List<Raspored> boks1 = kontekst.Rasporeds.Where(r => r.BoksId == 1 && DbFunctions.TruncateTime(r.DatumVrijeme) == calBirac.SelectionStart.Date).OrderBy(r => r.DatumVrijeme).ToList();
                List<Raspored> boks2 = kontekst.Rasporeds.Where(r => r.BoksId == 2 && DbFunctions.TruncateTime(r.DatumVrijeme) == calBirac.SelectionStart.Date).OrderBy(r => r.DatumVrijeme).ToList();
                List<Raspored> boks3 = kontekst.Rasporeds.Where(r => r.BoksId == 3 && DbFunctions.TruncateTime(r.DatumVrijeme) == calBirac.SelectionStart.Date).OrderBy(r => r.DatumVrijeme).ToList();
                txtBoks1.Text = String.Empty;
                txtBoks2.Text = String.Empty;
                txtBoks3.Text = String.Empty;
                foreach (Raspored rasp in boks1)
                {
                    txtBoks1.AppendText(rasp.DatumVrijeme.ToShortTimeString() + "   " + rasp.Vozilo.Reg_oznaka + "\n");
                }
                foreach (Raspored rasp in boks2)
                {
                    txtBoks2.AppendText(rasp.DatumVrijeme.ToShortTimeString() + "   " + rasp.Vozilo.Reg_oznaka + "\n");
                }
                foreach (Raspored rasp in boks3)
                {
                    txtBoks3.AppendText(rasp.DatumVrijeme.ToShortTimeString() + "   " + rasp.Vozilo.Reg_oznaka + "\n");
                }
            }
        }
        private void calBirac_DateChanged(object sender, DateRangeEventArgs e)
        {
            refreshBoks();
        }

        private void noviKlijentBtn_Click(object sender, EventArgs e)
        {
            panelNK.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            panelNK.Hide();
        }

        private void unesiNKbtn_Click(object sender, EventArgs e)
        {
            using (GumiServisModelEntities kontekst = new GumiServisModelEntities())
            {
                if (nazivNK.Text != "" && oibNK.Text != "")
                {
                    Klijent noviKlijent = new Klijent();

                    noviKlijent.Naziv = nazivNK.Text;
                    noviKlijent.OIB = oibNK.Text;
                    if (loyaltyNK.Checked && tvrtkaNK.Checked != false)
                    {
                        MessageBox.Show("Loyalty i Tvrtka ne mogu biti istovremeno selectani");
                    }
                    else
                    {

                        kontekst.Klijents.Add(noviKlijent);

                        kontekst.SaveChanges();
                        MessageBox.Show("Uspješno dodano.");
                        napuniBoksIVozila();
                    }
                }
                else
                {
                    MessageBox.Show("Niste unijeli sve podatke o klijentu.");
                }
            }

            panelNK.Hide();
        }

        public void StvoriRadniNalog(string tempB, string tempR, string tempDT)
        {
            radniNalogPanel.Show();
            radniNalogTxt.Text = "Radni nalog \n\n Dana " + tempDT + " \n Vozilo registracijske oznake: " + tempR + " je zakazalo izmjenu guma \n u boksu: " + tempB + "\n\n Potpis operatera:";
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            radniNalogPanel.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(radniNalogTxt.Text, new Font("Roboto", 15, FontStyle.Regular), Brushes.Black, 150, 125);
        }

        private void regNKbtn_Click(object sender, EventArgs e)
        {
            dodajAutoPanel.Show();
            using (GumiServisModelEntities context = new GumiServisModelEntities())
            {
                klijentZaRegCombo.DataSource = context.Klijents.ToList();
                klijentZaRegCombo.ValueMember = "Id";
                klijentZaRegCombo.DisplayMember = "Naziv";
            }
        }

        private void spremiRegBtn_Click(object sender, EventArgs e)
        {
            using (GumiServisModelEntities kontekst = new GumiServisModelEntities())
            {
                if (registracijaNK.Text != "")
                {
                    Vozilo novoVozilo = new Vozilo();
                    novoVozilo.Reg_oznaka = registracijaNK.Text;
                    novoVozilo.KlijentID = (int)klijentZaRegCombo.SelectedValue;
                    kontekst.Voziloes.Add(novoVozilo);
                    kontekst.SaveChanges();
                }
            }
            dodajAutoPanel.Hide();
            napuniBoksIVozila();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            dodajAutoPanel.Hide();
        }
    }
}
