using FrizerskiSalon.Helpers;
using FrizerskiSalon.Models;
using FrizerskiSalon.Repositories;
using System;
using System.Collections.Generic;
using System.IO;

namespace FrizerskiSalon.Services
{
    public class IzvestajService
    {
        private TerminiRepo _repo = new TerminiRepo();

        public Dictionary<string, int> BrojTerminaPoRadniku()
        {
            Dictionary<string, int> rezultat = new Dictionary<string, int>();

            foreach (Termin t in _repo.UcitajSve())
            {
                if (t.Status == StatusTermina.ODRADJEN)
                {
                    if (rezultat.ContainsKey(t.KorisnickoImeRadnika))
                        rezultat[t.KorisnickoImeRadnika]++;
                    else
                        rezultat[t.KorisnickoImeRadnika] = 1;
                }
            }

            return rezultat;
        }

        public void ExportUTxt()
        {
            Dictionary<string, int> izvestaj = BrojTerminaPoRadniku();
            List<string> linije = new List<string>();

            linije.Add("=== IZVEŠTAJ PO RADNIKU ===");
            linije.Add($"Datum: {DateTime.Now:yyyy-MM-dd HH:mm}");
            linije.Add("");

            foreach (var stavka in izvestaj)
                linije.Add($"{stavka.Key}: {stavka.Value} termina");

            File.WriteAllLines(FilePaths.IzvestajPath, linije);
        }
    }
}