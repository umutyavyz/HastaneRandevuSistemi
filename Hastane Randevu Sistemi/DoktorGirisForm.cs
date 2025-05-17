using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Hastane_Randevu_Sistemi
{
    public partial class DoktorGirisForm : Form
    {
       
        public DoktorGirisForm()
        {
            InitializeComponent();
            
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            string doktorAd = textBoxDoktorIsim.Text.Trim();
            string sifre = textBoxSifre.Text.Trim();

            if (string.IsNullOrEmpty(doktorAd) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            string query = "SELECT * FROM Doktorlar WHERE Ad_Soyad = @ad AND Sifre = @sifre";
            SqlParameter[] parameters = {
        new SqlParameter("@ad", doktorAd),
        new SqlParameter("@sifre", sifre)
    };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                int doktorID = Convert.ToInt32(dt.Rows[0]["DoktorID"]);
                string doktorAdSoyad = dt.Rows[0]["Ad_Soyad"].ToString();

                this.Hide();
                using (var doktorForm = new DoktorForm(doktorID, doktorAdSoyad))
                {
                    doktorForm.ShowDialog();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Doktor adı veya şifre hatalı.");
            }
        }


        private void buttonIptal_Click(object sender, EventArgs e)
        {
            this.Close(); // Formu kapat
        }

        private void DoktorGirisForm_Load(object sender, EventArgs e)
        {

        }
    }
}
