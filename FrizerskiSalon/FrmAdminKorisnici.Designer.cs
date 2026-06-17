namespace FrizerskiSalon.Forms
{
    partial class FrmAdminKorisnici
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
            this.dataGridViewKorisnici = new System.Windows.Forms.DataGridView();
            this.buttondodaj = new System.Windows.Forms.Button();
            this.buttonobrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKorisnici
            // 
            this.dataGridViewKorisnici.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKorisnici.Location = new System.Drawing.Point(248, 87);
            this.dataGridViewKorisnici.Name = "dataGridViewKorisnici";
            this.dataGridViewKorisnici.Size = new System.Drawing.Size(283, 213);
            this.dataGridViewKorisnici.TabIndex = 0;
            // 
            // buttondodaj
            // 
            this.buttondodaj.BackColor = System.Drawing.SystemColors.Info;
            this.buttondodaj.Location = new System.Drawing.Point(307, 323);
            this.buttondodaj.Name = "buttondodaj";
            this.buttondodaj.Size = new System.Drawing.Size(75, 23);
            this.buttondodaj.TabIndex = 1;
            this.buttondodaj.Text = "Dodaj";
            this.buttondodaj.UseVisualStyleBackColor = false;
            this.buttondodaj.Click += new System.EventHandler(this.buttondodaj_Click);
            // 
            // buttonobrisi
            // 
            this.buttonobrisi.BackColor = System.Drawing.SystemColors.Info;
            this.buttonobrisi.Location = new System.Drawing.Point(400, 323);
            this.buttonobrisi.Name = "buttonobrisi";
            this.buttonobrisi.Size = new System.Drawing.Size(75, 23);
            this.buttonobrisi.TabIndex = 2;
            this.buttonobrisi.Text = "Obriši";
            this.buttonobrisi.UseVisualStyleBackColor = false;
            this.buttonobrisi.Click += new System.EventHandler(this.buttonobrisi_Click);
            // 
            // FrmAdminKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonobrisi);
            this.Controls.Add(this.buttondodaj);
            this.Controls.Add(this.dataGridViewKorisnici);
            this.Name = "FrmAdminKorisnici";
            this.Text = "FrmAdminKorisnici";
            this.Load += new System.EventHandler(this.FrmAdminKorisnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorisnici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKorisnici;
        private System.Windows.Forms.Button buttondodaj;
        private System.Windows.Forms.Button buttonobrisi;
    }
}