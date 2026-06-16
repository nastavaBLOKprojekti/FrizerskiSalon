using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrizerskiSalon.Models
{
    public class Radnik : Korisnik
    {
        public string Specijalnost { get; set; }

        public Radnik(string username, string lozinkaHash, string imePrezime, string specijalnost)
        {
            Username = username;
            LozinkaHash = lozinkaHash;
            ImePrezime = imePrezime;
            Specijalnost = specijalnost;
            UcitajDozvole();
        }

        public override string UlogaNaziv() => "RADNIK";

        public override void UcitajDozvole()
        {
            dozvole.Clear();
            dozvole.Add(Dozvola.PregledMojiTermini);
            dozvole.Add(Dozvola.IzmeniStatus);
            dozvole.Add(Dozvola.UpisiNapomenu);
        }

        public override string ToString()
        {
            return $"U│{Username}│{LozinkaHash}│{ImePrezime}│{UlogaNaziv()}│{Specijalnost}│";
        }
    }
}
