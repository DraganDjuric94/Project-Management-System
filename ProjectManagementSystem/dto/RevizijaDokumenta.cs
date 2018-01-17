using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.dto
{
    class RevizijaDokumenta
    {
        public Int32? RevizijaDokumentaID { get; set; }
        public Int32? DokumentID { get; set; }
        public Int32? UcesnikID { get; set; }
        public DateTime? DatumVrijeme { get; set; }

        public override string ToString()
        {
            return
                "[" +
                "RevizijaDokumentaID=" + RevizijaDokumentaID +
                ", DokumentID=" + DokumentID +
                ", UcesnikID=" + UcesnikID +
                ", DatumVrijeme=" + DatumVrijeme +
                "]";
        }
    }
}
