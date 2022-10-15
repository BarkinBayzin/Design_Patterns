using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    //Subject
    abstract class absUrun
    {
        public string UrunAdi { get; set; }
        public decimal Fiyat 
        {
            get => _fiyat;
            set 
            {
                //eğer fiyatı düşmüşse üyelere haber ver
                if (_fiyat > value)
                {
                _fiyat = value;
                    NotifyUrun();
                }
            }
        }

        private decimal _fiyat;

        //Direkt erişim yerine private tanımlanıp, tanımlanacak metotlar ile yapılabilir.
        //Observer nesne listesi
        public List<IUye> TakipList = new List<IUye>();
        protected absUrun(string urunAdi, decimal fiyat)
        {
            UrunAdi = urunAdi;
            _fiyat = fiyat;
        }


        public void NotifyUrun()
        {
            foreach (IUye item in TakipList)
            {
                item.Update(this);
            }
        }
    }
}
