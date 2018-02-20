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

namespace ProjectManagementSystem
{
    public partial class AktivnostFormular : Form {
        private Aktivnost aktivnost = new Aktivnost();
        private bool edit = false;
        private int? cid = 0;
        public ListView Ucesnici { get; }
        public Dictionary<Ucesnik, int> Svi{ get; }
        public AktivnostFormular(Aktivnost ak, Int32 cjelinaID, bool edit)
        {
            InitializeComponent();
            Ucesnici = ucesniciListBox;
            Svi = new Dictionary<Ucesnik, int>();
            cid = cjelinaID;
            this.edit = edit;
            if(ak != null) {
                aktivnost = ak;
                Svi = ak.UcesniciSaBrojemUtrosenihSati;
                nazivTextBox.Text = ak.Naziv;
                foreach(KeyValuePair<Ucesnik,int> p in ak.UcesniciSaBrojemUtrosenihSati) {
                    ucesniciListBox.Items.Add(p.Key.UcesnikID + ". " + p.Key.Ime + " " + p.Key.Prezime + ", sati: " + p.Value);
                }
                opisRichTextBox.Text = ak.Opis;
                zavrsenaAktivnostCBX.Checked = Convert.ToBoolean(ak.Zavrsena);
            }
        }

        private void ucesceUcesnikaLBL_Click(object sender, EventArgs e)
        {

        }

        private void dodajButton_Click(object sender, EventArgs e) {
            new UtrosenoSatiUcesnikFormular(this, cid, new KeyValuePair<Ucesnik, int>(), false).ShowDialog();
        }

        private void izmijeniButton_Click(object sender, EventArgs e) {
            if (MySqlUcesnikDao.Instance.Read(new Ucesnik { UcesnikID = Convert.ToInt32(ucesniciListBox.SelectedItems[0].Text.Split('.')[0]), Aktivan = true }).Count > 0) {
                Ucesnik uc = MySqlUcesnikDao.Instance.Read(new Ucesnik { UcesnikID = Convert.ToInt32(ucesniciListBox.SelectedItems[0].Text.Split('.')[0]), Aktivan = true })[0];
                int val = 0;
                if (Svi.ContainsKey(uc)) {
                    val = Svi[uc];
                }
                KeyValuePair<Ucesnik, int> pair = new KeyValuePair<Ucesnik, int>(uc, val);
                new UtrosenoSatiUcesnikFormular(this, cid, pair, true).ShowDialog();
            }
        }

        private void obrisiButton_Click(object sender, EventArgs e) {
            foreach(ListViewItem it in ucesniciListBox.SelectedItems) {
                if (MySqlUcesnikDao.Instance.Read(new Ucesnik { UcesnikID = Convert.ToInt32(it.Text.Split('.')[0]), Aktivan = true }).Count > 0) {
                    ucesniciListBox.Items.Remove(it);
                    Ucesnik uc = MySqlUcesnikDao.Instance.Read(new Ucesnik { UcesnikID = Convert.ToInt32(it.Text.Split('.')[0]), Aktivan = true })[0];
                    if (Svi.ContainsKey(uc)) {
                        Svi.Remove(uc);
                    }
                }
            }
        }

        private void sacuvajBTN_Click(object sender, EventArgs e) {
            if (validniPodaci()) {
                sacuvajBTN.Enabled = false;
                aktivnost.Naziv = nazivTextBox.Text;
                aktivnost.UcesniciSaBrojemUtrosenihSati = Svi;
                aktivnost.CjelinaID = cid;
                aktivnost.Aktivna = true;
                aktivnost.Zavrsena = zavrsenaAktivnostCBX.Checked;
                aktivnost.Opis = opisRichTextBox.Text;
                if (edit) {
                    MySqlAktivnostDao.Instance.Update(aktivnost);
                    Projekti.updateNadcjeline(aktivnost.CjelinaID);
                    this.Close();
                } else {
                    MySqlAktivnostDao.Instance.Create(aktivnost);
                    Projekti.updateNadcjeline(aktivnost.CjelinaID);
                    this.Close();
                }
            } else {
                errorLBL.Visible = true;
            }
        }

        private bool validniPodaci() {
            if (!nazivTextBox.Text.Equals("") && !opisRichTextBox.Text.Equals("") && ucesniciListBox.Items.Count > 0)
                return true;
            return false;
        }
    }
}
