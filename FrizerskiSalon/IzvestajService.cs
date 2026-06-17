using FrizerskiSalon.Helpers;
using FrizerskiSalon.Models;
using FrizerskiSalon.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrizerskiSalon.Services
{
    public class IzvestajService
    {
        private TerminiRepo _repo = new TerminiRepo();

        public Dictionary<string, int> BrojTerminaPoRadniku()
        {
            return _repo.UcitajSve()
                .Where(t => t.Status == StatusTermina.ODRADJEN)
                .GroupBy(t => t.KorisnickoImeRadnika)
                .ToDictionary(g => g.Key, g => g.Count());
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
