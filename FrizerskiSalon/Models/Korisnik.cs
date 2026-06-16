using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrizerskiSalon.Models
{
    public class Korisnik
    {
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string ImePrezime { get; set; }
        public string Uloga { get; set; }

        public Korisnik(string korisnickoIme, string lozinkaHash, string imePrezime, string uloga)
        {
            KorisnickoIme = korisnickoIme;
            LozinkaHash = lozinkaHash;
            ImePrezime = imePrezime;
            Uloga = uloga;
        }

        public override string ToString()
        {
            return $"U│{KorisnickoIme}│{LozinkaHash}│{ImePrezime}│{Uloga}";
        }
    }
}
