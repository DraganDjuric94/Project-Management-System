using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.org.unibl.etf.model.dto
{
    class Cjelina
    {
        public Int32? CjelinaID { get; set; }
        public Int32? CjelinaRoditeljID { get; set; }
        public Int32? ProjekatID { get; set; }
        public String Naziv { get; set; }
        public Int32? ProcenatIzvrsenosti { get; set; }
        public DateTime? Rok { get; set; }
        public DateTime? DatumKreiranja { get; set; }
        public Int32? BrojPotrebnihCovjekCasova { get; set; }
        public Boolean? Aktivna { get; set; }

        public List<Aktivnost> Aktivnosti { get; set; }
        public List<Cjelina> Podcjeline { get; set; }

        public Cjelina()
        {
            Aktivnosti = new List<Aktivnost>();
            Podcjeline = new List<Cjelina>();
        }

        public static void DeaktivirajCjelinu(Cjelina cjelina)
        {
            foreach (Aktivnost aktivnost in cjelina.Aktivnosti)
            {
                aktivnost.Aktivna = false;
            }

            cjelina.Aktivna = false;

            foreach (Cjelina podcjelina in cjelina.Podcjeline)
            {
                DeaktivirajCjelinu(podcjelina);
            }
        }

        public override string ToString()
        {
            return
                "[" +
                "CjelinaID=" + CjelinaID +
                ", CjelinaRoditeljID=" + CjelinaRoditeljID +
                ", ProjekatID=" + ProjekatID +
                ", Naziv=" + Naziv +
                ", ProcenatIzvrsenosti=" + ProcenatIzvrsenosti +
                ", Rok=" + Rok.Value.ToString() +
                ", DatumKreiranja=" + DatumKreiranja.Value.ToString() +
                ", BrojPotrebnihCovjekCasova=" + BrojPotrebnihCovjekCasova +
                ", Aktivna=" + Aktivna +
                ", Aktivnosti=" + String.Join(",",Aktivnosti?.Select(aktivnost => aktivnost.ToString()).ToArray()) +
                ", Podcjeline=" + String.Join(",", Podcjeline?.Select(podcjelina => podcjelina.ToString()).ToArray()) + 
                "]";
        }
    }
}
