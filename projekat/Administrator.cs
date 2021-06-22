using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekat
{
    [Serializable]
    public class Administrator : Korisnik
    {
        private int id_administratora;

        public Administrator(int id_administratora, string email, string lozinka)
            :base(email, lozinka)
        {
            this.Id_administratora = id_administratora;
        }
        public Administrator() : base() { }

        public int Id_administratora { get => id_administratora; set => id_administratora = value; }

        public override string ToString()
        {
            return id_administratora + ": "+Email;
        }
    }
}
