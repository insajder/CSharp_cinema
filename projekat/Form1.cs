using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekat
{
    public partial class Form1 : Form
    {
        public delegate void PozivIdKupca(int id);
        public PozivIdKupca dogadjajIdKupca;

        FormaKorisnika fk;
        RegistracijaForma regf;
        AdminForma af;

        static List<Kupac> lst_kupci;
        static List<Administrator> lst_admina;
        static List<Korisnik> lst_korisnika;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            lst_kupci = PomocneMetode.CitajXML<Kupac>(Konstante.putanja_kupci);

            lst_admina = PomocneMetode.CitajXML<Administrator>(Konstante.putanja_admin);

            lst_korisnika = new List<Korisnik>();
            lst_korisnika.AddRange(lst_kupci);
            lst_korisnika.AddRange(lst_admina);

            if (txtEmail.Text.Trim().Length != 0 && txtLozinka.Text.Trim().Length  != 0) { 

                bool proveraKorisnika = false;

                foreach (Korisnik k in lst_korisnika)
                {
                    if (k is Kupac kupac)
                    {
                        if (kupac.prijaviSe(txtEmail.Text, txtLozinka.Text))
                        {
                            fk = new FormaKorisnika();
                            this.dogadjajIdKupca += new PozivIdKupca(fk.id_kupca_rezervacija);
                            dogadjajIdKupca(kupac.Id_kupca);
                        
                            fk.Show();
                            proveraKorisnika = true;
                            break;
                        }
                        else
                        {
                            proveraKorisnika = false;
                        }
                    }
                    if (k is Administrator admin)
                    {
                        if (admin.prijaviSe(txtEmail.Text, txtLozinka.Text))
                        {
                            af = new AdminForma();
                            af.Show();
                            proveraKorisnika = true;
                            break;
                        }
                        else
                        {
                            proveraKorisnika = false;
                        }
                    }
                }
                if(proveraKorisnika == false)
                {
                    MessageBox.Show("Podaci koje ste uneli nisu validni");
                }
            }
            else
            {
                MessageBox.Show("Popunite sva polja");
            }
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            regf = new RegistracijaForma();
            regf.Show();
            //this.Hide();
        }
    }
}
