﻿using System;
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
        public Projekti() {
            InitializeComponent();
        }

        private void projekat_Click(object sender, EventArgs e) {
            detaljiPNL.Controls.Clear();
            detaljiPNL.Controls.Add(new UcesnikProjekatDetalji());
        }

        private void zadatak_Click(object sender, EventArgs e) {
            detaljiPNL.Controls.Clear();
            detaljiPNL.Controls.Add(new UcesnikZadatakDetalji());
        }

        private void aktivnost_Click(object sender, EventArgs e) {
            detaljiPNL.Controls.Clear();
            detaljiPNL.Controls.Add(new UcesnikAktivnostDetalji());
        }
    }
}
