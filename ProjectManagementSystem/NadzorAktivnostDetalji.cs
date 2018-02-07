using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectManagementSystem.dto;
using ProjectManagementSystem.dao.mysql;

namespace ProjectManagementSystem {
    public partial class NadzorAktivnostDetalji : UserControl {
        public NadzorAktivnostDetalji(Aktivnost ak) {
            InitializeComponent();
            nazivAktivnostiLBL.Text = ak.Naziv;
            opisTBX.Text = ak.Opis;
            foreach(Ucesnik u in ak.UcesniciSaBrojemUtrosenihSati.Keys) {
                ucesnikSatLVW.Items.Add(u.Ime + "  " + ak.UcesniciSaBrojemUtrosenihSati[u]);
            }
            foreach(Transakcija t in ak.Transakcije) {
                char c = (t.PrihodRashod == true) ? '+' : '-';
                transakcijeLVW.Items.Add(t.DatumVrijeme + "  " + c + t.Iznos);
            }
            List<Dokument> dokumenti = MySqlDokumentDao.Instance.Read(new Dokument { AktivnostID = ak.AktivnostID, Aktivan = true });
            foreach(Dokument d in dokumenti) {
                dokumentiLVW.Items.Add(d.Putanja);
                //promijeniti u selection changed
                posljednjaIzmjenaLBL.Text = d.UcesnikID + d.DatumKreiranja.ToString();
                napomenaDokumentLBL.Text = d.Napomena;
            }
        }
    }
}
