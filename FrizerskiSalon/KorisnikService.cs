using FrizerskiSalon.Models;
using FrizerskiSalon.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrizerskiSalon.Services
{
    public class KorisnikService
    {
        private KorisniciRepo _repo = new KorisniciRepo();

        public List<Korisnik> SviKorisnici() => _repo.UcitajSve();

        public List<Radnik> SviRadnici()
        {
            return _repo.UcitajSve().OfType<Radnik>().ToList();
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
