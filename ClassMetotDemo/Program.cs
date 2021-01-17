using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Tc = 11111111111;
            musteri1.Ad = "Ali İmran";
            musteri1.Soyad = "Dinç";

            Musteri musteri2 = new Musteri();
            musteri2.Tc = 22222222222;
            musteri2.Ad = "Can";
            musteri2.Soyad = "Dinç";

            Musteri musteri3 = new Musteri();
            musteri3.Tc = 33333333333;
            musteri3.Ad = "Berkay";
            musteri3.Soyad = "Dinç";

            Console.WriteLine("MÜŞTERİLER");

            //Müşretileri listeleme
            Musteri[] musteriler = new Musteri[] { musteri1,musteri2,musteri3};

            foreach (var musteri in musteriler)
            {

                Console.WriteLine("---------------------");
                Console.WriteLine("TC: " + musteri.Tc);
                Console.WriteLine("AD: " + musteri.Ad);
                Console.WriteLine("SOYAD: " + musteri.Soyad);
            }


            Console.WriteLine("MÜŞTERİ EKLEME ");
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);



            Console.WriteLine("MÜŞTERİ SİLME ");
            MusteriManager musteriManager2 = new MusteriManager();
            musteriManager2.Sil(musteri1);
            musteriManager2.Sil(musteri2);
            musteriManager2.Sil(musteri3);

            
            



            Console.ReadLine();
        }
    }
}
