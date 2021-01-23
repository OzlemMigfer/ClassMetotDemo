using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad +" "+musteri.Id+" "+musteri.Tc_No+ " eklendi.");
        }
        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("-----------------Müşterilerin Tam Listesi-----------------");
            for (int i = 0; i < musteriler.Length; i++)
            {
                Console.WriteLine("Ad :"+musteriler[i].Ad+"\n"+"Soyad :"+musteriler[i].Soyad+"\n"+"Id :"+musteriler[i].Id+"\n"+"Tc No: "+musteriler[i].Tc_No);
            }
        }
        public void Remove(Musteri musteri)
        {
            Console.WriteLine(musteri.Id+" Id li Müşteri Silindi");
        }
    }
}
