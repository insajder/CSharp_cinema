using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace projekat
{
    public partial class ProjekcijaForma : Form
    {
        static List<Projekcija> projekcije;

        static List<RezervacijaProjekcija> relacija;

        static List<Film> filmovi;

        static List<Sala> sale;

        int id_projekcije;
        bool p;
        public ProjekcijaForma()
        {
            InitializeComponent();
            projekcije = PomocneMetode.CitajXML<Projekcija>(Konstante.putanja_projekcije);
            relacija = PomocneMetode.CitajXML<RezervacijaProjekcija>(Konstante.putanja_relacije);
            filmovi = PomocneMetode.CitajXML<Film>(Konstante.putanja_film);
            sale = PomocneMetode.CitajXML<Sala>(Konstante.putanja_sala);

            cbFilmovi.Items.Clear();
            foreach (Film f in filmovi)
                cbFilmovi.Items.Add(f.ToString());

            cbSale.Items.Clear();
            foreach (Sala s in sale)
            {
                cbSale.Items.Add(s.ToString());
            }

            for(int i=0; i<=23; i++)
            {
                cbSat.Items.Add(i.ToString("D2"));
            }
            for (int i = 0; i < 60; i+=5)
            {
                cbMinut.Items.Add(i.ToString("D2"));
            }
        }
        private void btnDodajProjekciju_Click(object sender, EventArgs e)
        {
            int id = PomocneMetode.generisiId();
            Film film = new Film();
            Sala sala = new Sala();
            double cena;
            DateTime datum;
            string vreme;
            if (cbFilmovi.SelectedItem.ToString().Trim().Length != 0 &&
                cbSale.SelectedItem.ToString().Trim().Length != 0 &&
                txtCena.Text.Trim().Length != 0 &&
                dtDatum.Text.Trim().Length != 0 &&
                cbSat.SelectedItem != null && cbMinut.SelectedItem != null)
            {
                foreach (Film f in filmovi)
                {
                    if (cbFilmovi.SelectedItem.ToString().Equals(f.ToString()))
                    {
                        film = new Film(f.Id_filma, f.Naziv, f.Zanr, f.Duzina_trajanja, f.Granica_god);
                    }
                }
                foreach (Sala s in sale)
                {
                    if (cbSale.SelectedItem.ToString().Equals(s.ToString()))
                    {
                        sala = new Sala(s.Id_sale, s.Broj_sale, s.Ukupno_sedista);
                    }
                }
                p = Double.TryParse(txtCena.Text, out cena);
                datum = dtDatum.Value.Date;
                vreme = cbSat.Text +":"+cbMinut.Text;
                if (p)
                {
                    bool projPostoji = false;
                    bool salaZauzeta = false;
                    foreach (Projekcija s in projekcije)
                    {
                        if (datum.Date != s.Datum_projekcije.Date || id_projekcije == s.Id_projekcije) continue;


                        string salaBroj = cbSale.SelectedItem.ToString().Split(' ')[1];
                        DateTime vremePocetka = DateTime.ParseExact(vreme, "HH:mm", CultureInfo.InvariantCulture);
                        DateTime vremeKraja = DateTime.ParseExact(vreme, "HH:mm", CultureInfo.InvariantCulture).AddMinutes(film.Duzina_trajanja + 10);

                        DateTime projekcijaVremePocetka = DateTime.ParseExact(s.Vreme_pocetka, "HH:mm", CultureInfo.InvariantCulture);
                        DateTime projekcijaVremeKraja = DateTime.ParseExact(s.Vreme_pocetka, "HH:mm", CultureInfo.InvariantCulture).AddMinutes(s.Film.Duzina_trajanja + 10);

                        if (s.Film.ToString() == cbFilmovi.SelectedItem.ToString() &&
                            s.Sala.Broj_sale == Convert.ToInt32(salaBroj) &&
                            vreme == s.Vreme_pocetka)
                        {
                            projPostoji = true;
                        }else if(s.Sala.Broj_sale == Convert.ToInt32(salaBroj) &&
                                (
                                    (projekcijaVremeKraja.TimeOfDay > vremePocetka.TimeOfDay && projekcijaVremeKraja.TimeOfDay < vremeKraja.TimeOfDay) || // preklapanje s leva
                                    (projekcijaVremePocetka.TimeOfDay < vremeKraja.TimeOfDay && projekcijaVremePocetka.TimeOfDay > vremePocetka.TimeOfDay) || // preklapanje s desna
                                    (projekcijaVremePocetka.TimeOfDay > vremePocetka.TimeOfDay && projekcijaVremeKraja.TimeOfDay < vremeKraja.TimeOfDay) || // prelapanje unutar termina
                                    (projekcijaVremePocetka.TimeOfDay < vremePocetka.TimeOfDay && projekcijaVremeKraja.TimeOfDay > vremeKraja.TimeOfDay) // preklapanje celog termina
                                )
                            )
                        {
                            salaZauzeta = true;
                        }
                    }
                    if (projPostoji == true)
                    {
                        MessageBox.Show("Vec postoji projekcija");
                    }else if(salaZauzeta == true)
                    {
                        MessageBox.Show("Sala je zauzeta");
                    }
                    else
                    {
                        if (btnDodajProjekciju.Text == "Dodaj")
                        {
                            projekcije.Add(new Projekcija(id, datum, sala, cena, vreme, film));
                            PomocneMetode.UpisiXML<Projekcija>(projekcije, Konstante.putanja_projekcije);
                            MessageBox.Show("Uspesno ste dodali projekciju");
                        }
                        if (btnDodajProjekciju.Text == "Izmeni")
                        {
                            Film filmSelekt = new Film();
                            Sala salaSelekt = new Sala();

                            foreach (Film f in filmovi)
                            {
                                if (cbFilmovi.SelectedItem.ToString() == f.ToString())
                                {
                                    filmSelekt = f;
                                }
                            }
                            foreach (Sala s in sale)
                            {
                                if (cbSale.SelectedItem.ToString() == s.ToString())
                                {
                                    salaSelekt = s;
                                }
                            }

                            PomocneMetode.izmeniXML(Konstante.putanja_projekcije, "Projekcija", "Id_projekcije", id_projekcije.ToString(), "Cena_karte", txtCena.Text);
                            PomocneMetode.izmeniXML(Konstante.putanja_projekcije, "Projekcija", "Id_projekcije", id_projekcije.ToString(), "Vreme_pocetka", cbSat.Text + ":" + cbMinut.Text);
                            PomocneMetode.izmeniXML(Konstante.putanja_projekcije, "Projekcija", "Id_projekcije", id_projekcije.ToString(), "Datum_projekcije", dtDatum.Value.Date.ToString("yyyy-MM-ddTHH\\:mm\\:ss"));

                            PomocneMetode.izmeniXMLunutar(Konstante.putanja_projekcije, "Projekcija", "Id_projekcije", id_projekcije.ToString(), "Sala", "Broj_sale", salaSelekt.Broj_sale.ToString());
                            PomocneMetode.izmeniXMLunutar(Konstante.putanja_projekcije, "Projekcija", "Id_projekcije", id_projekcije.ToString(), "Sala", "Ukupno_sedista", salaSelekt.Ukupno_sedista.ToString());

                            PomocneMetode.izmeniXMLunutar(Konstante.putanja_projekcije, "Projekcija", "Id_projekcije", id_projekcije.ToString(), "Film", "Naziv", filmSelekt.Naziv);
                            PomocneMetode.izmeniXMLunutar(Konstante.putanja_projekcije, "Projekcija", "Id_projekcije", id_projekcije.ToString(), "Film", "Zanr", filmSelekt.Zanr);
                            PomocneMetode.izmeniXMLunutar(Konstante.putanja_projekcije, "Projekcija", "Id_projekcije", id_projekcije.ToString(), "Film", "Duzina_trajanja", filmSelekt.Duzina_trajanja.ToString());
                            PomocneMetode.izmeniXMLunutar(Konstante.putanja_projekcije, "Projekcija", "Id_projekcije", id_projekcije.ToString(), "Film", "Granica_god", filmSelekt.Granica_god.ToString());


                            projekcije = PomocneMetode.CitajXML<Projekcija>(Konstante.putanja_projekcije);
                            Projekcija izmenjenaProjekcija = projekcije.Find(f => f.Id_projekcije == id_projekcije);
                            List<RezervacijaProjekcija> relacijeZaIzmenu = relacija.FindAll(rel => rel.Projekcija.Id_projekcije == izmenjenaProjekcija.Id_projekcije);

                            foreach (RezervacijaProjekcija rel in relacijeZaIzmenu)
                            {
                                PomocneMetode.izmeniXMLunutar(Konstante.putanja_relacije, "RezervacijaProjekcija", "Id_rez_proj", rel.Id_rez_proj.ToString(), "Projekcija", "Cena_karte", txtCena.Text);
                                PomocneMetode.izmeniXMLunutar(Konstante.putanja_relacije, "RezervacijaProjekcija", "Id_rez_proj", rel.Id_rez_proj.ToString(), "Projekcija", "Vreme_pocetka", cbSat.Text + ":" + cbMinut.Text);
                                PomocneMetode.izmeniXMLunutar(Konstante.putanja_relacije, "RezervacijaProjekcija", "Id_rez_proj", rel.Id_rez_proj.ToString(), "Projekcija", "Datum_projekcije", dtDatum.Value.Date.ToString());

                                PomocneMetode.izmeniXMLunutar2(Konstante.putanja_relacije, "RezervacijaProjekcija", "Id_rez_proj", rel.Id_rez_proj.ToString(), "Projekcija", "Sala", "Broj_sale", salaSelekt.Broj_sale.ToString());
                                PomocneMetode.izmeniXMLunutar2(Konstante.putanja_relacije, "RezervacijaProjekcija", "Id_rez_proj", rel.Id_rez_proj.ToString(), "Projekcija", "Sala", "Ukupno_sedista", salaSelekt.Ukupno_sedista.ToString());

                                PomocneMetode.izmeniXMLunutar2(Konstante.putanja_relacije, "RezervacijaProjekcija", "Id_rez_proj", rel.Id_rez_proj.ToString(), "Projekcija", "Film", "Naziv", filmSelekt.Naziv);
                                PomocneMetode.izmeniXMLunutar2(Konstante.putanja_relacije, "RezervacijaProjekcija", "Id_rez_proj", rel.Id_rez_proj.ToString(), "Projekcija", "Film", "Zanr", filmSelekt.Zanr);
                                PomocneMetode.izmeniXMLunutar2(Konstante.putanja_relacije, "RezervacijaProjekcija", "Id_rez_proj", rel.Id_rez_proj.ToString(), "Projekcija", "Film", "Duzina_trajanja", filmSelekt.Duzina_trajanja.ToString());
                                PomocneMetode.izmeniXMLunutar2(Konstante.putanja_relacije, "RezervacijaProjekcija", "Id_rez_proj", rel.Id_rez_proj.ToString(), "Projekcija", "Film", "Granica_god", filmSelekt.Granica_god.ToString());
                            }

                            MessageBox.Show("Uspesna izmena");
                        }

                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Niste uneli ispravne podatke za duzinu trajanja ili za granicu godina");
                }
            }
            else
            {
                MessageBox.Show("Popunite sva polja");
            }
        }
        public void PodaciProjekcije(int id, Film film1, Sala sala1, double cena1, DateTime datum1, string vreme1)
        {
            id_projekcije = id;
            cbFilmovi.SelectedIndex = cbFilmovi.FindStringExact(film1.ToString());
            cbSale.SelectedIndex = cbSale.FindStringExact(sala1.ToString());
            txtCena.Text = cena1.ToString();
            dtDatum.Value = datum1;
            btnDodajProjekciju.Text = "Izmeni";
            lblDodaj.Text = "Izmeni projekciju";
        }
    }
}
