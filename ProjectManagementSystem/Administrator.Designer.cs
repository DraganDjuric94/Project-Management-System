namespace ProjectManagementSystem
{
	partial class Administrator
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
			this.administratorTC = new System.Windows.Forms.TabControl();
			this.ucesniciTP = new System.Windows.Forms.TabPage();
			this.korisniciDGW = new System.Windows.Forms.DataGridView();
			this.projektiTP = new System.Windows.Forms.TabPage();
			this.projektiDGW = new System.Windows.Forms.DataGridView();
			this.projekatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.projekatNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.projekatDatumKreiranja = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.projekatAktivan = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dodatiBTN = new System.Windows.Forms.Button();
			this.azuriratiBTN = new System.Windows.Forms.Button();
			this.obrisatiBTN = new System.Windows.Forms.Button();
			this.ucesnikID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ucesnikIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ucesnikPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ucesnikKorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ucesnikLozinka = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ucesnikJmbg = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ucesnikAktivan = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ucesnikUlogaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ucesnikUlogaNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ucesnikPoslovnaLogika = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ucesnikUlogaAktivna = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.administratorTC.SuspendLayout();
			this.ucesniciTP.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.korisniciDGW)).BeginInit();
			this.projektiTP.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.projektiDGW)).BeginInit();
			this.SuspendLayout();
			// 
			// administratorTC
			// 
			this.administratorTC.Controls.Add(this.ucesniciTP);
			this.administratorTC.Controls.Add(this.projektiTP);
			this.administratorTC.Location = new System.Drawing.Point(-1, 0);
			this.administratorTC.Name = "administratorTC";
			this.administratorTC.SelectedIndex = 0;
			this.administratorTC.Size = new System.Drawing.Size(1052, 292);
			this.administratorTC.TabIndex = 0;
			this.administratorTC.SelectedIndexChanged += new System.EventHandler(this.administratorTC_SelectedIndexChanged);
			// 
			// ucesniciTP
			// 
			this.ucesniciTP.Controls.Add(this.korisniciDGW);
			this.ucesniciTP.Location = new System.Drawing.Point(4, 22);
			this.ucesniciTP.Name = "ucesniciTP";
			this.ucesniciTP.Padding = new System.Windows.Forms.Padding(3);
			this.ucesniciTP.Size = new System.Drawing.Size(1044, 266);
			this.ucesniciTP.TabIndex = 0;
			this.ucesniciTP.Text = "Učesnici";
			this.ucesniciTP.UseVisualStyleBackColor = true;
			// 
			// korisniciDGW
			// 
			this.korisniciDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.korisniciDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ucesnikID,
            this.ucesnikIme,
            this.ucesnikPrezime,
            this.ucesnikKorisnickoIme,
            this.ucesnikLozinka,
            this.ucesnikJmbg,
            this.ucesnikAktivan,
            this.ucesnikUlogaID,
            this.ucesnikUlogaNaziv,
            this.ucesnikPoslovnaLogika,
            this.ucesnikUlogaAktivna});
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> parent of 23e9a32... Merge branch 'master' of https://github.com/DraganDjuric94/Project-Management-System
			this.korisniciDGW.Location = new System.Drawing.Point(1, -1);
=======
			this.korisniciDGW.Location = new System.Drawing.Point(0, 0);
>>>>>>> parent of 6ca9bae... Update
			this.korisniciDGW.Name = "korisniciDGW";
			this.korisniciDGW.Size = new System.Drawing.Size(1043, 267);
			this.korisniciDGW.TabIndex = 0;
			// 
			// projektiTP
			// 
			this.projektiTP.Controls.Add(this.projektiDGW);
			this.projektiTP.Location = new System.Drawing.Point(4, 22);
			this.projektiTP.Name = "projektiTP";
			this.projektiTP.Padding = new System.Windows.Forms.Padding(3);
			this.projektiTP.Size = new System.Drawing.Size(1044, 266);
			this.projektiTP.TabIndex = 1;
			this.projektiTP.Text = "Projekti";
			this.projektiTP.UseVisualStyleBackColor = true;
			// 
			// projektiDGW
			// 
			this.projektiDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.projektiDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projekatID,
            this.projekatNaziv,
            this.projekatDatumKreiranja,
            this.projekatAktivan});
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> parent of 23e9a32... Merge branch 'master' of https://github.com/DraganDjuric94/Project-Management-System
			this.projektiDGW.Location = new System.Drawing.Point(-3, 0);
=======
			this.projektiDGW.Location = new System.Drawing.Point(0, 0);
