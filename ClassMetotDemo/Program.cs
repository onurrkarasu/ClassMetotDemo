using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            //Musterileri Tanimladim
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "onur";
            musteri1.Soyad = "Karasu";


            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Engin";
            musteri2.Soyad = "Demiroğ";

            Musteri[] musteriler = new Musteri[] { musteri1,musteri2}; //Musteriler Array'ini olustrudum

            MusteriManager musteriManager = new MusteriManager(); // MusteriManager Kısmını Tanimladım

            //Musteri Ekledim
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);


            //Musteri Sildim
            musteriManager.MusteriSil(musteri1);

            //Musterileri Listeledim
            musteriManager.MusteriListele(musteriler);
            

        }
    }
}
