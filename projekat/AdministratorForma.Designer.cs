namespace projekat
{
    partial class AdministratorForma
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
            this.btnDodajAdmina = new System.Windows.Forms.Button();
            this.txtLoz2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoz = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDodaj = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDodajAdmina
            // 
            this.btnDodajAdmina.Location = new System.Drawing.Point(106, 347);
            this.btnDodajAdmina.Name = "btnDodajAdmina";
            this.btnDodajAdmina.Size = new System.Drawing.Size(292, 41);
            this.btnDodajAdmina.TabIndex = 19;
            this.btnDodajAdmina.Text = "Dodaj";
            this.btnDodajAdmina.UseVisualStyleBackColor = true;
            this.btnDodajAdmina.Click += new System.EventHandler(this.btnDodajAdmina_Click);
            // 
            // txtLoz2
            // 
            this.txtLoz2.Location = new System.Drawing.Point(226, 281);
            this.txtLoz2.Name = "txtLoz2";
            this.txtLoz2.PasswordChar = '●';
            this.txtLoz2.Size = new System.Drawing.Size(172, 20);
            this.txtLoz2.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Potvrdite lozinku:";
            // 
            // txtLoz
            // 
            this.txtLoz.Location = new System.Drawing.Point(226, 232);
            this.txtLoz.Name = "txtLoz";
            this.txtLoz.PasswordChar = '●';
            this.txtLoz.Size = new System.Drawing.Size(172, 20);
            this.txtLoz.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Unesite lozinku";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(226, 182);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(172, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Unesite email:";
            // 
            // lblDodaj
            // 
            this.lblDodaj.AutoSize = true;
            this.lblDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDodaj.ForeColor = System.Drawing.Color.Blue;
            this.lblDodaj.Location = new System.Drawing.Point(87, 95);
            this.lblDodaj.Name = "lblDodaj";
            this.lblDodaj.Size = new System.Drawing.Size(213, 26);
            this.lblDodaj.TabIndex = 23;
            this.lblDodaj.Text = "Dodaj administratora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(184, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "***BIOSKOP***";
            // 
            // AdministratorForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 489);
            this.Controls.Add(this.lblDodaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDodajAdmina);
            this.Controls.Add(this.txtLoz2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLoz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Name = "AdministratorForma";
            this.Text = "AdministratorForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajAdmina;
        private System.Windows.Forms.TextBox txtLoz2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLoz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDodaj;
        private System.Windows.Forms.Label label5;
    }
}