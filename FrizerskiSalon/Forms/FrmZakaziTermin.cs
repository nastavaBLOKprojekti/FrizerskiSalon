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
    public partial class FrmZakaziTermin : Form
    {
        private Korisnik _korisnik;
        private KorisnikService _korisnikService = new KorisnikService();
        private TerminService _terminService = new TerminService();
        public FrmZakaziTermin(Korisnik korisnik)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }
        private void FrmZakaziTermin_Load(object sender, EventArgs e)
        {
            List<Radnik> radnici = _korisnikService.SviRadnici();
            comboBoxradnik.DataSource = radnici;
            comboBoxradnik.DisplayMember = "ImePrezime";
            comboBoxradnik.ValueMember = "KorisnickoIme";

            comboBoxusluga.Items.AddRange(new string[]
            {
                "Šišanje",
                "Farbanje",
                "Pranje",
                "Feniranje",
                "Trajni uvijač",
                "Manikir"
            });
            comboBoxusluga.SelectedIndex = 0;

            dateTimePickerdatum.MinDate = DateTime.Now.AddHours(1);
        }

        private void btnZakazi_Click(object sender, EventArgs e)
        {
            if (comboBoxradnik.SelectedItem == null || comboBoxusluga.SelectedItem == null)
            {
                MessageBox.Show("Odaberite radnika i uslugu.", "Greška");
                return;
            }

            string radnikIme = comboBoxradnik.SelectedValue.ToString();
            DateTime datum = dateTimePickerdatum.Value;
            string usluga = comboBoxusluga.SelectedItem.ToString();

            Termin t = new Termin(0, _korisnik.Username, radnikIme, datum, usluga);
            _terminService.ZakaziTermin(t);

            MessageBox.Show("Termin uspešno zakazan!", "Uspeh");
            this.Close();
        }
    }
}