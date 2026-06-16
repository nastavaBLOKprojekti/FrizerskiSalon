using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrizerskiSalon.Models
{
    public class Termin
    {
        public int Id { get; set; }
        public string KorisnickoImeKlijenta { get; set; }
        public string KorisnickoImeRadnika { get; set; }
        public DateTime DatumVreme { get; set; }
        public string Usluga { get; set; }
        public StatusTermina Status { get; set; }
        public string Napomena { get; set; }

        public Termin(int id, string klijent, string radnik, DateTime datumVreme, string usluga)
        {
            Id = id;
            KorisnickoImeKlijenta = klijent;
            KorisnickoImeRadnika = radnik;
            DatumVreme = datumVreme;
            Usluga = usluga;
            Status = StatusTermina.ZAKAZAN;
            Napomena = "";
        }

        public override string ToString()
        {
            return $"T│{Id}│{KorisnickoImeKlijenta}│{KorisnickoImeRadnika}│{DatumVreme:yyyy-MM-dd HH:mm}│{Usluga}│{Status}│{Napomena}";
        }
    }
}
