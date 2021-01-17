using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace ClassMetotDemo
{
    public class MusteriManager : IMusteriManager
    {
        
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Name+ " İsimli müşteri eklendi");
        }

        public void List(Musteri musteri)
        {
            Console.WriteLine("Ad :"+musteri.Name);
            Console.WriteLine("Soyad :"+musteri.LastName);
            Console.WriteLine("Yaş :"+musteri.Age);
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Name+ " İsimli müşteri silindi");
        }
    }
}
