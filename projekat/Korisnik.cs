using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekat
{
    public class Korisnik
    {
        private string email;
        private string lozinka;

        public Korisnik(string email, string lozinka)
        {
            this.Email = email;
            this.Lozinka = lozinka;
        }
        public Korisnik() { }

        public string Email { get => email; set => email = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }

        public bool prijaviSe(string mejl, string sifra)
        {
            if(email == mejl && lozinka == sifra)
            {
                return true;
            }
            return false;
        } 
    }
}
