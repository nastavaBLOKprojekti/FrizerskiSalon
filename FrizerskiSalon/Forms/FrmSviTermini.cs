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
    public partial class FrmSviTermini : Form
    {
        private TerminService _terminService = new TerminService();
        private KorisnikService _korisnikService = new KorisnikService();

        public FrmSviTermini()
        {
            InitializeComponent();
        }

        private void FrmSviTermini_Load(object sender, EventArgs e)
        {
            List<Radnik> radnici = _korisnikService.SviRadnici();
            cmbFilterRadnik.Items.Add("Svi");
            foreach (Radnik r in radnici)
                cmbFilterRadnik.Items.Add(r.KorisnickoIme);
            cmbFilterRadnik.SelectedIndex = 0;

            cmbFilterStatus.Items.Add("Svi");
            cmbFilterStatus.Items.Add("ZAKAZAN");
            cmbFilterStatus.Items.Add("OTKAZAN");
            cmbFilterStatus.Items.Add("ODRADJEN");
            cmbFilterStatus.SelectedIndex = 0;

            dtpFilter.Value = DateTime.Now;

            UcitajTermine();
        }

        private void UcitajTermine()
        {
            dgvTermini.DataSource = _terminService.SviTermini();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            List<Termin> termini = _terminService.SviTermini();

            if (cmbFilterRadnik.SelectedItem.ToString() != "Svi")
                termini = termini.Where(t => t.KorisnickoImeRadnika == cmbFilterRadnik.SelectedItem.ToString()).ToList();

            if (cmbFilterStatus.SelectedItem.ToString() != "Svi")
            {
                StatusTermina status = (StatusTermina)Enum.Parse(typeof(StatusTermina), cmbFilterStatus.SelectedItem.ToString());
                termini = termini.Where(t => t.Status == status).ToList();
            }

            termini = termini.Where(t => t.DatumVreme.Date == dtpFilter.Value.Date).ToList();

            dgvTermini.DataSource = termini;
        }

        private void btnResetuj_Click(object sender, EventArgs e)
        {
            cmbFilterRadnik.SelectedIndex = 0;
            cmbFilterStatus.SelectedIndex = 0;
            dtpFilter.Value = DateTime.Now;
            UcitajTermine();
        }
    }
}
