using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace projekat
{
    public class PomocneMetode
    {
        static public void UpisiXML<T>(List<T> list, string putanja)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            using (TextWriter tw = new StreamWriter(putanja))
            {
                serializer.Serialize(tw, list);
                tw.Close();
            }
        }
        static public List<T> CitajXML<T>(string putanja)
        {
            List<T> result;
            if (!File.Exists(putanja))
            {
                return new List<T>();
            }

            XmlSerializer ser = new XmlSerializer(typeof(List<T>));
            using (FileStream fs = new FileStream(putanja, FileMode.Open))
            {
                result = (List<T>)ser.Deserialize(fs);
            }
            return result;
        }

        static public void izmeniXML(string putanja, string roditelj, string roditeljPolje, string roditeljPoljeVrednost, string dete, string novo)
        {
            var put = XDocument.Load(putanja);
            IEnumerable<XElement> pronadji =
                 from element in put.Root.Elements(roditelj)
                 where (string)element.Element(roditeljPolje).Value == roditeljPoljeVrednost
                 select element;
            if (pronadji.Count() != 0)
            {
                foreach (XElement element in pronadji)
                {
                    element.Element(dete).SetValue(novo);
                }
            }
            put.Save(putanja);
        }

        static public void izmeniXMLunutar(string putanja, string roditelj, string roditeljPolje, string roditeljPoljeVrednost, string el, string dete, string novo)
        {
            var put = XDocument.Load(putanja);
            IEnumerable<XElement> pronadji =
                 from element in put.Root.Elements(roditelj)
                 where (string)element.Element(roditeljPolje).Value == roditeljPoljeVrednost
                 select element;
            if (pronadji.Count() != 0)
            {
                foreach (XElement element in pronadji)
                {
                    element.Element(el).Element(dete).SetValue(novo);
                }
            }
            put.Save(putanja);
        }

        static public void izmeniXMLunutar2(string putanja, string roditelj, string roditeljPolje, string roditeljPoljeVrednost, string el, string el2, string dete, string deteNovaVrednost)
        {
            XDocument put = XDocument.Load(putanja);
            IEnumerable<XElement> pronadji =
                 from element in put.Root.Elements(roditelj)
                 where (string)element.Element(roditeljPolje).Value == roditeljPoljeVrednost
                 select element;
            if (pronadji.Count() != 0)
            {
                foreach (XElement element in pronadji)
                {
                    element.Element(el).Element(el2).Element(dete).SetValue(deteNovaVrednost);
                }
            }
            put.Save(putanja);
        }

        static public void obrisiXML(string id, string putanja, string roditelj, string dete)
        {
            XDocument put = XDocument.Load(putanja);
            var pronadji = (from element in put.Descendants(roditelj)
                            where element.Element(dete).Value == id
                            select element).FirstOrDefault();

            pronadji.Remove();
            put.Save(putanja);
        }
        static public int generisiId()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            int id = rand.Next();
            return id;
        }

        static public void brisi4Level(List<Projekcija> projekcijeZaBrisanje, List<Projekcija> projekcije, List<RezervacijaProjekcija> relacije, List<Rezervacije> rezervacije,
            string putanja_rez, string putanja_rel, string putanja_projekcije)
        {
            List<RezervacijaProjekcija> relacijeZaBrisanje = new List<RezervacijaProjekcija>();
            List<Rezervacije> rezervacijeZaBrisanje = new List<Rezervacije>();
            foreach (Projekcija proj in projekcijeZaBrisanje)
            {
                List<RezervacijaProjekcija> trenutnaRelacije = relacije.FindAll(rel => rel.Projekcija.Id_projekcije == proj.Id_projekcije);
                if (trenutnaRelacije.Count() > 0)
                {
                    relacijeZaBrisanje.AddRange(trenutnaRelacije);
                }
            }
            foreach (RezervacijaProjekcija rel in relacijeZaBrisanje)
            {
                List<Rezervacije> trenutneRezervacije = rezervacije.FindAll(rez => rez.Id_rezervacije == rel.Rezervacija.Id_rezervacije);
                if (trenutneRezervacije.Count() > 0)
                {
                    rezervacijeZaBrisanje.AddRange(trenutneRezervacije);
                }
            }


            // brisanje svih relacija
            foreach (Rezervacije rez in rezervacijeZaBrisanje)
            {
                PomocneMetode.obrisiXML(rez.Id_rezervacije.ToString(), putanja_rez, "Rezervacije", "Id_rezervacije");
            }
            foreach (RezervacijaProjekcija rel in relacijeZaBrisanje)
            {
                PomocneMetode.obrisiXML(rel.Id_rez_proj.ToString(), putanja_rel, "RezervacijaProjekcija", "Id_rez_proj");
            }
            foreach (Projekcija proj in projekcijeZaBrisanje)
            {
                PomocneMetode.obrisiXML(proj.Id_projekcije.ToString(), putanja_projekcije, "Projekcija", "Id_projekcije");
            }
        }

        static public void brisi3level(List<RezervacijaProjekcija> relacijeZaBrisanje, List<Rezervacije> rezervacije,
            string putanja_rez, string putanja_rel)
        {
            List<Rezervacije> rezervacijeZaBrisanje = new List<Rezervacije>();
            foreach (RezervacijaProjekcija rel in relacijeZaBrisanje)
            {
                List<Rezervacije> trenutneRezervacije = rezervacije.FindAll(rez => rez.Id_rezervacije == rel.Rezervacija.Id_rezervacije);
                if (trenutneRezervacije.Count() > 0)
                {
                    rezervacijeZaBrisanje.AddRange(trenutneRezervacije);
                }
            }


            // brisanje svih relacija
            foreach (Rezervacije rez in rezervacijeZaBrisanje)
            {
                PomocneMetode.obrisiXML(rez.Id_rezervacije.ToString(), putanja_rez, "Rezervacije", "Id_rezervacije");
            }
            foreach (RezervacijaProjekcija rel in relacijeZaBrisanje)
            {
                PomocneMetode.obrisiXML(rel.Id_rez_proj.ToString(), putanja_rel, "RezervacijaProjekcija", "Id_rez_proj");
            }
        }
    }
}
