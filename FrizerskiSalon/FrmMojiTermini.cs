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

        private void UcitajTermine()
        {
            List<Termin> termini;

            if (_korisnik.UlogaNaziv() == "ADMIN")
                termini = _terminService.SviTermini();
            else if (_korisnik.Can(Dozvola.ZakaziTermin))
                termini = _terminService.TerminiZaKlijenta(_korisnik.KorisnickoIme);
            else
                termini = _terminService.TerminiZaRadnika(_korisnik.KorisnickoIme);

            dataGridViewtermini.DataSource = termini;
        }


        private void buttonsacuvaj_Click(object sender, EventArgs e)
        {
            if (dataGridViewtermini.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite termin.", "Greška");
                return;
            }

            Termin odabrani = (Termin)dataGridViewtermini.SelectedRows[0].DataBoundItem;
            odabrani.Status = (StatusTermina)Enum.Parse(typeof(StatusTermina), comboBoxstatus.SelectedItem.ToString());
            odabrani.Napomena = textBoxnapomena.Text;
            _terminService.AzurirajTermin(odabrani);
            UcitajTermine();
            MessageBox.Show("Termin sačuvan!", "Uspeh");
        }

        private void buttonotkazitetermin_Click(object sender, EventArgs e)
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

        private void buttonzakazitetermin_Click(object sender, EventArgs e)
        {
            FrmZakaziTermin forma = new FrmZakaziTermin(_korisnik);
            forma.ShowDialog();
            UcitajTermine();
        }

        private void FrmMojiTermini_Load_1(object sender, EventArgs e)
        {
            buttonzakazitetermin.Visible = _korisnik.Can(Dozvola.ZakaziTermin);
            buttonotkazitetermin.Visible = _korisnik.Can(Dozvola.OtkaziTermin);
            label1.Visible = _korisnik.Can(Dozvola.IzmeniStatus);
            label2.Visible = _korisnik.Can(Dozvola.UpisiNapomenu);

            comboBoxstatus.Visible = _korisnik.Can(Dozvola.IzmeniStatus);
            textBoxnapomena.Visible = _korisnik.Can(Dozvola.UpisiNapomenu);
            buttonsacuvaj.Visible = _korisnik.Can(Dozvola.IzmeniStatus);

            comboBoxstatus.Items.AddRange(new string[] { "ZAKAZAN", "OTKAZAN", "ODRADJEN" });

            UcitajTermine();
        }

        private void dataGridViewtermini_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridViewtermini.SelectedRows.Count == 0) return;

            Termin odabrani = (Termin)dataGridViewtermini.SelectedRows[0].DataBoundItem;
            if (odabrani == null) return;

            comboBoxstatus.SelectedItem = odabrani.Status.ToString();
            textBoxnapomena.Text = odabrani.Napomena;
        }
    }
}
