using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Musteri> musteris = new List<Musteri>()
            {
                new Musteri(){Id = 1,Age = 20,Name = "Yusuf",LastName = "Uğur"},
                new Musteri(){Id = 2,Age = 25,Name = "Bilal",LastName = "Güngör"},
                new Musteri(){Id = 3,Age = 32,Name = "Hamza",LastName = "Bahçeci"}
            };
            MusteriManager manager = new MusteriManager();
            manager.Add(musteris[0]);
            manager.List(musteris[1]);
            manager.Delete(musteris[2]);
        }
        
    }
}
