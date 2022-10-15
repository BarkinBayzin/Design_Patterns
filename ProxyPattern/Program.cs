using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class Program
    {
        /*
            Proxt tasarım deseni, structural grubuna ait oluşturulması karmaşık veya oluşturulması zaman alan işlemlerin kontrolünü sağlar. uluslar arası alanda kullanım sıklığı %80 civarındadır ve yapı bakımından basittir.

            Oluşturduğumuz tasarımda bazı sınıfların, nesnelerin yahut işleyişlerin sorumluluk ve süreçteki işlevsel hallerini bir başka nesne üzerinde kontrol edebilir ve sorumluluğu bu nesneye yükleyebilriiz. Daha net bir ifadeyle, nesnelerin süreçteki vekaletini başka bir sınıfa devredebiliriz.

            Client => İstemcidir.

            Subject => İstemcinin tek bir tip ile çalışmasını sağlayacak olan Interface yahut abstract class'ımızdır. Real Subject ve Proxy nesnelerimizin türetildiği yapıdır.

            Real Subject => O anki işin asıl çalışmasını gerçekleştirecek olan gerçek nesnemizdir.

            Proxy => Vekil sınıfımızdır. İçerisinde Real Subject referansını taşıyarak istemcinin isteklerine cevap verecektir. Doğal olarak istemci gerçek nesneye dolaylı yoldan Proxy üzerinden erişebilecektir.
         
         */
        static void Main(string[] args)
        {
            string kullaniciAdi = "", sifre = "";
            double tutar = 0;
            while(true)
            {
                Console.Write("Lütfen Kullanıcı Adı Giriniz : ");
                kullaniciAdi = Console.ReadLine();

                Console.Write("\nLütfen Şifresini Giriniz : ");
                sifre = Console.ReadLine();

                Console.Write("\nLütfen Ödenecek Miktarı Giriniz : ");
                tutar = Convert.ToInt32(Console.ReadLine());

                IBank banka = new ProxyBanka(kullaniciAdi, sifre);
                banka.OdemeYap(tutar);

                Console.WriteLine("*****************");
            }


            Console.ReadLine();

        }
    }
}
