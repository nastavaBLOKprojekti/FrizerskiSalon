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
            dataGridViewKorisnici.DataSource = null;
            dataGridViewKorisnici.DataSource = _korisnikService.SviKorisnici();
        }

        private string Unesi(string poruka)
        {
            Form forma = new Form();
            forma.Text = poruka;
            forma.Size = new Size(300, 120);
            forma.StartPosition = FormStartPosition.CenterParent;

            TextBox txt = new TextBox();
            txt.Size = new Size(260, 20);
            txt.Location = new Point(10, 10);
            forma.Controls.Add(txt);

            Button btn = new Button();
            btn.Text = "OK";
            btn.Location = new Point(100, 40);
            btn.DialogResult = DialogResult.OK;
            forma.Controls.Add(btn);
            forma.AcceptButton = btn;

            if (forma.ShowDialog() == DialogResult.OK)
                return txt.Text;
            return "";
        }

        private void buttondodaj_Click(object sender, EventArgs e)
        {
            string korisnickoIme = Unesi("Korisničko ime:");
            string lozinka = Unesi("Lozinka:");
            string imePrezime = Unesi("Ime i prezime:");
            string uloga = Unesi("Uloga (ADMIN/RADNIK/KLIJENT):");

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
                    string spec = Unesi("Specijalizacija:");
                    novi = new Radnik(korisnickoIme, hash, imePrezime, spec);
                    break;
                case "KLIJENT":
                    string tel = Unesi("Telefon:");
                    string email = Unesi("Email:");
                    novi = new Klijent(korisnickoIme, hash, imePrezime, tel, email);
                    break;
                default:
                    MessageBox.Show("Nepoznata uloga.", "Greška");
                    return;
            }

            _korisnikService.DodajKorisnika(novi);
            UcitajKorisnike();
            MessageBox.Show("Korisnik dodat!", "Uspeh");
        }

        private void buttonobrisi_Click(object sender, EventArgs e)
        {
            if (dataGridViewKorisnici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite korisnika.", "Greška");
                return;
            }

            Korisnik odabrani = (Korisnik)dataGridViewKorisnici.SelectedRows[0].DataBoundItem;
            DialogResult potvrda = MessageBox.Show($"Obrisati korisnika {odabrani.ImePrezime}?", "Potvrda", MessageBoxButtons.YesNo);

            if (potvrda == DialogResult.Yes)
            {
                _korisnikService.ObrisiKorisnika(odabrani.KorisnickoIme);
                UcitajKorisnike();
            }
        }
    }   
}