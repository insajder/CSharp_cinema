using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekat
{
    public partial class AdministratorForma : Form
    {
        static List<Administrator> admini;
        int id_administratora;
        public AdministratorForma()
        {
            InitializeComponent();
            admini = PomocneMetode.CitajXML<Administrator>(Konstante.putanja_admin);
        }

        private void btnDodajAdmina_Click(object sender, EventArgs e)
        {
            int id = PomocneMetode.generisiId();
            string email = "";
            string lozinka = "";
            if (txtEmail.Text.Trim().Length != 0 &&
                txtLoz.Text.Trim().Length != 0 &&
                txtLoz2.Text.Trim().Length != 0)
            {
                string pattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
                if (Regex.IsMatch(txtEmail.Text, pattern))
                {
                    email = txtEmail.Text;
                }
                else
                {
                    MessageBox.Show("Email nije validan");
                    return;
                }

                if(txtLoz.Text.Length >= 6)
                {
                    if (txtLoz.Text == txtLoz2.Text)
                    {
                        lozinka = txtLoz.Text;
                    }
                    else
                    {
                        MessageBox.Show("Lozinke se ne poklapaju");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Lozinka mora imati najmanje 6 karaktera");
                    return;
                }
                
                bool adminPostoji = false;
                foreach (Administrator a in admini)
                {
                    if (a.Email == txtEmail.Text)
                    {
                        adminPostoji = true;
                    }
                }
                if (adminPostoji == true)
                {
                    MessageBox.Show("Vec postoji ovaj nalog");
                    return;
                }
                else
                {
                    if (btnDodajAdmina.Text == "Dodaj")
                    {
                        admini.Add(new Administrator(id, email, lozinka));
                        PomocneMetode.UpisiXML<Administrator>(admini, Konstante.putanja_admin);
                        MessageBox.Show("Uspesno ste dodali admina");
                    }
                    else if (btnDodajAdmina.Text == "Izmeni")
                    {
                        PomocneMetode.izmeniXML(Konstante.putanja_admin, "Administrator", "id_administratora", id_administratora.ToString(), "Email", txtEmail.Text);
                        PomocneMetode.izmeniXML(Konstante.putanja_admin, "Administrator", "id_administratora", id_administratora.ToString(), "Zanr", txtLoz.Text);
                        MessageBox.Show("Uspesna izmena");
                    }

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Popunite sva polja");
            }
        }

        public void PodaciAdmin(int id, string email, string lozinka)
        {
            id_administratora = id;

            txtEmail.Text = email;

            txtLoz.Text = lozinka;

            btnDodajAdmina.Text = "Izmeni";
            lblDodaj.Text = "Izmeni admina";
        }
    }
}
