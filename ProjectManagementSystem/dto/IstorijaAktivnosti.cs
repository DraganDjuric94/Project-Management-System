using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.dto
{
    public class IstorijaAktivnosti
    {
        public Int32? IstorijaAktivnostiID { get; set; }
        public Int32? CjelinaID { get; set; }
        public String Opis { get; set; }
        public DateTime? Datum { get; set; }

        public override string ToString()
        {
            return
                "[" +
                "IstorijaAktivnostiID=" + IstorijaAktivnostiID +
                ", CjelinaID=" + CjelinaID +
                ", Opis=" + Opis +
                ", Datum=" + Datum +
                "]";
        }
    }
}
