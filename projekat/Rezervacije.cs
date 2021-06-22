using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace projekat
{
    [Serializable]
    public class Rezervacije
    {
        private int id_rezervacije;
        private int id_kupca_rez;
        private int broj_mesta;
        private double ukupna_cena;

        public Rezervacije(int id_rezervacije, int id_kupca_rez, int broj_mesta, double ukupna_cena)
        {
            this.Id_rezervacije = id_rezervacije;
            this.Id_kupca_rez = id_kupca_rez;
            this.Broj_mesta = broj_mesta;
            this.Ukupna_cena = ukupna_cena;
        }
        public Rezervacije() { }
        public int Id_rezervacije { get => id_rezervacije; set => id_rezervacije = value; }
        public int Id_kupca_rez { get => id_kupca_rez; set => id_kupca_rez = value; }
        public int Broj_mesta { get => broj_mesta; set => broj_mesta = value; }
        public double Ukupna_cena { get => ukupna_cena; set => ukupna_cena = value; }

        public override string ToString()
        {
            return "Broj mesta: " + broj_mesta + " | Ukupna cena: " + ukupna_cena;
        }
    }
}
