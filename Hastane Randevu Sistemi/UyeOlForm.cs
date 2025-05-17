using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hastane_Randevu_Sistemi
{
    public partial class UyeOlForm : Form
    {
        public UyeOlForm()
        {
            InitializeComponent();
        }
            
            

        private void ButtonKaydet_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UyeOlForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonKaydet_Click_1(object sender, EventArgs e)
        {
            string adSoyad = textBoxIsim.Text.Trim();
            string tc = textBoxTC.Text.Trim();
            string sifre = textBoxSifre.Text.Trim();

            // SQL sorgusu
            string insertQuery = "INSERT INTO Hastalar (Ad_Soyad, TC, Sifre) VALUES (@AdSoyad, @TC, @Sifre)";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@AdSoyad", adSoyad),
        new SqlParameter("@TC", tc),
        new SqlParameter("@Sifre", sifre)
            };

            // Girdi kontrolü
            if (adSoyad == "" || tc.Length != 11 || sifre == "")
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz ve doğru giriniz.");
                return;
            }

            try
            {
                DatabaseHelper.ExecuteNonQuery(insertQuery, parameters);
                MessageBox.Show("Kayıt başarıyla eklendi!");

                // Temizleme
                textBoxIsim.Clear();
                textBoxTC.Clear();
                textBoxTC.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }

        }
    }
}
