using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Demet";
            musteri1.Soyadi = " Özkaya";
            musteri1.KrediKartiLimiti = 28000;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Feyza";
            musteri2.Soyadi = " Özcan";
            musteri2.KrediKartiLimiti = 5000;

            Console.WriteLine("Müşteri Ekleme");
            MusteriManager musteriManager1 = new MusteriManager();
            musteriManager1.Ekle(musteri1);
            Console.WriteLine();

            Console.WriteLine("Müşteri Sil");
            MusteriManager musteriManager2 = new MusteriManager();
            musteriManager2.Sil(musteri2);
            Console.WriteLine();


            Console.WriteLine("Müşterileri Listele");
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri Id: " + musteri.Id);
                Console.WriteLine("Müşteri Adı:" + musteri.Adi);
                Console.WriteLine("Müşteri Soyadı:" +musteri.Soyadi);
                Console.WriteLine("Müşteri Kredi Karti Limiti: " + musteri.KrediKartiLimiti);
                Console.WriteLine("-----------------------------------------");
            }
        }
    }
}
