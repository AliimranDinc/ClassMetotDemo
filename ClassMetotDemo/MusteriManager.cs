using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Yeni müşteri başarıyla eklendi.");
            Console.WriteLine("TC: " + musteri.Tc);
            Console.WriteLine("AD: " + musteri.Ad);
            Console.WriteLine("SOYAD: " + musteri.Soyad);
            Console.WriteLine("---------------------");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("TC: " + musteri.Tc);
            Console.WriteLine("AD: " + musteri.Ad);
            Console.WriteLine("SOYAD: " + musteri.Soyad);
            Console.WriteLine("--Bilgili Müşteri başarıyla silinmiştir!--");
            Console.WriteLine("---------------------");
        }
    }
    
}
