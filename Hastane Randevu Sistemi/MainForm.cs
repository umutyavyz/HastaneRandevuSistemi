using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Hastane_Randevu_Sistemi
{
    public partial class MainForm : Form
    {
        

        public MainForm(int hastaID,string hastaAdSoyad)
        {
            InitializeComponent();
            girisYapanHastaID = hastaID;
            girisYapanHastaAdSoyad = hastaAdSoyad;

        }
        private int girisYapanHastaID;
        private string girisYapanHastaAdSoyad;

        private void RandevuGecmisiniGetir()
        {
            string query = @"
        SELECT R.RandevuID, D.Ad_Soyad, D.Brans, R.RandevuTarihi
        FROM Randevular R
        JOIN Doktorlar D ON R.DoktorID = D.DoktorID
        WHERE R.HastaID = @HastaID
        ORDER BY R.RandevuTarihi DESC";

            SqlParameter[] param = {
        new SqlParameter("@HastaID", girisYapanHastaID)
    };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, param);

            listBoxRandevuGecmisi.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                RandevuItem item = new RandevuItem
                {
                    RandevuID = Convert.ToInt32(row["RandevuID"]),
                    Aciklama = $"{row["Ad_Soyad"]} - {row["Brans"]} - {Convert.ToDateTime(row["RandevuTarihi"]):g}"
                };
                listBoxRandevuGecmisi.Items.Add(item);
            }
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            RandevuGecmisiniGetir();
            labelHastaBilgi.Text = "Hoşgeldiniz, " + girisYapanHastaAdSoyad;
            // Form yüklendiğinde yapılacak işlemler
            LoadRandevuGecmisi();
            string query = "SELECT DoktorID, Ad_Soyad, Brans FROM Doktorlar";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            comboBoxDoktorlar.DisplayMember = "Gosterim"; // Ekranda gösterilecek
            comboBoxDoktorlar.ValueMember = "DoktorID";   // Arka planda ID tutulacak

            // Doktorları yeni bir kolonla birleştirip göstermek için geçici tablo oluşturalım
            dt.Columns.Add("Gosterim", typeof(string));
            foreach (DataRow row in dt.Rows)
            {
                row["Gosterim"] = row["Ad_Soyad"] + " - " + row["Brans"];
            }

            comboBoxDoktorlar.DataSource = dt;
        }

        private void LoadRandevuGecmisi()
        {
            
        }

        private void buttonRandevuAl_Click(object sender, EventArgs e)
        {
            // Randevu alma işlemi
        }

        private void buttonRandevuIptal_Click(object sender, EventArgs e)
        {
            // Randevu iptal işlemi
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            // LoginForm'a yönlendirme
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void buttonRandevuAl_Click_1(object sender, EventArgs e)
        {
            if (comboBoxDoktorlar.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir doktor seçiniz.");
                return;
            }

            // Seçili doktorun ID'sini al
            if (comboBoxDoktorlar.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir doktor seçiniz.");
                return;
            }

            int doktorID = Convert.ToInt32(comboBoxDoktorlar.SelectedValue);
            DateTime randevuTarihi = dateTimePickerRandevu.Value;

            // Aynı doktordan aynı tarih/saatte randevu alınmış mı kontrolü
            string kontrolQuery = @"
        SELECT COUNT(*) FROM Randevular 
        WHERE DoktorID = @DoktorID AND RandevuTarihi = @Tarih";

            SqlParameter[] kontrolParams = {
        new SqlParameter("@DoktorID", doktorID),
        new SqlParameter("@Tarih", randevuTarihi)
    };

            DataTable kontrolSonucu = DatabaseHelper.ExecuteQuery(kontrolQuery, kontrolParams);
            int doluluk = Convert.ToInt32(kontrolSonucu.Rows[0][0]);

            if (doluluk > 0)
            {
                MessageBox.Show("Bu randevu saatinde doktor zaten dolu. Lütfen başka bir zaman seçin.");
                return;
            }

            // Randevuyu ekle
            string ekleQuery = @"
        INSERT INTO Randevular (HastaID, DoktorID, RandevuTarihi)
        VALUES (@HastaID, @DoktorID, @Tarih)";

            SqlParameter[] ekleParams = {
        new SqlParameter("@HastaID", girisYapanHastaID),
        new SqlParameter("@DoktorID", doktorID),
        new SqlParameter("@Tarih", randevuTarihi)
    };

            try
            {
                DatabaseHelper.ExecuteNonQuery(ekleQuery, ekleParams);
                MessageBox.Show("Randevu başarıyla alındı.");
                RandevuGecmisiniGetir(); // Geçmişi güncelle
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevu alınırken hata oluştu: " + ex.Message);
            }
        }

        private void buttonRandevuIptal_Click_1(object sender, EventArgs e)
        {
            if (listBoxRandevuGecmisi.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silmek istediğiniz randevuyu seçin.");
                return;
            }

            RandevuItem seciliRandevu = (RandevuItem)listBoxRandevuGecmisi.SelectedItem;

            DialogResult sonuc = MessageBox.Show("Seçilen randevuyu silmek istediğinize emin misiniz?",
                                                 "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                string deleteQuery = "DELETE FROM Randevular WHERE RandevuID = @RandevuID";
                SqlParameter[] param = {
            new SqlParameter("@RandevuID", seciliRandevu.RandevuID)
        };

                try
                {
                    DatabaseHelper.ExecuteNonQuery(deleteQuery, param);
                    MessageBox.Show("Randevu silindi.");
                    RandevuGecmisiniGetir(); // Listeyi güncelle
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme sırasında hata oluştu: " + ex.Message);
                }
            }
        }
    }

    public class RandevuItem
    {
        public int RandevuID { get; set; }
        public string Aciklama { get; set; }

        public override string ToString()
        {
            return Aciklama;
        }
    }
}
