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
    public partial class KupciForma : Form
    {
        List<Kupac> kupci;

        int id_kupca;
        public KupciForma()
        {
            InitializeComponent();
            kupci = PomocneMetode.CitajXML<Kupac>(Konstante.putanja_kupci);
        }
        public void PodaciKupca(int id, string ime, string prezime, string email, string telefon, DateTime rodjen, string pol)
        {
            id_kupca = id;
            txtIme.Text = ime;
            txtPrezime.Text = prezime;
            txtTelefon.Text = telefon;
            txtEmail.Text = email;
            dtRodjen.Value = rodjen;
            if(pol == "Muski") rbMuski.Checked = true;
            if (pol == "Zenski") rbZenski.Checked = true;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (txtIme.Text.Trim().Length != 0 &&
                txtPrezime.Text.Trim().Length != 0 &&
                txtTelefon.Text.Trim().Length != 0 &&
                (rbMuski.Checked || rbZenski.Checked))
            {
                bool proveraGodina = true;
                DateTime datum = DateTime.Now.AddYears(-12);
                if (datum <= dtRodjen.Value)
                {
                    MessageBox.Show("Nemate dovoljno godina za registraciju (12 min)");
                    proveraGodina = false;
                }
                if (proveraGodina == true)
                {
                    string pol = null;
                    if (rbMuski.Checked) pol = rbMuski.Text;
                    if (rbZenski.Checked) pol = rbZenski.Text;

                    PomocneMetode.izmeniXML(Konstante.putanja_kupci, "Kupac", "Id_kupca", id_kupca.ToString(), "Ime", txtIme.Text);
                    PomocneMetode.izmeniXML(Konstante.putanja_kupci, "Kupac", "Id_kupca", id_kupca.ToString(), "Prezime", txtPrezime.Text);
                    PomocneMetode.izmeniXML(Konstante.putanja_kupci, "Kupac", "Id_kupca", id_kupca.ToString(), "Telefon", txtTelefon.Text);
                    PomocneMetode.izmeniXML(Konstante.putanja_kupci, "Kupac", "Id_kupca", id_kupca.ToString(), "Datum_rodjenja", dtRodjen.Value.ToString("yyyy-MM-ddTHH\\:mm\\:ss"));
                    PomocneMetode.izmeniXML(Konstante.putanja_kupci, "Kupac", "Id_kupca", id_kupca.ToString(), "Pol", pol);

                    MessageBox.Show("Uspesna izmena");

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Popunite sva polja");
            }
        }
    }
}
