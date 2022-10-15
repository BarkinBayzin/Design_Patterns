using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    //Builder
    abstract class KrediKartiBuilder
    {
        protected KrediKarti _kart;
        public KrediKarti Kart
        {
            get { return _kart; }
            set { _kart = value; }
        }
        public abstract void BankaAdi();
        public abstract void KartTipi();
        public abstract void KartLimiti();
        public abstract void TaksitAtlatma();
    }
}
