﻿using System;
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
    public partial class SefUcesnikAktivnostDetalji : UserControl {
        Aktivnost aktivnost = new Aktivnost();
        Ucesnik ucesnik = new Ucesnik();

        public SefUcesnikAktivnostDetalji(Aktivnost ak, Ucesnik uc) {
            InitializeComponent();
            ucesnik = uc;
            aktivnost = ak;
            nazivAktivnostiLBL.Text = ak.Naziv;
            opisTBX.Text = ak.Opis;
            string zavrsena = (ak.Zavrsena == true) ? "završena" : "nezavršena";
            zavrsenaAktivnostStatusLBL.Text = "Status: " + zavrsena;
            foreach (Ucesnik u in ak.UcesniciSaBrojemUtrosenihSati.Keys) {
                ucesnikSatLVW.Items.Add(u.Ime + " " + u.Prezime + ", sati: " + ak.UcesniciSaBrojemUtrosenihSati[u]);
            }
            foreach (Transakcija t in ak.Transakcije) {
                char c = (t.PrihodRashod == true) ? '+' : '-';
                transakcijeLVW.Items.Add(t.TransakcijaID + "." + t.DatumVrijeme + "  " + c + t.Iznos);
            }
            List<Dokument> dokumenti = MySqlDokumentDao.Instance.Read(new Dokument { AktivnostID = ak.AktivnostID, Aktivan = true });
            foreach (Dokument d in dokumenti) {
                dokumentiLVW.Items.Add(d.DokumentID + "." + d.Putanja);
            }
        }

        private void dokumentiLVW_SelectedIndexChanged(object sender, EventArgs e) {
            if (dokumentiLVW.SelectedItems.Count > 0) {
                if (MySqlDokumentDao.Instance.Read(new Dokument { DokumentID = Convert.ToInt32(dokumentiLVW.SelectedItems[0].Text.Split('.')[0]), Aktivan = true }).Count > 0) {
                    Dokument d = MySqlDokumentDao.Instance.Read(new Dokument { DokumentID = Convert.ToInt32(dokumentiLVW.SelectedItems[0].Text.Split('.')[0]), Aktivan = true })[0];
                    if (MySqlUcesnikDao.Instance.Read(new Ucesnik { Aktivan = true, UcesnikID = d.UcesnikID }).Count > 0) {
                        Ucesnik u = MySqlUcesnikDao.Instance.Read(new Ucesnik { Aktivan = true, UcesnikID = d.UcesnikID })[0];
                        posljednjaIzmjenaLBL.Text = "Posljednja izmjena:\n" + d.DatumKreiranja.ToString() + "\n" + u.Ime + " " + u.Prezime;
                        napomenaDokumentLBL.Text = "Napomena:\n" + d.Napomena;
                    }
                }
            }
        }

        private void izmijeniDokumentBTN_Click(object sender, EventArgs e) {
            if (dokumentiLVW.SelectedItems.Count > 0) {
                if (MySqlDokumentDao.Instance.Read(new Dokument { DokumentID = Convert.ToInt32(dokumentiLVW.SelectedItems[0].Text.Split('.')[0]), Aktivan = true }).Count > 0) {
                    Dokument d = MySqlDokumentDao.Instance.Read(new Dokument { DokumentID = Convert.ToInt32(dokumentiLVW.SelectedItems[0].Text.Split('.')[0]), Aktivan = true })[0];
                    new DokumentFormular(aktivnost, ucesnik, d, true).ShowDialog();
                }
            }
        }

        private void dodajDokumentBTN_Click(object sender, EventArgs e) {
            new DokumentFormular(aktivnost, ucesnik, null, false).ShowDialog();
        }

        private void obrisiDokumentBTN_Click(object sender, EventArgs e) {
            if(dokumentiLVW.SelectedItems.Count > 0) {
                if (MySqlDokumentDao.Instance.Read(new Dokument { DokumentID = Convert.ToInt32(dokumentiLVW.SelectedItems[0].Text.Split('.')[0]), Aktivan = true }).Count > 0) {
                    Dokument d = MySqlDokumentDao.Instance.Read(new Dokument { DokumentID = Convert.ToInt32(dokumentiLVW.SelectedItems[0].Text.Split('.')[0]), Aktivan = true })[0];
                    MySqlDokumentDao.Instance.Delete(Convert.ToInt32(d.DokumentID));
                }
            }
        }

        private void izmijeniTransakcijuBTN_Click(object sender, EventArgs e) {
            if (transakcijeLVW.SelectedItems.Count > 0) {
                if (MySqlTransakcijaDao.Instance.Read(new Transakcija { TransakcijaID = Convert.ToInt32(transakcijeLVW.SelectedItems[0].Text.Split('.')[0]) }).Count > 0) {
                    Transakcija tr = MySqlTransakcijaDao.Instance.Read(new Transakcija { TransakcijaID = Convert.ToInt32(transakcijeLVW.SelectedItems[0].Text.Split('.')[0]) })[0];
                    new TransakcijaFormular(aktivnost, tr, true).ShowDialog();
                }
            }
        }

        private void dodajTransakcijuBTN_Click(object sender, EventArgs e) {
            new TransakcijaFormular(aktivnost, null, false).ShowDialog();
        }

        private void obrisiTransakcijuBTN_Click(object sender, EventArgs e) {
            if (transakcijeLVW.SelectedItems.Count > 0) {
                if (MySqlTransakcijaDao.Instance.Read(new Transakcija { TransakcijaID = Convert.ToInt32(transakcijeLVW.SelectedItems[0].Text.Split('.')[0]) }).Count > 0) {
                    Transakcija tr = MySqlTransakcijaDao.Instance.Read(new Transakcija { TransakcijaID = Convert.ToInt32(transakcijeLVW.SelectedItems[0].Text.Split('.')[0]) })[0];
                    MySqlTransakcijaDao.Instance.Delete(Convert.ToInt32(tr.TransakcijaID));
                }
            }
        }
    }
}
