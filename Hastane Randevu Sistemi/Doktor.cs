using System;

namespace Hastane_Randevu_Sistemi
{
    public class Doktor
    {
        public string Isim { get; set; }
        public string UzmanlikAlani { get; set; }
        public bool Musaitlik { get; set; }
        public string Sifre { get; set; }

        public Doktor(string isim, string uzmanlikAlani, string sifre, bool musaitlik = true)
        {
            Isim = isim;
            UzmanlikAlani = uzmanlikAlani;
            Sifre = sifre;
            Musaitlik = musaitlik;
        }
    }
}