﻿using System;
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
            updateTables();
            
        }

        private void updateTables() {
            korisniciDGW.Rows.Clear();
            List<Ucesnik> korisnici = MySqlUcesnikDao.Instance.Read(new Ucesnik());
            foreach (Ucesnik u in korisnici) {
                korisniciDGW.Rows.Add(u.UcesnikID.ToString(), u.Ime, u.Prezime, u.KorisnickoIme, u.Lozinka, u.Jmbg, u.Aktivan, u.Uloga.UlogaID, u.Uloga.Naziv, u.Uloga.SoftverPoslovnaLogika, u.Uloga.Aktivna);
            }
            projektiDGW.Rows.Clear();
            List<Projekat> projekti = MySqlProjekatDao.Instance.Read(new Projekat());
            foreach (Projekat p in projekti) {
                projektiDGW.Rows.Add(p.ProjekatID, p.Naziv, p.DatumKreiranja, p.Aktivan);
            }
        }

		private void dodatiBTN_Click(object sender, EventArgs e)
		{
			if (administratorTC.SelectedTab == administratorTC.TabPages["ucesniciTP"])
			{
				new UčesnikFormular().ShowDialog();
                updateTables();
            }
			else if (administratorTC.SelectedTab == administratorTC.TabPages["projektiTP"])
			{
				new ProjekatFormular().ShowDialog();
                updateTables();
            }
		}

		private void azuriratiBTN_Click(object sender, EventArgs e)
		{
            if (administratorTC.SelectedTab == administratorTC.TabPages["ucesniciTP"]) {
                if (korisniciDGW.SelectedRows.Count == 1) {
                    new UčesnikFormular().SetValues(Convert.ToInt32(korisniciDGW.SelectedCells[0].Value.ToString()));
                    updateTables();
                } else {
                    MessageBox.Show("Morate selektovati učesnika", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else if(administratorTC.SelectedTab == administratorTC.TabPages["projektiTP"]) {
                if(projektiDGW.SelectedRows.Count == 1) {
                    new ProjekatFormular().SetValues(Convert.ToInt32(projektiDGW.SelectedCells[0].Value.ToString()));
                    updateTables();
                } else {
                    MessageBox.Show("Morate selektovati projekat", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
		}

		private void obrisatiBTN_Click(object sender, EventArgs e)
		{
            BrisanjeForma dijalog = new BrisanjeForma();
            dijalog.ShowDialog();
            if (dijalog.DialogResult == DialogResult.Yes) {
                if (administratorTC.SelectedTab == administratorTC.TabPages["ucesniciTP"]) {
                    if (korisniciDGW.SelectedRows.Count == 1) {
                        MySqlUcesnikDao.Instance.Delete(Convert.ToInt32(korisniciDGW.SelectedCells[0].Value.ToString()));
                        MessageBox.Show("Izabrani korisnik je uspješno izbrisan", "Obavještenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        updateTables();
                    } else {
                        MessageBox.Show("Morate selektovati učesnika", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else if (administratorTC.SelectedTab == administratorTC.TabPages["projektiTP"]) {
                    if (projektiDGW.SelectedRows.Count == 1) {
                        MySqlProjekatDao.Instance.Delete(Convert.ToInt32(projektiDGW.SelectedCells[0].Value.ToString()));
                        MessageBox.Show("Izabrani projekat je uspješno izbrisan", "Obavještenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        updateTables();
                    } else {
                        MessageBox.Show("Morate selektovati projekat", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } else {

            }
		}

		private void administratorTC_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (administratorTC.SelectedTab == administratorTC.TabPages["ucesniciTP"])
			{
				azuriratiBTN.Enabled = true;

				korisniciDGW.Rows.Clear();
				List<Ucesnik> korisnici = MySqlUcesnikDao.Instance.Read(new Ucesnik());
				foreach (Ucesnik u in korisnici)
				{
					korisniciDGW.Rows.Add(u.UcesnikID.ToString(), u.Ime, u.Prezime, u.KorisnickoIme, u.Lozinka, u.Jmbg, u.Aktivan, u.Uloga.UlogaID, u.Uloga.Naziv, u.Uloga.SoftverPoslovnaLogika, u.Uloga.Aktivna);
				}
			}
			else if (administratorTC.SelectedTab == administratorTC.TabPages["projektiTP"])
			{
				azuriratiBTN.Enabled = true;

				projektiDGW.Rows.Clear();
				List<Projekat> projekti = MySqlProjekatDao.Instance.Read(new Projekat());
				foreach (Projekat p in projekti)
				{
					projektiDGW.Rows.Add(p.ProjekatID, p.Naziv, p.DatumKreiranja, p.Aktivan);
				}
			}
		}

        private void Administrator_FormClosed(object sender, FormClosedEventArgs e) {
            bool postojiLogin = false;
            foreach (Form f in Application.OpenForms) {
                if (f.GetType() == typeof(Login)) {
                    postojiLogin = true;
                    f.Show();
                    break;
                }
            }
            if (!postojiLogin) {
                Application.Exit();
            }
        }
    }
}
