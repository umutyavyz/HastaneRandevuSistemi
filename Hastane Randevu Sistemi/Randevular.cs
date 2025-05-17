using System;
using System.Collections.Generic;
using System.Linq;

namespace Hastane_Randevu_Sistemi
{
    public class RandevuSistemi
    {
        public List<Randevu> Randevular { get; private set; }
        public List<Doktor> Doktorlar { get; private set; }
        public List<Hasta> Hastalar { get; private set; }

        public RandevuSistemi(List<Doktor> doktorlar, List<Hasta> hastalar)
        {
            Doktorlar = doktorlar;
            Hastalar = hastalar;
            Randevular = new List<Randevu>();
        }

        // Randevu al: Doktor müsait ise, yeni randevu oluştur ve listelere ekle
        public bool RandevuAl(DateTime tarih, Doktor doktor, Hasta hasta)
        {
            if (!doktor.Musaitlik)
                return false;

            // Aynı tarih-doktor için başka randevu var mı kontrolü (isteğe bağlı)
            bool dolu = Randevular.Any(r => r.Doktor == doktor && r.Tarih == tarih);
            if (dolu)
                return false;

            var yeniRandevu = new Randevu(tarih, doktor, hasta);
            Randevular.Add(yeniRandevu);
            hasta.RandevuGecmisi.Add(yeniRandevu);

            // Doktorun müsaitliğini güncelle (örneğin 1 randevu alırsa dolu sayılır)
            doktor.Musaitlik = false;

            return true;
        }

        // Randevu iptal et: randevuyu kaldır ve doktor müsaitliğini aç
        public bool RandevuIptal(Randevu randevu)
        {
            if (Randevular.Remove(randevu))
            {
                randevu.Hasta.RandevuGecmisi.Remove(randevu);
                randevu.Doktor.Musaitlik = true;
                return true;
            }
            return false;
        }

        // Doktor müsaitlik güncelleme (manuel)
        public void DoktorMusaitlikGuncelle(Doktor doktor, bool musait)
        {
            doktor.Musaitlik = musait;
        }

        // Hasta randevu geçmişi veya başka fonksiyonlar eklenebilir.
    }
}
