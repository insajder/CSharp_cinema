using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekat
{
    [Serializable]
    public class RezervacijaProjekcija
    {
        private int id_rez_proj;
        private Rezervacije rezervacija;
        private Projekcija projekcija;

        public RezervacijaProjekcija(int id_rez_proj, Rezervacije rezervacija, Projekcija projekcija)
        {
            this.id_rez_proj = id_rez_proj;
            this.rezervacija = rezervacija;
            this.projekcija = projekcija;
        }
        public RezervacijaProjekcija() { }
        public int Id_rez_proj { get => id_rez_proj; set => id_rez_proj = value; }
        public Rezervacije Rezervacija { get => rezervacija; set => rezervacija = value; }
        public Projekcija Projekcija { get => projekcija; set => projekcija = value; }
        public override string ToString()
        {
            return rezervacija.ToString()+ " | " + projekcija.ToString2();
        }
    }
}
