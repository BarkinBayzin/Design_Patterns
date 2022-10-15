using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prototype tasarım deseni creational pattern grubuna aittir. Aslında adından da anlaşılacağı gibi var olan nesnelerin kopyasının üretiminden sorumludur. Dünya çapında kullanım oranı yaklaşık %60 civarındadır. Bazı nesnelerin üretim maliyeti ciddi anlamda yüksektir. Tabi burada maliyetten kasıt developerı yorması ve nesne yaratılırken sistemi ne kadar çok yorduğudur. Bu tarz nesnelerin yeniden yaratılmaktansa bir teknik ile kopyalanması söz konusu değildir. Prototype işte tam olarak bu tarz bir durumda geçerlidir. Kullanılan yöntem ise deep copydir. yani nesne bire bir kopyalanarak yeni referans değerlere atanır.

            //Prototype tasarım deseninde 3 nesne yapısı vardır.
            //Prototype: Klonlama yapılacak sınıfların uygulaması gereken interface veya abstract sınıf.
            //Concrete Prototype: Klonlama özelliği olacak gerçek sınıflar.
            //Client: Klonlanmış nesneyi elde edecek nesne.

            Game g1 = new Game(1, "PoolDay", "MultiPlayer", true);
            Game g2 = (Game)g1.Clone();

            if (g1.Equals(g2))
            {
                Console.WriteLine("Types are equal!");
            }
            else
            {
                Console.WriteLine("Types are not equal!");
            }

            Console.ReadLine();
            //En son CLient(istemci) tarafından bir talep gerçekleştirilmiştir. İkinci nesneyi new koywordü ile oluşturmaya gerek kalmayarak maliyeti göz ardı edip, var olan nesne üzerinden kopyalama işlemi gerçekleştirebiliyoruz. Burada dikkat etmemiz gereken husus, Prototype tasarım desinini uygulayabilmek için ilgili sınıftan öncellikle new keywördü ile bir nesne üretilmeli, ardından desenimiz üzerinden kopya üretimi tetiklenmelidir. Bu nesneler birbirlerinden farklı olacağından equals false dönmesi gerekmektedir.
        }
    }
}
