using FrizerskiSalon.Helpers;
using FrizerskiSalon.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FrizerskiSalon.Repositories
{
    public class KorisniciRepo:IsacuvajPodatke
    {
        public List<Korisnik> UcitajSve()
        {
            List<Korisnik> korisnici = new List<Korisnik>();

            if (!File.Exists(FilePaths.KorisniciPath))
                return korisnici;

            foreach (string linija in File.ReadAllLines(FilePaths.KorisniciPath))
            {
                string[] delovi = linija.Split('│');
                if (delovi.Length < 5) continue;

                string korisnickoIme = delovi[1];
                string lozinkaHash = delovi[2];
                string imePrezime = delovi[3];
                string uloga = delovi[4];

                switch (uloga)
                {
                    case "ADMIN":
                        korisnici.Add(new Administrator(korisnickoIme, lozinkaHash, imePrezime));
                        break;
                    case "RADNIK":
                        string spec = delovi.Length > 5 ? delovi[5] : "";
                        korisnici.Add(new Radnik(korisnickoIme, lozinkaHash, imePrezime, spec));
                        break;
                    case "KLIJENT":
                        string tel = delovi.Length > 5 ? delovi[5] : "";
                        string email = delovi.Length > 6 ? delovi[6] : "";
                        korisnici.Add(new Klijent(korisnickoIme, lozinkaHash, imePrezime, tel, email));
                        break;
                }
            }
            return korisnici;
        }

        public void SacuvajSve(List<Korisnik> korisnici)
        {
            List<string> linije = new List<string>();
            foreach (Korisnik k in korisnici)
                linije.Add(k.ToString());
            File.WriteAllLines(FilePaths.KorisniciPath, linije);
        }

        public void Dodaj(Korisnik korisnik)
        {
            List<Korisnik> svi = UcitajSve();
            svi.Add(korisnik);
            SacuvajSve(svi);
        }

        public void Obrisi(string korisnickoIme)
        {
            List<Korisnik> svi = UcitajSve();
            List<Korisnik> novi = new List<Korisnik>();
            foreach (Korisnik k in svi)
                if (k.KorisnickoIme != korisnickoIme)
                    novi.Add(k);
            SacuvajSve(novi);
        }

        public Korisnik NadjiPoImenu(string korisnickoIme)
        {
            foreach (Korisnik k in UcitajSve())
                if (k.KorisnickoIme == korisnickoIme)
                    return k;
            return null;
        }

        public void Ucitaj()
        {
            UcitajSve();
        }

        public void Sacuvaj()
        {
            SacuvajSve(UcitajSve());
        }
    }
}
