using FrizerskiSalon.Models;
using FrizerskiSalon.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrizerskiSalon.Services
{
    public class AuthService
    {
        private KorisniciRepo _repo = new KorisniciRepo();

        public Korisnik Prijavi(string korisnickoIme, string lozinka)
        {
            string hash = HashHelper.Hash(lozinka);
            Korisnik k = _repo.NadjiPoImenu(korisnickoIme);

            if (k == null) return null;
            if (k.LozinkaHash != hash) return null;

            return k;
        }
    }
}
