using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrizerskiSalon.Models
{
    public class Administrator : Korisnik
    {
        public Administrator(string korisnickoIme, string lozinkaHash, string imePrezime)
            : base(korisnickoIme, lozinkaHash, imePrezime, "ADMIN")
        {
        }
    }
}
