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
	public partial class ProjekatFormular : Form
	{
		public ProjekatFormular()
		{
			InitializeComponent();
		}

		private void dodatiBTN_Click(object sender, EventArgs e)
		{
			if (nazivKorektnoLBL.Text.Equals("korektno"))
			{
                dodatiBTN.Enabled = false;
				Dictionary<Ucesnik, Uloga> ucesnici = new Dictionary<Ucesnik, Uloga>();
				List<Ucesnik> ucesnik = MySqlUcesnikDao.Instance.Read(new Ucesnik { KorisnickoIme = sefProjektaCB.Text });
				List<Uloga> uloga = MySqlUlogaDao.Instance.Read(new Uloga { Naziv = "sef" });
				ucesnici.Add(ucesnik[0], uloga[0]);
				MySqlProjekatDao.Instance.Create(new Projekat { Naziv = nazivTXT.Text, DatumKreiranja = Convert.ToDateTime(DateTime.Now.ToString()), Aktivan = true, UcesniciNaProjektu = ucesnici });
				MessageBox.Show("Projekat je uspješno unešen", "Obavještenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
		}

		private void nazivTXT_TextChanged(object sender, EventArgs e)
		{
			List<Projekat> projekti = MySqlProjekatDao.Instance.Read(new Projekat { Naziv = nazivTXT.Text });
			if (projekti.Count == 0)
			{
				nazivKorektnoLBL.Text = "korektno";
			}
			else
			{
				nazivKorektnoLBL.Text = "nekorektno";
			}
		}

		private void sefProjektaCB_MouseClick(object sender, EventArgs e)
		{
			List<Ucesnik> ucesnici = MySqlUcesnikDao.Instance.Read(new Ucesnik());
			sefProjektaCB.Items.Clear();
			foreach (Ucesnik ucesnik in ucesnici)
			{
				if (ucesnik.Aktivan == true && ucesnik.Uloga.Naziv.Equals("korisnik"))
				{
					sefProjektaCB.Items.Add(ucesnik.KorisnickoIme);
				}
			}
		}
	}
}
