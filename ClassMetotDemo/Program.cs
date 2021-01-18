using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Sıla";
            musteri1.SoyAdi = "Demir";
            musteri1.Id = 303030;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Ayşe";
            musteri2.SoyAdi = "Işık";
            musteri2.Id = 606060;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Sevinç";
            musteri3.SoyAdi = "Aydın";
            musteri3.Id = 505050;
            
            Musteri[] musteriler= new Musteri [] { musteri1,musteri2,musteri3};

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.SoyAdi);
                Console.WriteLine(musteri.Id);
            }
            Console.WriteLine("---------------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sırala(musteri3);

        }
    }
}
