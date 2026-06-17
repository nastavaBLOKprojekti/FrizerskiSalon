using FrizerskiSalon.Models;
using FrizerskiSalon.Repositories;
using System;
using System.Collections.Generic;

namespace FrizerskiSalon.Services
{
    public class TerminService
    {
        private TerminiRepo _repo = new TerminiRepo();

        public List<Termin> SviTermini()
        {
            return _repo.UcitajSve();
        }

        public List<Termin> TerminiZaKlijenta(string korisnickoIme)
        {
            List<Termin> rezultat = new List<Termin>();
            foreach (Termin t in _repo.UcitajSve())
                if (t.KorisnickoImeKlijenta == korisnickoIme)
                    rezultat.Add(t);
            return rezultat;
        }

        public List<Termin> TerminiZaRadnika(string korisnickoIme)
        {
            List<Termin> rezultat = new List<Termin>();
            foreach (Termin t in _repo.UcitajSve())
                if (t.KorisnickoImeRadnika == korisnickoIme)
                    rezultat.Add(t);
            return rezultat;
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