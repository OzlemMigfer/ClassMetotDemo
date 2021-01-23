using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Sema";
            musteri1.Soyad = "Güler";
            musteri1.Id = 1;
            musteri1.Tc_No = 11567878998;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Ayşe";
            musteri2.Soyad = "Tam";
            musteri2.Id = 2;
            musteri2.Tc_No = 77865564323;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Hale";
            musteri3.Soyad = "Demir";
            musteri3.Id = 3;
            musteri3.Tc_No = 90087123445;

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            Console.WriteLine("\n************************************************************************");
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            musteriManager.Listele(musteriler);
            Console.WriteLine("\n************************************************************************");
            musteriManager.Remove(musteri1);
        }
    }

}
