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
    public partial class ZadatakFormular : Form
    {
        private Cjelina cjelina = new Cjelina();
        private bool edit = false;
        private int? pid = null;
        private int? ncid = null;
        public ZadatakFormular(Cjelina cj, Int32 projekatID, Int32? nadcjelinaID, bool edit)
        {
            InitializeComponent();
            this.edit = edit;
            pid = projekatID;
            ncid = nadcjelinaID;
            if (cj != null) {
                cjelina = cj;
                nazivTextBox.Text = cj.Naziv;
                rokDateTimePicker.Value = Convert.ToDateTime(cj.Rok);
                brojPotrebnihCovjekCasovaNumericUpDown.Value = Convert.ToInt32(cj.BrojPotrebnihCovjekCasova);
                foreach (Ucesnik u in cj.Ucesnici) {
                    ucesniciZadatkaListBox.Items.Add(u.Ime + " " + u.Prezime + " \"" + u.KorisnickoIme + "\"");
                }
                if (nadcjelinaID == null) {
                    foreach (Ucesnik u in MySqlProjekatDao.Instance.Read(new Projekat { ProjekatID = cj.ProjekatID, Aktivan = true })[0].UcesniciNaProjektu.Keys) {
                        if (!cj.Ucesnici.Contains(u)) {
                            dostupniUcesniciListBox.Items.Add(u.Ime + " " + u.Prezime + " \"" + u.KorisnickoIme + "\"");
                        }
                    }
                } else {
                    foreach (Ucesnik u in MySqlCjelinaDao.Instance.Read(new Cjelina { CjelinaID = nadcjelinaID, Aktivna = true })[0].Ucesnici) {
                        if (!cj.Ucesnici.Contains(u)) {
                            dostupniUcesniciListBox.Items.Add(u.Ime + " " + u.Prezime + " \"" + u.KorisnickoIme + "\"");
                        }
                    }
                }
            } else {
                if (nadcjelinaID == null) {
                    foreach (Ucesnik u in MySqlProjekatDao.Instance.Read(new Projekat { ProjekatID = projekatID, Aktivan = true })[0].UcesniciNaProjektu.Keys) {  
                        dostupniUcesniciListBox.Items.Add(u.Ime + " " + u.Prezime + " \"" + u.KorisnickoIme + "\"");
                    }
                } else {
                    foreach (Ucesnik u in MySqlCjelinaDao.Instance.Read(new Cjelina { CjelinaID = nadcjelinaID, Aktivna = true })[0].Ucesnici) {
                        dostupniUcesniciListBox.Items.Add(u.Ime + " " + u.Prezime + " \"" + u.KorisnickoIme + "\"");
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ubaciUcesnikaButton_Click(object sender, EventArgs e) {
            foreach(ListViewItem it in dostupniUcesniciListBox.SelectedItems) {
                dostupniUcesniciListBox.Items.Remove(it);
                ucesniciZadatkaListBox.Items.Add(it);
            }
        }

        private void izbaciUcesnikaButton_Click(object sender, EventArgs e) {
            foreach (ListViewItem it in ucesniciZadatkaListBox.SelectedItems) {
                ucesniciZadatkaListBox.Items.Remove(it);
                dostupniUcesniciListBox.Items.Add(it);
            }
        }

        private void sacuvajBTN_Click(object sender, EventArgs e) {
            cjelina.Naziv = nazivTextBox.Text;
            cjelina.ProcenatIzvrsenosti = Convert.ToInt32(procenatIzvrsenostiNUD.Value);
            cjelina.BrojPotrebnihCovjekCasova = Convert.ToInt32(brojPotrebnihCovjekCasovaNumericUpDown.Value);
            cjelina.Rok = rokDateTimePicker.Value;
            if (!edit) {
                cjelina.DatumKreiranja = DateTime.Now;
                cjelina.ProjekatID = pid;
                cjelina.CjelinaRoditeljID = ncid;
                cjelina.Aktivna = true;
                foreach(ListViewItem it in ucesniciZadatkaListBox.Items) {
                    cjelina.Ucesnici.Add(MySqlUcesnikDao.Instance.Read(new Ucesnik {KorisnickoIme = it.Text.Split('"')[1]})[0]);
                }
                MySqlCjelinaDao.Instance.Create(cjelina);
                updateNadcjeline();
            } else {
                cjelina.Ucesnici.Clear();
                foreach (ListViewItem it in ucesniciZadatkaListBox.Items) {
                    cjelina.Ucesnici.Add(MySqlUcesnikDao.Instance.Read(new Ucesnik { KorisnickoIme = it.Text.Split('"')[1] })[0]);
                }
                MySqlCjelinaDao.Instance.Update(cjelina);
                updateNadcjeline();
            }
        }

        private void updateNadcjeline() {
            int? id = ncid;
            while (id != null) {
                Cjelina c = MySqlCjelinaDao.Instance.Read(new Cjelina { Aktivna = true, CjelinaID = id })[0];
                int proc = 0;
                int potrebnoCC = 0;
                double zavrseno = 0;
                foreach (Cjelina cj in c.Podcjeline) {
                    potrebnoCC += Convert.ToInt32(cj.BrojPotrebnihCovjekCasova);
                    zavrseno += ((double)Convert.ToInt32(cj.ProcenatIzvrsenosti) * 0.01 * (double)Convert.ToInt32(cj.BrojPotrebnihCovjekCasova));
                }
                if (potrebnoCC != 0) {
                    proc = (int)(100.00 * (zavrseno / (double)potrebnoCC));
                } else proc = 0;
                c.ProcenatIzvrsenosti = proc;
                MySqlCjelinaDao.Instance.Update(c);
                id = c.CjelinaRoditeljID;
            }
        }
    }
}
