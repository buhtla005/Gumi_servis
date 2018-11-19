using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RacunUC : UserControl
    {
        List<Racun> racuni;
        double ukupno;
        public RacunUC()
        {
            InitializeComponent();
            napuniKlijente();
            napuniStavke();
            panelRacun.Hide();
            racuni = new List<Racun>();
            ukupno = 0;
            lblUkupno.Text = ukupno.ToString();
            stavkaDataGrid.DataSource = null;
        }

        private void napuniKlijente()
        {
            using (GumiServisModelEntities context = new GumiServisModelEntities())
            {
                klijentCombo.DataSource = context.Klijents.ToList();
                klijentCombo.ValueMember = "Id";
                klijentCombo.DisplayMember = "Naziv";
            }
        }
        private void napuniStavke()
        {
            using (GumiServisModelEntities context = new GumiServisModelEntities())
            {
                stavkaCombo.DataSource = context.UslugaProdajas.ToList();
                stavkaCombo.ValueMember = "Id";
                stavkaCombo.DisplayMember = "Naziv_us_pro";
            }
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            Racun racun = new Racun();
            Klijent klijent = new Klijent();
            using (GumiServisModelEntities context = new GumiServisModelEntities())
            {
                racun.Usluga = context.UslugaProdajas.Where(u => u.Id == (int)stavkaCombo.SelectedValue).FirstOrDefault();
                klijent = context.Klijents.Where(k => k.Id == (int)klijentCombo.SelectedValue).FirstOrDefault();
            }
            racun.Kolicina = Int32.Parse(kolicinaS.Text);
            if (klijent.Loyality.Value || klijent.Tvrtka.Value && racun.Usluga.Id >= 1 && racun.Usluga.Id <= 3)
            {
                racun.unesiCijenu(true);
            }
            else
                racun.unesiCijenu(false);

            racuni.Add(racun);
            refreshRacuna();
            ukupno += racun.Cijena;
            lblUkupno.Text = ukupno.ToString();
        }

        public string RacunToString()
        {
            string racun = "";
            foreach (Racun stavka in racuni)
            {
                racun += stavka.Usluga.Naziv_us_pro + "     " + stavka.Usluga.Jed_cijena + "        " + stavka.Kolicina + "     " + stavka.Cijena + "\n";
            }
            return racun;
        }

        private void refreshRacuna()
        {
            stavkaDataGrid.DataSource = null;
            stavkaDataGrid.DataSource = racuni;
        }

        private void printStavkaBtn_Click(object sender, EventArgs e)
        {
            panelRacun.Show();
            using (GumiServisModelEntities kontekst = new GumiServisModelEntities())
            {
                string datum = DateTime.Now.ToString();

                     
                racunLabel.Text = datum + "\n\n" + RacunToString() + "\n\n\tPotpis zaposlenika:                                 Potpis klijenta:";

                stavkaDataGrid.DataSource = null;

            }

                
        }
    }
}
