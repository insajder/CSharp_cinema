namespace projekat
{
    partial class ProjekcijaForma
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
            this.btnDodajProjekciju = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDatum = new System.Windows.Forms.DateTimePicker();
            this.cbSale = new System.Windows.Forms.ComboBox();
            this.cbFilmovi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDodaj = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSat = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbMinut = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDodajProjekciju
            // 
            this.btnDodajProjekciju.Location = new System.Drawing.Point(121, 427);
            this.btnDodajProjekciju.Name = "btnDodajProjekciju";
            this.btnDodajProjekciju.Size = new System.Drawing.Size(292, 41);
            this.btnDodajProjekciju.TabIndex = 19;
            this.btnDodajProjekciju.Text = "Dodaj";
            this.btnDodajProjekciju.UseVisualStyleBackColor = true;
            this.btnDodajProjekciju.Click += new System.EventHandler(this.btnDodajProjekciju_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Unesite vreme pocetka:";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(236, 268);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(200, 20);
            this.txtCena.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Unesite cenu karte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Izaberite salu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Izaberite datum:";
            // 
            // dtDatum
            // 
            this.dtDatum.Location = new System.Drawing.Point(236, 312);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.Size = new System.Drawing.Size(200, 20);
            this.dtDatum.TabIndex = 20;
            // 
            // cbSale
            // 
            this.cbSale.FormattingEnabled = true;
            this.cbSale.Location = new System.Drawing.Point(236, 218);
            this.cbSale.Name = "cbSale";
            this.cbSale.Size = new System.Drawing.Size(200, 21);
            this.cbSale.TabIndex = 21;
            // 
            // cbFilmovi
            // 
            this.cbFilmovi.FormattingEnabled = true;
            this.cbFilmovi.Location = new System.Drawing.Point(236, 172);
            this.cbFilmovi.Name = "cbFilmovi";
            this.cbFilmovi.Size = new System.Drawing.Size(200, 21);
            this.cbFilmovi.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Izaberite film:";
            // 
            // lblDodaj
            // 
            this.lblDodaj.AutoSize = true;
            this.lblDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDodaj.ForeColor = System.Drawing.Color.Blue;
            this.lblDodaj.Location = new System.Drawing.Point(101, 86);
            this.lblDodaj.Name = "lblDodaj";
            this.lblDodaj.Size = new System.Drawing.Size(167, 26);
            this.lblDodaj.TabIndex = 25;
            this.lblDodaj.Text = "Dodaj projekciju";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(202, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "***BIOSKOP***";
            // 
            // cbSat
            // 
            this.cbSat.FormattingEnabled = true;
            this.cbSat.Location = new System.Drawing.Point(33, 3);
            this.cbSat.Name = "cbSat";
            this.cbSat.Size = new System.Drawing.Size(45, 21);
            this.cbSat.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "h";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(158, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "m";
            // 
            // cbMinut
            // 
            this.cbMinut.FormattingEnabled = true;
            this.cbMinut.Location = new System.Drawing.Point(107, 3);
            this.cbMinut.Name = "cbMinut";
            this.cbMinut.Size = new System.Drawing.Size(45, 21);
            this.cbMinut.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbMinut);
            this.panel1.Controls.Add(this.cbSat);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(236, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 28);
            this.panel1.TabIndex = 31;
            // 
            // ProjekcijaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 569);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDodaj);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbFilmovi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbSale);
            this.Controls.Add(this.dtDatum);
            this.Controls.Add(this.btnDodajProjekciju);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProjekcijaForma";
            this.Text = "ProjekcijaForma";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajProjekciju;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDatum;
        private System.Windows.Forms.ComboBox cbSale;
        private System.Windows.Forms.ComboBox cbFilmovi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDodaj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbMinut;
        private System.Windows.Forms.Panel panel1;
    }
}