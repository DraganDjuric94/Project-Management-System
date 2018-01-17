using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.org.unibl.etf.model.dto
{
    class Projekat
    {
        public Int32? ProjekatID { get; set; }
        public String Naziv { get; set; }
        public DateTime? DatumKreiranja { get; set; }
        public Boolean? Aktivan { get; set; }

        public List<Cjelina> Cjeline { get; set; }

        public Projekat() => Cjeline = new List<Cjelina>();

        public static void DeaktivirajProjekat(Projekat projekat)
        {
            projekat.Aktivan = false;

            foreach(Cjelina cjelina in projekat.Cjeline)
            {
                Cjelina.DeaktivirajCjelinu(cjelina);
            }
        }

        public override string ToString()
        {
            return
                "[" +
                "ProjekatID=" + ProjekatID +
                ", Naziv=" + Naziv +
                ", DatumKreiranja=" + DatumKreiranja.Value.ToString() +
                ", Aktivan=" + Aktivan +
                ", Cjeline=" + String.Join(",", Cjeline?.Select(cjelina => cjelina.ToString()).ToArray()) +
                "]";
        }
    }
}
