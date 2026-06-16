using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrizerskiSalon.Models
{
    public class Radnik : Korisnik
    {
        public string Specijalizacija { get; set; }

        public Radnik(string korisnickoIme, string lozinkaHash, string imePrezime, string specijalizacija)
            : base(korisnickoIme, lozinkaHash, imePrezime, "RADNIK")
        {
            Specijalizacija = specijalizacija;
        }

        public override string ToString()
        {
            return $"U│{KorisnickoIme}│{LozinkaHash}│{ImePrezime}│{Uloga}│{Specijalizacija}";
        }
    }
}
