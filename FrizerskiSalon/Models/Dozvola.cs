using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrizerskiSalon.Models
{
    public class Dozvola
    {
        public string Uloga { get; set; }
        public List<string> Akcije { get; set; }

        public Dozvola(string uloga, List<string> akcije)
        {
            Uloga = uloga;
            Akcije = akcije;
        }

        public bool ImaDozvolu(string akcija)
        {
            return Akcije.Contains(akcija);
        }
    }
}
