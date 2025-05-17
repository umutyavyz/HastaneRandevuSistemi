using System;
using System.Collections.Generic;
using System.Linq;

namespace Hastane_Randevu_Sistemi
{
    public class RandevuSistemi
    {
        public List<Randevu> Randevular { get; set; }
        public List<Doktor> Doktorlar { get; set; }
        public List<Hasta> Hastalar { get; set; }

        public RandevuSistemi(List<Doktor> doktorlar, List<Hasta> hastalar)
        {
            Doktorlar = doktorlar;
            Hastalar = hastalar;
            Randevular = new List<Randevu>();
        }

        public bool RandevuAl(DateTime tarih, Doktor doktor, Hasta hasta)
        {
            // Ayný tarih ve saat için çakýþma kontrolü
            if (Randevular.Any(r => r.Tarih == tarih && r.Doktor == doktor))
            {
                return false; // Çakýþma var
            }

            // Yeni randevu oluþtur ve ekle
            var yeniRandevu = new Randevu(tarih, doktor, hasta);
            Randevular.Add(yeniRandevu);
            hasta.RandevuGecmisi.Add(yeniRandevu);

            return true; // Randevu baþarýyla alýndý
        }

        public bool RandevuIptal(Randevu randevu)
        {
            if (Randevular.Remove(randevu))
            {
                randevu.Hasta.RandevuGecmisi.Remove(randevu);
                return true; // Randevu baþarýyla iptal edildi
            }
            return false; // Randevu iptal edilemedi
        }
    }
}
