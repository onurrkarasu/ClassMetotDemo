using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
       
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+"  "+musteri.Soyad);
            Console.WriteLine("--------------Müşteri Eklendi-------------------");
        }


        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + "  " + musteri.Soyad);
            //Musteriler.Remove(musteri);
            Console.WriteLine("--------------Müşteri Silindi-------------------");

        }


        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (var item in musteriler)
            {
                Console.WriteLine(item.Ad + "  " + item.Soyad);

            }

        }
    }
}
