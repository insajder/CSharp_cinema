namespace projekat
{
    partial class SalaForma
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
            this.btnDodajSalu = new System.Windows.Forms.Button();
            this.txtSedista = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDodaj = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDodajSalu
            // 
            this.btnDodajSalu.Location = new System.Drawing.Point(150, 295);
            this.btnDodajSalu.Name = "btnDodajSalu";
            this.btnDodajSalu.Size = new System.Drawing.Size(292, 41);
            this.btnDodajSalu.TabIndex = 19;
            this.btnDodajSalu.Text = "Dodaj";
            this.btnDodajSalu.UseVisualStyleBackColor = true;
            this.btnDodajSalu.Click += new System.EventHandler(this.btnDodajSalu_Click);
            // 
            // txtSedista
            // 
            this.txtSedista.Location = new System.Drawing.Point(270, 205);
            this.txtSedista.Name = "txtSedista";
            this.txtSedista.Size = new System.Drawing.Size(172, 20);
            this.txtSedista.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Unesite ukupan broj sedista:";
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(270, 162);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(172, 20);
            this.txtBroj.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Unesite broj sale:";
            // 
            // lblDodaj
            // 
            this.lblDodaj.AutoSize = true;
            this.lblDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDodaj.ForeColor = System.Drawing.Color.Blue;
            this.lblDodaj.Location = new System.Drawing.Point(112, 73);
            this.lblDodaj.Name = "lblDodaj";
            this.lblDodaj.Size = new System.Drawing.Size(115, 26);
            this.lblDodaj.TabIndex = 21;
            this.lblDodaj.Text = "Dodaj salu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(213, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "***BIOSKOP***";
            // 
            // SalaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 460);
            this.Controls.Add(this.lblDodaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDodajSalu);
            this.Controls.Add(this.txtSedista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBroj);
            this.Controls.Add(this.label1);
            this.Name = "SalaForma";
            this.Text = "SalaForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajSalu;
        private System.Windows.Forms.TextBox txtSedista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDodaj;
        private System.Windows.Forms.Label label4;
    }
}