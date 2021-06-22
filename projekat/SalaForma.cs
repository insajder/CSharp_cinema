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
    public partial class SalaForma : Form
    {
        List<Sala> sale;

        List<Projekcija> projekcije;

        List<RezervacijaProjekcija> relacije;

        int id_sale;
        int stariBrojSale;
        public SalaForma()
        {
            InitializeComponent();

            projekcije = PomocneMetode.CitajXML<Projekcija>(Konstante.putanja_projekcije);
            relacije = PomocneMetode.CitajXML<RezervacijaProjekcija>(Konstante.putanja_relacije);
        }

        private void btnDodajSalu_Click(object sender, EventArgs e)
        {
            sale = PomocneMetode.CitajXML<Sala>(Konstante.putanja_sala);
            MessageBox.Show(stariBrojSale.ToString());
            int id = PomocneMetode.generisiId();
            int broj;
            int sedista;
            bool p;
            bool p2;
            if (txtBroj.Text.Trim().Length != 0 &&
                txtSedista.Text.Trim().Length != 0)
            {
                p = Int32.TryParse(txtBroj.Text, out broj);
                p2 = Int32.TryParse(txtSedista.Text, out sedista);
                if (p && p2)
                {
                    if (stariBrojSale == 0 || btnDodajSalu.Text == "Dodaj")
                    {
                        bool salaPostoji = false;
                        foreach (Sala s in sale)
                        {
                            if (s.Broj_sale.ToString() == txtBroj.Text)
                            {
                                salaPostoji = true;
                            }
                        }
                        if (salaPostoji == true)
                        {
                            MessageBox.Show("Vec postoji sala sa ovim brojem");
                        }
                        else
                        {
                            if (btnDodajSalu.Text == "Dodaj")
                            {
                                sale.Add(new Sala(id, broj, sedista));
                                PomocneMetode.UpisiXML<Sala>(sale, Konstante.putanja_sala);
                                MessageBox.Show("Uspesno ste dodali salu");
                            }
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Niste uneli ispravne podatke");
                }
            }
            else
            {
                MessageBox.Show("Popunite sva polja");
            }

            if (btnDodajSalu.Text == "Izmeni")
            {
                p2 = Int32.TryParse(txtSedista.Text, out sedista);
                if (p2)
                {
                    PomocneMetode.izmeniXML(Konstante.putanja_sala, "Sala", "Id_sale", id_sale.ToString(), "Ukupno_sedista", txtSedista.Text);

                    MessageBox.Show("Uspesna izmena");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Unesite ispravne podatke");
                }
            }
        }

        public void PodaciSale(int id, int broj, int sedista)
        {
            id_sale = id;

            txtBroj.Text = broj.ToString();
            stariBrojSale = Convert.ToInt32(txtBroj.Text);

            txtSedista.Text = sedista.ToString();

            btnDodajSalu.Text = "Izmeni";
            lblDodaj.Text = "Izmeni salu";
            txtBroj.ReadOnly = true;
        }
    }
}
