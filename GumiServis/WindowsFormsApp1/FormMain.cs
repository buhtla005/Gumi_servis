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
    public partial class FormMain : Form
    {
        
        public FormMain(string ime, string prezime)
        {
            InitializeComponent();
            SidePanel.Height = button5.Height;

            imeLabel.Text = ime + " " + prezime;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            rezervacijaUC1.SendToBack();
            racunUC1.SendToBack();
            skladistenjeUC1.SendToBack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            racunUC1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            rezervacijaUC1.BringToFront();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            skladistenjeUC1.BringToFront();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button4.Top;
            FormLogin forma = new FormLogin();
            forma.Show();
        }
    }
}
