using FrizerskiSalon.Models;
using FrizerskiSalon.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FrizerskiSalon.Forms
{
    public partial class FrmSviTermini : Form
    {
        private TerminService _terminService = new TerminService();
        private KorisnikService _korisnikService = new KorisnikService();

        public FrmSviTermini()
        {
            InitializeComponent();
        }

        private void UcitajTermine()
        {
            dataGridViewTermini.DataSource = _terminService.SviTermini();
        }

        private void FrmSviTermini_Load_1(object sender, EventArgs e)
        {
            List<Radnik> radnici = _korisnikService.SviRadnici();
            comboBoxFilterRadnik.Items.Add("Svi");
            foreach (Radnik r in radnici)
                comboBoxFilterRadnik.Items.Add(r.KorisnickoIme);
            comboBoxFilterRadnik.SelectedIndex = 0;

            comboBoxFilterStatus.Items.Add("Svi");
            comboBoxFilterStatus.Items.Add("ZAKAZAN");
            comboBoxFilterStatus.Items.Add("OTKAZAN");
            comboBoxFilterStatus.Items.Add("ODRADJEN");
            comboBoxFilterStatus.SelectedIndex = 0;

            dateTimePickerFilter.Value = DateTime.Now;

            UcitajTermine();
        }

        private void buttonFiltriraj_Click(object sender, EventArgs e)
        {
            List<Termin> termini = _terminService.SviTermini();

            if (comboBoxFilterRadnik.SelectedItem.ToString() != "Svi")
            {
                List<Termin> filtrirani = new List<Termin>();
                foreach (Termin t in termini)
                    if (t.KorisnickoImeRadnika == comboBoxFilterRadnik.SelectedItem.ToString())
                        filtrirani.Add(t);
                termini = filtrirani;
            }

            if (comboBoxFilterStatus.SelectedItem.ToString() != "Svi")
            {
                StatusTermina status = (StatusTermina)Enum.Parse(typeof(StatusTermina), comboBoxFilterStatus.SelectedItem.ToString());
                List<Termin> filtrirani = new List<Termin>();
                foreach (Termin t in termini)
                    if (t.Status == status)
                        filtrirani.Add(t);
                termini = filtrirani;
            }

            List<Termin> filtriraniDatum = new List<Termin>();
            foreach (Termin t in termini)
                if (t.DatumVreme.Date == dateTimePickerFilter.Value.Date)
                    filtriraniDatum.Add(t);
            termini = filtriraniDatum; 

            dataGridViewTermini.DataSource = termini;
        }

        private void buttonResetuj_Click(object sender, EventArgs e)
        {
            comboBoxFilterRadnik.SelectedIndex = 0;
            comboBoxFilterStatus.SelectedIndex = 0;
            dateTimePickerFilter.Value = DateTime.Now;
            UcitajTermine();
        }

        private void buttonexport_Click(object sender, EventArgs e)
        {
            List<Termin> termini = _terminService.SviTermini();
            List<string> linije = new List<string>();
            linije.Add("=== SVI TERMINI ===");
            linije.Add($"Datum: {DateTime.Now:yyyy-MM-dd HH:mm}");
            linije.Add("");
            foreach (Termin t in termini)
                linije.Add(t.ToString());
            System.IO.File.WriteAllLines(FrizerskiSalon.Helpers.FilePaths.IzvestajPath, linije);
            MessageBox.Show("Exportovano!", "Uspeh");
        }
    }
}
