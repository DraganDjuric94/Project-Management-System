using ProjectManagementSystem.dao.mysql;
using ProjectManagementSystem.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementSystem {
    public partial class DokumentFormular : Form {
        private Dokument dokument = new Dokument();
        private bool edit = false;
        private OpenFileDialog validanFajl = null;
        private Aktivnost aktivnost = null;
        private Ucesnik ucesnik = null;

        public DokumentFormular(Aktivnost ak, Ucesnik u, Dokument d, bool edit) {
            InitializeComponent();
            this.edit = edit;
            aktivnost = ak;
            ucesnik = u;
            if (edit) {
                dokument = d;
                putanjaLBL.Text = d.Putanja;
                napomenaTBX.Text = d.Napomena;
            } else {

            }
        }

        private void sacuvajBTN_Click(object sender, EventArgs e) {
            if (validniPodaci()) {
                if (edit) {
                    if (validanFajl != null) {
                        string novaPutanja = "Dokumenti\\" + aktivnost.Naziv + DateTime.Now.ToString("yyMMddHHmmssff") + System.IO.Path.GetExtension(validanFajl.FileName);
                        System.IO.File.Copy(validanFajl.FileName, novaPutanja, true);
                        dokument.Putanja = novaPutanja;
                        dokument.DatumKreiranja = DateTime.Now;
                    }
                    dokument.UcesnikID = ucesnik.UcesnikID;
                    dokument.Napomena = napomenaTBX.Text;
                    if (dokument.RevizijeDokumenta == null) {
                        dokument.RevizijeDokumenta = new List<RevizijaDokumenta>();
                    }
                    dokument.RevizijeDokumenta.Add(new RevizijaDokumenta { DokumentID = dokument.DokumentID, UcesnikID = ucesnik.UcesnikID, DatumVrijeme = DateTime.Now });
                    MySqlDokumentDao.Instance.Update(dokument);
                    this.Close();
                } else {
                    if (validanFajl != null) {
                        string novaPutanja = "Dokumenti\\" + aktivnost.Naziv + DateTime.Now.ToString("yyMMddHHmmssff") + System.IO.Path.GetExtension(validanFajl.FileName);
                        System.IO.File.Copy(validanFajl.FileName, novaPutanja, true);
                        dokument.Putanja = novaPutanja;
                        dokument.Napomena = napomenaTBX.Text;
                        dokument.UcesnikID = ucesnik.UcesnikID;
                        dokument.AktivnostID = aktivnost.AktivnostID;
                        dokument.DatumKreiranja = DateTime.Now;
                        dokument.Aktivan = true;
                        dokument.RevizijeDokumenta = new List<RevizijaDokumenta>();
                        MySqlDokumentDao.Instance.Create(dokument);
                        this.Close();
                    }
                }
            } else {
                errorLBL.Visible = true;
            }
        }

        private void izaberiDokumentBTN_Click(object sender, EventArgs e) {
            OpenFileDialog fajl = new OpenFileDialog();
            if(fajl.ShowDialog() == DialogResult.OK) {
                validanFajl = fajl;
                putanjaLBL.Text = validanFajl.FileName;
            }
        }

        private bool validniPodaci() {
            if (!putanjaLBL.Text.Equals("") && !napomenaTBX.Equals(""))
                return true;
            return false;

        }
    }
}
