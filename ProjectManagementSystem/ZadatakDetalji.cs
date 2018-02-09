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
using ProjectManagementSystem.dao.mysql;

namespace ProjectManagementSystem {
    public partial class ZadatakDetalji : UserControl {
        public ZadatakDetalji(Cjelina cj) {
            InitializeComponent();
            nazivZadatkaLBL.Text = cj.Naziv;
            datumKreiranjaLBL.Text = cj.DatumKreiranja.ToString();
            rokLBL.Text = cj.Rok.ToString();
            covjekCasLBL.Text = cj.BrojPotrebnihCovjekCasova.ToString();
            foreach(Ucesnik u in cj.Ucesnici) {
                ucesniciLVW.Items.Add(u.Ime);
            }
            
           procenatZavrsenostiLBL.Text = cj.ProcenatIzvrsenosti + "%";
            
            for (int i = 0; i < cj.ProcenatIzvrsenosti; i++) {
                procenatZavrsenostiPBR.PerformStep();
            }

            List<IstorijaAktivnosti> istorija = MySqlIstorijaAktivnostiDao.Instance.Read(new IstorijaAktivnosti { CjelinaID = cj.CjelinaID });
            foreach(IstorijaAktivnosti ia in istorija) {
                istorijaAktivnostiLVW.Items.Add(ia.Datum + " " + ia.Opis);
            }
            
        }

    }
}
