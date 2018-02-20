using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectManagementSystem.dto;

namespace ProjectManagementSystem {
    public partial class UcesnikProjekatDetalji : UserControl {
        public UcesnikProjekatDetalji(Projekat pr) {
            InitializeComponent();
            nazivProjektaLBL.Text = pr.Naziv;
            int? procenatIzvrsenosti = 0, ukupnoPotrebnoCC = 0;
            foreach (Cjelina c in pr.Cjeline) {
                if (c.CjelinaRoditeljID == null && c.Aktivna == true) {
                    procenatIzvrsenosti += ((c.ProcenatIzvrsenosti / 100) * c.BrojPotrebnihCovjekCasova);
                    ukupnoPotrebnoCC += c.BrojPotrebnihCovjekCasova;
                }
            }
            int? n;
            if (ukupnoPotrebnoCC == 0) {
                n = 0;
            } else {
                n = (int?)((procenatIzvrsenosti / ukupnoPotrebnoCC) * 100);
            }
            procenatIzvrsenostiLBL.Text = n + "%";
            for (int i = 0; i < n; i++) {
                procenatIzvrsenostiPBR.PerformStep();
            }
            Ucesnik sef = null;
            foreach (KeyValuePair<Ucesnik, Uloga> uu in pr.UcesniciNaProjektu) {
                if (uu.Value.Naziv.Equals("sef")) {
                    sef = uu.Key;
                    break;
                }
            }
            if (sef != null) {
                sefProjektaLBL.Text = "Šef projekta: " + sef.Ime + " " + sef.Prezime;
            }
        }
    }
}
