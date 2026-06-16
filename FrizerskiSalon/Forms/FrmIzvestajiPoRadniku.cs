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
    public partial class FrmIzvestajiPoRadniku : Form
    {
        private IzvestajService _izvestajService = new IzvestajService();

        public FrmIzvestajiPoRadniku()
        {
            InitializeComponent();
        }

        private void FrmIzvestajiPoRadniku_Load(object sender, EventArgs e)
        {
            UcitajIzvestaj();
        }

        private void UcitajIzvestaj()
        {
            Dictionary<string, int> podaci = _izvestajService.BrojTerminaPoRadniku();


            DataTable dt = new DataTable();
            dt.Columns.Add("Radnik");
            dt.Columns.Add("Broj termina");

            foreach (var stavka in podaci)
                dt.Rows.Add(stavka.Key, stavka.Value);

            dgvIzvestaj.DataSource = dt;

    
            chartIzvestaj.Series.Clear();
            var serija = chartIzvestaj.Series.Add("Termini");
            serija.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;

            foreach (var stavka in podaci)
                serija.Points.AddXY(stavka.Key, stavka.Value);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            _izvestajService.ExportUTxt();
            MessageBox.Show("Izveštaj exportovan u Data\\izvestaj.txt", "Uspeh");
        }
    }
}