using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hastane_Randevu_Sistemi
{
    public partial class DoktorForm : Form
    {
        private int doktorID;
        private string doktorAdSoyad;

        public DoktorForm(int doktorID, string doktorAdSoyad)
        {
            InitializeComponent();
            this.doktorID = doktorID;
            this.doktorAdSoyad = doktorAdSoyad;
        }

        private void DoktorForm_Load(object sender, EventArgs e)
        {
            labelDoktor.Text = doktorAdSoyad + " Hoş geldiniz!";
            RandevuListele();
        }

        private void RandevuListele()
        {
            listBoxRandevular.Items.Clear();

            string query = "SELECT Randevular.RandevuID, Randevular.RandevuTarihi, Hastalar.Ad_Soyad " +
                "FROM Randevular " +
                "JOIN Hastalar ON Randevular.HastaID = Hastalar.HastaID " +
                "WHERE Randevular.DoktorID = @DoktorID";

            SqlParameter[] param = {
                new SqlParameter("@DoktorID", doktorID)
            };

            var dt = DatabaseHelper.ExecuteQuery(query, param);

            foreach (System.Data.DataRow row in dt.Rows)
            {
                var item = new ListBoxItem
                {
                    Text = row["Ad_Soyad"].ToString() + " - " + row["RandevuTarihi"].ToString(),
                    Value = row["RandevuID"].ToString()
                };
                listBoxRandevular.Items.Add(item);
            }
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRandevuIptal_Click(object sender, EventArgs e)
        {
            if (listBoxRandevular.SelectedItem == null)
            {
                MessageBox.Show("Lütfen iptal etmek için bir randevu seçin.");
                return;
            }

            var selectedItem = (ListBoxItem)listBoxRandevular.SelectedItem;
            int randevuID = int.Parse(selectedItem.Value);

            string query = "DELETE FROM Randevular WHERE RandevuID = @RandevuID";
            SqlParameter[] param = {
                new SqlParameter("@RandevuID", randevuID)
            };

            int affectedRows = DatabaseHelper.ExecuteNonQuery(query, param);

            if (affectedRows > 0)
            {
                MessageBox.Show("Randevu başarıyla iptal edildi.");
                RandevuListele();
            }
            else
            {
                MessageBox.Show("Randevu iptal edilemedi.");
            }
        }

        private class ListBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void listBoxRandevular_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
