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
    public partial class Projekti : Form {

        public Ucesnik Ucesnik { get; set; }

        public Projekti(Ucesnik uc) {
            Ucesnik = uc;
            InitializeComponent();
        }

        private void Projekti_Load(object sender, EventArgs e) {
            List<Projekat> projekti = MySqlProjekatDao.Instance.ReadProjekatByUcesnikID(Ucesnik);
            Uloga uloga = null;
            foreach (Projekat p in projekti) {
                if (p.UcesniciNaProjektu.ContainsKey(Ucesnik)) {
                    if (p.UcesniciNaProjektu.TryGetValue(Ucesnik, out uloga) && (uloga.Naziv.Equals("sef") || uloga.Naziv.Equals("nadzor"))) {
                        Console.WriteLine("Projekat: " + p.Naziv + " Uloga: nadzor ili sef");
                        projektiTVW.Nodes.Add("p#" + p.ProjekatID.ToString(), p.Naziv, 2); //dodaj projekat u tree view
                        TreeNode me = projektiTVW.Nodes.Find("p#" + p.ProjekatID.ToString(), false)[0];
                        Cjelina cjelinaZaPretragu = new Cjelina {
                            ProjekatID = p.ProjekatID
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
                            ProjekatID = p.ProjekatID
                        };
                        List<Cjelina> cjeline = MySqlCjelinaDao.Instance.Read(cjelinaZaPretragu);
                        foreach (Cjelina c1 in cjeline.ToArray()) {
                            if (!c1.Ucesnici.Contains(Ucesnik)){
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

        private void dodajCjelinu(Cjelina cjelina, TreeNode parent, bool obicniUcesnik) {
            parent.Nodes.Add("c#" + cjelina.CjelinaID.ToString(), cjelina.Naziv, 1);
            TreeNode me = parent.Nodes.Find("c#" + cjelina.CjelinaID.ToString(), false)[0];
            Cjelina cjelinaZaPretragu = new Cjelina {
                CjelinaRoditeljID = cjelina.CjelinaID
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
                CjelinaID = cjelina.CjelinaID
            };
            List<Aktivnost> aktivnosti = MySqlAktivnostDao.Instance.Read(aktivnostZaPretragu);
            foreach(Aktivnost a in aktivnosti) {
                me.Nodes.Add("a#" + a.AktivnostID, a.Naziv, 0);
            }
        }

        private void projektiTVW_AfterSelect(object sender, TreeViewEventArgs e) {
            TreeNode selected = projektiTVW.SelectedNode;
            String ulogaUcesnika = "";
            TreeNode temp = selected;
            while (temp.Parent != null) {
                temp = temp.Parent;
            }
            Console.WriteLine(temp.Name);
            String izabraniId = temp.Name.Split('#')[1];
            Projekat izabraniProjekat = MySqlProjekatDao.Instance.Read(new Projekat { ProjekatID = Convert.ToInt32(izabraniId) })[0];
            ulogaUcesnika = izabraniProjekat.UcesniciNaProjektu[Ucesnik].Naziv;

            if (selected.Name.StartsWith("p")) {
                if (ulogaUcesnika.Equals("sef")) {
                    detaljiPNL.Controls.Clear();
                    detaljiPNL.Controls.Add(new SefNadzorProjekatDetalji(izabraniProjekat));
                } else if (ulogaUcesnika.Equals("ucesnik")) {
                    detaljiPNL.Controls.Clear();
                    detaljiPNL.Controls.Add(new UcesnikProjekatDetalji(izabraniProjekat));
                } else if (ulogaUcesnika.Equals("nadzor")) {
                    detaljiPNL.Controls.Clear();
                    detaljiPNL.Controls.Add(new SefNadzorProjekatDetalji(izabraniProjekat));
                }
            } else if (selected.Name.StartsWith("c")) {
                Cjelina izabranaCjelina = MySqlCjelinaDao.Instance.Read(new Cjelina { CjelinaID = Convert.ToInt32(selected.Name.Split('#')[1]) })[0];
                detaljiPNL.Controls.Clear();
                detaljiPNL.Controls.Add(new ZadatakDetalji(izabranaCjelina));
            } else if (selected.Name.StartsWith("a")) {
                Aktivnost izabranaAktivnost = MySqlAktivnostDao.Instance.Read(new Aktivnost { AktivnostID = Convert.ToInt32(selected.Name.Split('#')[1]) })[0];
                if (ulogaUcesnika.Equals("sef")) {
                    detaljiPNL.Controls.Clear();
                    detaljiPNL.Controls.Add(new SefUcesnikAktivnostDetalji(izabranaAktivnost));
                } else if (ulogaUcesnika.Equals("ucesnik")) {
                    detaljiPNL.Controls.Clear();
                    detaljiPNL.Controls.Add(new SefUcesnikAktivnostDetalji(izabranaAktivnost));
                } else if (ulogaUcesnika.Equals("nadzor")) {
                    detaljiPNL.Controls.Clear();
                    detaljiPNL.Controls.Add(new NadzorAktivnostDetalji(izabranaAktivnost));
                }
            }
        }
    }
}
