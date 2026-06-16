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
    public partial class FrmAdminKorisnici : Form
    {
        private KorisnikService _korisnikService = new KorisnikService();

        public FrmAdminKorisnici()
        {
            InitializeComponent();
        }

        private void FrmAdminKorisnici_Load(object sender, EventArgs e)
        {
            UcitajKorisnike();
        }

        private void UcitajKorisnike()
        {
            dgvKorisnici.DataSource = _korisnikService.SviKorisnici();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string korisnickoIme = Microsoft.VisualBasic.Interaction.InputBox("Korisničko ime:", "Novi korisnik");
            string lozinka = Microsoft.VisualBasic.Interaction.InputBox("Lozinka:", "Novi korisnik");
            string imePrezime = Microsoft.VisualBasic.Interaction.InputBox("Ime i prezime:", "Novi korisnik");
            string uloga = Microsoft.VisualBasic.Interaction.InputBox("Uloga (ADMIN/RADNIK/KLIJENT):", "Novi korisnik");

            if (string.IsNullOrEmpty(korisnickoIme) || string.IsNullOrEmpty(lozinka))
            {
                MessageBox.Show("Podaci nisu uneti.", "Greška");
                return;
            }

            if (_korisnikService.PostojiKorisnik(korisnickoIme))
            {
                MessageBox.Show("Korisnik već postoji.", "Greška");
                return;
            }

            string hash = HashHelper.Hash(lozinka);
            Korisnik novi;

            switch (uloga.ToUpper())
            {
                case "ADMIN":
                    novi = new Administrator(korisnickoIme, hash, imePrezime);
                    break;
                case "RADNIK":
                    string spec = Microsoft.VisualBasic.Interaction.InputBox("Specijalizacija:", "Novi korisnik");
                    novi = new Radnik(korisnickoIme, hash, imePrezime, spec);
                    break;
                case "KLIJENT":
                    string tel = Microsoft.VisualBasic.Interaction.InputBox("Telefon:", "Novi korisnik");
                    novi = new Klijent(korisnickoIme, hash, imePrezime, tel);
                    break;
                default:
                    MessageBox.Show("Nepoznata uloga.", "Greška");
                    return;
            }

            _korisnikService.DodajKorisnika(novi);
            UcitajKorisnike();
            MessageBox.Show("Korisnik dodat!", "Uspeh");
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvKorisnici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite korisnika.", "Greška");
                return;
            }

            Korisnik odabrani = (Korisnik)dgvKorisnici.SelectedRows[0].DataBoundItem;
            DialogResult potvrda = MessageBox.Show($"Obrisati korisnika {odabrani.ImePrezime}?", "Potvrda", MessageBoxButtons.YesNo);

            if (potvrda == DialogResult.Yes)
            {
                _korisnikService.ObrisiKorisnika(odabrani.KorisnickoIme);
                UcitajKorisnike();
            }
        }
    }
}
