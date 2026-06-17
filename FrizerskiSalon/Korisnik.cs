using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrizerskiSalon.Models
{
    public abstract class Korisnik
    {
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string ImePrezime { get; set; }

        protected List<Dozvola> dozvole = new List<Dozvola>();

        public bool Can(Dozvola d)
        {
            foreach (var dozvola in dozvole)
                if (dozvola == d) return true;
            return false;
        }

        public abstract string UlogaNaziv();
        public abstract void UcitajDozvole();

        public override string ToString()
        {
            return $"U│{KorisnickoIme}│{LozinkaHash}│{ImePrezime}│{UlogaNaziv()}";
        }
    }
}
