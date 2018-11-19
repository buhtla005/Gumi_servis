using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    { 
        public FormLogin()
        {
           InitializeComponent();
        }

        private void izlazButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void prijavaButton_Click(object sender, EventArgs e)
        {
            using (GumiServisModelEntities kontekst = new GumiServisModelEntities())
            {
                if (userBox.Text != "" && passwordBox.Text != "")
                {
                    Zaposlenik zap = kontekst.Zaposleniks.FirstOrDefault(c => c.Korisnicko_ime == userBox.Text);

                    if (zap == null)
                    {
                        MessageBox.Show("Taj korisnik ne postoji u bazi.");
                    }
                    else
                    {
                        if (zap.Lozinka != passwordBox.Text)
                            MessageBox.Show("Kriva lozinka. Unesite ponovno.");
                        else
                        {
                            this.Hide();
                            FormMain f1 = new FormMain(zap.Ime, zap.Prezime);
                            f1.Show();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Unesite korisnicko ime i lozinku.");
                }
            }
        }
    }
}
