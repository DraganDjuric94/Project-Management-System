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
            /*
            HashAlgorithm sha256 = new SHA256CryptoServiceProvider();
            string hashLozinke = "";
            Byte[] lozinka = Encoding.Unicode.GetBytes(lozinkaTXT.Text);
            Byte[] hesirano = sha256.ComputeHash(lozinka);
            hashLozinke = BitConverter.ToString(hesirano);
            if (!korisnickoImeTXT.Text.Equals("") && !lozinkaTXT.Text.Equals("")) {
                List<Ucesnik> ucesnik = MySqlUcesnikDao.Instance.Read(new Ucesnik { KorisnickoIme = korisnickoImeTXT.Text, Lozinka = hashLozinke, Aktivan = true });
                if (ucesnik.Count() == 0) {
                    MessageBox.Show("Korisnik sa unjetim informacijama ne postoji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else if (ucesnik[0].Uloga.Naziv.Equals("administrator")) {
                    new Administrator().Show();
                    this.Hide();
                } else if (ucesnik[0].Uloga.Naziv.Equals("korisnik")) {
                    new Projekti(ucesnik[0]).Show();
                    this.Hide();
                }
            }
            */
            new Administrator().Show();
        }

        private void testBTN_Click(object sender, EventArgs e) {
            Ucesnik uc = MySqlUcesnikDao.Instance.Read(new Ucesnik { UcesnikID = 1})[0];
            new Projekti(uc).Show();
        }
    }
}
