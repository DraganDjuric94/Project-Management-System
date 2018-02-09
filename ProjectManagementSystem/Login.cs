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

namespace ProjectManagementSystem {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

		private void prijavaBTN_Click(object sender, EventArgs e)
		{
			/*List<Ucesnik> ucesnik = MySqlUcesnikDao.Instance.Read(new Ucesnik { KorisnickoIme = korisnickoImeTXT.Text, Lozinka = lozinkaTXT.Text });
			if (ucesnik.Count() == 0)
			{
				MessageBox.Show("Korisnik sa unjetim informacijama ne postoji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (ucesnik[0].Uloga.Naziv.Equals("administrator"))
			{
				new Administrator().Show();
			}
			else if (ucesnik[0].Uloga.Naziv.Equals("učesnik"))
			{

			}*/
			new Administrator().Show();
		}

        private void testBTN_Click(object sender, EventArgs e) {
            Ucesnik uc = MySqlUcesnikDao.Instance.Read(new Ucesnik { UcesnikID = 2})[0];
            new Projekti(uc).Show();
        }
    }
}
