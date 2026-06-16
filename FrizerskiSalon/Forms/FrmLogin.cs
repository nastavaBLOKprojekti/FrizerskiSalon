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
    public partial class FrmLogin : Form
    {
        private AuthService _authService = new AuthService();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void buttonprijava_Click(object sender, EventArgs e)
        {
            string korisnickoIme = textBoxkorisnickoime.Text.Trim();
            string lozinka = textBoxlozinka.Text;

            if (string.IsNullOrEmpty(korisnickoIme) || string.IsNullOrEmpty(lozinka))
            {
                MessageBox.Show("Unesite korisničko ime i lozinku.", "Greška");
                return;
            }

            Korisnik k = _authService.Prijavi(korisnickoIme, lozinka);

            if (k == null)
            {
                MessageBox.Show("Pogrešno korisničko ime ili lozinka.", "Greška");
                return;
            }

            FrmGlavna glavna = new FrmGlavna(k);
            glavna.Show();
            this.Hide();
        }
    }
}