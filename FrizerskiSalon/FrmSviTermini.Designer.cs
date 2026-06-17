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
            this.dateTimePickerFilter = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTermini = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTermini)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxFilterRadnik
            // 
            this.comboBoxFilterRadnik.FormattingEnabled = true;
            this.comboBoxFilterRadnik.Location = new System.Drawing.Point(489, 124);
            this.comboBoxFilterRadnik.Name = "comboBoxFilterRadnik";
            this.comboBoxFilterRadnik.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilterRadnik.TabIndex = 0;
            // 
            // comboBoxFilterStatus
            // 
            this.comboBoxFilterStatus.FormattingEnabled = true;
            this.comboBoxFilterStatus.Location = new System.Drawing.Point(489, 168);
            this.comboBoxFilterStatus.Name = "comboBoxFilterStatus";
            this.comboBoxFilterStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilterStatus.TabIndex = 1;
            // 
            // buttonFiltriraj
            // 
            this.buttonFiltriraj.BackColor = System.Drawing.SystemColors.Info;
            this.buttonFiltriraj.Location = new System.Drawing.Point(403, 253);
            this.buttonFiltriraj.Name = "buttonFiltriraj";
            this.buttonFiltriraj.Size = new System.Drawing.Size(95, 21);
            this.buttonFiltriraj.TabIndex = 2;
            this.buttonFiltriraj.Text = "Filtriraj";
            this.buttonFiltriraj.UseVisualStyleBackColor = false;
            this.buttonFiltriraj.Click += new System.EventHandler(this.buttonFiltriraj_Click);
            // 
            // buttonResetuj
            // 
            this.buttonResetuj.BackColor = System.Drawing.SystemColors.Info;
            this.buttonResetuj.Location = new System.Drawing.Point(518, 253);
            this.buttonResetuj.Name = "buttonResetuj";
            this.buttonResetuj.Size = new System.Drawing.Size(92, 22);
            this.buttonResetuj.TabIndex = 3;
            this.buttonResetuj.Text = "Resetuj";
            this.buttonResetuj.UseVisualStyleBackColor = false;
            this.buttonResetuj.Click += new System.EventHandler(this.buttonResetuj_Click);
            // 
            // dateTimePickerFilter
            // 
            this.dateTimePickerFilter.Location = new System.Drawing.Point(403, 210);
            this.dateTimePickerFilter.Name = "dateTimePickerFilter";
            this.dateTimePickerFilter.Size = new System.Drawing.Size(207, 20);
            this.dateTimePickerFilter.TabIndex = 4;
            // 
            // dataGridViewTermini
            // 
            this.dataGridViewTermini.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTermini.Location = new System.Drawing.Point(104, 111);
            this.dataGridViewTermini.Name = "dataGridViewTermini";
            this.dataGridViewTermini.Size = new System.Drawing.Size(277, 182);
            this.dataGridViewTermini.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Radnik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Status:";
            // 
            // FrmSviTermini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTermini);
            this.Controls.Add(this.dateTimePickerFilter);
            this.Controls.Add(this.buttonResetuj);
            this.Controls.Add(this.buttonFiltriraj);
            this.Controls.Add(this.comboBoxFilterStatus);
            this.Controls.Add(this.comboBoxFilterRadnik);
            this.Name = "FrmSviTermini";
            this.Text = "FrmSviTermini";
            this.Load += new System.EventHandler(this.FrmSviTermini_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTermini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFilterRadnik;
        private System.Windows.Forms.ComboBox comboBoxFilterStatus;
        private System.Windows.Forms.Button buttonFiltriraj;
        private System.Windows.Forms.Button buttonResetuj;
        private System.Windows.Forms.DateTimePicker dateTimePickerFilter;
        private System.Windows.Forms.DataGridView dataGridViewTermini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}