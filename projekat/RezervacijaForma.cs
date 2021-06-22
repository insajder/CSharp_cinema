using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;

namespace projekat
{
    public partial class RezervacijaForma : Form
    {
        static List<Rezervacije> lst_rezervacije;

        static List<Projekcija> lst_proj;

        static List<RezervacijaProjekcija> lst_rel;

        List<Sala> lst_sala;

        List<Film> lst_film;

        int br_mesta;
        double uk_cena;
        int idKUPCA;

        public RezervacijaForma()
        {
            InitializeComponent();

            dtKrajnji.Value = DateTime.Now.AddDays(30).Date;
            dtPocetni.MinDate = DateTime.Now.Date;
            dtKrajnji.MinDate = DateTime.Now.AddDays(1).Date;
        }

        private void btnPrikazi_Click(object sender, EventArgs e) //za filtriranje
        {
            lbRepertoar.Items.Clear();
            lst_proj = PomocneMetode.CitajXML<Projekcija>(Konstante.putanja_projekcije);

            foreach (Projekcija p in lst_proj) //za filtriranje
            {
                int pocetniRezultat = DateTime.Compare(p.Datum_projekcije.Date, dtPocetni.Value.Date);
                int krajnjiRezultat = DateTime.Compare(p.Datum_projekcije.Date, dtKrajnji.Value.Date);
                if (pocetniRezultat >= 0 && krajnjiRezultat <= 0)
                {
                    if (cbSala.Text.Trim().Length != 0 && cbNaziv.Text.Trim().Length != 0)
                    {
                        if (cbSala.SelectedItem.ToString().Equals(p.Sala.ispisSale()) && cbNaziv.SelectedItem.ToString().Equals(p.Film.Naziv))
                        {
                            lbRepertoar.Items.Add(p.ToString());
                        }
                    }
                    else if (cbSala.Text.Trim().Length != 0 && cbNaziv.Text.Trim().Length == 0)
                    {
                        if (cbSala.SelectedItem.ToString().Equals(p.Sala.ispisSale()))
                        {
                            lbRepertoar.Items.Add(p.ToString());
                        }
                    }
                    else if (cbSala.Text.Trim().Length == 0 && cbNaziv.Text.Length != 0)
                    {
                        if (cbNaziv.SelectedItem.ToString().Equals(p.Film.Naziv))
                        {
                            lbRepertoar.Items.Add(p.ToString());
                        }
                    }
                    else
                    {
                        lbRepertoar.Items.Add(p.ToString());
                    }
                }

            }
        }
        public void dodajRezervaciju(int idKupca)
        {
            idKUPCA = idKupca; 
        }

        private void nudBrojMesta_ValueChanged(object sender, EventArgs e)//za ispis ukupne cene
        {
            br_mesta = Convert.ToInt32(nudBrojMesta.Value);
            lst_proj = PomocneMetode.CitajXML<Projekcija>(Konstante.putanja_projekcije);

            foreach (Projekcija p in lst_proj)
            {
                if (p.ToString().Equals(lbRepertoar.SelectedItem))
                {
                    uk_cena = p.Cena_karte * br_mesta;
                    break;
                }
            }
            txtUkupnaCena.Text = uk_cena + " RSD";
        }

        private void btnRezervisi_Click(object sender, EventArgs e)
        {
            lst_proj = PomocneMetode.CitajXML<Projekcija>(Konstante.putanja_projekcije);
            lst_rezervacije = PomocneMetode.CitajXML<Rezervacije>(Konstante.putanja_rezervacije);
            lst_rel = PomocneMetode.CitajXML<RezervacijaProjekcija>(Konstante.putanja_relacije);

            int brojMesta = 0;
            int idProjekcija = 0;

            if (lbRepertoar.SelectedItem != null && nudBrojMesta.Value > 0)
            {
                foreach (Projekcija p in lst_proj)
                {
                    if (p.ToString().Equals(lbRepertoar.SelectedItem))
                    {
                        if (nudBrojMesta.Value > p.Sala.Ukupno_sedista)
                        {
                            MessageBox.Show("Nema dovoljno sedista");
                            break;
                        }
                        else
                        {
                            brojMesta = p.Sala.Ukupno_sedista - Convert.ToInt32(nudBrojMesta.Value);

                            int id_rez = PomocneMetode.generisiId();

                            Rezervacije rez1 = new Rezervacije(id_rez, idKUPCA, br_mesta, uk_cena);
                            lst_rezervacije.Add(new Rezervacije(id_rez, idKUPCA, br_mesta, uk_cena));
                            
                            int id_rel = PomocneMetode.generisiId();
                            lst_rel.Add(new RezervacijaProjekcija(id_rel, rez1, p));

                            PomocneMetode.UpisiXML<RezervacijaProjekcija>(lst_rel, Konstante.putanja_relacije);

                            PomocneMetode.UpisiXML<Rezervacije>(lst_rezervacije, Konstante.putanja_rezervacije);

                            nudBrojMesta.Value = 0;
                            idProjekcija = p.Id_projekcije;
                            MessageBox.Show("uspesna rezervacija");
                            this.Close();
                            break;
                        }
                    }
                }
                lbRepertoar.Items.Clear();
                foreach (Projekcija p2 in lst_proj) //prikaz na listboksu
                {
                    lbRepertoar.Items.Add(p2.ToString());
                }
                foreach(Projekcija p in lst_proj)
                {
                    if(idProjekcija == p.Id_projekcije)
                    {
                        p.Sala.Ukupno_sedista = brojMesta;
                        break;
                    }
                }
                lst_rel = PomocneMetode.CitajXML<RezervacijaProjekcija>(Konstante.putanja_relacije);
                foreach (RezervacijaProjekcija p in lst_rel)
                {
                    if (idProjekcija == p.Projekcija.Id_projekcije)
                    {
                        p.Projekcija.Sala.Ukupno_sedista = brojMesta;
                        break;
                    }
                }
                PomocneMetode.UpisiXML<RezervacijaProjekcija>(lst_rel, Konstante.putanja_relacije);
                PomocneMetode.UpisiXML<Projekcija>(lst_proj, Konstante.putanja_projekcije);
            }
            else
            {
                MessageBox.Show("Izaberite film i broj mesta");
            }
        }

        private void RezervacijaForma_Load(object sender, EventArgs e)
        {
            lst_proj = PomocneMetode.CitajXML<Projekcija>(Konstante.putanja_projekcije);
            foreach (Projekcija p in lst_proj)
            {
                if(p.Datum_projekcije > DateTime.Now)
                {
                    lbRepertoar.Items.Add(p.ToString());
                }
            }

            lst_film = PomocneMetode.CitajXML<Film>(Konstante.putanja_film);
            foreach (Film f in lst_film)
            {
                foreach (Projekcija p in lst_proj)
                {
                    if (f.Naziv == p.Film.Naziv)
                    {
                        cbNaziv.Items.Add(f.Naziv);
                        break;
                    }
                }
            }

            lst_sala = PomocneMetode.CitajXML<Sala>(Konstante.putanja_sala);
            foreach (Sala s in lst_sala)
            {
                cbSala.Items.Add(s.ispisSale());
            }
        }
    }
}
