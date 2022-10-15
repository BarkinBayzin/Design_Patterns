using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class VisaConcreteBuilder : KrediKartiBuilder
    {
        public VisaConcreteBuilder()
        {
            Kart = new KrediKarti();
        }
        public override void BankaAdi()
        {
            Kart.BankaAdi = "Garanti Bankası";
        }

        public override void KartLimiti()
        {
            Kart.KartLimiti = 5000;
        }

        public override void KartTipi()
        {
            Kart.KartTipi = "Visa";
        }

        public override void TaksitAtlatma()
        {
            Kart.TaksitAtlatma = true;
        }
    }
}
