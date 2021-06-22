using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekat
{
    [Serializable]
    public class Film
    {
        private int id_filma;
        private string naziv;
        private string zanr;
        private int duzina_trajanja;
        private int granica_god;

        public Film(int id_filma, string naziv, string zanr, int duzina_trajanja, int granica_god)
        {
            this.Id_filma = id_filma;
            this.Naziv = naziv;
            this.Zanr = zanr;
            this.Duzina_trajanja = duzina_trajanja;
            this.Granica_god = granica_god;
        }
        public Film() { }
        public Film(Film f) 
        {
            this.Id_filma = f.id_filma;
            this.Naziv = f.naziv;
            this.Zanr = f.zanr;
            this.Duzina_trajanja = f.duzina_trajanja;
            this.Granica_god = f.granica_god;
        }

        public int Id_filma { get => id_filma; set => id_filma = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Zanr { get => zanr; set => zanr = value; }
        public int Duzina_trajanja { get => duzina_trajanja; set => duzina_trajanja = value; }
        public int Granica_god { get => granica_god; set => granica_god = value; }

        public override string ToString()
        {
            return "\"" + Naziv + "\" | " + Duzina_trajanja + " min | " + Zanr + " | " + granica_god;
        }
    }
}
