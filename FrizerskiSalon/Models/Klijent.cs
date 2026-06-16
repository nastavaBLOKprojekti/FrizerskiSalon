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
        public string Email { get; set; }

        public Klijent(string username, string lozinkaHash, string imePrezime, string telefon, string email)
        {
            Username = username;
            LozinkaHash = lozinkaHash;
            ImePrezime = imePrezime;
            Telefon = telefon;
            Email = email;
            UcitajDozvole();
        }

        public override string UlogaNaziv() => "KLIJENT";

        public override void UcitajDozvole()
        {
            dozvole.Clear();
            dozvole.Add(Dozvola.PregledMojiTermini);
            dozvole.Add(Dozvola.ZakaziTermin);
            dozvole.Add(Dozvola.OtkaziTermin);
        }

        public override string ToString()
        {
            return $"U│{Username}│{LozinkaHash}│{ImePrezime}│{UlogaNaziv()}│{Telefon}│{Email}";
        }
    }
}
