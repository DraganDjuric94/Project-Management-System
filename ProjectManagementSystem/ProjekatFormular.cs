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
			MySqlProjekatDao.Instance.Create(new Projekat { Naziv = nazivTXT.Text, DatumKreiranja = Convert.ToDateTime(datumKreiranjaDTP.Value.Date.ToString()), Aktivan = aktivanProjekatCB.Checked });
			MessageBox.Show("Projekat je uspješno unešen", "Obavještenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}
	}
}
