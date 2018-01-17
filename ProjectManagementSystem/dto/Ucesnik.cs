using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.org.unibl.etf.model.dto
{
    class Ucesnik
    {
        public Int32? UcesnikID { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String KorisnickoIme { get; set; }
        public String Lozinka { get; set; }
        public String Jmbg { get; set; }
        public Boolean? Aktivan { get; set; }

        public Uloga Uloga { get; set; }

        public override int GetHashCode() => UcesnikID.GetHashCode();

        public override bool Equals(object obj)
        {
            var ucesnik = obj as Ucesnik;

            if(ucesnik is null)
            {
                return false;
            }

            return UcesnikID.Equals(ucesnik.UcesnikID);
        }

        public override string ToString()
        {
            return
                "[" +
                "UcesnikID=" + UcesnikID +
                ", Ime=" + Ime +
                ", Prezime=" + Prezime +
                ", KorisnickoIme=" + KorisnickoIme +
                ", Lozinka=" + Lozinka +
                ", Jmbg=" + Jmbg +
                ", Aktivan=" + Aktivan +
                ", Uloga" + Uloga.ToString() +
                "]";
        }
    }
}
