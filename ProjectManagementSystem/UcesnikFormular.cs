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
		public UčesnikFormular()
		{
			InitializeComponent();
		}

		private void dodatiBTN_Click(object sender, EventArgs e)
		{
			if (korisnickoImeKorektnoLBL.Text.Equals("korektno"))
			{
				Uloga uloga = new Uloga { Naziv = nazivUlogeCB.Text, Aktivna = aktivnaUlogaCB.Checked };
				MySqlUcesnikDao.Instance.Create(new Ucesnik { Ime = imeTXT.Text, Prezime = prezimeTXT.Text, KorisnickoIme = korisnickoImeTXT.Text, Lozinka = lozinkaTXT.Text, Jmbg = jmbgTXT.Text, Aktivan = aktivanUcesnikCB.Checked, Uloga = uloga });
				MessageBox.Show("Korisnik je uspješno unešen", "Obavještenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void korisnickoImeTXT_TextChanged(object sender, EventArgs e)
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
	}
}
