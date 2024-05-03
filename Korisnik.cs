using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz.edukos
{
    class Korisnik: Osoba, IBankovniRacun
    {
        public int BrojRačuna { get; set; }
        public double Stanje_ { get; set; }

        public Korisnik( string ime, string prezime, string oib, double stanje, int brojRačuna)
        {
            Ime = ime;
            Prezime = prezime;
            OIB = oib;
            Stanje_ = stanje;
            BrojRačuna = brojRačuna;
        }

        public void Uplata(double iznos)
        {
            Stanje_ = Stanje_ + iznos;
        }

        public void Isplata(double iznos)
        {
            Stanje_ = Stanje_ - iznos;
        }
        public double Stanje()
        {
            return Stanje_;
        }
        public void IspisInformacija()
        {
            Console.WriteLine($"Vlasnik: {Ime} {Prezime} {OIB}");
            Console.WriteLine($"Broj računa: {Stanje_}");
            Console.WriteLine($"Stanje: {BrojRačuna}");
        }
        
        
    }
}
