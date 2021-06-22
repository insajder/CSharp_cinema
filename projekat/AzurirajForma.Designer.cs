namespace projekat
{
    partial class AzurirajForma
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
            this.lblAzuriraj = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCenaUkupno = new System.Windows.Forms.TextBox();
            this.nudBrMesta = new System.Windows.Forms.NumericUpDown();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDodaj = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrMesta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAzuriraj
            // 
            this.lblAzuriraj.AutoSize = true;
            this.lblAzuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAzuriraj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblAzuriraj.Location = new System.Drawing.Point(26, 133);
            this.lblAzuriraj.Name = "lblAzuriraj";
            this.lblAzuriraj.Size = new System.Drawing.Size(41, 15);
            this.lblAzuriraj.TabIndex = 0;
            this.lblAzuriraj.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Broj mesta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ukupna cena:";
            // 
            // txtCenaUkupno
            // 
            this.txtCenaUkupno.Location = new System.Drawing.Point(50, 260);
            this.txtCenaUkupno.Name = "txtCenaUkupno";
            this.txtCenaUkupno.ReadOnly = true;
            this.txtCenaUkupno.Size = new System.Drawing.Size(204, 20);
            this.txtCenaUkupno.TabIndex = 3;
            // 
            // nudBrMesta
            // 
            this.nudBrMesta.Location = new System.Drawing.Point(50, 202);
            this.nudBrMesta.Name = "nudBrMesta";
            this.nudBrMesta.Size = new System.Drawing.Size(204, 20);
            this.nudBrMesta.TabIndex = 4;
            this.nudBrMesta.ValueChanged += new System.EventHandler(this.nudBrMesta_ValueChanged);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(50, 305);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(550, 40);
            this.btnAzuriraj.TabIndex = 5;
            this.btnAzuriraj.Text = "Azuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "RSD";
            // 
            // lblDodaj
            // 
            this.lblDodaj.AutoSize = true;
            this.lblDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDodaj.ForeColor = System.Drawing.Color.Blue;
            this.lblDodaj.Location = new System.Drawing.Point(88, 76);
            this.lblDodaj.Name = "lblDodaj";
            this.lblDodaj.Size = new System.Drawing.Size(126, 26);
            this.lblDodaj.TabIndex = 25;
            this.lblDodaj.Text = "Rezervacija";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(280, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "***BIOSKOP***";
            // 
            // AzurirajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 385);
            this.Controls.Add(this.lblDodaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.nudBrMesta);
            this.Controls.Add(this.txtCenaUkupno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAzuriraj);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "AzurirajForma";
            this.Text = "AzurirajForma";
            ((System.ComponentModel.ISupportInitialize)(this.nudBrMesta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAzuriraj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCenaUkupno;
        private System.Windows.Forms.NumericUpDown nudBrMesta;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDodaj;
        private System.Windows.Forms.Label label4;
    }
}