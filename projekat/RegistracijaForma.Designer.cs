namespace projekat
{
    partial class RegistracijaForma
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPotvrdaLoz = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtRodjen = new System.Windows.Forms.DateTimePicker();
            this.rbMuski = new System.Windows.Forms.RadioButton();
            this.rbZenski = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblLozinka2 = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblRodjen = new System.Windows.Forms.Label();
            this.lblPol = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // txtIme
            // 
            this.txtIme.BackColor = System.Drawing.SystemColors.Window;
            this.txtIme.Location = new System.Drawing.Point(95, 141);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(312, 20);
            this.txtIme.TabIndex = 1;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(95, 190);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(312, 20);
            this.txtPrezime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(95, 241);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(312, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(95, 291);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '●';
            this.txtLozinka.Size = new System.Drawing.Size(312, 20);
            this.txtLozinka.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lozinka:";
            // 
            // txtPotvrdaLoz
            // 
            this.txtPotvrdaLoz.Location = new System.Drawing.Point(95, 344);
            this.txtPotvrdaLoz.Name = "txtPotvrdaLoz";
            this.txtPotvrdaLoz.PasswordChar = '●';
            this.txtPotvrdaLoz.Size = new System.Drawing.Size(312, 20);
            this.txtPotvrdaLoz.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Potvrdite lozinku:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Datum rodjenja:";
            // 
            // dtRodjen
            // 
            this.dtRodjen.Location = new System.Drawing.Point(95, 455);
            this.dtRodjen.Name = "dtRodjen";
            this.dtRodjen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtRodjen.Size = new System.Drawing.Size(312, 20);
            this.dtRodjen.TabIndex = 11;
            // 
            // rbMuski
            // 
            this.rbMuski.AutoSize = true;
            this.rbMuski.Location = new System.Drawing.Point(68, 29);
            this.rbMuski.Name = "rbMuski";
            this.rbMuski.Size = new System.Drawing.Size(53, 17);
            this.rbMuski.TabIndex = 13;
            this.rbMuski.TabStop = true;
            this.rbMuski.Text = "Muski";
            this.rbMuski.UseVisualStyleBackColor = true;
            // 
            // rbZenski
            // 
            this.rbZenski.AutoSize = true;
            this.rbZenski.Location = new System.Drawing.Point(189, 29);
            this.rbZenski.Name = "rbZenski";
            this.rbZenski.Size = new System.Drawing.Size(57, 17);
            this.rbZenski.TabIndex = 14;
            this.rbZenski.TabStop = true;
            this.rbZenski.Text = "Zenski";
            this.rbZenski.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Broj telefona:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(95, 397);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(312, 20);
            this.txtTelefon.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMuski);
            this.groupBox1.Controls.Add(this.rbZenski);
            this.groupBox1.Location = new System.Drawing.Point(95, 492);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 66);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pol:";
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistracija.Location = new System.Drawing.Point(95, 586);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(312, 52);
            this.btnRegistracija.TabIndex = 18;
            this.btnRegistracija.Text = "Registruj se";
            this.btnRegistracija.UseVisualStyleBackColor = true;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.ForeColor = System.Drawing.Color.Red;
            this.lblIme.Location = new System.Drawing.Point(428, 144);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(62, 13);
            this.lblIme.TabIndex = 19;
            this.lblIme.Text = "Unesite ime";
            this.lblIme.Visible = false;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.ForeColor = System.Drawing.Color.Red;
            this.lblPrezime.Location = new System.Drawing.Point(428, 190);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(82, 13);
            this.lblPrezime.TabIndex = 20;
            this.lblPrezime.Text = "Unesite prezime";
            this.lblPrezime.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.Red;
            this.lblEmail.Location = new System.Drawing.Point(427, 241);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(70, 13);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Unesite email";
            this.lblEmail.Visible = false;
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.ForeColor = System.Drawing.Color.Red;
            this.lblLozinka.Location = new System.Drawing.Point(428, 291);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(79, 13);
            this.lblLozinka.TabIndex = 22;
            this.lblLozinka.Text = "Unesite lozinku";
            this.lblLozinka.Visible = false;
            // 
            // lblLozinka2
            // 
            this.lblLozinka2.AutoSize = true;
            this.lblLozinka2.ForeColor = System.Drawing.Color.Red;
            this.lblLozinka2.Location = new System.Drawing.Point(428, 341);
            this.lblLozinka2.Name = "lblLozinka2";
            this.lblLozinka2.Size = new System.Drawing.Size(85, 13);
            this.lblLozinka2.TabIndex = 23;
            this.lblLozinka2.Text = "Potvrdite lozinku";
            this.lblLozinka2.Visible = false;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.ForeColor = System.Drawing.Color.Red;
            this.lblTel.Location = new System.Drawing.Point(428, 397);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(104, 13);
            this.lblTel.TabIndex = 24;
            this.lblTel.Text = "Unesite broj telefona";
            this.lblTel.Visible = false;
            // 
            // lblRodjen
            // 
            this.lblRodjen.AutoSize = true;
            this.lblRodjen.ForeColor = System.Drawing.Color.Red;
            this.lblRodjen.Location = new System.Drawing.Point(428, 452);
            this.lblRodjen.Name = "lblRodjen";
            this.lblRodjen.Size = new System.Drawing.Size(115, 13);
            this.lblRodjen.TabIndex = 25;
            this.lblRodjen.Text = "Unesite datum rodjenja";
            this.lblRodjen.Visible = false;
            // 
            // lblPol
            // 
            this.lblPol.AutoSize = true;
            this.lblPol.ForeColor = System.Drawing.Color.Red;
            this.lblPol.Location = new System.Drawing.Point(428, 508);
            this.lblPol.Name = "lblPol";
            this.lblPol.Size = new System.Drawing.Size(64, 13);
            this.lblPol.TabIndex = 26;
            this.lblPol.Text = "Izaberite pol";
            this.lblPol.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(227, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "***BIOSKOP***";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(90, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 26);
            this.label9.TabIndex = 28;
            this.label9.Text = "Registracija";
            // 
            // RegistracijaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 706);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPol);
            this.Controls.Add(this.lblRodjen);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblLozinka2);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtRodjen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPotvrdaLoz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Name = "RegistracijaForma";
            this.Text = "RegistracijaForma";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPotvrdaLoz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtRodjen;
        private System.Windows.Forms.RadioButton rbMuski;
        private System.Windows.Forms.RadioButton rbZenski;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblLozinka2;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblRodjen;
        private System.Windows.Forms.Label lblPol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
    }
}