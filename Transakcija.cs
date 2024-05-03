using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz.edukos
{
    abstract class Transakcija: ITransakcija
    {
        protected IBankovniRacun racun;
        protected double Iznos { get; set; }

        public Transakcija(IBankovniRacun racun, double iznos)
        {
            this.racun = racun;
            Iznos = iznos;
        }

        public abstract void IzvrsiTransakciju();
    }
}
