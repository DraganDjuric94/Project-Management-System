using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.dto
{
    public class Aktivnost
    {
        public Int32? AktivnostID { get; set; }
        public Int32? CjelinaID { get; set; }
        public String Naziv { get; set; }
        public String Opis { get; set; }
        public Boolean? Aktivna { get; set; }

        public List<Transakcija> Transakcije { get; set; }
        public Dictionary<Ucesnik, Int32> UcesniciSaBrojemUtrosenihSati { get; set; }

        public Aktivnost()
        {
            Transakcije = new List<Transakcija>();
            UcesniciSaBrojemUtrosenihSati = new Dictionary<Ucesnik, Int32>();
        }

        public override string ToString()
        {
            return
                "[AktivnostID=" + AktivnostID +
                ", CjelinaID=" + CjelinaID +
                ", Naziv=" + Naziv +
                ", Opis=" + Opis +
                ", Aktivna=" + Aktivna +
                ", UcesniciSaPotrosenimBrojemSati=" + String.Join(",", UcesniciSaBrojemUtrosenihSati?.Select(elem => "[" + elem.Key.ToString() + ", BrojPotrosenihSati=" + elem.Value.ToString() + "]" ).ToArray()) +
                ", Transakcije=" + String.Join(",",Transakcije?.Select(transakcija => transakcija.ToString()).ToArray()) + 
                "]";
        }
    }
}
