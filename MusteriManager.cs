using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethotDemo
{
    class MusteriManager
    {
        public void EkleMusteri(Musteri musteri)
        {
            Console.WriteLine("Talebiniz Alınmıştır.Müşteri eklendi. : " + musteri.adi + musteri.soyadi );
        }


        public void SilMusteri(Musteri musteri)
        {
            Console.WriteLine("Talebiniz Alındı. Müşteri silindi. : " + musteri.adi + musteri.soyadi);
        }




    }
}
