using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz.edukos
{
    class Banka
    {
        public List<Korisnik> korisnici;
        private List<Transakcija> transakcije;
        public Banka()
        {
            korisnici = new List<Korisnik>();
            transakcije = new List<Transakcija>();

        }
        
        public void DodajKorisnika(Korisnik korisnik)
        {
            korisnici.Add(korisnik);
        }
        public void DodajTransakciju(Transakcija transakcija)
        {
            transakcije.Add(transakcija);
        }
        public void IzvrsiTransakciju(Transakcija transakcija)
        {
            transakcija.IzvrsiTransakciju();
           
        }
    }

}
