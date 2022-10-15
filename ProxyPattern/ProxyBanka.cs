using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    //ProxyBanka
    class ProxyBanka : IBank
    {
        Banka banka;
        bool login;
        string userName, password;

        public ProxyBanka(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }
        
        bool GirisYap()
        {
            if(userName.Equals("bayzin") && password.Equals("1234"))
            {
                banka = new Banka();
                login = true;
                Console.WriteLine("Hesaba Giriş Başarılı");
                return true;
            }
            else Console.WriteLine("Şifre ya da kullanıcı adı hatalı.");

            login = false;
            return false;
        }

        public bool OdemeYap(double tutar)
        {
            GirisYap();
            if(!login)
            {
                Console.WriteLine("Hesaba giriş başarısız, ödeme gerçekleştirilemedi!");
                return false;
            }

            banka.Pay(tutar);
            return true;
        }
    }
}
