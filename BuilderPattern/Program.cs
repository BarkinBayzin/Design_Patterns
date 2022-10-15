using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Builder tasarım deseni creational patterns grubuna aittir. Uluslar arası standartta hangi tasarım deseninin en fazla kullanıldığını gösteren dofactory.com'a göre kullanım oranı %40 civarındadır.
            Builder tasarım deseninin esas amacı genişletilebilirliği sağlamak ve kod karmaşıklığını engellemek için kullanılır. Tam olarak çalışma prensibi ise bazı nesneler birden fazla nesnenin birleşmesinden meydana gelir. Zamanla bu asıl nesneyi oluşturan nesnelerde değişiklik meydana gelebilir ya da ek nesneler ile genişletilmek istenebilir. Bu esas sınıfları yaratmak isteyen sınıflara Builder denir.

            Builde deseninu oluşturam 4 alt yapı vardır.
            Product: Oluştulan nesne.
            Builder: Product oluşturacak nesnelerin (Concrete Builder) uygulaması gereken arayüz.
            Concrete Builder: Product nesnesini oluşturan nesne veya özelliklerin oluşturulduğu sınıflar. Her concrete builder sınıfı aynı arayüzde farklı bir ürünün oluşturulmasını sağlar.
            Director: Verilen builder nesnesine göre product örneği oluşturur.
             */

            KrediKartiBuilder gercekKart = new MasterConcreteBuilder();
            KrediKartiKullan kullan =  new KrediKartiKullan();

            kullan.KartKullan(gercekKart);

            Console.WriteLine(gercekKart.Kart.ToString());

            Console.WriteLine("--**--**--*--**-*-*-*-*-*-**-*-*-*-");

            gercekKart = new VisaConcreteBuilder();
            kullan.KartKullan(gercekKart);
            Console.WriteLine(gercekKart.Kart.ToString());

            gercekKart = new AmericanExpressConcreteBuilder();
            kullan.KartKullan(gercekKart);
            Console.WriteLine(gercekKart.Kart.ToString());


            Console.ReadLine();

        }
    }
}
