using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace projekat
{
    [Serializable]
     public class Projekcija 
    {
        private int id_projekcije;
        private DateTime datum_projekcije;
        private Sala sala;
        private double cena_karte;
        private string vreme_pocetka;
        private Film film;

        public Projekcija(int id_projekcije, DateTime datum_projekcije, Sala sala, double cena_karte, string vreme_pocetka, Film film)
        {
            this.Id_projekcije = id_projekcije;
            this.Datum_projekcije = datum_projekcije.Date;
            this.Sala = sala;
            this.Cena_karte = cena_karte;
            this.Vreme_pocetka = vreme_pocetka;
            this.Film = film;
        }
        public Projekcija() { }
        public int Id_projekcije { get => id_projekcije; set => id_projekcije = value; }
        public DateTime Datum_projekcije { get => datum_projekcije; set => datum_projekcije = value; }
        public double Cena_karte { get => cena_karte; set => cena_karte = value; }
        public string Vreme_pocetka { get => vreme_pocetka; set => vreme_pocetka = value; }
        public Sala Sala { get => sala; set => sala = value; }
        public Film Film { get => film; set => film = value; }

        public override string ToString()
        {
            return film.ToString() + " | Cena karte: " +cena_karte+" | Datum i vreme: "+datum_projekcije.ToString("dd'.'MM'.'yyyy") + " - "+
                vreme_pocetka+" | " + sala.ToString();
        }
        public string ToString2()
        {
            return film.ToString() + " | Cena karte: " + cena_karte + " | Datum i vreme: " + datum_projekcije.ToString("dd'.'MM'.'yyyy") + " - " +
                vreme_pocetka + " | " + sala.ispisSale();
        }
    }
}
