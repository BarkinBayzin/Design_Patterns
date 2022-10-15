using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    //ConcreteBuilder Class
    class MasterConcreteBuilder : KrediKartiBuilder
    {
        public MasterConcreteBuilder()
        {
            Kart = new KrediKarti();
        }
        public override void BankaAdi()
        {
            Kart.BankaAdi = "Garanti Bankası";
        }

        public override void KartLimiti()
        {
            Kart.KartLimiti = 3500;
        }

        public override void KartTipi()
        {
            Kart.KartTipi = "Master Card";
        }

        public override void TaksitAtlatma()
        {
            Kart.TaksitAtlatma = true;
        }
    }
}
