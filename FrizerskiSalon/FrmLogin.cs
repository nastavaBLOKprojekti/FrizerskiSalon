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

            try
            {
                Korisnik k = _authService.Prijavi(korisnickoIme, lozinka);
                FrmGlavna glavna = new FrmGlavna(k);
                glavna.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška");
            }
        }

        private void checkBoxprikazi_CheckedChanged(object sender, EventArgs e)
        {
            textBoxlozinka.PasswordChar = checkBoxprikazi.Checked ? '\0' : '*';
        }
    }
}