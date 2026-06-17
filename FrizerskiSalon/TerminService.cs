using FrizerskiSalon.Models;
using FrizerskiSalon.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrizerskiSalon.Services
{
    public class TerminService
    {
        private TerminiRepo _repo = new TerminiRepo();

        public List<Termin> SviTermini() => _repo.UcitajSve();

        public List<Termin> TerminiZaKlijenta(string korisnickoIme)
        {
            return _repo.UcitajSve().Where(t => t.KorisnickoImeKlijenta == korisnickoIme).ToList();
        }

        public List<Termin> TerminiZaRadnika(string korisnickoIme)
        {
            return _repo.UcitajSve().Where(t => t.KorisnickoImeRadnika == korisnickoIme).ToList();
        }

        public void ZakaziTermin(Termin t)
        {
            _repo.Dodaj(t);
        }

        public void AzurirajTermin(Termin t)
        {
            _repo.Azuriraj(t);
        }

        public bool MozeOtkazati(Termin t)
        {
            return t.Status == StatusTermina.ZAKAZAN &&
                   t.DatumVreme > DateTime.Now.AddHours(24);
        }
    }
}
