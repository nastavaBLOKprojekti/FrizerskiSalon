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
        private void FrmGlavna_Load(object sender, EventArgs e)
        {
            labeldobrodosli.Text = $"Dobrodošli, {_prijavljeniKorisnik.ImePrezime}!";

            buttonsvitermini.Visible = false;
            buttonkorisnici.Visible = false;
            buttonizvestaj.Visible = false;

            if (_prijavljeniKorisnik.Uloga == "ADMIN")
            {
                buttonsvitermini.Visible = true;
                buttonkorisnici.Visible = true;
                buttonizvestaj.Visible = true;
            }
        }

        private void btnMojiTermini_Click(object sender, EventArgs e)
        {
            FrmMojiTermini forma = new FrmMojiTermini(_prijavljeniKorisnik);
            forma.Show();
        }

        private void btnSviTermini_Click(object sender, EventArgs e)
        {
            FrmSviTermini forma = new FrmSviTermini();
            forma.Show();
        }

        private void btnKorisnici_Click(object sender, EventArgs e)
        {
            FrmAdminKorisnici forma = new FrmAdminKorisnici();
            forma.Show();
        }

        private void btnIzvestaj_Click(object sender, EventArgs e)
        {
            FrmIzvestajiPoRadniku forma = new FrmIzvestajiPoRadniku();
            forma.Show();
        }

        private void btnOdjavi_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();
        }
    }
}
