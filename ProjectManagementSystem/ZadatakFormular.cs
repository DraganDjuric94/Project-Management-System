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
            if (this.edit && cj != null) {
                rokDateTimePicker.MinDate = Convert.ToDateTime(cj.DatumKreiranja);
            } else {
                rokDateTimePicker.MinDate = DateTime.Now;
            }
            
            if (nadcjelinaID == null) {
                brojPotrebnihCovjekCasovaNumericUpDown.Maximum = 100000;
            } else if(MySqlCjelinaDao.Instance.Read(new Cjelina { CjelinaID = nadcjelinaID, Aktivna = true }).Count > 0) {
                Cjelina nadcjelina = MySqlCjelinaDao.Instance.Read(new Cjelina { CjelinaID = nadcjelinaID, Aktivna = true })[0];
                int? max = nadcjelina.BrojPotrebnihCovjekCasova;
                foreach (Cjelina c in nadcjelina.Podcjeline) {
                    if (c.CjelinaRoditeljID == nadcjelina.CjelinaID && (cj == null || (cj != null && c.CjelinaID != cj.CjelinaID))) {
                        max -= c.BrojPotrebnihCovjekCasova;
                    }
                }
                brojPotrebnihCovjekCasovaNumericUpDown.Maximum = Convert.ToInt32(max);
            }
            if (cj != null) {
                cjelina = cj;
                nazivTextBox.Text = cj.Naziv;
                if (!cj.Rok.Value.Date.Equals(cj.DatumKreiranja.Value.Date)) {
                    rokDateTimePicker.Value = Convert.ToDateTime(cj.Rok);
                }
                if (cj.BrojPotrebnihCovjekCasova <= brojPotrebnihCovjekCasovaNumericUpDown.Maximum && cj.BrojPotrebnihCovjekCasova >= brojPotrebnihCovjekCasovaNumericUpDown.Minimum) {
                    brojPotrebnihCovjekCasovaNumericUpDown.Value = Convert.ToInt32(cj.BrojPotrebnihCovjekCasova);
                } else {
                    brojPotrebnihCovjekCasovaNumericUpDown.Value = brojPotrebnihCovjekCasovaNumericUpDown.Maximum;
                }
                foreach (Ucesnik u in cj.Ucesnici) {
                    ucesniciZadatkaListBox.Items.Add(u.Ime + " " + u.Prezime + " \"" + u.KorisnickoIme + "\"");
                }
                if (nadcjelinaID == null) {
                    if (MySqlProjekatDao.Instance.Read(new Projekat { ProjekatID = cj.ProjekatID, Aktivan = true }).Count > 0) {
                        Projekat proj = MySqlProjekatDao.Instance.Read(new Projekat { ProjekatID = cj.ProjekatID, Aktivan = true })[0];
                        foreach (Ucesnik u in proj.UcesniciNaProjektu.Keys) {
                            if (!cj.Ucesnici.Contains(u) && !proj.UcesniciNaProjektu[u].Naziv.Equals("sef")) {
                                dostupniUcesniciListBox.Items.Add(u.Ime + " " + u.Prezime + " \"" + u.KorisnickoIme + "\"");
                            }
                        }
                    }
                } else {
                    if (MySqlCjelinaDao.Instance.Read(new Cjelina { CjelinaID = nadcjelinaID, Aktivna = true }).Count > 0) {
                        if (MySqlCjelinaDao.Instance.Read(new Cjelina { CjelinaID = nadcjelinaID, Aktivna = true }).Count > 0) {
                            foreach (Ucesnik u in MySqlCjelinaDao.Instance.Read(new Cjelina { CjelinaID = nadcjelinaID, Aktivna = true })[0].Ucesnici) {
                                if (!cj.Ucesnici.Contains(u)) {
                                    dostupniUcesniciListBox.Items.Add(u.Ime + " " + u.Prezime + " \"" + u.KorisnickoIme + "\"");
                                }
                            }
                        }
                    }
                }
            } else {
                if (nadcjelinaID == null) {
                    if (MySqlProjekatDao.Instance.Read(new Projekat { ProjekatID = projekatID, Aktivan = true }).Count > 0) {
                        Projekat proj = MySqlProjekatDao.Instance.Read(new Projekat { ProjekatID = projekatID, Aktivan = true })[0];
                        foreach (Ucesnik u in proj.UcesniciNaProjektu.Keys) {
                            if (!proj.UcesniciNaProjektu[u].Naziv.Equals("sef")) {
                                dostupniUcesniciListBox.Items.Add(u.Ime + " " + u.Prezime + " \"" + u.KorisnickoIme + "\"");
                            }
                        }
                    }
                } else {
                    if (MySqlCjelinaDao.Instance.Read(new Cjelina { CjelinaID = nadcjelinaID, Aktivna = true }).Count > 0) {
                        foreach (Ucesnik u in MySqlCjelinaDao.Instance.Read(new Cjelina { CjelinaID = nadcjelinaID, Aktivna = true })[0].Ucesnici) {
                            dostupniUcesniciListBox.Items.Add(u.Ime + " " + u.Prezime + " \"" + u.KorisnickoIme + "\"");
                        }
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
            if (validanUnos()) {
                sacuvajBTN.Enabled = false;
                cjelina.Naziv = nazivTextBox.Text;
                cjelina.ProcenatIzvrsenosti = Convert.ToInt32(procenatIzvrsenostiNUD.Value);
                cjelina.BrojPotrebnihCovjekCasova = Convert.ToInt32(brojPotrebnihCovjekCasovaNumericUpDown.Value);
                cjelina.Rok = rokDateTimePicker.Value;
                if (!edit) {
                    cjelina.DatumKreiranja = DateTime.Now;
                    cjelina.ProjekatID = pid;
                    cjelina.CjelinaRoditeljID = ncid;
                    cjelina.Aktivna = true;
                    foreach (ListViewItem it in ucesniciZadatkaListBox.Items) {
                        if (MySqlUcesnikDao.Instance.Read(new Ucesnik { KorisnickoIme = it.Text.Split('"')[1], Aktivan = true }).Count > 0) {
                            cjelina.Ucesnici.Add(MySqlUcesnikDao.Instance.Read(new Ucesnik { KorisnickoIme = it.Text.Split('"')[1], Aktivan = true })[0]);
                        }
                    }
                    MySqlCjelinaDao.Instance.Create(cjelina);
                    Projekti.updateNadcjeline(ncid);
                    this.Close();
                } else {
                    cjelina.Ucesnici.Clear();
                    foreach (ListViewItem it in ucesniciZadatkaListBox.Items) {
                        if (MySqlUcesnikDao.Instance.Read(new Ucesnik { KorisnickoIme = it.Text.Split('"')[1], Aktivan = true }).Count > 0) {
                            cjelina.Ucesnici.Add(MySqlUcesnikDao.Instance.Read(new Ucesnik { KorisnickoIme = it.Text.Split('"')[1], Aktivan = true })[0]);
                        }
                    }
                    MySqlCjelinaDao.Instance.Update(cjelina);
                    Projekti.updateNadcjeline(this.ncid);
                    this.Close();
                }
            } else {
                errorLBL.Visible = true;
            }
        }

        private bool validanUnos() {
            if (!nazivTextBox.Text.Equals("") && rokDateTimePicker.Value != null && ucesniciZadatkaListBox.Items.Count > 0)
                return true;
            return false;
        }
    }
}
