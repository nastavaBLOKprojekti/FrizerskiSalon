using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrizerskiSalon.Models
{
    public class Administrator : Korisnik
    {
        public Administrator(string username, string lozinkaHash, string imePrezime)
        {
            Username = username;
            LozinkaHash = lozinkaHash;
            ImePrezime = imePrezime;
            UcitajDozvole();
        }

        public override string UlogaNaziv() => "ADMIN";

        public override void UcitajDozvole()
        {
            dozvole.Clear();
            dozvole.Add(Dozvola.PregledMojiTermini);
            dozvole.Add(Dozvola.PregledSviTermini);
            dozvole.Add(Dozvola.ZakaziTermin);
            dozvole.Add(Dozvola.OtkaziTermin);
            dozvole.Add(Dozvola.IzmeniStatus);
            dozvole.Add(Dozvola.UpisiNapomenu);
            dozvole.Add(Dozvola.UpravljanjeKorisnicima);
            dozvole.Add(Dozvola.Izvestaji);
        }
    }
}
