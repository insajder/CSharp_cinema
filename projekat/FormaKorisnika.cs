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
    public partial class FormaKorisnika : Form
    {
        static List<Rezervacije> rezervacije;

        static List<Projekcija> projekcije;

        static List<RezervacijaProjekcija> relacije;

        int idRelacije;
        int IdKUPCA;
        RezervacijaForma fr;
        AzurirajForma af;

        public delegate void PozivSelektovani(int id);
        public PozivSelektovani dogadjajSelektovani;

        public delegate void PozivSelektovaniIzmena(int id, int broj, double cena);
        public PozivSelektovaniIzmena dogadjajSelektovaniIzmena;

        public FormaKorisnika()
        {
            InitializeComponent();
            rezervacije = PomocneMetode.CitajXML<Rezervacije>(Konstante.putanja_rezervacije);
            projekcije = PomocneMetode.CitajXML<Projekcija>(Konstante.putanja_projekcije);
            relacije = PomocneMetode.CitajXML<RezervacijaProjekcija>(Konstante.putanja_relacije);
        }

        private void btnDodajRez_Click(object sender, EventArgs e)
        {
            relacije = PomocneMetode.CitajXML<RezervacijaProjekcija>(Konstante.putanja_relacije);
            fr = new RezervacijaForma();

            this.dogadjajSelektovani += new PozivSelektovani(fr.dodajRezervaciju);
            dogadjajSelektovani(IdKUPCA);
            fr.Show();
        }
        public void id_kupca_rezervacija(int id)
        {
            IdKUPCA = id;
        }

        private void btnObrisiRez_Click(object sender, EventArgs e)
        {
            relacije = PomocneMetode.CitajXML<RezervacijaProjekcija>(Konstante.putanja_relacije);
            rezervacije = PomocneMetode.CitajXML<Rezervacije>(Konstante.putanja_rezervacije);
            projekcije = PomocneMetode.CitajXML<Projekcija>(Konstante.putanja_projekcije);

            if (lbRezervacije.SelectedItem != null)
            {
                RezervacijaProjekcija relZaBrisanje = relacije.Find(rel => rel.ToString() == lbRezervacije.SelectedItem.ToString());
                Rezervacije rezZaBrisanje = rezervacije.Find(rez => rez.Id_rezervacije == relZaBrisanje.Rezervacija.Id_rezervacije);
                if (relZaBrisanje != null && rezZaBrisanje != null)
                {
                    int brMesta = rezZaBrisanje.Broj_mesta;

                    foreach (Projekcija p in projekcije)
                    {
                        if (relZaBrisanje.Projekcija.Id_projekcije == p.Id_projekcije)
                        {
                            p.Sala.Ukupno_sedista += brMesta;
                            break;
                        }
                    }
                    relacije = PomocneMetode.CitajXML<RezervacijaProjekcija>(Konstante.putanja_relacije);
                    foreach (RezervacijaProjekcija p in relacije)
                    {
                        if (relZaBrisanje.Projekcija.Id_projekcije == p.Projekcija.Id_projekcije)
                        {
                            p.Projekcija.Sala.Ukupno_sedista += brMesta;
                            break;
                        }
                    }
                    PomocneMetode.UpisiXML<RezervacijaProjekcija>(relacije, Konstante.putanja_relacije);
                    PomocneMetode.UpisiXML<Projekcija>(projekcije, Konstante.putanja_projekcije);
                    PomocneMetode.obrisiXML(rezZaBrisanje.Id_rezervacije.ToString(), Konstante.putanja_rezervacije, "Rezervacije", "Id_rezervacije");
                    PomocneMetode.obrisiXML(relZaBrisanje.Id_rez_proj.ToString(), Konstante.putanja_relacije, "RezervacijaProjekcija", "Id_rez_proj");
                    MessageBox.Show("Uspesno brisanje");
                }
            }
            else
            {
                MessageBox.Show("Izaberite rezervaciju za brisanje");
            }
            relacije = PomocneMetode.CitajXML<RezervacijaProjekcija>(Konstante.putanja_relacije);
            lbRezervacije.Items.Clear();
            foreach (RezervacijaProjekcija r in relacije)
            {
                if (r.Projekcija.Datum_projekcije > DateTime.Now && r.Rezervacija.Id_kupca_rez == IdKUPCA)
                {
                    lbRezervacije.Items.Add(r.ToString());
                }
            }
        }

        private void btnAzurirajRez_Click(object sender, EventArgs e)
        {
            relacije = PomocneMetode.CitajXML<RezervacijaProjekcija>(Konstante.putanja_relacije);
            if (lbRezervacije.SelectedItem != null)
            {
                foreach(RezervacijaProjekcija rp in relacije)
                {
                    if(lbRezervacije.SelectedItem.ToString() == rp.ToString())
                    {
                        af = new AzurirajForma();

                        idRelacije = rp.Id_rez_proj;
                        this.dogadjajSelektovaniIzmena += new PozivSelektovaniIzmena(af.selektovani);
                        dogadjajSelektovaniIzmena(rp.Id_rez_proj, rp.Rezervacija.Broj_mesta, rp.Rezervacija.Ukupna_cena);
                        
                        af.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Izaberite rezervaciju za azuriranje");
            }
        }
        public void posaljiCenuIBrojMesta(int br_mes, double cena)
        {
            if(lbRezervacije.SelectedItem != null)
            {
                foreach(RezervacijaProjekcija rp in relacije)
                {
                    if(lbRezervacije.SelectedItem.ToString() == rp.ToString())
                    {
                        br_mes = rp.Rezervacija.Broj_mesta;
                        cena = rp.Projekcija.Cena_karte * br_mes;
                    }
                }
            }
        }

        private void btnOsvezi_Click(object sender, EventArgs e)
        {
            lbRezervacije.Items.Clear();
            relacije = PomocneMetode.CitajXML<RezervacijaProjekcija>(Konstante.putanja_relacije);
            foreach(RezervacijaProjekcija rp in relacije)
            {
                if (rp.Projekcija.Datum_projekcije > DateTime.Now && rp.Rezervacija.Id_kupca_rez == IdKUPCA)
                {
                    lbRezervacije.Items.Add(rp.ToString());
                }
            }
        }

        private void FormaKorisnika_Load(object sender, EventArgs e)
        {
            relacije = PomocneMetode.CitajXML<RezervacijaProjekcija>(Konstante.putanja_relacije);
            lbRezervacije.Items.Clear();
            foreach (RezervacijaProjekcija r in relacije)
            {
                if (r.Projekcija.Datum_projekcije > DateTime.Now && r.Rezervacija.Id_kupca_rez == IdKUPCA)
                {
                    lbRezervacije.Items.Add(r.ToString());
                }
            }
        }
    }
}
