using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz.edukos
{
    class Isplata : Transakcija
    {
        public Isplata(IBankovniRacun racun, double iznos) : base(racun, iznos)
        {
       
        }

        public override void IzvrsiTransakciju()
        {
            racun.Isplata(Iznos);
        }
    }
}
