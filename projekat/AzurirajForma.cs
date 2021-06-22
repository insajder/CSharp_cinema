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
    public partial class AzurirajForma : Form
    {
        static List<RezervacijaProjekcija> lst_rel;

        List<Rezervacije> lst_rez;

        int id_rel;
        public AzurirajForma()
        {
            InitializeComponent();
        }
        public void selektovani(int id, int broj_mesta, double cena)
        {
            lst_rel = PomocneMetode.CitajXML<RezervacijaProjekcija>(Konstante.putanja_relacije);

            foreach(RezervacijaProjekcija rp in lst_rel)
            {
                if(id == rp.Id_rez_proj)
                {
                    id_rel = rp.Id_rez_proj;
                    lblAzuriraj.Text = rp.ToString();
                    break;
                }
            }

            nudBrMesta.Value = broj_mesta;
            txtCenaUkupno.Text = cena.ToString();
        }
        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            int id_rez = 0;

            lst_rel = PomocneMetode.CitajXML<RezervacijaProjekcija>(Konstante.putanja_relacije);

            foreach(RezervacijaProjekcija rp in lst_rel)
            {
                if(id_rel == rp.Id_rez_proj)
                {
                    id_rez = rp.Rezervacija.Id_rezervacije;
                    PomocneMetode.izmeniXMLunutar(Konstante.putanja_relacije, "RezervacijaProjekcija", "Id_rez_proj", rp.Id_rez_proj.ToString(), "Rezervacija", "Broj_mesta", nudBrMesta.Value.ToString());
                    PomocneMetode.izmeniXMLunutar(Konstante.putanja_relacije, "RezervacijaProjekcija", "Id_rez_proj", rp.Id_rez_proj.ToString(), "Rezervacija", "Ukupna_cena", txtCenaUkupno.Text);
                    break;
                }
            }

            lst_rez = PomocneMetode.CitajXML<Rezervacije>(Konstante.putanja_rezervacije);

            foreach(Rezervacije r in lst_rez)
            {
                if(r.Id_rezervacije == id_rez)
                {
                    PomocneMetode.izmeniXML(Konstante.putanja_rezervacije, "Rezervacije", "Id_rezervacije", r.Id_rezervacije.ToString(), "Broj_mesta", nudBrMesta.Value.ToString());
                    PomocneMetode.izmeniXML(Konstante.putanja_relacije, "Rezervacije", "Id_rezervacije", r.Id_rezervacije.ToString(), "Ukupna_cena", txtCenaUkupno.Text);
                    break;
                }
            }

            MessageBox.Show("Uspesna izmena");
            this.Close();
        }
        private void nudBrMesta_ValueChanged(object sender, EventArgs e)
        {
            double cenaZaRacunanje = 1;
            lst_rel = PomocneMetode.CitajXML<RezervacijaProjekcija>(Konstante.putanja_relacije);

            foreach(RezervacijaProjekcija rp in lst_rel)
            {
                if(id_rel == rp.Id_rez_proj)
                {
                    cenaZaRacunanje = rp.Projekcija.Cena_karte;
                }
            }

            int mesta = Convert.ToInt32(nudBrMesta.Value);
            double ukupno = mesta * cenaZaRacunanje;
            txtCenaUkupno.Text = ukupno.ToString();
        }
    }
}
