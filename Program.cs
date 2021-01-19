using System;

namespace ClassMethotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();

            musteri1.Id = 1;
            musteri1.adi = "Ahmet";
            musteri1.soyadi = "Keskin";
            musteri1.yas = 26;

            Musteri musteri2 = new Musteri();

            musteri2.Id = 2;
            musteri2.adi = "Burcu";
            musteri2.soyadi = "Ak";
            musteri2.yas = 35;

            Musteri musteri3 = new Musteri();

            musteri3.Id = 3;
            musteri3.adi = "Sevil";
            musteri3.soyadi = "Şeker";
            musteri3.yas = 18;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.adi);
                Console.WriteLine(musteri.soyadi);
                Console.WriteLine(musteri.yas);
                Console.WriteLine("-------------------------------");


            }

            MusteriManager musteriManager = new MusteriManager();
            
            musteriManager.EkleMusteri(musteri1);

            musteriManager.SilMusteri(musteri2);








            //Console.WriteLine("Hello World!");
        }
    }
}
