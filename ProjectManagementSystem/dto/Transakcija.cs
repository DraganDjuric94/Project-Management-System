using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.dto
{
    public class Transakcija
    {
        public Int32? TransakcijaID { get; set; }
        public Int32? AktivnostID { get; set; }
        public Boolean? PrihodRashod { get; set; }
        public Decimal? Iznos { get; set; }
        public DateTime? DatumVrijeme { get; set; }
        public String Opis { get; set; }

        public override string ToString()
        {
            return
                "[TransakcijaID=" + TransakcijaID +
                ", AktivnostID=" + AktivnostID +
                ", PrihodRashod=" + PrihodRashod +
                ", Iznos=" + Iznos +
                ", DatumVrijeme=" + DatumVrijeme.ToString() +
                ", Opis=" + Opis +
                "]";
        }



    }
}
