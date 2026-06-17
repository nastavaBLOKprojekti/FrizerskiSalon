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
    public partial class FrmIzvestajiPoRadniku : Form
    {
        private IzvestajService _izvestajService = new IzvestajService();

        public FrmIzvestajiPoRadniku()
        {
            InitializeComponent();
        }

        private void UcitajIzvestaj()
        {
            Dictionary<string, int> podaci = _izvestajService.BrojTerminaPoRadniku();


            DataTable dt = new DataTable();
            dt.Columns.Add("Radnik");
            dt.Columns.Add("Broj termina");

            foreach (var stavka in podaci)
                dt.Rows.Add(stavka.Key, stavka.Value);

            dataGridViewizvestaj.DataSource = dt;

    
            chartizvestaj.Series.Clear();
            var serija = chartizvestaj.Series.Add("Termini");
            serija.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;

            foreach (var stavka in podaci)
                serija.Points.AddXY(stavka.Key, stavka.Value);
        }


        private void FrmIzvestajiPoRadniku_Load_1(object sender, EventArgs e)
        {
            UcitajIzvestaj();
        }

        private void buttonexport_Click(object sender, EventArgs e)
        {
            _izvestajService.ExportUTxt();
            MessageBox.Show("Izveštaj exportovan u Data\\izvestaj.txt", "Uspeh");
        }
    }
}