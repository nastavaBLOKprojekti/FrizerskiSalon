namespace FrizerskiSalon.Forms
{
    partial class FrmGlavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGlavna));
            this.labeldobrodosli = new System.Windows.Forms.Label();
            this.buttonmojitermini = new System.Windows.Forms.Button();
            this.buttonsvitermini = new System.Windows.Forms.Button();
            this.buttonkorisnici = new System.Windows.Forms.Button();
            this.buttonizvestaj = new System.Windows.Forms.Button();
            this.buttonodjavise = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labeldobrodosli
            // 
            this.labeldobrodosli.AutoSize = true;
            this.labeldobrodosli.Location = new System.Drawing.Point(188, 105);
            this.labeldobrodosli.Name = "labeldobrodosli";
            this.labeldobrodosli.Size = new System.Drawing.Size(29, 13);
            this.labeldobrodosli.TabIndex = 0;
            this.labeldobrodosli.Text = "label";
            // 
            // buttonmojitermini
            // 
            this.buttonmojitermini.BackColor = System.Drawing.SystemColors.Info;
            this.buttonmojitermini.Location = new System.Drawing.Point(191, 132);
            this.buttonmojitermini.Name = "buttonmojitermini";
            this.buttonmojitermini.Size = new System.Drawing.Size(75, 23);
            this.buttonmojitermini.TabIndex = 1;
            this.buttonmojitermini.Text = "Moji termini";
            this.buttonmojitermini.UseVisualStyleBackColor = false;
            // 
            // buttonsvitermini
            // 
            this.buttonsvitermini.BackColor = System.Drawing.SystemColors.Info;
            this.buttonsvitermini.Location = new System.Drawing.Point(191, 161);
            this.buttonsvitermini.Name = "buttonsvitermini";
            this.buttonsvitermini.Size = new System.Drawing.Size(75, 23);
            this.buttonsvitermini.TabIndex = 2;
            this.buttonsvitermini.Text = "Svi termini";
            this.buttonsvitermini.UseVisualStyleBackColor = false;
            // 
            // buttonkorisnici
            // 
            this.buttonkorisnici.BackColor = System.Drawing.SystemColors.Info;
            this.buttonkorisnici.Location = new System.Drawing.Point(191, 190);
            this.buttonkorisnici.Name = "buttonkorisnici";
            this.buttonkorisnici.Size = new System.Drawing.Size(75, 23);
            this.buttonkorisnici.TabIndex = 3;
            this.buttonkorisnici.Text = "Korisnici";
            this.buttonkorisnici.UseVisualStyleBackColor = false;
            // 
            // buttonizvestaj
            // 
            this.buttonizvestaj.BackColor = System.Drawing.SystemColors.Info;
            this.buttonizvestaj.Location = new System.Drawing.Point(191, 219);
            this.buttonizvestaj.Name = "buttonizvestaj";
            this.buttonizvestaj.Size = new System.Drawing.Size(75, 23);
            this.buttonizvestaj.TabIndex = 4;
            this.buttonizvestaj.Text = "Izveštaj";
            this.buttonizvestaj.UseVisualStyleBackColor = false;
            // 
            // buttonodjavise
            // 
            this.buttonodjavise.BackColor = System.Drawing.SystemColors.Info;
            this.buttonodjavise.Location = new System.Drawing.Point(191, 248);
            this.buttonodjavise.Name = "buttonodjavise";
            this.buttonodjavise.Size = new System.Drawing.Size(75, 23);
            this.buttonodjavise.TabIndex = 5;
            this.buttonodjavise.Text = "Odjavi se";
            this.buttonodjavise.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(289, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonodjavise);
            this.Controls.Add(this.buttonizvestaj);
            this.Controls.Add(this.buttonkorisnici);
            this.Controls.Add(this.buttonsvitermini);
            this.Controls.Add(this.buttonmojitermini);
            this.Controls.Add(this.labeldobrodosli);
            this.Name = "FrmGlavna";
            this.Text = "FrmGlavna";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeldobrodosli;
        private System.Windows.Forms.Button buttonmojitermini;
        private System.Windows.Forms.Button buttonsvitermini;
        private System.Windows.Forms.Button buttonkorisnici;
        private System.Windows.Forms.Button buttonizvestaj;
        private System.Windows.Forms.Button buttonodjavise;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}