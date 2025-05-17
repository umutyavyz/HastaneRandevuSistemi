using Hastane_Randevu_Sistemi;
using System.Collections.Generic;

public class Hasta
{
    public string Isim { get; set; }
    public string TC { get; set; }
    public string Sifre { get; set; }
    public List<Randevu> RandevuGecmisi { get; set; }

    public Hasta(string isim, string tc, string sifre)
    {
        Isim = isim;
        TC = tc;
        Sifre = sifre;
        RandevuGecmisi = new List<Randevu>();
    }
}