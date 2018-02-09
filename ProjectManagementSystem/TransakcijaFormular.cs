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
    public partial class TransakcijaFormular : Form {
        private Aktivnost aktivnost;
        private Transakcija transakcija;
        private bool edit;

        public TransakcijaFormular(Aktivnost ak, Transakcija tr, bool edit) {
            InitializeComponent();
            transakcija = new Transakcija();
            aktivnost = ak;
            this.edit = edit;
            if (edit) {
                transakcija = tr;
                opisTBX.Text = tr.Opis;
                if (tr.PrihodRashod == true) {
                    prihodRBT.Checked = true;
                    rashodRBT.Checked = false;
                } else {
                    prihodRBT.Checked = false;
                    rashodRBT.Checked = true;
                }
                iznosTBX.Text = Convert.ToDecimal(tr.Iznos).ToString();
                datumTransakcijeDTP.Value = tr.DatumVrijeme.Value;
            } else { }

        }

        private void sacuvajBTN_Click(object sender, EventArgs e) {
            transakcija.Opis = opisTBX.Text;
            transakcija.DatumVrijeme = datumTransakcijeDTP.Value;
            transakcija.Iznos = Convert.ToDecimal(iznosTBX.Text);
            if (prihodRBT.Checked == true) {
                transakcija.PrihodRashod = true;
            } else {
                transakcija.PrihodRashod = false;
            }
            transakcija.AktivnostID = aktivnost.AktivnostID;
            if (edit) {
                MySqlTransakcijaDao.Instance.Update(transakcija);
            } else {
                MySqlTransakcijaDao.Instance.Create(transakcija);
            }
        }
    }
}
