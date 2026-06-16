using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrizerskiSalon.Models
{
    public class Klijent : Korisnik
    {
        public string Telefon { get; set; }

        public Klijent(string korisnickoIme, string lozinkaHash, string imePrezime, string telefon)
            : base(korisnickoIme, lozinkaHash, imePrezime, "KLIJENT")
        {
            Telefon = telefon;
        }

        public override string ToString()
        {
            return $"U│{KorisnickoIme}│{LozinkaHash}│{ImePrezime}│{Uloga}│{Telefon}";
        }
    }
}
