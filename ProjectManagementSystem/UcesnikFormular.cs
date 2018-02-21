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

namespace ProjectManagementSystem
{
	public partial class UčesnikFormular : Form
	{

		public Int32? UcesnikIDKontrolni { get; set; }
        private bool edit = false;
        private Ucesnik uc = new Ucesnik();
        private string staraLozinka = "";

		public UčesnikFormular()
		{
			UcesnikIDKontrolni = 0;
			InitializeComponent();
		}

		private void dodatiBTN_Click(object sender, EventArgs e)
		{
            if (validniPodaci() && korisnickoImeKorektnoLBL.Text.Equals("korektno")) {
                dodatiBTN.Enabled = false;
                if (UcesnikIDKontrolni == 0) {
                    List<Uloga> uloga = MySqlUlogaDao.Instance.Read(new Uloga { Naziv = nazivUlogeCB.Text });
                    HashAlgorithm sha256 = new SHA256CryptoServiceProvider();
                    string hashLozinke = "";
                    Byte[] lozinka = Encoding.Unicode.GetBytes(lozinkaTXT.Text);
                    Byte[] hesirano = sha256.ComputeHash(lozinka);
                    hashLozinke = BitConverter.ToString(hesirano);
                    MySqlUcesnikDao.Instance.Create(new Ucesnik { Ime = imeTXT.Text, Prezime = prezimeTXT.Text, KorisnickoIme = korisnickoImeTXT.Text, Lozinka = hashLozinke, Jmbg = jmbgTXT.Text, Aktivan = aktivanUcesnikCB.Checked, Uloga = uloga[0] });
                    MessageBox.Show("Korisnik je uspješno unešen", "Obavještenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                } else if (UcesnikIDKontrolni != 0) {
                    if (MySqlUcesnikDao.Instance.Read(new Ucesnik { UcesnikID = UcesnikIDKontrolni }).Count > 0) {
                        List<Ucesnik> ucesnik = MySqlUcesnikDao.Instance.Read(new Ucesnik { UcesnikID = UcesnikIDKontrolni });
                        HashAlgorithm sha256 = new SHA256CryptoServiceProvider();
                        string hashLozinke = "";
                        Byte[] lozinka = Encoding.Unicode.GetBytes(lozinkaTXT.Text);
                        Byte[] hesirano = sha256.ComputeHash(lozinka);
                        hashLozinke = BitConverter.ToString(hesirano);
                        ucesnik[0].Ime = imeTXT.Text;
                        ucesnik[0].Prezime = prezimeTXT.Text;
                        ucesnik[0].KorisnickoIme = korisnickoImeTXT.Text;
                        if (staraLozinkaCBX.Checked == false) {
                            ucesnik[0].Lozinka = hashLozinke;
                        } else {
                            ucesnik[0].Lozinka = staraLozinka;
                        }
                        ucesnik[0].Jmbg = jmbgTXT.Text;
                        ucesnik[0].Aktivan = aktivanUcesnikCB.Checked;
                        List<Uloga> uloga = MySqlUlogaDao.Instance.Read(new Uloga { Naziv = nazivUlogeCB.Text });
                        ucesnik[0].Uloga = uloga[0];
                        MySqlUcesnikDao.Instance.Update(ucesnik[0]);
                        MessageBox.Show("Korisnik je uspješno ažuriran", "Obavještenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            } else {
                errorLBL.Visible = true;
            }
		}

		public void korisnickoImeTXT_TextChanged(object sender, EventArgs e)
		{
			List<Ucesnik> ucesnici = MySqlUcesnikDao.Instance.Read(new Ucesnik { KorisnickoIme = korisnickoImeTXT.Text});
			if (ucesnici.Count() == 0 || (edit && korisnickoImeTXT.Text.Equals(uc.KorisnickoIme)))
			{
				korisnickoImeKorektnoLBL.Text = "korektno";
			}
			else
			{
				korisnickoImeKorektnoLBL.Text = "nekorektno";
			}
		}

		public void SetValues(Int32 IDUcesnik)
		{
			List<Ucesnik> ucesnici = MySqlUcesnikDao.Instance.Read(new Ucesnik { UcesnikID = IDUcesnik });
            if (ucesnici.Count > 0) {
                edit = true;
                staraLozinkaCBX.Enabled = true;
                uc = ucesnici[0];
                imeTXT.Text = ucesnici[0].Ime;
                prezimeTXT.Text = ucesnici[0].Prezime;
                korisnickoImeTXT.Text = ucesnici[0].KorisnickoIme;
                lozinkaTXT.Text = "";
                staraLozinka = ucesnici[0].Lozinka;
                jmbgTXT.Text = ucesnici[0].Jmbg;
                aktivanUcesnikCB.Checked = (bool)ucesnici[0].Aktivan;
                nazivUlogeCB.Text = ucesnici[0].Uloga.Naziv;
                UcesnikIDKontrolni = ucesnici[0].UcesnikID;
                popuniComboBoxUloge();
                foreach(String s in nazivUlogeCB.Items) {
                    if (s.Equals(ucesnici[0].Uloga.Naziv)) {
                        nazivUlogeCB.SelectedItem = s;
                        break;
                    }
                }
                this.ShowDialog();
            }
		}

		private void nazivUlogeCB_MouseClick(object sender, EventArgs e)
		{
            popuniComboBoxUloge();
		}

        private void popuniComboBoxUloge() {
            List<Uloga> uloge = MySqlUlogaDao.Instance.Read(new Uloga { SoftverPoslovnaLogika = true });
            nazivUlogeCB.Items.Clear();
            foreach (Uloga uloga in uloge) {
                nazivUlogeCB.Items.Add(uloga.Naziv);
            }
        }

        private bool validniPodaci() {
            if (!imeTXT.Text.Equals("") && !prezimeTXT.Text.Equals("") && !korisnickoImeTXT.Text.Equals("") && (!lozinkaTXT.Text.Equals("") || staraLozinkaCBX.Checked == true) && !korisnickoImeTXT.Text.Equals("") && !jmbgTXT.Text.Equals("") && jmbgTXT.Text.Length == 13 && nazivUlogeCB.SelectedItem != null)
                return true;
            return false;
        }

        private void staraLozinkaCBX_CheckedChanged(object sender, EventArgs e) {
            if(staraLozinkaCBX.Checked == true) {
                lozinkaTXT.Enabled = false;
            } else {
                lozinkaTXT.Enabled = true;
            }
        }
    }
}
