
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.dto
{
    class Dokument
    {
        public Int32? DokumentID { get; set; }
        public Int32? UcesnikID { get; set; }
        public Int32? AktivnostID { get; set; }
        public String Putanja { get; set; }
        public DateTime? DatumKreiranja { get; set; }
        public String Napomena { get; set; }
        public Boolean? Aktivan { get; set; }

        public List<RevizijaDokumenta> RevizijeDokumenta { get; set; }

        public override string ToString()
        {
            return
                "[" +
                "DokumentID=" + DokumentID +
                ", UcesnikID=" + UcesnikID +
                ", AktivnostID=" + AktivnostID +
                ", Putanja=" + Putanja +
                ", DatumKreiranja=" + DatumKreiranja +
                ", Napomena=" + Napomena +
                ", Aktivan=" + Aktivan +
                ", RevizijeDokumenta=" + String.Join(",", RevizijeDokumenta?.Select(revizijaDokumenta => revizijaDokumenta.ToString()).ToArray()) +
                "]";
        }
    }
}
