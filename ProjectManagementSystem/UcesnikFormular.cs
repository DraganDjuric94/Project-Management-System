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

namespace ProjectManagementSystem
{
	public partial class UčesnikFormular : Form
	{

		public Int32? UcesnikIDKontrolni { get; set; }

		public UčesnikFormular()
		{
			UcesnikIDKontrolni = 0;
			InitializeComponent();
		}

		private void dodatiBTN_Click(object sender, EventArgs e)
		{
			if (korisnickoImeKorektnoLBL.Text.Equals("korektno") && UcesnikIDKontrolni == 0)
			{
				Uloga uloga = new Uloga { Naziv = nazivUlogeCB.Text, Aktivna = aktivnaUlogaCB.Checked, SoftverPoslovnaLogika = poslovnaLogikaCB.Checked };
				MySqlUcesnikDao.Instance.Create(new Ucesnik { Ime = imeTXT.Text, Prezime = prezimeTXT.Text, KorisnickoIme = korisnickoImeTXT.Text, Lozinka = lozinkaTXT.Text, Jmbg = jmbgTXT.Text, Aktivan = aktivanUcesnikCB.Checked, Uloga = uloga });
				MessageBox.Show("Korisnik je uspješno unešen", "Obavještenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			else if (UcesnikIDKontrolni != 0)
			{
				List<Ucesnik> ucesnik = MySqlUcesnikDao.Instance.Read(new Ucesnik { UcesnikID = UcesnikIDKontrolni });
				ucesnik[0].Ime = imeTXT.Text;
				ucesnik[0].Prezime = prezimeTXT.Text;
				ucesnik[0].KorisnickoIme = korisnickoImeTXT.Text;
				ucesnik[0].Lozinka = lozinkaTXT.Text;
				ucesnik[0].Jmbg = jmbgTXT.Text;
				ucesnik[0].Aktivan = aktivanUcesnikCB.Checked;
				ucesnik[0].Uloga.Naziv = nazivUlogeCB.Text;
				ucesnik[0].Uloga.Aktivna = aktivnaUlogaCB.Checked;
				ucesnik[0].Uloga.SoftverPoslovnaLogika = poslovnaLogikaCB.Checked;
				MySqlUcesnikDao.Instance.Update(ucesnik[0]);
				MessageBox.Show("Korisnik je uspješno ažuriran", "Obavještenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
		}

		public void korisnickoImeTXT_TextChanged(object sender, EventArgs e)
		{
			List<Ucesnik> ucesnici = MySqlUcesnikDao.Instance.Read(new Ucesnik { KorisnickoIme = korisnickoImeTXT.Text});
			if (ucesnici.Count() == 0)
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
			imeTXT.Text = ucesnici[0].Ime;
			prezimeTXT.Text = ucesnici[0].Prezime;
			korisnickoImeTXT.Text = ucesnici[0].KorisnickoIme;
			lozinkaTXT.Text = ucesnici[0].Lozinka;
			jmbgTXT.Text = ucesnici[0].Jmbg;
			aktivanUcesnikCB.Checked = (bool)ucesnici[0].Aktivan;
			nazivUlogeCB.Text = ucesnici[0].Uloga.Naziv;
			aktivnaUlogaCB.Checked = (bool)ucesnici[0].Uloga.Aktivna;
			poslovnaLogikaCB.Checked = (bool)ucesnici[0].Uloga.SoftverPoslovnaLogika;
			UcesnikIDKontrolni = ucesnici[0].UcesnikID;
			this.ShowDialog();
		}

	}
}
