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
	public partial class Administrator : Form
	{

		public Administrator()
		{
			InitializeComponent();
		}

		private void dodatiBTN_Click(object sender, EventArgs e)
		{
			if (administratorTC.SelectedTab == administratorTC.TabPages["ucesniciTP"])
			{
				new UčesnikFormular().ShowDialog();
			}
			else if (administratorTC.SelectedTab == administratorTC.TabPages["projektiTP"])
			{
				new ProjekatFormular().ShowDialog();
			}
		}

		private void azuriratiBTN_Click(object sender, EventArgs e)
		{
			
		}

		private void obrisatiBTN_Click(object sender, EventArgs e)
		{
			if (administratorTC.SelectedTab == administratorTC.TabPages["ucesniciTP"])
			{
				if (korisniciDGW.SelectedRows.Count == 1)
				{
					MySqlUcesnikDao.Instance.Delete(Convert.ToInt32(korisniciDGW.SelectedCells[0].Value.ToString()));
				}
				else
				{
					MessageBox.Show("Morate selektovati učesnika", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else if (administratorTC.SelectedTab == administratorTC.TabPages["projektiTP"])
			{
				if (projektiDGW.SelectedRows.Count == 1)
				{
					MySqlProjekatDao.Instance.Delete(Convert.ToInt32(projektiDGW.SelectedCells[0].Value.ToString()));
				}
				else
				{
					MessageBox.Show("Morate selektovati projekat", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void administratorTC_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (administratorTC.SelectedTab == administratorTC.TabPages["ucesniciTP"])
			{
				azuriratiBTN.Enabled = true;

				korisniciDGW.Rows.Clear();
			}
			else if (administratorTC.SelectedTab == administratorTC.TabPages["projektiTP"])
			{
				azuriratiBTN.Enabled = false;

				projektiDGW.Rows.Clear();
			}
		}

	}
}
