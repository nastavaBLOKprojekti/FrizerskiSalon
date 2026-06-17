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
                termini = termini.Where(t => t.KorisnickoImeRadnika == comboBoxFilterRadnik.SelectedItem.ToString()).ToList();

            if (comboBoxFilterStatus.SelectedItem.ToString() != "Svi")
            {
                StatusTermina status = (StatusTermina)Enum.Parse(typeof(StatusTermina), comboBoxFilterStatus.SelectedItem.ToString());
                termini = termini.Where(t => t.Status == status).ToList();
            }

            termini = termini.Where(t => t.DatumVreme.Date == dateTimePickerFilter.Value.Date).ToList();

            dataGridViewTermini.DataSource = termini;
        }

        private void buttonResetuj_Click(object sender, EventArgs e)
        {
            comboBoxFilterRadnik.SelectedIndex = 0;
            comboBoxFilterStatus.SelectedIndex = 0;
            dateTimePickerFilter.Value = DateTime.Now;
            UcitajTermine();
        }
    }
}
