using FrizerskiSalon.Models;
using FrizerskiSalon.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrizerskiSalon.Forms
{
    public partial class FrmMojiTermini : Form
    {
        private Korisnik _korisnik;
        private TerminService _terminService = new TerminService();
        public FrmMojiTermini(Korisnik korisnik)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }
        private void FrmMojiTermini_Load(object sender, EventArgs e)
        {
            buttonzakazitetermin.Visible = _korisnik.Uloga == "KLIJENT";
            buttonotkazitetermin.Visible = _korisnik.Uloga == "KLIJENT";

            UcitajTermine();
        }

        private void UcitajTermine()
        {
            List<Termin> termini;

            if (_korisnik.Uloga == "KLIJENT")
                termini = _terminService.TerminiZaKlijenta(_korisnik.KorisnickoIme);
            else
                termini = _terminService.TerminiZaRadnika(_korisnik.KorisnickoIme);

            dataGridViewtermini.DataSource = termini;
        }

        private void btnZakaziTermin_Click(object sender, EventArgs e)
        {
            FrmZakaziTermin forma = new FrmZakaziTermin(_korisnik);
            forma.ShowDialog();
            UcitajTermine();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            if (dataGridViewtermini.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite termin.", "Greška");
                return;
            }

            Termin odabrani = (Termin)dataGridViewtermini.SelectedRows[0].DataBoundItem;

            if (!_terminService.MozeOtkazati(odabrani))
            {
                MessageBox.Show("Ne možete otkazati termin manje od 24h pre.", "Greška");
                return;
            }

            odabrani.Status = StatusTermina.OTKAZAN;
            _terminService.AzurirajTermin(odabrani);
            UcitajTermine();
        }
    }
}
