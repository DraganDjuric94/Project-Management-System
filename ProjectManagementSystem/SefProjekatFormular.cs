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
    public partial class SefProjekatFormular : Form {
        private Projekat projekat;
        public SefProjekatFormular(Projekat pr) {
            InitializeComponent();
            if(pr != null) {
                projekat = pr;
                nazivProjektaTBX.Text = pr.Naziv;
                List<Ucesnik> ucesniciNaProjektu = new List<Ucesnik>();
                ucesniciNaProjektu.AddRange(pr.UcesniciNaProjektu.Keys);
                List<Ucesnik> ucesniciVanProjekta = new List<Ucesnik>();
                if (MySqlUlogaDao.Instance.Read(new Uloga { Naziv = "korisnik" }).Count > 0) {
                    Uloga korisnik = MySqlUlogaDao.Instance.Read(new Uloga { Naziv = "korisnik" })[0];
                    foreach (Ucesnik uc in MySqlUcesnikDao.Instance.Read(new Ucesnik { Aktivan = true })) {
                        if (!ucesniciNaProjektu.Contains(uc) && (uc.Uloga.Naziv.Equals(korisnik.Naziv))) {
                            ucesniciVanProjekta.Add(uc);
                        }
                    }
                    foreach (Ucesnik uc in ucesniciNaProjektu) {
                        if (!pr.UcesniciNaProjektu[uc].Naziv.Equals("sef")) {
                            string s = "";
                            if (pr.UcesniciNaProjektu[uc].Naziv.Equals("nadzor")) {
                                s = "Nadzor: ";
                            } else if (pr.UcesniciNaProjektu[uc].Naziv.Equals("ucesnik")) {
                                s = "Učesnik: ";
                            }
                            ucesniciNaProjektuLVW.Items.Add(s + uc.Ime + " " + uc.Prezime + " \"" + uc.KorisnickoIme + "\"");
                        }
                    }
                    foreach (Ucesnik uc in ucesniciVanProjekta) {
                        uceniciZaDodatiLVW.Items.Add(uc.Ime + " " + uc.Prezime + " \"" + uc.KorisnickoIme + "\"");
                    }
                }
            }
        }

        private void dodajBTN_Click(object sender, EventArgs e) {
            foreach(ListViewItem it in uceniciZaDodatiLVW.SelectedItems) {
                uceniciZaDodatiLVW.Items.Remove(it);
                string s = "";
                if (nadzorRBT.Checked) {
                    s = "Nadzor: ";
                } else {
                    s = "Učesnik: ";
                }
                it.Text = s + it.Text;
                ucesniciNaProjektuLVW.Items.Add(it);
            }
        }

        private void izbaciBTN_Click(object sender, EventArgs e) {
            foreach (ListViewItem it in ucesniciNaProjektuLVW.SelectedItems) {
                ucesniciNaProjektuLVW.Items.Remove(it);
                ListViewItem i = it;
                i.Text = it.Text.Substring(it.Text.IndexOf(':') + 2);
                uceniciZaDodatiLVW.Items.Add(i);
            }
        }

        private void sacuvajBTN_Click(object sender, EventArgs e) {
            if (projekat != null) {
                projekat.Naziv = nazivProjektaTBX.Text;
                Ucesnik sef = null;
                foreach (Ucesnik u in projekat.UcesniciNaProjektu.Keys) {
                    if (projekat.UcesniciNaProjektu[u].Naziv.Equals("sef")) {
                        sef = u;
                        break;
                    }
                }
                Dictionary<Ucesnik, Uloga> novi = new Dictionary<Ucesnik, Uloga>();
                novi.Add(sef, projekat.UcesniciNaProjektu[sef]);
                foreach (ListViewItem it in ucesniciNaProjektuLVW.Items) {
                    if (it.Text.Split('\"').Length > 1 && MySqlUcesnikDao.Instance.Read(new Ucesnik { KorisnickoIme = it.Text.Split('\"')[1] }).Count > 0) {
                        Ucesnik u = MySqlUcesnikDao.Instance.Read(new Ucesnik { KorisnickoIme = it.Text.Split('\"')[1] })[0];
                        Uloga ul = null;
                        if (it.Text.StartsWith("Nadzor")) {
                            ul = MySqlUlogaDao.Instance.Read(new Uloga { Naziv = "nadzor" })[0];
                        } else if (it.Text.StartsWith("Učesnik")) {
                            ul = MySqlUlogaDao.Instance.Read(new Uloga { Naziv = "ucesnik" })[0];
                        }
                        novi.Add(u, ul);
                    }
                    projekat.UcesniciNaProjektu = novi;
                    MySqlProjekatDao.Instance.Update(projekat);
                }
            }
        }
    }
}
