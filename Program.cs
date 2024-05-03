using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz.edukos
{
    class Program
    {
        static void Main(string[] args)
        {
            Banka banka = new Banka();
            Korisnik korisnik = new Korisnik("Roko", "Rok", "123456789", 1000, 123456);

            banka.DodajKorisnika(korisnik);

  
            ITransakcija uplata = new Uplata(korisnik, 500);

            
            banka.IzvrsiTransakciju(uplata);


            Console.WriteLine($"Trenutno stanje: {korisnik.Stanje()} HRK.");
        }
    }
}
