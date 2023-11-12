﻿namespace OOP2
{
    public class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Id = "1";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "22222222";
            

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.MusteriNo = "54321";
            musteri2.Id = "2";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo= "1234900123";


            //Gerçek Müşteri-Tüzel Müşteri


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2); 




        }
    }
}