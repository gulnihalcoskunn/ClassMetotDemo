using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi!:"+ musteri.Adi+" "+musteri.SoyAdi+"("+musteri.Id+")");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi!:"+ musteri.Adi + " " + musteri.SoyAdi + "(" + musteri.Id + ")");
        }
        public void Sırala(Musteri musteri)
        {
            Console.WriteLine("Müşteri sıralandı!:" + musteri.Adi + " " + musteri.SoyAdi + "(" + musteri.Id + ")");
        }



    }
}
