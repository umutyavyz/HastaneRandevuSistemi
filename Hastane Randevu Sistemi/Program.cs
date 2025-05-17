using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hastane_Randevu_Sistemi
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Örnek doktor ve hasta verileri oluşturuluyor
            List<Doktor> doktorlar = new List<Doktor>
            {
                new Doktor("Dr. Ahmet Yılmaz", "Kardioloji", "1234"),
                new Doktor("Dr. Ayşe Demir", "Dahiliye", "5678"),
                new Doktor("Dr. Mehmet Kaya", "Ortopedi", "91011")
            };

            List<Hasta> hastalar = new List<Hasta>
            {
                new Hasta("Ali Veli", "12345678901", "sifre1"),
                new Hasta("Ayşe Fatma", "10987654321", "sifre2")
            };

            RandevuSistemi sistem = new RandevuSistemi(doktorlar, hastalar);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Login formunu başlat
            Application.Run(new LoginForm());
        }
    }
}

