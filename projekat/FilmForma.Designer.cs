namespace projekat
{
    partial class FilmForma
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtZanr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDuzina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGranica = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDodajFilm = new System.Windows.Forms.Button();
            this.lblDodaj = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(226, 138);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(172, 20);
            this.txtNaziv.TabIndex = 1;
            // 
            // txtZanr
            // 
            this.txtZanr.Location = new System.Drawing.Point(226, 188);
            this.txtZanr.Name = "txtZanr";
            this.txtZanr.Size = new System.Drawing.Size(172, 20);
            this.txtZanr.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unesite zanr:";
            // 
            // txtDuzina
            // 
            this.txtDuzina.Location = new System.Drawing.Point(226, 237);
            this.txtDuzina.Name = "txtDuzina";
            this.txtDuzina.Size = new System.Drawing.Size(172, 20);
            this.txtDuzina.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unesite duzinu trajanja:";
            // 
            // txtGranica
            // 
            this.txtGranica.Location = new System.Drawing.Point(226, 295);
            this.txtGranica.Name = "txtGranica";
            this.txtGranica.Size = new System.Drawing.Size(172, 20);
            this.txtGranica.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Unesite granicu godina:";
            // 
            // btnDodajFilm
            // 
            this.btnDodajFilm.Location = new System.Drawing.Point(106, 380);
            this.btnDodajFilm.Name = "btnDodajFilm";
            this.btnDodajFilm.Size = new System.Drawing.Size(292, 41);
            this.btnDodajFilm.TabIndex = 9;
            this.btnDodajFilm.Text = "Dodaj";
            this.btnDodajFilm.UseVisualStyleBackColor = true;
            this.btnDodajFilm.Click += new System.EventHandler(this.btnDodajFilm_Click);
            // 
            // lblDodaj
            // 
            this.lblDodaj.AutoSize = true;
            this.lblDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDodaj.ForeColor = System.Drawing.Color.Blue;
            this.lblDodaj.Location = new System.Drawing.Point(101, 78);
            this.lblDodaj.Name = "lblDodaj";
            this.lblDodaj.Size = new System.Drawing.Size(110, 26);
            this.lblDodaj.TabIndex = 23;
            this.lblDodaj.Text = "Dodaj film";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(180, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "***BIOSKOP***";
            // 
            // FilmForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 506);
            this.Controls.Add(this.lblDodaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDodajFilm);
            this.Controls.Add(this.txtGranica);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDuzina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtZanr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Name = "FilmForma";
            this.Text = "FilmForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtZanr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDuzina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGranica;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDodajFilm;
        private System.Windows.Forms.Label lblDodaj;
        private System.Windows.Forms.Label label6;
    }
}