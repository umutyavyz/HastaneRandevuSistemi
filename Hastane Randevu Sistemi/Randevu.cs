using System;

namespace Hastane_Randevu_Sistemi
{
    public class Randevu
    {
        public DateTime Tarih { get; set; }
        public Doktor Doktor { get; set; }
        public Hasta Hasta { get; set; }

        public Randevu(DateTime tarih, Doktor doktor, Hasta hasta)
        {
            Tarih = tarih;
            Doktor = doktor;
            Hasta = hasta;
        }
    }
}