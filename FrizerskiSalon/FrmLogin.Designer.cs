namespace FrizerskiSalon.Forms
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.labelkorisnickoime = new System.Windows.Forms.Label();
            this.labellozinka = new System.Windows.Forms.Label();
            this.textBoxkorisnickoime = new System.Windows.Forms.TextBox();
            this.textBoxlozinka = new System.Windows.Forms.TextBox();
            this.buttonprijava = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxprikazi = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelkorisnickoime
            // 
            this.labelkorisnickoime.AutoSize = true;
            this.labelkorisnickoime.Location = new System.Drawing.Point(150, 153);
            this.labelkorisnickoime.Name = "labelkorisnickoime";
            this.labelkorisnickoime.Size = new System.Drawing.Size(78, 13);
            this.labelkorisnickoime.TabIndex = 0;
            this.labelkorisnickoime.Text = "Korisničko ime:";
            // 
            // labellozinka
            // 
            this.labellozinka.AutoSize = true;
            this.labellozinka.Location = new System.Drawing.Point(181, 197);
            this.labellozinka.Name = "labellozinka";
            this.labellozinka.Size = new System.Drawing.Size(47, 13);
            this.labellozinka.TabIndex = 1;
            this.labellozinka.Text = "Lozinka:";
            // 
            // textBoxkorisnickoime
            // 
            this.textBoxkorisnickoime.Location = new System.Drawing.Point(245, 150);
            this.textBoxkorisnickoime.Name = "textBoxkorisnickoime";
            this.textBoxkorisnickoime.Size = new System.Drawing.Size(120, 20);
            this.textBoxkorisnickoime.TabIndex = 2;
            // 
            // textBoxlozinka
            // 
            this.textBoxlozinka.Location = new System.Drawing.Point(245, 197);
            this.textBoxlozinka.Name = "textBoxlozinka";
            this.textBoxlozinka.PasswordChar = '*';
            this.textBoxlozinka.Size = new System.Drawing.Size(120, 20);
            this.textBoxlozinka.TabIndex = 3;
            // 
            // buttonprijava
            // 
            this.buttonprijava.BackColor = System.Drawing.SystemColors.Info;
            this.buttonprijava.Location = new System.Drawing.Point(270, 248);
            this.buttonprijava.Name = "buttonprijava";
            this.buttonprijava.Size = new System.Drawing.Size(80, 23);
            this.buttonprijava.TabIndex = 4;
            this.buttonprijava.Text = "Prijavi se";
            this.buttonprijava.UseVisualStyleBackColor = false;
            this.buttonprijava.Click += new System.EventHandler(this.buttonprijava_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(371, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // checkBoxprikazi
            // 
            this.checkBoxprikazi.AutoSize = true;
            this.checkBoxprikazi.Location = new System.Drawing.Point(257, 225);
            this.checkBoxprikazi.Name = "checkBoxprikazi";
            this.checkBoxprikazi.Size = new System.Drawing.Size(93, 17);
            this.checkBoxprikazi.TabIndex = 6;
            this.checkBoxprikazi.Text = "Prikaži lozinku";
            this.checkBoxprikazi.UseVisualStyleBackColor = true;
            this.checkBoxprikazi.CheckedChanged += new System.EventHandler(this.checkBoxprikazi_CheckedChanged);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxprikazi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonprijava);
            this.Controls.Add(this.textBoxlozinka);
            this.Controls.Add(this.textBoxkorisnickoime);
            this.Controls.Add(this.labellozinka);
            this.Controls.Add(this.labelkorisnickoime);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelkorisnickoime;
        private System.Windows.Forms.Label labellozinka;
        private System.Windows.Forms.TextBox textBoxkorisnickoime;
        private System.Windows.Forms.TextBox textBoxlozinka;
        private System.Windows.Forms.Button buttonprijava;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxprikazi;
    }
}