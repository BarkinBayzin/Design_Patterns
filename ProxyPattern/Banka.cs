using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    //Real Subject Class
    class Banka
    {
        public bool Pay(double amount)
        {
            if (amount < 100)
            {
                Console.WriteLine("Ödeyeceğiniz tutar 100 TL'den az olamazz Fark: " +(100 - amount));
            }
            else if(amount > 100)
            {
                Console.WriteLine("Ödeyeceğiniz tutar 100 TL'den fazla olamaz Fark: " +(amount - 100));
            }
            else
            {
                Console.WriteLine("Ödeme başarılı bir şekilde gerçekleştirildi tutar: " +amount + " TL");
                return true;
            }
            return false;
        }
    }
}
