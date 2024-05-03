using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz.edukos
{
    class Uplata : Transakcija
    {
    
         public Uplata(IBankovniRacun racun, double iznos) : base(racun, iznos)
         {
         }

         public override void IzvrsiTransakciju()
         {
             racun.Uplata(Iznos);
             Console.WriteLine($"Izvršena uplata od {Iznos} HRK.");
         }
    


    }
}
