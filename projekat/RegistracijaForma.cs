using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace projekat
{
    public partial class RegistracijaForma : Form
    {
        static List<Kupac> lst_kupci = PomocneMetode.CitajXML<Kupac>(Konstante.putanja_kupci);

        //Form1 f = new Form1();
        public RegistracijaForma()
        {
            InitializeComponent();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            bool proveraIme = false;
            bool proveraPrezime = false;
            bool proveraEmail = false;
            bool proveraLozinka = false;
            bool proveraTel = false;
            bool proveraDatum = false;
            bool proveraPol = false;

            string ime = "";
            if (txtIme.Text.Trim().Length != 0)
            {
                lblIme.Visible = false;
                ime = txtIme.Text;
                proveraIme = true;
            }
            else
            {
                lblIme.Visible = true;
            }
            string prezime = "";
            if (txtPrezime.Text.Trim().Length != 0)
            {
                lblPrezime.Visible = false;
                prezime = txtPrezime.Text;
                proveraPrezime = true;
            }
            else
            {
                lblPrezime.Visible = true;
            }
            string email = "";
            if (txtEmail.Text.Trim().Length != 0)
            {
                lblEmail.Visible = false;
                bool proveraPostojecegNaloga = false;
                string pattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
                if (Regex.IsMatch(txtEmail.Text, pattern))
                {
                    foreach(Kupac k in lst_kupci)
                    {
                        if(txtEmail.Text == k.Email)
                        {
                            MessageBox.Show("Vec postoji korisnik sa ovim nalogom");
                            proveraPostojecegNaloga = true;
                        }
                    }
                    if(proveraPostojecegNaloga == false)
                    {
                        lblEmail.Visible = false;
                        email = txtEmail.Text;
                        proveraEmail = true;
                    }
                }
                else
                {
                    MessageBox.Show("Email nije validan");
                }
            }
            else
            {
                lblEmail.Visible = true;
            }
            string lozinka = "";
            if (txtLozinka.Text.Trim().Length != 0)
            {
                lblLozinka.Visible = false;
                if (txtLozinka.Text.Length < 6)
                {
                    lblLozinka.Text = "Lozinka mora imate najmanje 6 karaktera";
                    lblLozinka.Visible = true;
                }
                else
                {
                    if (txtPotvrdaLoz.Text.Trim().Length != 0)
                    {
                        if (txtLozinka.Text == txtPotvrdaLoz.Text)
                        {
                            lblLozinka2.Visible = false;
                            lozinka = txtLozinka.Text;
                            proveraLozinka = true;
                        }
                        else
                        {
                            lblLozinka2.Text = "Lozinke se ne poklapaju";
                            lblLozinka2.Visible = true;
                        }
                    }
                    else
                    {
                        lblLozinka2.Text = "Potvrdite lozinku";
                        lblLozinka2.Visible = true;
                    }
                }
                
            }
            else
            {
                lblLozinka.Visible = true;
            }
            string telefon = "";
            if (txtTelefon.Text.Trim().Length != 0)
            {
                lblTel.Visible = false;
                telefon = txtTelefon.Text;
                proveraTel = true;
            }
            else
            {
                lblTel.Visible = true;
            }
            DateTime dat_rodjenja = new DateTime();
            if (dtRodjen.Value.Date != DateTime.Now.Date)
            {
                bool proveraGodina = true;
                DateTime datum = DateTime.Now.AddYears(-12);
                if (datum <= dtRodjen.Value)
                {
                    lblRodjen.Visible = false;
                    MessageBox.Show("Nemate dovoljno godina za registraciju (12 min)");
                    proveraGodina = false;
                }
                if(proveraGodina == true)
                {
                    lblRodjen.Visible = false;
                    dat_rodjenja = dtRodjen.Value.Date;
                    proveraDatum = true;
                }
            }
            else
            {
                lblRodjen.Visible = true;
            }
            string pol = "";
            if (rbMuski.Checked)
            {
                lblPol.Visible = false;
                pol = rbMuski.Text;
                proveraPol = true;
            }
            else if (rbZenski.Checked)
            {
                lblPol.Visible = false;
                pol = rbZenski.Text;
                proveraPol = true;
            }
            else
            {
                lblPol.Visible = true;
            }

            if (proveraIme == true &&
                proveraPrezime == true &&
                proveraEmail == true &&
                proveraLozinka == true &&
                proveraTel == true &&
                proveraDatum == true &&
                proveraPol == true)
            {
                int id = PomocneMetode.generisiId();

                lst_kupci.Add(new Kupac(id, ime, prezime, dat_rodjenja, telefon, pol, email, lozinka));
                PomocneMetode.UpisiXML<Kupac>(lst_kupci, Konstante.putanja_kupci);

                MessageBox.Show("Uspesno ste se registrovali");
                //f.Show();
                this.Close();
            }
        }
    }
}
