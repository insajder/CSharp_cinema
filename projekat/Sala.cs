using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekat
{
    [Serializable]
    public class Sala
    {
        private int id_sale;
        private int broj_sale;
        private int ukupno_sedista;

        public Sala(int id_sale, int broj_sale, int ukupno_sedista)
        {
            this.id_sale = id_sale;
            this.broj_sale = broj_sale;
            this.ukupno_sedista = ukupno_sedista;
        }
        public Sala() { }
        public int Id_sale { get => id_sale; set => id_sale = value; }
        public int Broj_sale { get => broj_sale; set => broj_sale = value; }
        public int Ukupno_sedista { get => ukupno_sedista; set => ukupno_sedista = value; }
        public override string ToString()
        {
            return "Sala: "+broj_sale+" | Broj dostupnih sedista: "+ukupno_sedista;
        }
        public string ToString2()
        {
            return "Sala: " + broj_sale + " | Ukupno sedista: " + ukupno_sedista;
        }
        public string ispisSale()
        {
            return "Sala " + broj_sale;
        }
    }
}
