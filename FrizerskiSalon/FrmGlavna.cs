using FrizerskiSalon.Models;
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
    public partial class FrmGlavna : Form
    {
        private Korisnik _prijavljeniKorisnik;

        public FrmGlavna(Korisnik korisnik)
        {
            InitializeComponent();
            _prijavljeniKorisnik = korisnik;
        }
        private void buttonmojitermini_Click(object sender, EventArgs e)
        {
            FrmMojiTermini forma = new FrmMojiTermini(_prijavljeniKorisnik);
            forma.Show();
        }

        private void buttonsvitermini_Click(object sender, EventArgs e)
        {
            FrmSviTermini forma = new FrmSviTermini();
            forma.Show();
        }

        private void buttonkorisnici_Click(object sender, EventArgs e)
        {
            FrmAdminKorisnici forma = new FrmAdminKorisnici();
            forma.Show();
        }

        private void buttonizvestaj_Click(object sender, EventArgs e)
        {
            FrmIzvestajiPoRadniku forma = new FrmIzvestajiPoRadniku();
            forma.Show();
        }

        private void buttonodjavise_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();
        }

        private void FrmGlavna_Load_1(object sender, EventArgs e)
        {
            labeldobrodosli.Text = $"Dobrodošli, {_prijavljeniKorisnik.ImePrezime}!";

            buttonsvitermini.Visible = _prijavljeniKorisnik.Can(Dozvola.PregledSviTermini);
            buttonkorisnici.Visible = _prijavljeniKorisnik.Can(Dozvola.UpravljanjeKorisnicima);
            buttonizvestaj.Visible = _prijavljeniKorisnik.Can(Dozvola.Izvestaji);
        }
    }
}
