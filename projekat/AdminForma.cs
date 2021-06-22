using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace projekat
{

    public partial class AdminForma : Form
    {
        FilmForma f;
        public delegate void PozivFilm(int id, string naziv, string zanr, int duzina, int godine);
        public event PozivFilm dogadjajFilm;

        SalaForma sf;
        public delegate void PozivSala(int id, int broj, int sedista);
        public event PozivSala dogadjajSala;

        ProjekcijaForma pf;
        public delegate void PozivProjekcija(int id, Film film1, Sala sala1, double cena1, DateTime datum1, string vreme1);
        public event PozivProjekcija dogadjajProjekcija;

        AdministratorForma af;
        public delegate void PozivAdmin(int id,string email, string lozinka);
        public event PozivAdmin dogadjajAdmin;

        KupciForma kf;
        public delegate void PozivKupac(int id, string ime, string prezime, string email, string telefon, DateTime rodjen, string pol);
        public event PozivKupac dogadjajKupac;

        List<Kupac> kupci;
        List<Film> filmovi;
        List<Sala> sale;
        List<Rezervacije> rezervacije;
        List<Projekcija> projekcije;
        List<Administrator> admini;
        List<RezervacijaProjekcija> relacije;
        public AdminForma()
        {
            InitializeComponent();
        }

        private void AdminForma_Load(object sender, EventArgs e)
        {
            kupci = PomocneMetode.CitajXML<Kupac>(Konstante.putanja_kupci);

            foreach (Kupac k1 in kupci)
            {
                cbKupci.Items.Add(k1.ToString());
            }
            cbKategorija.Items.Add("Filmovi");
            cbKategorija.Items.Add("Sale");
            cbKategorija.Items.Add("Projekcije");
            cbKategorija.Items.Add("Administratori");
        }
        private void btnUpisi_Click(object sender, EventArgs e)
        {
            if (cbKategorija.SelectedItem != null) 
            { 
                if (cbKategorija.SelectedItem.ToString().Equals("Filmovi"))
                {
                    f = new FilmForma();
                    f.Show();
                }
                if (cbKategorija.SelectedItem.ToString().Equals("Sale"))
                {
                    sf = new SalaForma();
                    sf.Show();
                }
                if (cbKategorija.SelectedItem.ToString().Equals("Projekcije"))
                {
                    pf = new ProjekcijaForma();
                    pf.Show();
                }
                if (cbKategorija.SelectedItem.ToString().Equals("Administratori"))
                {
                    af = new AdministratorForma();
                    af.Show();
                }
            }
            else
            {
                MessageBox.Show("Izaberite kategoriju");
            }
        }

        private void cbKategorija_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbKategorija.SelectedItem.ToString().Equals("Filmovi"))
            {
                filmovi = PomocneMetode.CitajXML<Film>(Konstante.putanja_film);
                lbKategorija.Items.Clear();

                foreach (Film f1 in filmovi)
                {
                    lbKategorija.Items.Add(f1.ToString());
                }
            }
            if (cbKategorija.SelectedItem.ToString().Equals("Sale"))
            {
                sale = PomocneMetode.CitajXML<Sala>(Konstante.putanja_sala);
                lbKategorija.Items.Clear();

                foreach (Sala s1 in sale)
                {
                    lbKategorija.Items.Add(s1.ToString2());
                }
            }
            if (cbKategorija.SelectedItem.ToString().Equals("Projekcije"))
            {
                projekcije = PomocneMetode.CitajXML<Projekcija>(Konstante.putanja_projekcije);
                lbKategorija.Items.Clear();

                foreach (Projekcija p1 in projekcije)
                {
                    lbKategorija.Items.Add(p1.ToString());
                }
            }
            if (cbKategorija.SelectedItem.ToString().Equals("Administratori"))
            {
                admini = PomocneMetode.CitajXML<Administrator>(Konstante.putanja_admin);
                lbKategorija.Items.Clear();

                foreach (Administrator a1 in admini)
                {
                    lbKategorija.Items.Add(a1.ToString());
                }
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (lbKategorija.SelectedItem != null)
            {
                filmovi = PomocneMetode.CitajXML<Film>(Konstante.putanja_film);

                foreach (Film f1 in filmovi)
                {
                    if (lbKategorija.SelectedItem.ToString().Equals(f1.ToString()))
                    {
                        f = new FilmForma();
                        this.dogadjajFilm += new PozivFilm(f.PodaciFilma);
                        dogadjajFilm(f1.Id_filma, f1.Naziv, f1.Zanr, f1.Duzina_trajanja, f1.Granica_god);
                        f.Show();
                    }
                }

                sale = PomocneMetode.CitajXML<Sala>(Konstante.putanja_sala);

                foreach (Sala s1 in sale)
                {
                    if (lbKategorija.SelectedItem.ToString().Equals(s1.ToString2()))
                    {
                        sf = new SalaForma();
                        this.dogadjajSala += new PozivSala(sf.PodaciSale);
                        dogadjajSala(s1.Id_sale, s1.Broj_sale, s1.Ukupno_sedista);
                        sf.Show();
                    }
                }

                projekcije = PomocneMetode.CitajXML<Projekcija>(Konstante.putanja_projekcije);

                foreach (Projekcija p1 in projekcije)
                {
                    if (lbKategorija.SelectedItem.ToString().Equals(p1.ToString()))
                    {
                        pf = new ProjekcijaForma();
                        this.dogadjajProjekcija += new PozivProjekcija(pf.PodaciProjekcije);
                        Sala s = sale.Find(s1 => s1.ispisSale() == p1.Sala.ispisSale());
                        dogadjajProjekcija(p1.Id_projekcije, p1.Film, s, p1.Cena_karte, p1.Datum_projekcije.Date, p1.Vreme_pocetka);
                        pf.Show();
                    }
                }

                admini = PomocneMetode.CitajXML<Administrator>(Konstante.putanja_admin);

                foreach (Administrator a1 in admini)
                {
                    if (lbKategorija.SelectedItem.ToString().Equals(a1.ToString()))
                    {
                        af = new AdministratorForma();
                        this.dogadjajAdmin += new PozivAdmin(af.PodaciAdmin);
                        dogadjajAdmin(a1.Id_administratora, a1.Email, a1.Lozinka);
                        af.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Izaberite podatak za izmenu");
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            filmovi = PomocneMetode.CitajXML<Film>(Konstante.putanja_film);
            projekcije = PomocneMetode.CitajXML<Projekcija>(Konstante.putanja_projekcije);
            relacije = PomocneMetode.CitajXML<RezervacijaProjekcija>(Konstante.putanja_relacije);
            rezervacije = PomocneMetode.CitajXML<Rezervacije>(Konstante.putanja_rezervacije);
            sale = PomocneMetode.CitajXML<Sala>(Konstante.putanja_sala);
            admini = PomocneMetode.CitajXML<Administrator>(Konstante.putanja_admin);

            if (lbKategorija.SelectedItem != null)
            {
                if (cbKategorija.SelectedItem.ToString().Equals("Filmovi"))
                {
                    DialogResult d = MessageBox.Show("Da li ste sigurni?", "Brisete i rezervacije i projekcije", MessageBoxButtons.YesNoCancel);
                    if (d == DialogResult.Yes)
                    {
                        Film filmZaBrisanje = filmovi.Find(f => f.ToString() == lbKategorija.SelectedItem.ToString());
                        if (filmZaBrisanje != null)
                        {
                            List<Projekcija> projekcijeZaBrisanje = projekcije.FindAll(proj => proj.Film.Id_filma == filmZaBrisanje.Id_filma);
                            PomocneMetode.brisi4Level(projekcijeZaBrisanje, projekcije, relacije, rezervacije, Konstante.putanja_rezervacije, Konstante.putanja_relacije, Konstante.putanja_projekcije);
                            PomocneMetode.obrisiXML(filmZaBrisanje.Id_filma.ToString(), Konstante.putanja_film, "Film", "Id_filma");
                            MessageBox.Show("Uspesno brisanje");
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                if (cbKategorija.SelectedItem.ToString().Equals("Sale"))
                {
                    DialogResult d = MessageBox.Show("Da li ste sigurni?", "Brisete i rezervacije i projekcije", MessageBoxButtons.YesNoCancel);
                    if (d == DialogResult.Yes)
                    {
                        Sala salaZaBrisanje = sale.Find(f => f.ToString() == lbKategorija.SelectedItem.ToString());
                        if (salaZaBrisanje != null)
                        {
                            List<Projekcija> projekcijeZaBrisanje = projekcije.FindAll(proj => proj.Sala.Id_sale == salaZaBrisanje.Id_sale);
                            PomocneMetode.brisi4Level(projekcijeZaBrisanje, projekcije, relacije, rezervacije, Konstante.putanja_rezervacije, Konstante.putanja_relacije, Konstante.putanja_projekcije);
                            PomocneMetode.obrisiXML(salaZaBrisanje.Id_sale.ToString(), Konstante.putanja_sala, "Sala", "Id_sale");
                            MessageBox.Show("Uspesno brisanje");
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                if (cbKategorija.SelectedItem.ToString().Equals("Projekcije"))
                {
                    DialogResult d = MessageBox.Show("Da li ste sigurni?", "Brisete i rezervacije", MessageBoxButtons.YesNoCancel);
                    if (d == DialogResult.Yes)
                    {
                        Projekcija projZaBrisanje = projekcije.Find(f => f.ToString() == lbKategorija.SelectedItem.ToString());
                        if (projZaBrisanje != null)
                        {
                            List<RezervacijaProjekcija> relacijeZaBrisanje = relacije.FindAll(rel => rel.Projekcija.Id_projekcije == projZaBrisanje.Id_projekcije);
                            PomocneMetode.brisi3level(relacijeZaBrisanje, rezervacije, Konstante.putanja_rezervacije, Konstante.putanja_relacije);
                            PomocneMetode.obrisiXML(projZaBrisanje.Id_projekcije.ToString(), Konstante.putanja_projekcije, "Projekcija", "Id_projekcije");
                            MessageBox.Show("Uspesno brisanje");
                        }
                    }
                    else
                    {
                        return;
                    }
                }

                foreach (Administrator a1 in admini)
                {
                    if (lbKategorija.SelectedItem.ToString().Equals(a1.ToString()))
                    {
                        PomocneMetode.obrisiXML(a1.Id_administratora.ToString(), Konstante.putanja_projekcije, "Administrator", "Id_administratora");
                        MessageBox.Show("Uspesno brisanje");
                    }
                }
            }
            else
            {
                MessageBox.Show("Izaberite podatak za brisanje");
            }
        }

        private void cbKupci_SelectedValueChanged(object sender, EventArgs e)
        {
            relacije = PomocneMetode.CitajXML<RezervacijaProjekcija>(Konstante.putanja_relacije);
            rezervacije = PomocneMetode.CitajXML<Rezervacije>(Konstante.putanja_rezervacije);
            kupci = PomocneMetode.CitajXML<Kupac>(Konstante.putanja_kupci);

            int id = 0;
            string[] selektovaniKupac = cbKupci.SelectedItem.ToString().Split('|');
            lbKupciRezervacije.Items.Clear();
            foreach (Kupac k in kupci)
            {
                if (selektovaniKupac[1].Trim().Equals(k.Email))
                {
                    id = k.Id_kupca;
                }
            }
            List<RezervacijaProjekcija> rel = relacije.FindAll(r => r.Rezervacija.Id_kupca_rez == id);
            foreach (RezervacijaProjekcija r in rel)
            {
                lbKupciRezervacije.Items.Add(r.ToString());
            }
        } 

        private void btnIzmenaKupca_Click(object sender, EventArgs e)
        {
            if(cbKupci.SelectedItem != null)
            {
                kupci = PomocneMetode.CitajXML<Kupac>(Konstante.putanja_kupci);

                foreach (Kupac k in kupci)
                {
                    if (cbKupci.SelectedItem.ToString().Equals(k.ToString()))
                    {
                        kf = new KupciForma();
                        this.dogadjajKupac += new PozivKupac(kf.PodaciKupca);
                        dogadjajKupac(k.Id_kupca, k.Ime, k.Prezime, k.Email, k.Telefon, k.Datum_rodjenja.Date, k.Pol);
                        kf.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Izaberite kupca");
            }
        }

        private void btnObrisiKupca_Click(object sender, EventArgs e)
        {
            kupci = PomocneMetode.CitajXML<Kupac>(Konstante.putanja_kupci);
            relacije = PomocneMetode.CitajXML<RezervacijaProjekcija>(Konstante.putanja_relacije);
            rezervacije = PomocneMetode.CitajXML<Rezervacije>(Konstante.putanja_rezervacije);
            projekcije = PomocneMetode.CitajXML<Projekcija>(Konstante.putanja_projekcije);

            //prvo brisanje svih relacija i rezervacija koje ima kupac koji se brise
            // i brisanje kupca
            if (cbKupci.SelectedItem != null)
            {
                Kupac kupacZaBrisanje = kupci.Find(f => f.ToString() == cbKupci.SelectedItem.ToString());
                if (kupacZaBrisanje != null)
                {
                    int brMesta = 0;
                    
                    foreach (Rezervacije r in rezervacije)
                    {
                        if (r.Id_kupca_rez == kupacZaBrisanje.Id_kupca)
                        {
                            brMesta = r.Broj_mesta;
                            foreach (RezervacijaProjekcija pr in relacije)
                            {
                                if (r.Id_rezervacije == pr.Rezervacija.Id_rezervacije)
                                {
                                    pr.Projekcija.Sala.Ukupno_sedista += brMesta;
                                    foreach (Projekcija p in projekcije)
                                    {
                                        if (pr.Projekcija.Id_projekcije == p.Id_projekcije)
                                        {
                                            p.Sala.Ukupno_sedista += brMesta;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                   
                    PomocneMetode.UpisiXML<RezervacijaProjekcija>(relacije, Konstante.putanja_relacije);
                    PomocneMetode.UpisiXML<Projekcija>(projekcije, Konstante.putanja_projekcije);

                    List<RezervacijaProjekcija> relacijeZaBrisanje = relacije.FindAll(r => r.Rezervacija.Id_kupca_rez == kupacZaBrisanje.Id_kupca);
                    PomocneMetode.brisi3level(relacijeZaBrisanje, rezervacije, Konstante.putanja_rezervacije, Konstante.putanja_relacije);
                    PomocneMetode.obrisiXML(kupacZaBrisanje.Id_kupca.ToString(), Konstante.putanja_kupci, "Kupac", "Id_kupca");
                    
                    MessageBox.Show("Uspesno brisanje");
                    kupci = PomocneMetode.CitajXML<Kupac>(Konstante.putanja_kupci);
                    cbKupci.Items.Clear();
                    foreach (Kupac k1 in kupci)
                    {
                        cbKupci.Items.Add(k1.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Izaberite kupca");
            }
        }

        private void btnOsvezi_Click(object sender, EventArgs e)
        {
            kupci = PomocneMetode.CitajXML<Kupac>(Konstante.putanja_kupci);
            cbKupci.Items.Clear();
            foreach (Kupac k1 in kupci)
            {
                cbKupci.Items.Add(k1.ToString());
            }
        }
    }
}
