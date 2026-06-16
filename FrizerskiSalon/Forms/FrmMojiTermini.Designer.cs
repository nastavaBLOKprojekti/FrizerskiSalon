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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtermini)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewtermini
            // 
            this.dataGridViewtermini.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridViewtermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtermini.Location = new System.Drawing.Point(126, 91);
            this.dataGridViewtermini.Name = "dataGridViewtermini";
            this.dataGridViewtermini.Size = new System.Drawing.Size(286, 203);
            this.dataGridViewtermini.TabIndex = 0;
            // 
            // buttonzakazitetermin
            // 
            this.buttonzakazitetermin.BackColor = System.Drawing.SystemColors.Info;
            this.buttonzakazitetermin.Location = new System.Drawing.Point(454, 167);
            this.buttonzakazitetermin.Name = "buttonzakazitetermin";
            this.buttonzakazitetermin.Size = new System.Drawing.Size(111, 23);
            this.buttonzakazitetermin.TabIndex = 1;
            this.buttonzakazitetermin.Text = "Zakažite termin";
            this.buttonzakazitetermin.UseVisualStyleBackColor = false;
            // 
            // buttonotkazitetermin
            // 
            this.buttonotkazitetermin.BackColor = System.Drawing.SystemColors.Info;
            this.buttonotkazitetermin.Location = new System.Drawing.Point(454, 196);
            this.buttonotkazitetermin.Name = "buttonotkazitetermin";
            this.buttonotkazitetermin.Size = new System.Drawing.Size(111, 23);
            this.buttonotkazitetermin.TabIndex = 2;
            this.buttonotkazitetermin.Text = "Otkažite termin";
            this.buttonotkazitetermin.UseVisualStyleBackColor = false;
            // 
            // FrmMojiTermini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonotkazitetermin);
            this.Controls.Add(this.buttonzakazitetermin);
            this.Controls.Add(this.dataGridViewtermini);
            this.Name = "FrmMojiTermini";
            this.Text = "FrmMojiTermini";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtermini)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewtermini;
        private System.Windows.Forms.Button buttonzakazitetermin;
        private System.Windows.Forms.Button buttonotkazitetermin;
    }
}