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

        private void projekat_Click(object sender, EventArgs e) {
            detaljiPNL.Controls.Clear();
            detaljiPNL.Controls.Add(new UcesnikProjekatDetalji());
        }

        private void zadatak_Click(object sender, EventArgs e) {
            detaljiPNL.Controls.Clear();
            Projekat pr = MySqlProjekatDao.Instance.ReadProjekatByUcesnikID(Ucesnik).First();
            detaljiPNL.Controls.Add(new SefNadzorProjekatDetalji(pr));
        }

        private void aktivnost_Click(object sender, EventArgs e) {
            detaljiPNL.Controls.Clear();
            detaljiPNL.Controls.Add(new SefUcesnikAktivnostDetalji());
        }
    }
}
