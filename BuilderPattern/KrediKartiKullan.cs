using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    //Director CLass
    class KrediKartiKullan
    {
        public void KartKullan(KrediKartiBuilder kart)
        {
            kart.BankaAdi();
            kart.KartTipi();
            kart.KartLimiti();
            kart.TaksitAtlatma();
        }
    }
}
