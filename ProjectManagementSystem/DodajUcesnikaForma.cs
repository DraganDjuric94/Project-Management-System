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
    public partial class DodajUcesnikaForma : Form {
        private Cjelina cjelina;
        private Projekat projekat;
        public DodajUcesnikaForma(Projekat pr, Cjelina cj) {
            InitializeComponent();
            projekat = pr;
            cjelina = cj;
            if(pr != null) {
                List<Ucesnik> ucesniciVanProjekta = new List<Ucesnik>();
                Uloga korisnik = MySqlUlogaDao.Instance.Read(new Uloga { Naziv = "korisnik" })[0];
                foreach (Ucesnik uc in MySqlUcesnikDao.Instance.Read(new Ucesnik { Aktivan = true })) {
                    if (!pr.UcesniciNaProjektu.Keys.Contains(uc) && (uc.Uloga.Naziv.Equals(korisnik.Naziv))) {
                        ucesniciVanProjekta.Add(uc);
                    }
                }
                foreach(Ucesnik u in ucesniciVanProjekta) {
                    moguciUcesniciCBX.Items.Add(u.Ime + " " + u.Prezime + " \"" + u.KorisnickoIme + "\"");
                }
            } else if(cj != null) {
                List<Ucesnik> ucesniciVanProjekta = new List<Ucesnik>();
                if (cj.CjelinaRoditeljID == null) {
                    Projekat p = MySqlProjekatDao.Instance.Read(new Projekat { ProjekatID = cj.ProjekatID })[0];
                    foreach (Ucesnik uc in p.UcesniciNaProjektu.Keys) {
                        if (!cj.Ucesnici.Contains(uc) && (p.UcesniciNaProjektu[uc].Naziv.Equals("ucesnik"))) {
                            ucesniciVanProjekta.Add(uc);
                        }
                    }
                    foreach(Ucesnik u in ucesniciVanProjekta) {
                        moguciUcesniciCBX.Items.Add(u.Ime + " " + u.Prezime + " \"" + u.KorisnickoIme + "\"");
                    }
                } else {
                    Cjelina nadcjelina = MySqlCjelinaDao.Instance.Read(new Cjelina { CjelinaID = cj.CjelinaRoditeljID })[0];
                    Projekat p = MySqlProjekatDao.Instance.Read(new Projekat { ProjekatID = nadcjelina.ProjekatID })[0];
                    foreach (Ucesnik uc in nadcjelina.Ucesnici) {
                        if (!cj.Ucesnici.Contains(uc) && (p.UcesniciNaProjektu[uc].Naziv.Equals("ucesnik"))) {
                            ucesniciVanProjekta.Add(uc);
                        }
                    }
                }
            } else {
                this.Close();
            }
        }

        private void dodajBTN_Click(object sender, EventArgs e) {
            if (validanUnos()) {
                if (moguciUcesniciCBX.SelectedItem != null) {
                    String korIme = moguciUcesniciCBX.SelectedItem.ToString().Split('"')[1];
                    Ucesnik uc = MySqlUcesnikDao.Instance.Read(new Ucesnik { KorisnickoIme = korIme })[0];
                    Uloga ul = MySqlUlogaDao.Instance.Read(new Uloga { Naziv = "ucesnik" })[0];
                    if (projekat != null) {
                        projekat.UcesniciNaProjektu.Add(uc, ul);
                        MySqlProjekatDao.Instance.Update(projekat);
                        this.Close();
                    } else if (cjelina != null) {
                        cjelina.Ucesnici.Add(uc);
                        MySqlCjelinaDao.Instance.Update(cjelina);
                        this.Close();
                    }
                }
            } else {
                errorLBL.Visible = true;
            }
        }

        private bool validanUnos() {
            if (moguciUcesniciCBX.SelectedItem != null)
                return true;
            return false;

        }
    }
}
