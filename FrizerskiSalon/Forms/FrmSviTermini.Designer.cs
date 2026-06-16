namespace FrizerskiSalon.Forms
{
    partial class FrmSviTermini
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
            this.comboBoxFilterRadnik = new System.Windows.Forms.ComboBox();
            this.comboBoxFilterStatus = new System.Windows.Forms.ComboBox();
            this.buttonFiltriraj = new System.Windows.Forms.Button();
            this.buttonResetuj = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // comboBoxFilterRadnik
            // 
            this.comboBoxFilterRadnik.FormattingEnabled = true;
            this.comboBoxFilterRadnik.Location = new System.Drawing.Point(113, 75);
            this.comboBoxFilterRadnik.Name = "comboBoxFilterRadnik";
            this.comboBoxFilterRadnik.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilterRadnik.TabIndex = 0;
            // 
            // comboBoxFilterStatus
            // 
            this.comboBoxFilterStatus.FormattingEnabled = true;
            this.comboBoxFilterStatus.Location = new System.Drawing.Point(113, 117);
            this.comboBoxFilterStatus.Name = "comboBoxFilterStatus";
            this.comboBoxFilterStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilterStatus.TabIndex = 1;
            // 
            // buttonFiltriraj
            // 
            this.buttonFiltriraj.Location = new System.Drawing.Point(487, 65);
            this.buttonFiltriraj.Name = "buttonFiltriraj";
            this.buttonFiltriraj.Size = new System.Drawing.Size(95, 46);
            this.buttonFiltriraj.TabIndex = 2;
            this.buttonFiltriraj.Text = "Filtriraj";
            this.buttonFiltriraj.UseVisualStyleBackColor = true;
            // 
            // buttonResetuj
            // 
            this.buttonResetuj.Location = new System.Drawing.Point(487, 117);
            this.buttonResetuj.Name = "buttonResetuj";
            this.buttonResetuj.Size = new System.Drawing.Size(92, 44);
            this.buttonResetuj.TabIndex = 3;
            this.buttonResetuj.Text = "Resetuj";
            this.buttonResetuj.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(193, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(386, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // FrmSviTermini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonResetuj);
            this.Controls.Add(this.buttonFiltriraj);
            this.Controls.Add(this.comboBoxFilterStatus);
            this.Controls.Add(this.comboBoxFilterRadnik);
            this.Name = "FrmSviTermini";
            this.Text = "FrmSviTermini";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFilterRadnik;
        private System.Windows.Forms.ComboBox comboBoxFilterStatus;
        private System.Windows.Forms.Button buttonFiltriraj;
        private System.Windows.Forms.Button buttonResetuj;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}