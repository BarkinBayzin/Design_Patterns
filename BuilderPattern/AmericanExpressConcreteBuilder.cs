using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    //ConcreteBuilder Class
    class AmericanExpressConcreteBuilder : KrediKartiBuilder
    {
        public AmericanExpressConcreteBuilder()
        {
            Kart = new KrediKarti();
        }
        public override void BankaAdi()
        {
            Kart.BankaAdi = "Bank of America";
        }

        public override void KartLimiti()
        {
            Kart.KartLimiti = 6000;
        }

        public override void KartTipi()
        {
            Kart.KartTipi = "American Express";
        }

        public override void TaksitAtlatma()
        {
            Kart.TaksitAtlatma = false;
        }
    }
}
