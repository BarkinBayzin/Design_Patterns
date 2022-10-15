using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    //ConcreteObserver
    internal class Uye : IUye
    {
        public string E_Mail { get; set; }
        public void Update(absUrun urun)
        {
            Console.WriteLine("{0} ın fiyatı {1} oldu {2} adresine gönderildi.",urun.UrunAdi, urun.Fiyat.ToString("C2"),E_Mail);
        }
    }
}
