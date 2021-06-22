using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace projekat
{
    public partial class FilmForma : Form
    {
        List<Film> filmovi;

        List<Projekcija> projekcije;

        List<RezervacijaProjekcija> relacije;

        int id_filma;

        public FilmForma()
        {
            InitializeComponent();
            
            projekcije = PomocneMetode.CitajXML<Projekcija>(Konstante.putanja_projekcije);
            relacije = PomocneMetode.CitajXML<RezervacijaProjekcija>(Konstante.putanja_relacije);
        }

        private void btnDodajFilm_Click(object sender, EventArgs e)
        {
            filmovi = PomocneMetode.CitajXML<Film>(Konstante.putanja_film);
            int id = PomocneMetode.generisiId();
            string naziv;
            string zanr;
            int duzina;
            bool p;
            int granica;
            bool p2;
            if(txtNaziv.Text.Trim().Length != 0 &&
                txtZanr.Text.Trim().Length != 0 &&
                txtDuzina.Text.Trim().Length != 0 &&
                txtGranica.Text.Trim().Length != 0 )
            {
                naziv = txtNaziv.Text;
                zanr = txtZanr.Text;
                p = Int32.TryParse(txtDuzina.Text, out duzina);
                p2 = Int32.TryParse(txtGranica.Text, out granica);
                if (p && p2)
                {
                    bool filmPostoji = false;
                    foreach (Film f in filmovi)
                    {
                        if (f.Naziv == txtNaziv.Text &&  f.Zanr == txtZanr.Text && f.Duzina_trajanja.ToString() == txtDuzina.Text && f.Granica_god.ToString() == txtGranica.Text)
                        {
                            filmPostoji = true;
                        }
                    }
                    if (filmPostoji == true)
                    {
                        MessageBox.Show("Vec postoji ovaj film");
                    }
                    else
                    {
                        if (btnDodajFilm.Text == "Dodaj")
                        {
                            filmovi.Add(new Film(id, naziv, zanr, duzina, granica));
                            PomocneMetode.UpisiXML<Film>(filmovi, Konstante.putanja_film);
                            MessageBox.Show("Uspesno ste dodali film");
                        }
                        if (btnDodajFilm.Text == "Izmeni")
                        {
                            //izmena filma za Projekcija.cs i relacije
                            filmovi = PomocneMetode.CitajXML<Film>(Konstante.putanja_film);

                            List<Projekcija> projekcijeZaIzmenu = projekcije.FindAll(proj => proj.Film.Id_filma == id_filma);
                            List<RezervacijaProjekcija> relacijeZaIzmenu = new List<RezervacijaProjekcija>();
                            foreach (Projekcija proj in projekcijeZaIzmenu)
                            {
                                List<RezervacijaProjekcija> trenutneRelacije = relacije.FindAll(rel => rel.Projekcija.Id_projekcije == proj.Id_projekcije);
                                if (trenutneRelacije.Count() > 0)
                                {
                                    relacijeZaIzmenu.AddRange(trenutneRelacije);
                                }
                            }

                            foreach (RezervacijaProjekcija rel in relacijeZaIzmenu)
                            {
                                PomocneMetode.izmeniXMLunutar2(Konstante.putanja_relacije, "RezervacijaProjekcija", "Id_rez_proj", rel.Id_rez_proj.ToString(), "Projekcija", "Film", "Naziv", naziv);
                                PomocneMetode.izmeniXMLunutar2(Konstante.putanja_relacije, "RezervacijaProjekcija", "Id_rez_proj", rel.Id_rez_proj.ToString(), "Projekcija", "Film", "Zanr", zanr);
                                PomocneMetode.izmeniXMLunutar2(Konstante.putanja_relacije, "RezervacijaProjekcija", "Id_rez_proj", rel.Id_rez_proj.ToString(), "Projekcija", "Film", "Duzina_trajanja", duzina.ToString());
                                PomocneMetode.izmeniXMLunutar2(Konstante.putanja_relacije, "RezervacijaProjekcija", "Id_rez_proj", rel.Id_rez_proj.ToString(), "Projekcija", "Film", "Granica_god", granica.ToString());
                            }
                            foreach (Projekcija proj in projekcijeZaIzmenu)
                            {
                                PomocneMetode.izmeniXMLunutar(Konstante.putanja_projekcije, "Projekcija", "Id_projekcije", proj.Id_projekcije.ToString(), "Film", "Naziv", naziv);
                                PomocneMetode.izmeniXMLunutar(Konstante.putanja_projekcije, "Projekcija", "Id_projekcije", proj.Id_projekcije.ToString(), "Film", "Zanr", zanr);
                                PomocneMetode.izmeniXMLunutar(Konstante.putanja_projekcije, "Projekcija", "Id_projekcije", proj.Id_projekcije.ToString(), "Film", "Duzina_trajanja", duzina.ToString());
                                PomocneMetode.izmeniXMLunutar(Konstante.putanja_projekcije, "Projekcija", "Id_projekcije", proj.Id_projekcije.ToString(), "Film", "Granica_god", granica.ToString());
                            }

                            //izmena filma za Film.cs
                            filmovi = PomocneMetode.CitajXML<Film>(Konstante.putanja_film);
                            foreach (Film f in filmovi)
                            {
                                if (id_filma == f.Id_filma)
                                {
                                    PomocneMetode.obrisiXML(f.Id_filma.ToString(), Konstante.putanja_film, "Film", "Id_filma");
                                    break;
                                }
                            }
                            filmovi = PomocneMetode.CitajXML<Film>(Konstante.putanja_film);
                            filmovi.Add(new Film(id_filma, naziv, zanr, duzina, granica));
                            PomocneMetode.UpisiXML<Film>(filmovi, Konstante.putanja_film);
                            //kraj izmena filma za Film.cs

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

        public void PodaciFilma(int id, string naziv, string zanr, int duzina, int granica)
        {
            id_filma = id;

            txtNaziv.Text = naziv;

            txtZanr.Text = zanr;

            txtDuzina.Text = duzina.ToString();

            txtGranica.Text = granica.ToString();

            btnDodajFilm.Text = "Izmeni";
            lblDodaj.Text = "Izmeni film";
        }
    }
}
