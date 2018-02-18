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
    public partial class SefNadzorProjekatDetalji : UserControl {
        public SefNadzorProjekatDetalji(Projekat pr) {
            InitializeComponent();
            nazivProjektaLBL.Text = pr.Naziv;
            int procenatIzvrsenosti = 0, ukupnoPotrebnoCC = 0;
            foreach (Cjelina c in pr.Cjeline) {
                if (c.CjelinaRoditeljID == null && c.Aktivna == true) {
                    procenatIzvrsenosti += (int)(((double)c.ProcenatIzvrsenosti / 100.0) * c.BrojPotrebnihCovjekCasova);
                    ukupnoPotrebnoCC += (int)c.BrojPotrebnihCovjekCasova;
                    Console.WriteLine("PI: " + procenatIzvrsenosti + " UK:" + ukupnoPotrebnoCC);
                }
            }
            int procenat = 0;
            if(ukupnoPotrebnoCC != 0) {
                procenat = (int)(((double)procenatIzvrsenosti / ukupnoPotrebnoCC) * 100);
            }
            procenatIzvrsenostiLBL.Text = procenat + "%";
            for (int i = 0; i < procenat; i++) {
                procenatIzvrsenostiPBR.PerformStep();
            }
            datumKreiranjaLBL.Text = "Datum kreiranja: " + pr.DatumKreiranja;
            Ucesnik sef = null;
            foreach(KeyValuePair<Ucesnik, Uloga> uu in pr.UcesniciNaProjektu) {
                if (uu.Value.Naziv.Equals("sef")) {
                    sef = uu.Key;
                    break;
                }
            }
            if (sef != null) {
                sefProjektaLBL.Text = "Šef projekta: " + sef.Ime;
            }
            for (int i = 0; i < pr.UcesniciNaProjektu.Count; i++) {
                if (!pr.UcesniciNaProjektu[pr.UcesniciNaProjektu.ElementAt(i).Key].Naziv.Equals("sef")) {
                    Ucesnik u = pr.UcesniciNaProjektu.ElementAt(i).Key;
                    ucesniciLVW.Items.Add(u.Ime + " " + u.Prezime + " \"" + u.KorisnickoIme + "\"");
                }
            }
            foreach(Cjelina c in pr.Cjeline) {
                if(c.CjelinaRoditeljID == null) {
                    zadaciLVW.Items.Add(c.Naziv);
                }
            }
        }
    }
}
