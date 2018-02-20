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
            string zavrsena = (ak.Zavrsena == true) ? "završena" : "nezavršena";
            zavrsenaAktivnostStatusLBL.Text = "Status: " + zavrsena;
            foreach (Ucesnik u in ak.UcesniciSaBrojemUtrosenihSati.Keys) {
                ucesnikSatLVW.Items.Add(u.Ime + " " + u.Prezime + ", sati: " + ak.UcesniciSaBrojemUtrosenihSati[u]);
            }
            foreach(Transakcija t in ak.Transakcije) {
                char c = (t.PrihodRashod == true) ? '+' : '-';
                transakcijeLVW.Items.Add(t.TransakcijaID + ". " +t.DatumVrijeme + "  " + c + t.Iznos);
            }
            List<Dokument> dokumenti = MySqlDokumentDao.Instance.Read(new Dokument { AktivnostID = ak.AktivnostID, Aktivan = true });
            foreach(Dokument d in dokumenti) {
                dokumentiLVW.Items.Add(d.Putanja);
                //promijeniti u selection changed
                
            }
        }

        private void dokumentiLVW_SelectedIndexChanged(object sender, EventArgs e) {
            String selektovani = dokumentiLVW.SelectedItems[0].Text;
            if (MySqlDokumentDao.Instance.Read(new Dokument { Aktivan = true, Putanja = selektovani }).Count > 0) {
                Dokument d = MySqlDokumentDao.Instance.Read(new Dokument { Aktivan = true, Putanja = selektovani })[0];
                if (MySqlUcesnikDao.Instance.Read(new Ucesnik { UcesnikID = d.UcesnikID, Aktivan = true }).Count > 0) {
                    Ucesnik u = MySqlUcesnikDao.Instance.Read(new Ucesnik { UcesnikID = d.UcesnikID, Aktivan = true })[0];
                    posljednjaIzmjenaLBL.Text = "Posljednja izmjena: \n" + d.DatumKreiranja.ToString() + "\n" + u.Ime + " " + u.Prezime;
                    napomenaDokumentLBL.Text = "Napomena> \n" + d.Napomena;
                }
            }
        }

        private void detaljiTransakcijeBTN_Click(object sender, EventArgs e) {
            if (transakcijeLVW.SelectedItems.Count > 0) {
                if (MySqlTransakcijaDao.Instance.Read(new Transakcija { TransakcijaID = Convert.ToInt32(transakcijeLVW.SelectedItems[0].Text.Split('.')[0]) }).Count > 0) {
                    Transakcija tr = MySqlTransakcijaDao.Instance.Read(new Transakcija { TransakcijaID = Convert.ToInt32(transakcijeLVW.SelectedItems[0].Text.Split('.')[0]) })[0];
                    new DetaljiTransakcije(tr).ShowDialog();
                }
            }
        }
    }
}
