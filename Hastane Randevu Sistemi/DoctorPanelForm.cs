using System;
using System.Windows.Forms;

namespace Hastane_Randevu_Sistemi
{
    public partial class DoctorPanelForm : Form
    {
        private Doktor aktifDoktor;

        public DoctorPanelForm(Doktor doktor)
        {
            InitializeComponent();
            aktifDoktor = doktor;
        }

        private void DoctorPanelForm_Load(object sender, EventArgs e)
        {
            labelDoktorBilgi.Text = $"Hoş geldiniz, {aktifDoktor.Isim} ({aktifDoktor.UzmanlikAlani})";
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}