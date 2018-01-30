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
            procenatIzvrsenostiLBL.Text = "32%";
            for (int i = 0; i < 32; i++) {
                procenatIzvrsenostiPBR.PerformStep();
            }
            datumKreiranjaLBL.Text = "Datum kreiranja: " + pr.DatumKreiranja;
            sefProjektaLBL.Text = "Sef projekta: JA";
            for (int i = 0; i < pr.UcesniciNaProjektu.Count; i++) {
                ucesniciLVW.Items.Add(pr.UcesniciNaProjektu.ElementAt(i).Key.Ime);
            }
        }
    }
}
