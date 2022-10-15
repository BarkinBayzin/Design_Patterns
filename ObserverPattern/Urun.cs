using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    //ConcreteSubject
    internal class Urun : absUrun
    {
        public Urun(string urunAdi, decimal fiyat) : base(urunAdi, fiyat)
        {
        }
    }
}
