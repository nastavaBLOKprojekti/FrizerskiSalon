namespace FrizerskiSalon.Forms
{
    partial class FrmZakaziTermin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmZakaziTermin));
            this.comboBoxradnik = new System.Windows.Forms.ComboBox();
            this.comboBoxusluga = new System.Windows.Forms.ComboBox();
            this.dateTimePickerdatum = new System.Windows.Forms.DateTimePicker();
            this.buttonzakazi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxradnik
            // 
            this.comboBoxradnik.FormattingEnabled = true;
            this.comboBoxradnik.Location = new System.Drawing.Point(280, 136);
            this.comboBoxradnik.Name = "comboBoxradnik";
            this.comboBoxradnik.Size = new System.Drawing.Size(151, 21);
            this.comboBoxradnik.TabIndex = 0;
            // 
            // comboBoxusluga
            // 
            this.comboBoxusluga.FormattingEnabled = true;
            this.comboBoxusluga.Location = new System.Drawing.Point(280, 211);
            this.comboBoxusluga.Name = "comboBoxusluga";
            this.comboBoxusluga.Size = new System.Drawing.Size(151, 21);
            this.comboBoxusluga.TabIndex = 1;
            // 
            // dateTimePickerdatum
            // 
            this.dateTimePickerdatum.Location = new System.Drawing.Point(237, 173);
            this.dateTimePickerdatum.Name = "dateTimePickerdatum";
            this.dateTimePickerdatum.Size = new System.Drawing.Size(194, 20);
            this.dateTimePickerdatum.TabIndex = 2;
            // 
            // buttonzakazi
            // 
            this.buttonzakazi.BackColor = System.Drawing.SystemColors.Info;
            this.buttonzakazi.Location = new System.Drawing.Point(356, 251);
            this.buttonzakazi.Name = "buttonzakazi";
            this.buttonzakazi.Size = new System.Drawing.Size(75, 23);
            this.buttonzakazi.TabIndex = 3;
            this.buttonzakazi.Text = "Zakaži";
            this.buttonzakazi.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Radnik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datum i vreme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Usluga:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(437, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FrmZakaziTermin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonzakazi);
            this.Controls.Add(this.dateTimePickerdatum);
            this.Controls.Add(this.comboBoxusluga);
            this.Controls.Add(this.comboBoxradnik);
            this.Name = "FrmZakaziTermin";
            this.Text = "FrmZakazaniTermin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxradnik;
        private System.Windows.Forms.ComboBox comboBoxusluga;
        private System.Windows.Forms.DateTimePicker dateTimePickerdatum;
        private System.Windows.Forms.Button buttonzakazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}