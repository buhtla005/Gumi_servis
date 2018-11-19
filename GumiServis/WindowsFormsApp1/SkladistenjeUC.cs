using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace WindowsFormsApp1
{
    public partial class SkladistenjeUC : UserControl
    {
        public SkladistenjeUC()
        {
            InitializeComponent();
            PopuniUgovor();
            pnlUgovori.Hide();
            ugovorPanel.Hide();
        }


        public void PopuniUgovor()
        {
            using (GumiServisModelEntities context = new GumiServisModelEntities())
            {
                klijentCombo.DataSource = context.Klijents.ToList();
                klijentCombo.ValueMember = "Id";
                klijentCombo.DisplayMember = "Naziv";
                klijentCombo.SelectedIndex = 0;

                poslovnicaCombo.DataSource = context.Poslovnicas.ToList();
                poslovnicaCombo.ValueMember = "Id";
                poslovnicaCombo.DisplayMember = "Naziv_po";

                skladisteCombo.DataSource = context.Skladistes.ToList();
                skladisteCombo.ValueMember = "Id";
                skladisteCombo.DisplayMember = "Naziv_sk";

            }
        }

        private void sklopiBtn_Click(object sender, EventArgs e)
        {
            if (ugovorTxt.Text != "" && datumUgovorCal.Value != null && poslovnicaCombo.SelectedValue != null && skladisteCombo.SelectedValue != null && klijentCombo.SelectedValue != null && regCombo.SelectedValue != null)
            {

                using (GumiServisModelEntities context = new GumiServisModelEntities())
                {
                    Ugovor noviUgovor = new Ugovor();
                    noviUgovor.Br_ugovora = Int32.Parse(ugovorTxt.Text);
                    noviUgovor.Datum_sklapanja = datumUgovorCal.Value;
                    noviUgovor.PoslovnicaID = (int)poslovnicaCombo.SelectedValue;
                    noviUgovor.KlijentID = (int)klijentCombo.SelectedValue;
                    noviUgovor.VoziloID = (int)regCombo.SelectedValue;
                    noviUgovor.SkladisteID = (int)skladisteCombo.SelectedValue;
                    noviUgovor.Datum_Isteka = noviUgovor.Datum_sklapanja.AddMonths(6);
                    context.Ugovors.Add(noviUgovor);
                    context.SaveChanges();
                }
                ugovorPanel.Show();
                string pos = poslovnicaCombo.GetItemText(poslovnicaCombo.SelectedItem);
                string kli = klijentCombo.GetItemText(klijentCombo.SelectedItem);
                string reg = regCombo.GetItemText(regCombo.SelectedItem);
                string datIst = datumUgovorCal.Value.AddMonths(6).ToString();
                ugovorTxtLabel.Text = "Ugovor br. " + ugovorTxt.Text.ToString() + "\n\nDana " + datumUgovorCal.Value + " sklopljen je ugovor po kojem \nposlovnica - " + pos + " garantira da će čuvati gume \nklijenta - " + kli + " vozila registracijske oznake - " + reg + "\nu razdoblju do " + datIst + ". Nakon toga plaćaju \nse penali u iznosu od 0,30 Kn za gumu po danu ili 0,25 Kn\nukoliko je klijent tvrtka.";
            }
            else
                MessageBox.Show("Ugovor zahtjeva sve navedene podatke!");


        }


        private void klijentCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (GumiServisModelEntities context = new GumiServisModelEntities())
            {
                int klijentId = (int)klijentCombo.SelectedValue;
                regCombo.DataSource = context.Voziloes.Where(v => v.KlijentID == klijentId).ToList();
                regCombo.ValueMember = "Id";
                regCombo.DisplayMember = "Reg_oznaka";
            }
        }

        private void btnUgovori_Click(object sender, EventArgs e)
        {
            pnlUgovori.Show();
            using (GumiServisModelEntities con = new GumiServisModelEntities())
            {
                dgvUgovori.AutoGenerateColumns = false;
                List<Ugovor> ugovori = con.Ugovors.Include(u => u.Klijent).Include(u => u.Vozilo).ToList();
                dgvUgovori.DataSource = ugovori;
            }
        }

        private void printUgovorBtn_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            ugovorPanel.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(ugovorTxtLabel.Text, new Font("Roboto", 15, FontStyle.Regular), Brushes.Black, 150, 125);
        }

        private void natragBtn_Click(object sender, EventArgs e)
        {
            pnlUgovori.Hide();
        }
    }
}
