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
    public partial class DetaljiTransakcije : Form {
        public DetaljiTransakcije(Transakcija tr) {
            InitializeComponent();
            if (tr != null) {
                opisTXT.Text = tr.Opis;
                datumLBL.Text = "Datum transakcije: " + tr.DatumVrijeme;
                string vrsta = (tr.PrihodRashod == true) ? "Prihod" : "Rashod";
                vrstaLBL.Text = "Vrsta transakcije: " + vrsta;
                iznosLBL.Text = "Iznos: " + tr.Iznos;
            }
        }

        private void zatvoriBTN_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
