using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectManagementSystem.dao.mysql;
using ProjectManagementSystem.dto;
using System.Security.Cryptography;

namespace ProjectManagementSystem {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

		private void prijavaBTN_Click(object sender, EventArgs e)
		{
            provjeriPrijavu();
        }

        private void provjeriPrijavu() {
            HashAlgorithm sha256 = new SHA256CryptoServiceProvider();
            string hashLozinke = "";
            Byte[] lozinka = Encoding.Unicode.GetBytes(lozinkaTXT.Text);
            Byte[] hesirano = sha256.ComputeHash(lozinka);
            hashLozinke = BitConverter.ToString(hesirano);
            if (!korisnickoImeTXT.Text.Equals("") && !lozinkaTXT.Text.Equals("")) {
                List<Ucesnik> ucesnik = MySqlUcesnikDao.Instance.Read(new Ucesnik { KorisnickoIme = korisnickoImeTXT.Text, Lozinka = hashLozinke, Aktivan = true });
                if (ucesnik.Count() == 0) {
                    MessageBox.Show("Korisnik sa unešenim informacijama ne postoji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else if (ucesnik[0].Uloga.Naziv.Equals("administrator")) {
                    new Administrator().Show();
                    this.Hide();
                } else if (ucesnik[0].Uloga.Naziv.Equals("korisnik")) {
                    new Projekti(ucesnik[0]).Show();
                    this.Hide();
                }
            }
        }

        private void lozinkaTXT_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                provjeriPrijavu();
            }
        }

        private void korisnickoImeTXT_Click(object sender, EventArgs e) {
            korisnickoImeTXT.SelectionStart = 0;
            korisnickoImeTXT.SelectionLength = korisnickoImeTXT.Text.Length;
        }

        private void lozinkaTXT_Click(object sender, EventArgs e) {
            lozinkaTXT.SelectionStart = 0;
            lozinkaTXT.SelectionLength = lozinkaTXT.Text.Length;
        }

        private void korisnickoImeTXT_Enter(object sender, EventArgs e) {
            korisnickoImeTXT.SelectionStart = 0;
            korisnickoImeTXT.SelectionLength = korisnickoImeTXT.Text.Length;
        }

        private void lozinkaTXT_Enter(object sender, EventArgs e) {
            lozinkaTXT.SelectionStart = 0;
            lozinkaTXT.SelectionLength = lozinkaTXT.Text.Length;
        }
    }
}
