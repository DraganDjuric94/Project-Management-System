
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.org.unibl.etf.model.dto
{
    class Dokument
    {
        public Int32? DokumentID { get; set; }
        public Int32? UcesnikID { get; set; }
        public String Putanja { get; set; }
        public DateTime? DatumKreiranja { get; set; }
        public Boolean? Aktivan { get; set; }

        public List<Komentar> Komentari { get; set; }

        public List<RevizijaDokumenta> RevizijeDokumenta { get; set; }

        public override string ToString()
        {
            return
                "[" +
                "DokumentID=" + DokumentID +
                ", UcesnikID=" + UcesnikID +
                ", Putanja=" + Putanja +
                ", DatumKreiranja=" + DatumKreiranja +
                ", Aktivan=" + Aktivan +
                ", Komentari=" + String.Join(",", Komentari?.Select(komentar => komentar.ToString()).ToArray()) +
                ", RevizijeDokumenta=" + String.Join(",", RevizijeDokumenta?.Select(revizijaDokumenta => revizijaDokumenta.ToString()).ToArray()) +
                "]";
        }
    }
}
