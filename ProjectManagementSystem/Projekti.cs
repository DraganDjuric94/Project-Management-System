using ProjectManagementSystem.dao.mysql;
using ProjectManagementSystem.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementSystem {
    public partial class Projekti : Form {

        public Ucesnik Ucesnik { get; set; }

        public Projekti(Ucesnik uc) {
            Ucesnik = uc;
            InitializeComponent();
        }

        private void Projekti_Load(object sender, EventArgs e) {
            updateTreeView();
        }

        private void dodajCjelinu(Cjelina cjelina, TreeNode parent, bool obicniUcesnik) {
            parent.Nodes.Add("c#" + cjelina.CjelinaID.ToString(), cjelina.Naziv, 1);
            TreeNode me = parent.Nodes.Find("c#" + cjelina.CjelinaID.ToString(), false)[0];
            Cjelina cjelinaZaPretragu = new Cjelina {
                CjelinaRoditeljID = cjelina.CjelinaID, Aktivna = true
            };
            List<Cjelina> podcjeline = MySqlCjelinaDao.Instance.Read(cjelinaZaPretragu);
            if (obicniUcesnik) {
                foreach(Cjelina c1 in podcjeline.ToArray()) {
                    if (!c1.Ucesnici.Contains(Ucesnik)){
                        podcjeline.Remove(c1);
                    }
                }
            }
            foreach(Cjelina c2 in podcjeline) {
                dodajCjelinu(c2, me, obicniUcesnik);
            }
            Aktivnost aktivnostZaPretragu = new Aktivnost {
                CjelinaID = cjelina.CjelinaID, Aktivna = true
            };
            List<Aktivnost> aktivnosti = MySqlAktivnostDao.Instance.Read(aktivnostZaPretragu);
            foreach(Aktivnost a in aktivnosti) {
                me.Nodes.Add("a#" + a.AktivnostID, a.Naziv, 0);
            }
        }

        private void projektiTVW_AfterSelect(object sender, TreeViewEventArgs e) {
            prikaziDetalje();
        }

        private void azrirajTSB_Click(object sender, EventArgs e) {
            TreeNode selected = projektiTVW.SelectedNode;
            if (selected.Name.StartsWith("p")) {
                if(MySqlProjekatDao.Instance.Read(new Projekat { ProjekatID = Convert.ToInt32(selected.Name.Split('#')[1]), Aktivan = true }).Count > 0)
                new SefProjekatFormular(MySqlProjekatDao.Instance.Read(new Projekat { ProjekatID = Convert.ToInt32(selected.Name.Split('#')[1]), Aktivan = true })[0]).ShowDialog();
            } else if (selected.Name.StartsWith("c")) {
                if (MySqlCjelinaDao.Instance.Read(new Cjelina { CjelinaID = Convert.ToInt32(selected.Name.Split('#')[1]), Aktivna = true }).Count > 0) {
                    Cjelina ova = MySqlCjelinaDao.Instance.Read(new Cjelina { CjelinaID = Convert.ToInt32(selected.Name.Split('#')[1]), Aktivna = true })[0];
                    new ZadatakFormular(ova, Convert.ToInt32(ova.ProjekatID), ova.CjelinaRoditeljID, true).ShowDialog();
                }
            } else if (selected.Name.StartsWith("a")) {
                if (MySqlAktivnostDao.Instance.Read(new Aktivnost { AktivnostID = Convert.ToInt32(selected.Name.Split('#')[1]), Aktivna = true }).Count > 0) {
                    Aktivnost ova = MySqlAktivnostDao.Instance.Read(new Aktivnost { AktivnostID = Convert.ToInt32(selected.Name.Split('#')[1]), Aktivna = true })[0];
                    new AktivnostFormular(ova, Convert.ToInt32(ova.CjelinaID), true).ShowDialog();
                }
            }
        }

        private void obrisiTSB_Click(object sender, EventArgs e) {
            BrisanjeForma dijalog = new BrisanjeForma();
            dijalog.ShowDialog();
            if (dijalog.DialogResult == DialogResult.Yes) {
                TreeNode selected = projektiTVW.SelectedNode;
                if (selected.Name.StartsWith("p")) {
                } else if (selected.Name.StartsWith("c")) {
                    if (MySqlCjelinaDao.Instance.Read(new Cjelina { Aktivna = true, CjelinaID = Convert.ToInt32(selected.Name.Split('#')[1]) }).Count > 0) {
                        Cjelina c = MySqlCjelinaDao.Instance.Read(new Cjelina { Aktivna = true, CjelinaID = Convert.ToInt32(selected.Name.Split('#')[1]) })[0];
                        int? ncid = c.CjelinaRoditeljID;
                        MySqlCjelinaDao.Instance.Delete(Convert.ToInt32(c.CjelinaID));
                        updateNadcjeline(ncid);
                    }
                } else if (selected.Name.StartsWith("a")) {
                    MySqlAktivnostDao.Instance.Delete(Convert.ToInt32(selected.Name.Split('#')[1]));
                    if (MySqlAktivnostDao.Instance.Read(new Aktivnost { Aktivna = true, AktivnostID = Convert.ToInt32(selected.Name.Split('#')[1]) }).Count > 0) {
                        Aktivnost a = MySqlAktivnostDao.Instance.Read(new Aktivnost { Aktivna = true, AktivnostID = Convert.ToInt32(selected.Name.Split('#')[1]) })[0];
                        int? ncid = a.CjelinaID;
                        MySqlCjelinaDao.Instance.Delete(Convert.ToInt32(a.AktivnostID));
                        updateNadcjeline(ncid);
                    }
                }
            } else {
            }
        }

        private void dodajZadatakTSB_Click(object sender, EventArgs e) {
            TreeNode selected = projektiTVW.SelectedNode;
            if (selected.Name.StartsWith("p")) {
                if(MySqlProjekatDao.Instance.Read(new Projekat {ProjekatID = Convert.ToInt32(selected.Name.Split('#')[1]), Aktivan = true }).Count > 0)
                new ZadatakFormular(null, Convert.ToInt32(selected.Name.Split('#')[1]), null,false).ShowDialog();
            } else if (selected.Name.StartsWith("c")) {
                if (MySqlCjelinaDao.Instance.Read(new Cjelina { CjelinaID = Convert.ToInt32(selected.Name.Split('#')[1]), Aktivna = true }).Count > 0) {
                    Cjelina cj = MySqlCjelinaDao.Instance.Read(new Cjelina { CjelinaID = Convert.ToInt32(selected.Name.Split('#')[1]), Aktivna = true })[0];
                    new ZadatakFormular(null, Convert.ToInt32(cj.ProjekatID), Convert.ToInt32(selected.Name.Split('#')[1]), false).ShowDialog();
                }
            } else if (selected.Name.StartsWith("a")) {
            }
        }

        private void dodajAktivnostTSB_Click(object sender, EventArgs e) {
            TreeNode selected = projektiTVW.SelectedNode;
            if (selected.Name.StartsWith("p")) {
            } else if (selected.Name.StartsWith("c")) {
                if (MySqlCjelinaDao.Instance.Read(new Cjelina { CjelinaID = Convert.ToInt32(selected.Name.Split('#')[1]), Aktivna = true }).Count > 0)
                new AktivnostFormular(null, Convert.ToInt32(selected.Name.Split('#')[1]),false).ShowDialog();
            } else if (selected.Name.StartsWith("a")) {
            }
        }

        private void prikaziIzvjestajTSB_Click(object sender, EventArgs e) {
            TreeNode selected = projektiTVW.SelectedNode;
            if (MySqlProjekatDao.Instance.Read(new Projekat { ProjekatID = Convert.ToInt32(selected.Name.Split('#')[1]), Aktivan = true }).Count > 0) {
                if (selected.Name.StartsWith("p")) {
                    new IzvjestajForma(MySqlProjekatDao.Instance.Read(new Projekat { ProjekatID = Convert.ToInt32(selected.Name.Split('#')[1]), Aktivan = true })[0]).ShowDialog();
                } else if (selected.Name.StartsWith("c")) {
                } else if (selected.Name.StartsWith("a")) {
                }
            }
        }

        private void dodajUcesnikaTSB_Click(object sender, EventArgs e) {
            TreeNode selected = projektiTVW.SelectedNode;
            if (selected.Name.StartsWith("p")) {
                if(MySqlProjekatDao.Instance.Read(new Projekat { ProjekatID = Convert.ToInt32(selected.Name.Split('#')[1]), Aktivan = true }).Count > 0)
                new DodajUcesnikaForma(MySqlProjekatDao.Instance.Read(new Projekat { ProjekatID = Convert.ToInt32(selected.Name.Split('#')[1]) })[0], null).ShowDialog();
            } else if (selected.Name.StartsWith("c")) {
                if(MySqlCjelinaDao.Instance.Read(new Cjelina { CjelinaID = Convert.ToInt32(selected.Name.Split('#')[1]), Aktivna = true }).Count > 0)
                new DodajUcesnikaForma(null, MySqlCjelinaDao.Instance.Read(new Cjelina { CjelinaID = Convert.ToInt32(selected.Name.Split('#')[1]) })[0]).ShowDialog();
            } else if (selected.Name.StartsWith("a")) {
            }
        }

        public static void updateNadcjeline(int? ncid) {
            int? id = ncid;
            while (id != null) {
                if (MySqlCjelinaDao.Instance.Read(new Cjelina { Aktivna = true, CjelinaID = id }).Count > 0) {
                    Cjelina c = MySqlCjelinaDao.Instance.Read(new Cjelina { Aktivna = true, CjelinaID = id })[0];
                    int proc = 0;
                    int potrebnoCC = 0;
                    double zavrseno = 0;
                    foreach (Cjelina cj in c.Podcjeline) {
                        potrebnoCC += Convert.ToInt32(cj.BrojPotrebnihCovjekCasova);
                        zavrseno += ((double)Convert.ToInt32(cj.ProcenatIzvrsenosti) * 0.01 * (double)Convert.ToInt32(cj.BrojPotrebnihCovjekCasova));
                    }

                    int brojAktivnosti = 0;
                    foreach(Aktivnost a in c.Aktivnosti) {
                        if(a.Aktivna == true) {
                            brojAktivnosti++;
                        }
                    }
                    int potrebnoZaPodcjeline = 0;
                    foreach(Cjelina pc in c.Podcjeline) {
                        if(pc.Aktivna == true) {
                            potrebnoZaPodcjeline += Convert.ToInt32(pc.BrojPotrebnihCovjekCasova);
                        }
                    }
                    if (brojAktivnosti > 0) {
                        int? brojPreostalihCC = c.BrojPotrebnihCovjekCasova - potrebnoZaPodcjeline;
                        if (brojPreostalihCC > 0) {
                            foreach (Aktivnost ak in c.Aktivnosti) {
                                if (ak.Aktivna == true) {
                                    if (ak.Zavrsena == true) {
                                        zavrseno += (int)((double)brojPreostalihCC / (double)brojAktivnosti);
                                        potrebnoCC += (int)((double)brojPreostalihCC / (double)brojAktivnosti);
                                    } else {
                                            potrebnoCC += (int)((double)brojPreostalihCC / (double)brojAktivnosti);
                                    }
                                }
                            }
                        }
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

        private void updateTreeView() {
            projektiTVW.Nodes.Clear();
            List<Projekat> projekti = MySqlProjekatDao.Instance.ReadProjekatByUcesnikID(Ucesnik);
            Uloga uloga = null;
            foreach (Projekat p in projekti) {
                if (p.UcesniciNaProjektu.ContainsKey(Ucesnik) && p.Aktivan == true) {
                    if (p.UcesniciNaProjektu.TryGetValue(Ucesnik, out uloga) && (uloga.Naziv.Equals("sef") || uloga.Naziv.Equals("nadzor"))) {
                        Console.WriteLine("Projekat: " + p.Naziv + " Uloga: nadzor ili sef");
                        projektiTVW.Nodes.Add("p#" + p.ProjekatID.ToString(), p.Naziv, 2); //dodaj projekat u tree view
                        TreeNode me = projektiTVW.Nodes.Find("p#" + p.ProjekatID.ToString(), false)[0];
                        Cjelina cjelinaZaPretragu = new Cjelina {
                            ProjekatID = p.ProjekatID, Aktivna = true
                        };
                        List<Cjelina> cjeline = MySqlCjelinaDao.Instance.Read(cjelinaZaPretragu);
                        foreach (Cjelina c in cjeline) {
                            if (c.CjelinaRoditeljID == null) {
                                dodajCjelinu(c, me, false);
                            }
                        }

                    } else if (p.UcesniciNaProjektu.TryGetValue(Ucesnik, out uloga) && uloga.Naziv.Equals("ucesnik")) {
                        Console.WriteLine("Projekat: " + p.Naziv + " Uloga: ucesnik");
                        projektiTVW.Nodes.Add("p#" + p.ProjekatID.ToString(), p.Naziv, 2); //dodaj projekat u tree view
                        TreeNode me = projektiTVW.Nodes.Find("p#" + p.ProjekatID.ToString(), false)[0];
                        Cjelina cjelinaZaPretragu = new Cjelina {
                            ProjekatID = p.ProjekatID, Aktivna = true
                        };
                        List<Cjelina> cjeline = MySqlCjelinaDao.Instance.Read(cjelinaZaPretragu);
                        foreach (Cjelina c1 in cjeline.ToArray()) {
                            if (!c1.Ucesnici.Contains(Ucesnik)) {
                                cjeline.Remove(c1);
                                Console.WriteLine(c1.Naziv);
                            }
                        }
                        foreach (Cjelina c2 in cjeline) {
                            if (c2.CjelinaRoditeljID == null) {
                                dodajCjelinu(c2, me, true);
                            }
                        }
                    } else {
                        Application.Exit();
                    }
                } else {
                    //nista
                }
            }
        }

        private void updateTSB_Click(object sender, EventArgs e) {
            updateTreeView();
        }

        private void prikaziDetalje() {
            TreeNode selected = projektiTVW.SelectedNode;
            String ulogaUcesnika = "";
            TreeNode temp = selected;
            while (temp.Parent != null) {
                temp = temp.Parent;
            }
            Console.WriteLine(temp.Name);
            String izabraniId = temp.Name.Split('#')[1];
            if (MySqlProjekatDao.Instance.Read(new Projekat { ProjekatID = Convert.ToInt32(izabraniId), Aktivan = true }).Count > 0) {
                Projekat izabraniProjekat = MySqlProjekatDao.Instance.Read(new Projekat { ProjekatID = Convert.ToInt32(izabraniId), Aktivan = true })[0];
                if (izabraniProjekat.UcesniciNaProjektu.Keys.Contains(Ucesnik)) {
                    ulogaUcesnika = izabraniProjekat.UcesniciNaProjektu[Ucesnik].Naziv;
                } else return;

                if (selected.Name.StartsWith("p")) {
                    if (ulogaUcesnika.Equals("sef")) {
                        detaljiPNL.Controls.Clear();
                        detaljiPNL.Controls.Add(new SefNadzorProjekatDetalji(izabraniProjekat));
                        azrirajTSB.Enabled = true;
                        obrisiTSB.Enabled = false;
                        dodajAktivnostTSB.Enabled = false;
                        dodajZadatakTSB.Enabled = true;
                        prikaziIzvjestajTSB.Enabled = true;
                        dodajUcesnikaTSB.Enabled = true;
                    } else if (ulogaUcesnika.Equals("ucesnik")) {
                        detaljiPNL.Controls.Clear();
                        azrirajTSB.Enabled = false;
                        obrisiTSB.Enabled = false;
                        dodajAktivnostTSB.Enabled = false;
                        dodajZadatakTSB.Enabled = false;
                        prikaziIzvjestajTSB.Enabled = false;
                        dodajUcesnikaTSB.Enabled = false;
                        detaljiPNL.Controls.Add(new UcesnikProjekatDetalji(izabraniProjekat));
                    } else if (ulogaUcesnika.Equals("nadzor")) {
                        detaljiPNL.Controls.Clear();
                        detaljiPNL.Controls.Add(new SefNadzorProjekatDetalji(izabraniProjekat));
                        azrirajTSB.Enabled = false;
                        obrisiTSB.Enabled = false;
                        dodajAktivnostTSB.Enabled = false;
                        dodajZadatakTSB.Enabled = false;
                        prikaziIzvjestajTSB.Enabled = true;
                        dodajUcesnikaTSB.Enabled = false;
                    }
                } else if (selected.Name.StartsWith("c")) {
                    if (MySqlCjelinaDao.Instance.Read(new Cjelina { CjelinaID = Convert.ToInt32(selected.Name.Split('#')[1]), Aktivna = true }).Count > 0) {
                        Cjelina izabranaCjelina = MySqlCjelinaDao.Instance.Read(new Cjelina { CjelinaID = Convert.ToInt32(selected.Name.Split('#')[1]), Aktivna = true })[0];
                        detaljiPNL.Controls.Clear();
                        detaljiPNL.Controls.Add(new ZadatakDetalji(izabranaCjelina));
                        if (ulogaUcesnika.Equals("sef")) {
                            azrirajTSB.Enabled = true;
                            obrisiTSB.Enabled = true;
                            dodajAktivnostTSB.Enabled = true;
                            dodajZadatakTSB.Enabled = true;
                            prikaziIzvjestajTSB.Enabled = false;
                            dodajUcesnikaTSB.Enabled = true;
                        } else if (ulogaUcesnika.Equals("ucesnik")) {
                            azrirajTSB.Enabled = false;
                            obrisiTSB.Enabled = false;
                            dodajAktivnostTSB.Enabled = true;
                            dodajZadatakTSB.Enabled = false;
                            prikaziIzvjestajTSB.Enabled = false;
                            dodajUcesnikaTSB.Enabled = false;
                        } else if (ulogaUcesnika.Equals("nadzor")) {
                            azrirajTSB.Enabled = false;
                            obrisiTSB.Enabled = false;
                            dodajAktivnostTSB.Enabled = false;
                            dodajZadatakTSB.Enabled = false;
                            prikaziIzvjestajTSB.Enabled = false;
                            dodajUcesnikaTSB.Enabled = false;
                        }
                    }
                } else if (selected.Name.StartsWith("a")) {
                    if (MySqlAktivnostDao.Instance.Read(new Aktivnost { AktivnostID = Convert.ToInt32(selected.Name.Split('#')[1]), Aktivna = true }).Count > 0) {
                        Aktivnost izabranaAktivnost = MySqlAktivnostDao.Instance.Read(new Aktivnost { AktivnostID = Convert.ToInt32(selected.Name.Split('#')[1]), Aktivna = true })[0];
                        if (ulogaUcesnika.Equals("sef")) {
                            detaljiPNL.Controls.Clear();
                            azrirajTSB.Enabled = true;
                            obrisiTSB.Enabled = true;
                            dodajAktivnostTSB.Enabled = false;
                            dodajZadatakTSB.Enabled = false;
                            prikaziIzvjestajTSB.Enabled = false;
                            dodajUcesnikaTSB.Enabled = false;
                            detaljiPNL.Controls.Add(new SefUcesnikAktivnostDetalji(izabranaAktivnost, Ucesnik));
                        } else if (ulogaUcesnika.Equals("ucesnik")) {
                            detaljiPNL.Controls.Clear();
                            azrirajTSB.Enabled = true;
                            obrisiTSB.Enabled = true;
                            dodajAktivnostTSB.Enabled = false;
                            dodajZadatakTSB.Enabled = false;
                            prikaziIzvjestajTSB.Enabled = false;
                            dodajUcesnikaTSB.Enabled = false;
                            detaljiPNL.Controls.Add(new SefUcesnikAktivnostDetalji(izabranaAktivnost, Ucesnik));
                        } else if (ulogaUcesnika.Equals("nadzor")) {
                            detaljiPNL.Controls.Clear();
                            azrirajTSB.Enabled = false;
                            obrisiTSB.Enabled = false;
                            dodajAktivnostTSB.Enabled = false;
                            dodajZadatakTSB.Enabled = false;
                            prikaziIzvjestajTSB.Enabled = false;
                            dodajUcesnikaTSB.Enabled = false;
                            detaljiPNL.Controls.Add(new NadzorAktivnostDetalji(izabranaAktivnost));
                        }
                    }
                }
            }
        }

        private void a_Click(object sender, EventArgs e) {
            if(projektiTVW.SelectedNode != null) {
                prikaziDetalje();   
            }
        }
    }
}
