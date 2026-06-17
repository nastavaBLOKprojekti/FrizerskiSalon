namespace FrizerskiSalon.Forms
{
    partial class FrmIzvestajiPoRadniku
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridViewizvestaj = new System.Windows.Forms.DataGridView();
            this.chartizvestaj = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonexport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewizvestaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartizvestaj)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewizvestaj
            // 
            this.dataGridViewizvestaj.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewizvestaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewizvestaj.Location = new System.Drawing.Point(110, 86);
            this.dataGridViewizvestaj.Name = "dataGridViewizvestaj";
            this.dataGridViewizvestaj.Size = new System.Drawing.Size(262, 229);
            this.dataGridViewizvestaj.TabIndex = 0;
            // 
            // chartizvestaj
            // 
            chartArea1.Name = "ChartArea1";
            this.chartizvestaj.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartizvestaj.Legends.Add(legend1);
            this.chartizvestaj.Location = new System.Drawing.Point(378, 86);
            this.chartizvestaj.Name = "chartizvestaj";
            this.chartizvestaj.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartizvestaj.Series.Add(series1);
            this.chartizvestaj.Size = new System.Drawing.Size(336, 228);
            this.chartizvestaj.TabIndex = 1;
            this.chartizvestaj.Text = "Izveštaj";
            // 
            // buttonexport
            // 
            this.buttonexport.BackColor = System.Drawing.SystemColors.Info;
            this.buttonexport.Location = new System.Drawing.Point(332, 332);
            this.buttonexport.Name = "buttonexport";
            this.buttonexport.Size = new System.Drawing.Size(91, 23);
            this.buttonexport.TabIndex = 2;
            this.buttonexport.Text = "Export u TXT";
            this.buttonexport.UseVisualStyleBackColor = false;
            this.buttonexport.Click += new System.EventHandler(this.buttonexport_Click);
            // 
            // FrmIzvestajiPoRadniku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonexport);
            this.Controls.Add(this.chartizvestaj);
            this.Controls.Add(this.dataGridViewizvestaj);
            this.Name = "FrmIzvestajiPoRadniku";
            this.Text = "FrmIzvestajiPoRadniku";
            this.Load += new System.EventHandler(this.FrmIzvestajiPoRadniku_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewizvestaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartizvestaj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewizvestaj;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartizvestaj;
        private System.Windows.Forms.Button buttonexport;
    }
}