namespace FrizerskiSalon.Forms
{
    partial class FrmMojiTermini
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
            this.dataGridViewtermini = new System.Windows.Forms.DataGridView();
            this.buttonzakazitetermin = new System.Windows.Forms.Button();
            this.buttonotkazitetermin = new System.Windows.Forms.Button();
            this.comboBoxstatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxnapomena = new System.Windows.Forms.TextBox();
            this.buttonsacuvaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtermini)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewtermini
            // 
            this.dataGridViewtermini.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewtermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtermini.Location = new System.Drawing.Point(126, 91);
            this.dataGridViewtermini.Name = "dataGridViewtermini";
            this.dataGridViewtermini.Size = new System.Drawing.Size(286, 203);
            this.dataGridViewtermini.TabIndex = 0;
            this.dataGridViewtermini.SelectionChanged += new System.EventHandler(this.dataGridViewtermini_SelectionChanged_1);
            // 
            // buttonzakazitetermin
            // 
            this.buttonzakazitetermin.BackColor = System.Drawing.SystemColors.Info;
            this.buttonzakazitetermin.Location = new System.Drawing.Point(126, 309);
            this.buttonzakazitetermin.Name = "buttonzakazitetermin";
            this.buttonzakazitetermin.Size = new System.Drawing.Size(111, 23);
            this.buttonzakazitetermin.TabIndex = 1;
            this.buttonzakazitetermin.Text = "Zakažite termin";
            this.buttonzakazitetermin.UseVisualStyleBackColor = false;
            this.buttonzakazitetermin.Click += new System.EventHandler(this.buttonzakazitetermin_Click);
            // 
            // buttonotkazitetermin
            // 
            this.buttonotkazitetermin.BackColor = System.Drawing.SystemColors.Info;
            this.buttonotkazitetermin.Location = new System.Drawing.Point(301, 309);
            this.buttonotkazitetermin.Name = "buttonotkazitetermin";
            this.buttonotkazitetermin.Size = new System.Drawing.Size(111, 23);
            this.buttonotkazitetermin.TabIndex = 2;
            this.buttonotkazitetermin.Text = "Otkažite termin";
            this.buttonotkazitetermin.UseVisualStyleBackColor = false;
            this.buttonotkazitetermin.Click += new System.EventHandler(this.buttonotkazitetermin_Click);
            // 
            // comboBoxstatus
            // 
            this.comboBoxstatus.FormattingEnabled = true;
            this.comboBoxstatus.Location = new System.Drawing.Point(522, 142);
            this.comboBoxstatus.Name = "comboBoxstatus";
            this.comboBoxstatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxstatus.TabIndex = 3;
            this.comboBoxstatus.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Napomena:";
            // 
            // textBoxnapomena
            // 
            this.textBoxnapomena.Location = new System.Drawing.Point(522, 188);
            this.textBoxnapomena.Name = "textBoxnapomena";
            this.textBoxnapomena.Size = new System.Drawing.Size(121, 20);
            this.textBoxnapomena.TabIndex = 6;
            this.textBoxnapomena.Visible = false;
            // 
            // buttonsacuvaj
            // 
            this.buttonsacuvaj.BackColor = System.Drawing.SystemColors.Info;
            this.buttonsacuvaj.Location = new System.Drawing.Point(490, 231);
            this.buttonsacuvaj.Name = "buttonsacuvaj";
            this.buttonsacuvaj.Size = new System.Drawing.Size(75, 23);
            this.buttonsacuvaj.TabIndex = 7;
            this.buttonsacuvaj.Text = "Sačuvaj";
            this.buttonsacuvaj.UseVisualStyleBackColor = false;
            this.buttonsacuvaj.Click += new System.EventHandler(this.buttonsacuvaj_Click);
            // 
            // FrmMojiTermini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonsacuvaj);
            this.Controls.Add(this.textBoxnapomena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxstatus);
            this.Controls.Add(this.buttonotkazitetermin);
            this.Controls.Add(this.buttonzakazitetermin);
            this.Controls.Add(this.dataGridViewtermini);
            this.Name = "FrmMojiTermini";
            this.Text = "FrmMojiTermini";
            this.Load += new System.EventHandler(this.FrmMojiTermini_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtermini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewtermini;
        private System.Windows.Forms.Button buttonzakazitetermin;
        private System.Windows.Forms.Button buttonotkazitetermin;
        private System.Windows.Forms.ComboBox comboBoxstatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxnapomena;
        private System.Windows.Forms.Button buttonsacuvaj;
    }
}