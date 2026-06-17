using FrizerskiSalon.Models;
using FrizerskiSalon.Repositories;
using System.Collections.Generic;

namespace FrizerskiSalon.Services
{
    public class KorisnikService
    {
        private KorisniciRepo _repo = new KorisniciRepo();

        public List<Korisnik> SviKorisnici()
        {
            return _repo.UcitajSve();
        }

        public List<Radnik> SviRadnici()
        {
            List<Radnik> radnici = new List<Radnik>();
            foreach (Korisnik k in _repo.UcitajSve())
                if (k is Radnik)
                    radnici.Add((Radnik)k);
            return radnici;
        }

        public void DodajKorisnika(Korisnik k)
        {
            _repo.Dodaj(k);
        }

        public void ObrisiKorisnika(string korisnickoIme)
        {
            _repo.Obrisi(korisnickoIme);
        }

        public bool PostojiKorisnik(string korisnickoIme)
        {
            return _repo.NadjiPoImenu(korisnickoIme) != null;
        }
    }
}