using FrizerskiSalon.Helpers;
using FrizerskiSalon.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FrizerskiSalon.Repositories
{
    public class TerminiRepo:IsacuvajPodatke
    {
        public List<Termin> UcitajSve()
        {
            List<Termin> termini = new List<Termin>();

            if (!File.Exists(FilePaths.TerminiPath))
                return termini;

            foreach (string linija in File.ReadAllLines(FilePaths.TerminiPath))
            {
                string[] delovi = linija.Split('│');
                if (delovi.Length < 7) continue;

                int id = int.Parse(delovi[1]);
                string klijent = delovi[2];
                string radnik = delovi[3];
                DateTime datum = DateTime.ParseExact(delovi[4], "yyyy-MM-dd HH:mm", null);
                string usluga = delovi[5];
                StatusTermina status = (StatusTermina)Enum.Parse(typeof(StatusTermina), delovi[6]);
                string napomena = delovi.Length > 7 ? delovi[7] : "";

                Termin t = new Termin(id, klijent, radnik, datum, usluga);
                t.Status = status;
                t.Napomena = napomena;
                termini.Add(t);
            }
            return termini;
        }

        public void SacuvajSve(List<Termin> termini)
        {
            List<string> linije = new List<string>();
            foreach (Termin t in termini)
                linije.Add(t.ToString());
            File.WriteAllLines(FilePaths.TerminiPath, linije);
        }

        public void Dodaj(Termin termin)
        {
            List<Termin> svi = UcitajSve();
            int maxId = 0;
            foreach (Termin t in svi)
                if (t.Id > maxId)
                    maxId = t.Id;
            termin.Id = maxId + 1;
            svi.Add(termin);
            SacuvajSve(svi);
        }

        public void Azuriraj(Termin termin)
        {
            List<Termin> svi = UcitajSve();
            for (int i = 0; i < svi.Count; i++)
            {
                if (svi[i].Id == termin.Id)
                {
                    svi[i] = termin;
                    SacuvajSve(svi);
                    return;
                }
            }
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
