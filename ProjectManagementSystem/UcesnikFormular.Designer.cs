using ProjectManagementSystem.dto;

namespace ProjectManagementSystem
{
	partial class UčesnikFormular
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.imeLBL = new System.Windows.Forms.Label();
			this.prezimeLBL = new System.Windows.Forms.Label();
			this.korisnickoImeLBL = new System.Windows.Forms.Label();
			this.lozinkaLBL = new System.Windows.Forms.Label();
			this.jmbgLBL = new System.Windows.Forms.Label();
			this.aktivanLBL = new System.Windows.Forms.Label();
			this.nazivUlogeLBL = new System.Windows.Forms.Label();
			this.imeTXT = new System.Windows.Forms.TextBox();
			this.prezimeTXT = new System.Windows.Forms.TextBox();
			this.korisnickoImeTXT = new System.Windows.Forms.TextBox();
			this.lozinkaTXT = new System.Windows.Forms.TextBox();
			this.jmbgTXT = new System.Windows.Forms.TextBox();
			this.nazivUlogeCB = new System.Windows.Forms.ComboBox();
			this.aktivnaUlogaLBL = new System.Windows.Forms.Label();
			this.aktivanUcesnikCB = new System.Windows.Forms.CheckBox();
			this.aktivnaUlogaCB = new System.Windows.Forms.CheckBox();
			this.dodatiBTN = new System.Windows.Forms.Button();
			this.korisnickoImeKorektnoLBL = new System.Windows.Forms.Label();
			this.poslovnaLogikaLBL = new System.Windows.Forms.Label();
			this.poslovnaLogikaCB = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// imeLBL
			// 
			this.imeLBL.AutoSize = true;
			this.imeLBL.Location = new System.Drawing.Point(37, 24);
			this.imeLBL.Name = "imeLBL";
			this.imeLBL.Size = new System.Drawing.Size(24, 13);
			this.imeLBL.TabIndex = 0;
			this.imeLBL.Text = "Ime";
			// 
			// prezimeLBL
			// 
			this.prezimeLBL.AutoSize = true;
			this.prezimeLBL.Location = new System.Drawing.Point(37, 61);
			this.prezimeLBL.Name = "prezimeLBL";
			this.prezimeLBL.Size = new System.Drawing.Size(44, 13);
			this.prezimeLBL.TabIndex = 1;
			this.prezimeLBL.Text = "Prezime";
			// 
			// korisnickoImeLBL
			// 
			this.korisnickoImeLBL.AutoSize = true;
			this.korisnickoImeLBL.Location = new System.Drawing.Point(37, 98);
			this.korisnickoImeLBL.Name = "korisnickoImeLBL";
			this.korisnickoImeLBL.Size = new System.Drawing.Size(75, 13);
			this.korisnickoImeLBL.TabIndex = 2;
			this.korisnickoImeLBL.Text = "Korisničko ime";
			// 
			// lozinkaLBL
			// 
			this.lozinkaLBL.AutoSize = true;
			this.lozinkaLBL.Location = new System.Drawing.Point(37, 134);
			this.lozinkaLBL.Name = "lozinkaLBL";
			this.lozinkaLBL.Size = new System.Drawing.Size(44, 13);
			this.lozinkaLBL.TabIndex = 3;
			this.lozinkaLBL.Text = "Lozinka";
			// 
			// jmbgLBL
			// 
			this.jmbgLBL.AutoSize = true;
			this.jmbgLBL.Location = new System.Drawing.Point(37, 170);
			this.jmbgLBL.Name = "jmbgLBL";
			this.jmbgLBL.Size = new System.Drawing.Size(36, 13);
			this.jmbgLBL.TabIndex = 4;
			this.jmbgLBL.Text = "JMBG";
			// 
			// aktivanLBL
			// 
			this.aktivanLBL.AutoSize = true;
			this.aktivanLBL.Location = new System.Drawing.Point(37, 210);
			this.aktivanLBL.Name = "aktivanLBL";
			this.aktivanLBL.Size = new System.Drawing.Size(83, 13);
			this.aktivanLBL.TabIndex = 5;
			this.aktivanLBL.Text = "Aktivan učesnik";
			// 
			// nazivUlogeLBL
			// 
			this.nazivUlogeLBL.AutoSize = true;
			this.nazivUlogeLBL.Location = new System.Drawing.Point(38, 251);
			this.nazivUlogeLBL.Name = "nazivUlogeLBL";
			this.nazivUlogeLBL.Size = new System.Drawing.Size(63, 13);
			this.nazivUlogeLBL.TabIndex = 6;
			this.nazivUlogeLBL.Text = "Naziv uloge";
			// 
			// imeTXT
			// 
			this.imeTXT.Location = new System.Drawing.Point(150, 24);
			this.imeTXT.Name = "imeTXT";
			this.imeTXT.Size = new System.Drawing.Size(157, 20);
			this.imeTXT.TabIndex = 7;
			// 
			// prezimeTXT
			// 
			this.prezimeTXT.Location = new System.Drawing.Point(150, 61);
			this.prezimeTXT.Name = "prezimeTXT";
			this.prezimeTXT.Size = new System.Drawing.Size(157, 20);
			this.prezimeTXT.TabIndex = 8;
			// 
			// korisnickoImeTXT
			// 
			this.korisnickoImeTXT.Location = new System.Drawing.Point(150, 98);
			this.korisnickoImeTXT.Name = "korisnickoImeTXT";
			this.korisnickoImeTXT.Size = new System.Drawing.Size(157, 20);
			this.korisnickoImeTXT.TabIndex = 9;
			this.korisnickoImeTXT.TextChanged += new System.EventHandler(this.korisnickoImeTXT_TextChanged);
			// 
			// lozinkaTXT
			// 
			this.lozinkaTXT.Location = new System.Drawing.Point(150, 134);
			this.lozinkaTXT.Name = "lozinkaTXT";
			this.lozinkaTXT.Size = new System.Drawing.Size(157, 20);
			this.lozinkaTXT.TabIndex = 10;
			// 
			// jmbgTXT
			// 
			this.jmbgTXT.Location = new System.Drawing.Point(150, 170);
			this.jmbgTXT.Name = "jmbgTXT";
			this.jmbgTXT.Size = new System.Drawing.Size(157, 20);
			this.jmbgTXT.TabIndex = 11;
			// 
			// nazivUlogeCB
			// 
			this.nazivUlogeCB.FormattingEnabled = true;
			this.nazivUlogeCB.Items.AddRange(new object[] {
            "administrator",
            "učesnik"});
			this.nazivUlogeCB.Location = new System.Drawing.Point(150, 243);
			this.nazivUlogeCB.Name = "nazivUlogeCB";
			this.nazivUlogeCB.Size = new System.Drawing.Size(157, 21);
			this.nazivUlogeCB.TabIndex = 12;
			// 
			// aktivnaUlogaLBL
			// 
			this.aktivnaUlogaLBL.AutoSize = true;
			this.aktivnaUlogaLBL.Location = new System.Drawing.Point(40, 288);
			this.aktivnaUlogaLBL.Name = "aktivnaUlogaLBL";
			this.aktivnaUlogaLBL.Size = new System.Drawing.Size(72, 13);
			this.aktivnaUlogaLBL.TabIndex = 13;
			this.aktivnaUlogaLBL.Text = "Aktivna uloga";
			// 
			// aktivanUcesnikCB
			// 
			this.aktivanUcesnikCB.AutoSize = true;
			this.aktivanUcesnikCB.Location = new System.Drawing.Point(150, 206);
			this.aktivanUcesnikCB.Name = "aktivanUcesnikCB";
			this.aktivanUcesnikCB.Size = new System.Drawing.Size(62, 17);
			this.aktivanUcesnikCB.TabIndex = 14;
			this.aktivanUcesnikCB.Text = "Aktivan";
			this.aktivanUcesnikCB.UseVisualStyleBackColor = true;
			// 
			// aktivnaUlogaCB
			// 
			this.aktivnaUlogaCB.AutoSize = true;
			this.aktivnaUlogaCB.Location = new System.Drawing.Point(150, 284);
			this.aktivnaUlogaCB.Name = "aktivnaUlogaCB";
			this.aktivnaUlogaCB.Size = new System.Drawing.Size(62, 17);
			this.aktivnaUlogaCB.TabIndex = 15;
			this.aktivnaUlogaCB.Text = "Aktivna";
			this.aktivnaUlogaCB.UseVisualStyleBackColor = true;
			// 
			// dodatiBTN
			// 
			this.dodatiBTN.Location = new System.Drawing.Point(243, 362);
			this.dodatiBTN.Name = "dodatiBTN";
			this.dodatiBTN.Size = new System.Drawing.Size(75, 23);
			this.dodatiBTN.TabIndex = 16;
			this.dodatiBTN.Text = "Dodati";
			this.dodatiBTN.UseVisualStyleBackColor = true;
			this.dodatiBTN.Click += new System.EventHandler(this.dodatiBTN_Click);
			// 
			// korisnickoImeKorektnoLBL
			// 
			this.korisnickoImeKorektnoLBL.AutoSize = true;
			this.korisnickoImeKorektnoLBL.Location = new System.Drawing.Point(313, 101);
			this.korisnickoImeKorektnoLBL.Name = "korisnickoImeKorektnoLBL";
			this.korisnickoImeKorektnoLBL.Size = new System.Drawing.Size(0, 13);
			this.korisnickoImeKorektnoLBL.TabIndex = 17;
			// 
			// poslovnaLogikaLBL
			// 
			this.poslovnaLogikaLBL.AutoSize = true;
			this.poslovnaLogikaLBL.Location = new System.Drawing.Point(40, 325);
			this.poslovnaLogikaLBL.Name = "poslovnaLogikaLBL";
			this.poslovnaLogikaLBL.Size = new System.Drawing.Size(82, 13);
			this.poslovnaLogikaLBL.TabIndex = 18;
			this.poslovnaLogikaLBL.Text = "Poslovna logika";
			// 
			// poslovnaLogikaCB
			// 
			this.poslovnaLogikaCB.AutoSize = true;
			this.poslovnaLogikaCB.Location = new System.Drawing.Point(150, 324);
			this.poslovnaLogikaCB.Name = "poslovnaLogikaCB";
			this.poslovnaLogikaCB.Size = new System.Drawing.Size(62, 17);
			this.poslovnaLogikaCB.TabIndex = 19;
			this.poslovnaLogikaCB.Text = "Aktivna";
			this.poslovnaLogikaCB.UseVisualStyleBackColor = true;
			// 
			// UčesnikFormular
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(371, 411);
			this.Controls.Add(this.poslovnaLogikaCB);
			this.Controls.Add(this.poslovnaLogikaLBL);
			this.Controls.Add(this.korisnickoImeKorektnoLBL);
			this.Controls.Add(this.dodatiBTN);
			this.Controls.Add(this.aktivnaUlogaCB);
			this.Controls.Add(this.aktivanUcesnikCB);
			this.Controls.Add(this.aktivnaUlogaLBL);
			this.Controls.Add(this.nazivUlogeCB);
			this.Controls.Add(this.jmbgTXT);
			this.Controls.Add(this.lozinkaTXT);
			this.Controls.Add(this.korisnickoImeTXT);
			this.Controls.Add(this.prezimeTXT);
			this.Controls.Add(this.imeTXT);
			this.Controls.Add(this.nazivUlogeLBL);
			this.Controls.Add(this.aktivanLBL);
			this.Controls.Add(this.jmbgLBL);
			this.Controls.Add(this.lozinkaLBL);
			this.Controls.Add(this.korisnickoImeLBL);
			this.Controls.Add(this.prezimeLBL);
			this.Controls.Add(this.imeLBL);
			this.Name = "UčesnikFormular";
			this.Text = "Formular za korisnika";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label imeLBL;
		private System.Windows.Forms.Label prezimeLBL;
		private System.Windows.Forms.Label korisnickoImeLBL;
		private System.Windows.Forms.Label lozinkaLBL;
		private System.Windows.Forms.Label jmbgLBL;
		private System.Windows.Forms.Label aktivanLBL;
		private System.Windows.Forms.Label nazivUlogeLBL;
		private System.Windows.Forms.TextBox imeTXT;
		private System.Windows.Forms.TextBox prezimeTXT;
		private System.Windows.Forms.TextBox korisnickoImeTXT;
		private System.Windows.Forms.TextBox lozinkaTXT;
		private System.Windows.Forms.TextBox jmbgTXT;
		private System.Windows.Forms.ComboBox nazivUlogeCB;
		private System.Windows.Forms.Label aktivnaUlogaLBL;
		private System.Windows.Forms.CheckBox aktivanUcesnikCB;
		private System.Windows.Forms.CheckBox aktivnaUlogaCB;
		private System.Windows.Forms.Button dodatiBTN;
		private System.Windows.Forms.Label korisnickoImeKorektnoLBL;
		private System.Windows.Forms.Label poslovnaLogikaLBL;
		private System.Windows.Forms.CheckBox poslovnaLogikaCB;
	}
}