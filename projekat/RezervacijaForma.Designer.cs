namespace projekat
{
    partial class RezervacijaForma
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtPocetni = new System.Windows.Forms.DateTimePicker();
            this.dtKrajnji = new System.Windows.Forms.DateTimePicker();
            this.cbSala = new System.Windows.Forms.ComboBox();
            this.cbNaziv = new System.Windows.Forms.ComboBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbRepertoar = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUkupnaCena = new System.Windows.Forms.TextBox();
            this.nudBrojMesta = new System.Windows.Forms.NumericUpDown();
            this.btnRezervisi = new System.Windows.Forms.Button();
            this.lblDodaj = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojMesta)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filteri:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pocetni datum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Krajnji datum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(747, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sala";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(977, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Naziv";
            // 
            // dtPocetni
            // 
            this.dtPocetni.Location = new System.Drawing.Point(50, 205);
            this.dtPocetni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtPocetni.MinDate = new System.DateTime(2021, 4, 12, 0, 0, 0, 0);
            this.dtPocetni.Name = "dtPocetni";
            this.dtPocetni.Size = new System.Drawing.Size(298, 26);
            this.dtPocetni.TabIndex = 6;
            // 
            // dtKrajnji
            // 
            this.dtKrajnji.Location = new System.Drawing.Point(398, 205);
            this.dtKrajnji.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtKrajnji.Name = "dtKrajnji";
            this.dtKrajnji.Size = new System.Drawing.Size(298, 26);
            this.dtKrajnji.TabIndex = 7;
            // 
            // cbSala
            // 
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Location = new System.Drawing.Point(752, 202);
            this.cbSala.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(180, 28);
            this.cbSala.TabIndex = 8;
            // 
            // cbNaziv
            // 
            this.cbNaziv.FormattingEnabled = true;
            this.cbNaziv.Location = new System.Drawing.Point(981, 202);
            this.cbNaziv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbNaziv.Name = "cbNaziv";
            this.cbNaziv.Size = new System.Drawing.Size(180, 28);
            this.cbNaziv.TabIndex = 9;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikazi.Location = new System.Drawing.Point(50, 260);
            this.btnPrikazi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(1113, 63);
            this.btnPrikazi.TabIndex = 10;
            this.btnPrikazi.Text = "Prikazi dostupne projekcije";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 340);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Repertoar bioskopa";
            // 
            // lbRepertoar
            // 
            this.lbRepertoar.FormattingEnabled = true;
            this.lbRepertoar.ItemHeight = 20;
            this.lbRepertoar.Location = new System.Drawing.Point(50, 370);
            this.lbRepertoar.Name = "lbRepertoar";
            this.lbRepertoar.Size = new System.Drawing.Size(1113, 224);
            this.lbRepertoar.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 609);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "Broj mesta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(251, 609);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ukupna cena:";
            // 
            // txtUkupnaCena
            // 
            this.txtUkupnaCena.Location = new System.Drawing.Point(256, 638);
            this.txtUkupnaCena.Name = "txtUkupnaCena";
            this.txtUkupnaCena.Size = new System.Drawing.Size(161, 26);
            this.txtUkupnaCena.TabIndex = 15;
            this.txtUkupnaCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudBrojMesta
            // 
            this.nudBrojMesta.Location = new System.Drawing.Point(50, 638);
            this.nudBrojMesta.Name = "nudBrojMesta";
            this.nudBrojMesta.Size = new System.Drawing.Size(147, 26);
            this.nudBrojMesta.TabIndex = 16;
            this.nudBrojMesta.ValueChanged += new System.EventHandler(this.nudBrojMesta_ValueChanged);
            // 
            // btnRezervisi
            // 
            this.btnRezervisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervisi.Location = new System.Drawing.Point(448, 609);
            this.btnRezervisi.Name = "btnRezervisi";
            this.btnRezervisi.Size = new System.Drawing.Size(713, 71);
            this.btnRezervisi.TabIndex = 17;
            this.btnRezervisi.Text = "Rezervisi";
            this.btnRezervisi.UseVisualStyleBackColor = true;
            this.btnRezervisi.Click += new System.EventHandler(this.btnRezervisi_Click);
            // 
            // lblDodaj
            // 
            this.lblDodaj.AutoSize = true;
            this.lblDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDodaj.ForeColor = System.Drawing.Color.Blue;
            this.lblDodaj.Location = new System.Drawing.Point(45, 70);
            this.lblDodaj.Name = "lblDodaj";
            this.lblDodaj.Size = new System.Drawing.Size(246, 26);
            this.lblDodaj.TabIndex = 23;
            this.lblDodaj.Text = "Rezervacija projekcija";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(532, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "***BIOSKOP***";
            // 
            // RezervacijaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.lblDodaj);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnRezervisi);
            this.Controls.Add(this.nudBrojMesta);
            this.Controls.Add(this.txtUkupnaCena);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbRepertoar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.cbNaziv);
            this.Controls.Add(this.cbSala);
            this.Controls.Add(this.dtKrajnji);
            this.Controls.Add(this.dtPocetni);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RezervacijaForma";
            this.Text = "RezervacijaForma";
            this.Load += new System.EventHandler(this.RezervacijaForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojMesta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtPocetni;
        private System.Windows.Forms.DateTimePicker dtKrajnji;
        private System.Windows.Forms.ComboBox cbSala;
        private System.Windows.Forms.ComboBox cbNaziv;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbRepertoar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUkupnaCena;
        private System.Windows.Forms.NumericUpDown nudBrojMesta;
        private System.Windows.Forms.Button btnRezervisi;
        private System.Windows.Forms.Label lblDodaj;
        private System.Windows.Forms.Label label10;
    }
}