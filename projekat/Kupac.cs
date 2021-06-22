using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekat
{
    [Serializable]
    public class Kupac : Korisnik
    {
        private int id_kupca;
        private string ime;
        private string prezime;
        private DateTime datum_rodjenja;
        private string telefon;
        private string pol;

        public Kupac(int id_kupca, string ime, string prezime, DateTime datum_rodjenja, string telefon, string pol, string email, string lozinka)
            :base(email, lozinka)
        {
            this.Id_kupca = id_kupca;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Datum_rodjenja = datum_rodjenja.Date;
            this.Telefon = telefon;
            this.Pol = pol;
        }
        public Kupac():base() { }
        public int Id_kupca { get => id_kupca; set => id_kupca = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public DateTime Datum_rodjenja { get => datum_rodjenja; set => datum_rodjenja = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Pol { get => pol; set => pol = value; }

        public override string ToString()
        {
            return Ime + " " + Prezime + " | " + Email + " | " + telefon + " | " + datum_rodjenja.ToString("dd.MMMM.yyyy");
        }
    }
}
