using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class Program
    {
        /*
            Observer tasarım deseni behavior grubuna ait, bir nesnede meydana gelen değişikliklerde içinde bulundurduğu listede bulunan nesnelere haber gönderen tasarım desenidir. Kullanımı en sık olan tasarım desenlerindendir.

            Observer tasarım deseni; birbirleri ile bire çok (yani bir nesnenin içinde başka bir nesnenin listesinin bulunması olarak da düşünebiliriz) ilişki olan nesneler arasında ola bazlı bir etkileşim olduğu durumları düzenler. Örnek senaryo olarak;

            Bir e-ticaret sitesinde bir üründeki stok değişiminde, o ürünü takip eden üyelere haber verilmesi.

            Ham madde - ürün ilişkisi olan bir durumda, ham maddenin fiyatı değişince ürünün fiyatının da değişmesi.

            Instagram da ki bir iletiye yorum yapılması duurmunda o iletiye yorum yapan ve beğenen üyelere bildirim gitmesi gibi..

            Subject: Takip edilecek nesneyi Subject terimiyle ifade etmekteyiz.

            Observer: Subject'i takip edecek olan aboneler tek tip olmayabilirler. İşte böyle bir durumda birden fazla tipe arayüz görevi görecek abstract ya da interface yapımıza Observer denmektedir.

            Concrete: Subject'i takip eden nesnelerdir.
         
         */
        static void Main(string[] args)
        {
            //İlk olarak Subject nesnemizi oluşturuyoruz.
            absUrun kitap = new Urun("Kitap", 10.25M);

            //Subject nesnemiz ile ilgili olan Uye(observer) listesine nesne ekliyoruz.
            kitap.TakipList.Add(new Uye { E_Mail = "barkin.bayzin@gmail.com" });
            kitap.TakipList.Add(new Uye { E_Mail = "erkan.tas@gmail.com" });

            //Subject yani ürün fiyatını değiştirdiğimizde listedeki observer nesnelerinin ilgili metodu çalıştırılacak.
            kitap.Fiyat = 8.99M;

            Console.ReadLine();
        }
    }
}
