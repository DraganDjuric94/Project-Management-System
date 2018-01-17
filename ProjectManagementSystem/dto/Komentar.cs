using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.dto
{
    class Komentar
    {
        public Int32? KomentarID { get; set; }
        public Int32? KomentarRoditeljID { get; set; }
        public Int32? UcesnikID { get; set; }
        public Int32? DokumentID { get; set; }
        public String Tekst { get; set; }
        public DateTime? DatumVrijeme { get; set; }
        public Boolean? Aktivan { get; set; }

        public List<Komentar> Podkomentari { get; set; }

        public Komentar() => Podkomentari = new List<Komentar>();

        public static void DeaktivirajKomentar(Komentar komentar)
        {
            komentar.Aktivan = false;

            foreach (Komentar podkomentar in komentar.Podkomentari)
            {
                DeaktivirajKomentar(komentar);
            }
        }

        public override string ToString()
        {
            return
                "[" +
                "KomentarID=" + KomentarID +
                ", KomentarRoditeljID=" + KomentarRoditeljID +
                ", UcesnikID=" + UcesnikID +
                ", DokumentID=" + DokumentID +
                ", Tekst=" + Tekst +
                ", DatumVrijeme=" + DatumVrijeme +
                ", Aktivan=" + Aktivan +
                ", Podkomentari=" + String.Join(",",Podkomentari?.Select(podkomentar => podkomentar.ToString()).ToArray()) +
                "]";
        }
    }
}
