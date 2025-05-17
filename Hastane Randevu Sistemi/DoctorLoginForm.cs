using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hastane_Randevu_Sistemi
{
    public partial class DoctorLoginForm : Form
    {
        private List<Doktor> doktorlar;

        public DoctorLoginForm(List<Doktor> doktorListesi)
        {
            InitializeComponent();
            doktorlar = doktorListesi;
            buttonGiris.Click += ButtonGiris_Click;
        }

        private void ButtonGiris_Click(object sender, EventArgs e)
        {
            string isim = textBoxIsim.Text.Trim();
            string sifre = textBoxSifre.Text;

            var doktor = doktorlar.Find(d => d.Isim == isim && d.Sifre == sifre);
            if (doktor != null)
            {
                DoctorPanelForm panel = new DoctorPanelForm(doktor);
                panel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("İsim veya şifre yanlış.");
            }
        }
    }
}