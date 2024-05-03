using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz.edukos
{
    public interface IBankovniRacun
    {
        void Uplata(double iznos);
        void Isplata(double iznos);
        double Stanje();

        void IspisInformacija();
    }
}
