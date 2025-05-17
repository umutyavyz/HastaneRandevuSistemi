using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hastane_Randevu_Sistemi
{
    public partial class LoginForm : Form
    {

       

        public LoginForm()
        {
            InitializeComponent();
            
            

            // Button event handler'larını bağlama
            buttonGiris.Click += ButtonGiris_Click;
            buttonUyeOl.Click += ButtonUyeOl_Click;
            buttonDoktorGiris.Click += ButtonDoktorGiris_Click;
        }

        private void ButtonGiris_Click(object sender, EventArgs e)
        {
            string girisTC = textBoxTC.Text.Trim();
            string girisSifre = textBoxSifre.Text;

            if (string.IsNullOrEmpty(girisTC) || string.IsNullOrEmpty(girisSifre))
            {
                MessageBox.Show("Lütfen TC ve şifrenizi giriniz.");
                return;
            }

           
        }

        private void ButtonUyeOl_Click(object sender, EventArgs e)
        {
            // Üye Ol formunu aç
            UyeOlForm uyeOlForm = new UyeOlForm();
            uyeOlForm.ShowDialog();
        }

        private void ButtonDoktorGiris_Click(object sender, EventArgs e)
        {
            // Doktor giriş formunu aç
            DoktorGirisForm doktorGirisForm = new DoktorGirisForm();
            doktorGirisForm.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yapılacak işlemler
        }


        private void buttonGiris_Click_1(object sender, EventArgs e)
        {
            string tc = textBoxTC.Text.Trim();
            string sifre = textBoxSifre.Text.Trim();

            // Basit doğrulama
            if (tc.Length != 11 || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen geçerli TC ve şifre giriniz.");
                return;
            }

            // SQL sorgusu
            string query = "SELECT * FROM Hastalar WHERE TC = @TC AND Sifre = @Sifre";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@TC", tc),
        new SqlParameter("@Sifre", sifre)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                string adSoyad = dt.Rows[0]["Ad_Soyad"].ToString();
                int hastaID = Convert.ToInt32(dt.Rows[0]["HastaID"]);
                string hastaAdi = dt.Rows[0]["Ad_Soyad"].ToString();
                MessageBox.Show("Giriş başarılı! Hoş geldiniz, " + adSoyad);
                MainForm form = new MainForm(hastaID,adSoyad); // Doğru
                form.Show();
                this.Hide(); // Login formunu gizle


            }
            else
            {
                MessageBox.Show("TC veya şifre hatalı. Lütfen tekrar deneyin.");
            }
        }
    }
}

