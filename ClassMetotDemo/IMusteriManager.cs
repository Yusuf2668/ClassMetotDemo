using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public interface IMusteriManager
    {
        void Add(Musteri musteri);
        void List(Musteri musteri);
        void Delete(Musteri musteri);
    }
}
