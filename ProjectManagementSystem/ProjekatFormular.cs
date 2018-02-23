using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectManagementSystem.dao.mysql;
using ProjectManagementSystem.dto;

namespace ProjectManagementSystem
{
	public partial class ProjekatFormular : Form
	{
        private bool edit = false;
        private Projekat projekat = new Projekat();
        private string stariNaziv = "";
		public ProjekatFormular()
		{
			InitializeComponent();
		}

		private void dodatiBTN_Click(object sender, EventArgs e)
		{
			if (nazivKorektnoLBL.Text.Equals("korektno") && validniPodaci())
			{
                if (!edit) {
                    dodatiBTN.Enabled = false;
                    Dictionary<Ucesnik, Uloga> ucesnici = new Dictionary<Ucesnik, Uloga>();
                    List<Ucesnik> ucesnik = MySqlUcesnikDao.Instance.Read(new Ucesnik { KorisnickoIme = sefProjektaCB.Text });
                    List<Uloga> uloga = MySqlUlogaDao.Instance.Read(new Uloga { Naziv = "sef" });
                    ucesnici.Add(ucesnik[0], uloga[0]);
                    MySqlProjekatDao.Instance.Create(new Projekat { Naziv = nazivTXT.Text, DatumKreiranja = Convert.ToDateTime(DateTime.Now.ToString()), Aktivan = aktivanCBX.Checked, UcesniciNaProjektu = ucesnici });
                    MessageBox.Show("Projekat je uspješno unešen", "Obavještenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                } else {
                    if (MySqlProjekatDao.Instance.Read(new Projekat { ProjekatID = projekat.ProjekatID }).Count > 0) {
                        List<Projekat> projekti = MySqlProjekatDao.Instance.Read(new Projekat { ProjekatID = projekat.ProjekatID });
                        projekti[0].Naziv = nazivTXT.Text;
                        Ucesnik sef = null;
                        foreach (Ucesnik u in projekat.UcesniciNaProjektu.Keys) {
                            if (projekat.UcesniciNaProjektu[u].Naziv.Equals("sef")) {
                                sef = u;
                                break;
                            }
                        }
                        if (sef != null) {
                            if (MySqlUcesnikDao.Instance.Read(new Ucesnik { KorisnickoIme = sefProjektaCB.SelectedItem.ToString(), Aktivan = true }).Count > 0 && MySqlUlogaDao.Instance.Read(new Uloga { Naziv = "sef" }).Count > 0) {
                                Ucesnik noviSef = MySqlUcesnikDao.Instance.Read(new Ucesnik { KorisnickoIme = sefProjektaCB.SelectedItem.ToString() })[0];
                                Uloga sefovska = MySqlUlogaDao.Instance.Read(new Uloga { Naziv = "sef" })[0];

                                if (projekti[0].UcesniciNaProjektu.Keys.Contains(noviSef) && noviSef.UcesnikID != sef.UcesnikID) {
                                    projekti[0].UcesniciNaProjektu.Remove(noviSef);
                                    foreach (Cjelina c in projekti[0].Cjeline) {
                                        if (c.Ucesnici.Contains(noviSef)) {
                                            c.Ucesnici.Remove(noviSef);
                                            MySqlCjelinaDao.Instance.Update(c);
                                        }
                                    }
                                }
                                projekti[0].UcesniciNaProjektu.Remove(sef);
                                projekti[0].UcesniciNaProjektu.Add(noviSef, sefovska);
                                projekti[0].Aktivan = aktivanCBX.Checked;
                                MySqlProjekatDao.Instance.Update(projekti[0]);
                                MessageBox.Show("Projekat je uspješno ažuriran", "Obavještenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                        this.Close();
                    }
                }
            } else {
                errorLBL.Visible = true;
            }
		}

		private void nazivTXT_TextChanged(object sender, EventArgs e)
		{
			List<Projekat> projekti = MySqlProjekatDao.Instance.Read(new Projekat { Naziv = nazivTXT.Text });
			if (projekti.Count == 0 || (edit && nazivTXT.Text.Equals(stariNaziv)))
			{
				nazivKorektnoLBL.Text = "korektno";
			}
			else
			{
				nazivKorektnoLBL.Text = "nekorektno";
			}
		}

		private void sefProjektaCB_MouseClick(object sender, EventArgs e)
		{
            popuniComboBoxSef();
		}

        private bool validniPodaci() {
            if (!nazivTXT.Text.Equals("") && sefProjektaCB.SelectedItem != null)
                return true;
            return false;
        }

        private void popuniComboBoxSef() {
            List<Ucesnik> ucesnici = MySqlUcesnikDao.Instance.Read(new Ucesnik());
            sefProjektaCB.Items.Clear();
            foreach (Ucesnik ucesnik in ucesnici) {
                if (ucesnik.Aktivan == true && ucesnik.Uloga.Naziv.Equals("korisnik")) {
                    sefProjektaCB.Items.Add(ucesnik.KorisnickoIme);
                }
            }
        }

        public void SetValues(Int32 IDProjekat) {
            List<Projekat> projekti = MySqlProjekatDao.Instance.Read(new Projekat { ProjekatID = IDProjekat });
            if (projekti.Count > 0) {
                edit = true;
                projekat = projekti[0];
                aktivanCBX.Checked = Convert.ToBoolean(projekti[0].Aktivan);
                stariNaziv = projekti[0].Naziv;
                nazivTXT.Text = projekti[0].Naziv;
                popuniComboBoxSef();
                string sefKorIme = "";
                foreach(Ucesnik u in projekti[0].UcesniciNaProjektu.Keys) {
                    if (projekti[0].UcesniciNaProjektu[u].Naziv.Equals("sef")) {
                        sefKorIme = u.KorisnickoIme;
                        break;
                    }
                }
                foreach (String s in sefProjektaCB.Items) {
                    if (s.Equals(sefKorIme)) {
                        sefProjektaCB.SelectedItem = s;
                        break;
                    }
                }
                this.ShowDialog();
            }



        }

        private void provjeriPostojanje() {
            if(sefProjektaCB.SelectedItem != null && edit) {
                string izabraniSef = sefProjektaCB.SelectedItem.ToString();
                if(MySqlUcesnikDao.Instance.Read(new Ucesnik { KorisnickoIme = izabraniSef, Aktivan = true }).Count > 0) {
                    Ucesnik noviSef = MySqlUcesnikDao.Instance.Read(new Ucesnik { KorisnickoIme = izabraniSef, Aktivan = true })[0];
                    foreach(Ucesnik u in projekat.UcesniciNaProjektu.Keys) {
                        if(u.UcesnikID == noviSef.UcesnikID && !projekat.UcesniciNaProjektu[u].Naziv.Equals("sef")) {
                            MessageBox.Show("Izabrani korisnik već učestvuje na tom projektu. Akcija \"Sačuvaj\" će izbaciti datog korisnika sa svih zadataka na kojima je učestvovao i unaprijediti ga u šefa projekta. Ukoliko ovo nije željeni efekat, izaberite drugog šefa projekta", "Obavještenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    }
                }
            }
        }

        private void sefProjektaCB_SelectedIndexChanged(object sender, EventArgs e) {
            provjeriPostojanje();
        }
    }
}
