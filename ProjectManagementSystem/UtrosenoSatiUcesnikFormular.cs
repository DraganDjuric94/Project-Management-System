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
    public partial class UtrosenoSatiUcesnikFormular : Form {
        
        private bool edit = false;
        private int? cid = 0;
        private AktivnostFormular af = null;
        private KeyValuePair<Ucesnik, int> p;
        public UtrosenoSatiUcesnikFormular(AktivnostFormular af, int? cjelinaId, KeyValuePair<Ucesnik,int> pair, bool edit) {
            InitializeComponent();
            cid = cjelinaId;
            this.edit = edit;
            this.af = af;
            this.p = pair;
            if(edit) {
                ucesniciLVW.Enabled = false;
                utrosenoSatiNUD.Value = pair.Value;
            } else {
                if (MySqlCjelinaDao.Instance.Read(new Cjelina { CjelinaID = cid, Aktivna = true }).Count > 0) {
                    Cjelina c = MySqlCjelinaDao.Instance.Read(new Cjelina { CjelinaID = cid, Aktivna = true })[0];
                    foreach (Ucesnik u in c.Ucesnici) {
                        bool postoji = false;
                        foreach (ListViewItem it in af.Ucesnici.Items) {
                            if (it.Text.StartsWith(u.UcesnikID + ". " + u.Ime + " " + u.Prezime)) {
                                postoji = true;
                                break;
                            }
                        }
                        if (!postoji && !u.Uloga.Naziv.Equals("sef")) {
                            ucesniciLVW.Items.Add(u.UcesnikID + ". " + u.Ime + " " + u.Prezime);
                        }
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void sacuvajBTN_Click(object sender, EventArgs e) {
            if (edit) {
                if (MySqlUcesnikDao.Instance.Read(new Ucesnik { UcesnikID = Convert.ToInt32(af.Ucesnici.SelectedItems[0].Text.Split('.')[0]), Aktivan = true }).Count > 0) {
                    Ucesnik u = MySqlUcesnikDao.Instance.Read(new Ucesnik { UcesnikID = Convert.ToInt32(af.Ucesnici.SelectedItems[0].Text.Split('.')[0]), Aktivan = true })[0];
                    af.Ucesnici.Items.Remove(af.Ucesnici.SelectedItems[0]);
                    af.Ucesnici.Items.Add(p.Key.UcesnikID + ". " + p.Key.Ime + " " + p.Key.Prezime + " " + Convert.ToInt32(utrosenoSatiNUD.Value) + " sati");
                    if (af.Svi.ContainsKey(u)) {
                        af.Svi[u] = Convert.ToInt32(utrosenoSatiNUD.Value);
                    }
                }
            } else {
                if (MySqlUcesnikDao.Instance.Read(new Ucesnik { UcesnikID = Convert.ToInt32(ucesniciLVW.SelectedItems[0].Text.Split('.')[0]), Aktivan = true }).Count > 0) {
                    Ucesnik u = MySqlUcesnikDao.Instance.Read(new Ucesnik { UcesnikID = Convert.ToInt32(ucesniciLVW.SelectedItems[0].Text.Split('.')[0]), Aktivan = true })[0];
                    af.Ucesnici.Items.Add(u.UcesnikID + ". " + u.Ime + " " + u.Prezime + " " + Convert.ToInt32(utrosenoSatiNUD.Value) + " sati");
                    af.Svi.Add(u, (int)Convert.ToInt32(utrosenoSatiNUD.Value));
                }
            }
        }
    }
}
