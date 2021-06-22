namespace projekat
{
    partial class AdminForma
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
            this.cbKupci = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbKupciRezervacije = new System.Windows.Forms.ListBox();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbKategorija = new System.Windows.Forms.ListBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnUpisi = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnObrisiKupca = new System.Windows.Forms.Button();
            this.btnIzmenaKupca = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOsvezi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbKupci
            // 
            this.cbKupci.FormattingEnabled = true;
            this.cbKupci.Location = new System.Drawing.Point(20, 44);
            this.cbKupci.Name = "cbKupci";
            this.cbKupci.Size = new System.Drawing.Size(438, 21);
            this.cbKupci.TabIndex = 0;
            this.cbKupci.SelectedValueChanged += new System.EventHandler(this.cbKupci_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rezervacije:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Izaberi kupca";
            // 
            // lbKupciRezervacije
            // 
            this.lbKupciRezervacije.FormattingEnabled = true;
            this.lbKupciRezervacije.Location = new System.Drawing.Point(20, 96);
            this.lbKupciRezervacije.Name = "lbKupciRezervacije";
            this.lbKupciRezervacije.Size = new System.Drawing.Size(977, 160);
            this.lbKupciRezervacije.TabIndex = 3;
            // 
            // cbKategorija
            // 
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(20, 54);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(252, 21);
            this.cbKategorija.TabIndex = 4;
            this.cbKategorija.SelectedValueChanged += new System.EventHandler(this.cbKategorija_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Izaberi kategoriju";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sadrzaj:";
            // 
            // lbKategorija
            // 
            this.lbKategorija.FormattingEnabled = true;
            this.lbKategorija.HorizontalScrollbar = true;
            this.lbKategorija.Location = new System.Drawing.Point(19, 103);
            this.lbKategorija.Name = "lbKategorija";
            this.lbKategorija.Size = new System.Drawing.Size(977, 173);
            this.lbKategorija.TabIndex = 7;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(778, 54);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(219, 27);
            this.btnObrisi.TabIndex = 8;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(540, 54);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(219, 26);
            this.btnIzmeni.TabIndex = 9;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnUpisi
            // 
            this.btnUpisi.Location = new System.Drawing.Point(294, 54);
            this.btnUpisi.Name = "btnUpisi";
            this.btnUpisi.Size = new System.Drawing.Size(219, 26);
            this.btnUpisi.TabIndex = 10;
            this.btnUpisi.Text = "Upisi";
            this.btnUpisi.UseVisualStyleBackColor = true;
            this.btnUpisi.Click += new System.EventHandler(this.btnUpisi_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(61, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 26);
            this.label9.TabIndex = 30;
            this.label9.Text = "Administracija";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(472, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "***BIOSKOP***";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOsvezi);
            this.groupBox1.Controls.Add(this.btnObrisiKupca);
            this.groupBox1.Controls.Add(this.btnIzmenaKupca);
            this.groupBox1.Controls.Add(this.lbKupciRezervacije);
            this.groupBox1.Controls.Add(this.cbKupci);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(47, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 277);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kupci";
            // 
            // btnObrisiKupca
            // 
            this.btnObrisiKupca.Location = new System.Drawing.Point(777, 40);
            this.btnObrisiKupca.Name = "btnObrisiKupca";
            this.btnObrisiKupca.Size = new System.Drawing.Size(219, 26);
            this.btnObrisiKupca.TabIndex = 12;
            this.btnObrisiKupca.Text = "Obrisi kupca";
            this.btnObrisiKupca.UseVisualStyleBackColor = true;
            this.btnObrisiKupca.Click += new System.EventHandler(this.btnObrisiKupca_Click);
            // 
            // btnIzmenaKupca
            // 
            this.btnIzmenaKupca.Location = new System.Drawing.Point(552, 41);
            this.btnIzmenaKupca.Name = "btnIzmenaKupca";
            this.btnIzmenaKupca.Size = new System.Drawing.Size(219, 26);
            this.btnIzmenaKupca.TabIndex = 11;
            this.btnIzmenaKupca.Text = "Izmeni podatke o kupcu";
            this.btnIzmenaKupca.UseVisualStyleBackColor = true;
            this.btnIzmenaKupca.Click += new System.EventHandler(this.btnIzmenaKupca_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbKategorija);
            this.groupBox2.Controls.Add(this.cbKategorija);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnUpisi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnIzmeni);
            this.groupBox2.Controls.Add(this.btnObrisi);
            this.groupBox2.Location = new System.Drawing.Point(47, 400);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1018, 299);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kategorije";
            // 
            // btnOsvezi
            // 
            this.btnOsvezi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOsvezi.Location = new System.Drawing.Point(465, 41);
            this.btnOsvezi.Name = "btnOsvezi";
            this.btnOsvezi.Size = new System.Drawing.Size(48, 28);
            this.btnOsvezi.TabIndex = 13;
            this.btnOsvezi.Text = "↺";
            this.btnOsvezi.UseVisualStyleBackColor = true;
            this.btnOsvezi.Click += new System.EventHandler(this.btnOsvezi_Click);
            // 
            // AdminForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 711);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Name = "AdminForma";
            this.Text = "AdminForma";
            this.Load += new System.EventHandler(this.AdminForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKupci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbKupciRezervacije;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbKategorija;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnUpisi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnObrisiKupca;
        private System.Windows.Forms.Button btnIzmenaKupca;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOsvezi;
    }
}