>>>>>>> parent of 6ca9bae... Update
			this.projektiDGW.Name = "projektiDGW";
			this.projektiDGW.Size = new System.Drawing.Size(1044, 266);
			this.projektiDGW.TabIndex = 0;
			// 
			// projekatID
			// 
			this.projekatID.HeaderText = "ID";
			this.projekatID.Name = "projekatID";
			// 
			// projekatNaziv
			// 
			this.projekatNaziv.HeaderText = "Naziv";
			this.projekatNaziv.Name = "projekatNaziv";
			// 
			// projekatDatumKreiranja
			// 
			this.projekatDatumKreiranja.HeaderText = "Datum Kreiranja";
			this.projekatDatumKreiranja.Name = "projekatDatumKreiranja";
			// 
			// projekatAktivan
			// 
			this.projekatAktivan.HeaderText = "Aktivan";
			this.projekatAktivan.Name = "projekatAktivan";
			// 
			// dodatiBTN
			// 
			this.dodatiBTN.Location = new System.Drawing.Point(3, 313);
			this.dodatiBTN.Name = "dodatiBTN";
			this.dodatiBTN.Size = new System.Drawing.Size(75, 23);
			this.dodatiBTN.TabIndex = 1;
			this.dodatiBTN.Text = "Dodati";
			this.dodatiBTN.UseVisualStyleBackColor = true;
			this.dodatiBTN.Click += new System.EventHandler(this.dodatiBTN_Click);
			// 
			// azuriratiBTN
			// 
			this.azuriratiBTN.Location = new System.Drawing.Point(102, 313);
			this.azuriratiBTN.Name = "azuriratiBTN";
			this.azuriratiBTN.Size = new System.Drawing.Size(75, 23);
			this.azuriratiBTN.TabIndex = 2;
			this.azuriratiBTN.Text = "Ažurirati";
			this.azuriratiBTN.UseVisualStyleBackColor = true;
			this.azuriratiBTN.Click += new System.EventHandler(this.azuriratiBTN_Click);
			// 
			// obrisatiBTN
			// 
			this.obrisatiBTN.Location = new System.Drawing.Point(198, 313);
			this.obrisatiBTN.Name = "obrisatiBTN";
			this.obrisatiBTN.Size = new System.Drawing.Size(75, 23);
			this.obrisatiBTN.TabIndex = 3;
			this.obrisatiBTN.Text = "Obrisati";
			this.obrisatiBTN.UseVisualStyleBackColor = true;
			this.obrisatiBTN.Click += new System.EventHandler(this.obrisatiBTN_Click);
			// 
			// ucesnikID
			// 
			this.ucesnikID.HeaderText = "ID";
			this.ucesnikID.Name = "ucesnikID";
			// 
			// ucesnikIme
			// 
			this.ucesnikIme.HeaderText = "Ime";
			this.ucesnikIme.Name = "ucesnikIme";
			// 
			// ucesnikPrezime
			// 
			this.ucesnikPrezime.HeaderText = "Prezime";
			this.ucesnikPrezime.Name = "ucesnikPrezime";
			// 
			// ucesnikKorisnickoIme
			// 
			this.ucesnikKorisnickoIme.HeaderText = "Korisničko ime";
			this.ucesnikKorisnickoIme.Name = "ucesnikKorisnickoIme";
			// 
			// ucesnikLozinka
			// 
			this.ucesnikLozinka.HeaderText = "Lozinka";
			this.ucesnikLozinka.Name = "ucesnikLozinka";
			// 
			// ucesnikJmbg
			// 
			this.ucesnikJmbg.HeaderText = "Jmbg";
			this.ucesnikJmbg.Name = "ucesnikJmbg";
			// 
			// ucesnikAktivan
			// 
			this.ucesnikAktivan.HeaderText = "Aktivan";
			this.ucesnikAktivan.Name = "ucesnikAktivan";
			// 
			// ucesnikUlogaID
			// 
			this.ucesnikUlogaID.HeaderText = "ID uloge";
			this.ucesnikUlogaID.Name = "ucesnikUlogaID";
			// 
			// ucesnikUlogaNaziv
			// 
			this.ucesnikUlogaNaziv.HeaderText = "Naziv uloge";
			this.ucesnikUlogaNaziv.Name = "ucesnikUlogaNaziv";
			// 
			// ucesnikPoslovnaLogika
			// 
			this.ucesnikPoslovnaLogika.HeaderText = "Poslovna logika";
			this.ucesnikPoslovnaLogika.Name = "ucesnikPoslovnaLogika";
			// 
			// ucesnikUlogaAktivna
			// 
			this.ucesnikUlogaAktivna.HeaderText = "Aktivna uloga";
			this.ucesnikUlogaAktivna.Name = "ucesnikUlogaAktivna";
			// 
			// Administrator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1051, 348);
			this.Controls.Add(this.obrisatiBTN);
			this.Controls.Add(this.azuriratiBTN);
			this.Controls.Add(this.dodatiBTN);
			this.Controls.Add(this.administratorTC);
			this.Name = "Administrator";
			this.Text = "Administrator";
			this.administratorTC.ResumeLayout(false);
			this.ucesniciTP.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.korisniciDGW)).EndInit();
			this.projektiTP.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.projektiDGW)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl administratorTC;
		private System.Windows.Forms.TabPage ucesniciTP;
		private System.Windows.Forms.TabPage projektiTP;
		private System.Windows.Forms.DataGridView korisniciDGW;
		private System.Windows.Forms.DataGridView projektiDGW;
		private System.Windows.Forms.Button dodatiBTN;
		private System.Windows.Forms.Button azuriratiBTN;
		private System.Windows.Forms.Button obrisatiBTN;
		private System.Windows.Forms.DataGridViewTextBoxColumn projekatID;
		private System.Windows.Forms.DataGridViewTextBoxColumn projekatNaziv;
		private System.Windows.Forms.DataGridViewTextBoxColumn projekatDatumKreiranja;
		private System.Windows.Forms.DataGridViewTextBoxColumn projekatAktivan;
		private System.Windows.Forms.DataGridViewTextBoxColumn ucesnikID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ucesnikIme;
		private System.Windows.Forms.DataGridViewTextBoxColumn ucesnikPrezime;
		private System.Windows.Forms.DataGridViewTextBoxColumn ucesnikKorisnickoIme;
		private System.Windows.Forms.DataGridViewTextBoxColumn ucesnikLozinka;
		private System.Windows.Forms.DataGridViewTextBoxColumn ucesnikJmbg;
		private System.Windows.Forms.DataGridViewTextBoxColumn ucesnikAktivan;
		private System.Windows.Forms.DataGridViewTextBoxColumn ucesnikUlogaID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ucesnikUlogaNaziv;
		private System.Windows.Forms.DataGridViewTextBoxColumn ucesnikPoslovnaLogika;
		private System.Windows.Forms.DataGridViewTextBoxColumn ucesnikUlogaAktivna;
	}
}