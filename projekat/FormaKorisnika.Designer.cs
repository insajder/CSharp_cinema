namespace projekat
{
    partial class FormaKorisnika
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
            this.lbRezervacije = new System.Windows.Forms.ListBox();
            this.btnObrisiRez = new System.Windows.Forms.Button();
            this.btnAzurirajRez = new System.Windows.Forms.Button();
            this.btnDodajRez = new System.Windows.Forms.Button();
            this.btnOsvezi = new System.Windows.Forms.Button();
            this.lblDodaj = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbRezervacije
            // 
            this.lbRezervacije.FormattingEnabled = true;
            this.lbRezervacije.Location = new System.Drawing.Point(46, 143);
            this.lbRezervacije.Name = "lbRezervacije";
            this.lbRezervacije.Size = new System.Drawing.Size(816, 199);
            this.lbRezervacije.TabIndex = 1;
            // 
            // btnObrisiRez
            // 
            this.btnObrisiRez.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiRez.Location = new System.Drawing.Point(46, 385);
            this.btnObrisiRez.Name = "btnObrisiRez";
            this.btnObrisiRez.Size = new System.Drawing.Size(247, 36);
            this.btnObrisiRez.TabIndex = 2;
            this.btnObrisiRez.Text = "Obrisi";
            this.btnObrisiRez.UseVisualStyleBackColor = true;
            this.btnObrisiRez.Click += new System.EventHandler(this.btnObrisiRez_Click);
            // 
            // btnAzurirajRez
            // 
            this.btnAzurirajRez.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajRez.Location = new System.Drawing.Point(368, 385);
            this.btnAzurirajRez.Name = "btnAzurirajRez";
            this.btnAzurirajRez.Size = new System.Drawing.Size(247, 36);
            this.btnAzurirajRez.TabIndex = 3;
            this.btnAzurirajRez.Text = "Azuriraj";
            this.btnAzurirajRez.UseVisualStyleBackColor = true;
            this.btnAzurirajRez.Click += new System.EventHandler(this.btnAzurirajRez_Click);
            // 
            // btnDodajRez
            // 
            this.btnDodajRez.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajRez.Location = new System.Drawing.Point(46, 442);
            this.btnDodajRez.Name = "btnDodajRez";
            this.btnDodajRez.Size = new System.Drawing.Size(569, 36);
            this.btnDodajRez.TabIndex = 4;
            this.btnDodajRez.Text = "Dodaj novu rezervaciju";
            this.btnDodajRez.UseVisualStyleBackColor = true;
            this.btnDodajRez.Click += new System.EventHandler(this.btnDodajRez_Click);
            // 
            // btnOsvezi
            // 
            this.btnOsvezi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOsvezi.Location = new System.Drawing.Point(668, 385);
            this.btnOsvezi.Name = "btnOsvezi";
            this.btnOsvezi.Size = new System.Drawing.Size(194, 93);
            this.btnOsvezi.TabIndex = 5;
            this.btnOsvezi.Text = "Osvezi";
            this.btnOsvezi.UseVisualStyleBackColor = true;
            this.btnOsvezi.Click += new System.EventHandler(this.btnOsvezi_Click);
            // 
            // lblDodaj
            // 
            this.lblDodaj.AutoSize = true;
            this.lblDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDodaj.ForeColor = System.Drawing.Color.Blue;
            this.lblDodaj.Location = new System.Drawing.Point(41, 87);
            this.lblDodaj.Name = "lblDodaj";
            this.lblDodaj.Size = new System.Drawing.Size(173, 26);
            this.lblDodaj.TabIndex = 23;
            this.lblDodaj.Text = "Vase rezervacije";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(347, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "***BIOSKOP***";
            // 
            // FormaKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 525);
            this.Controls.Add(this.lblDodaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOsvezi);
            this.Controls.Add(this.btnDodajRez);
            this.Controls.Add(this.btnAzurirajRez);
            this.Controls.Add(this.btnObrisiRez);
            this.Controls.Add(this.lbRezervacije);
            this.Name = "FormaKorisnika";
            this.Text = "FormaKorisnika";
            this.Load += new System.EventHandler(this.FormaKorisnika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbRezervacije;
        private System.Windows.Forms.Button btnObrisiRez;
        private System.Windows.Forms.Button btnAzurirajRez;
        private System.Windows.Forms.Button btnDodajRez;
        private System.Windows.Forms.Button btnOsvezi;
        private System.Windows.Forms.Label lblDodaj;
        private System.Windows.Forms.Label label4;
    }
}