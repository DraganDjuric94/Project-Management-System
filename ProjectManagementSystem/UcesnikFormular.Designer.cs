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
            this.nazivUlogeLBL = new System.Windows.Forms.Label();
            this.imeTXT = new System.Windows.Forms.TextBox();
            this.prezimeTXT = new System.Windows.Forms.TextBox();
            this.korisnickoImeTXT = new System.Windows.Forms.TextBox();
            this.lozinkaTXT = new System.Windows.Forms.TextBox();
            this.nazivUlogeCB = new System.Windows.Forms.ComboBox();
            this.aktivanUcesnikCB = new System.Windows.Forms.CheckBox();
            this.dodatiBTN = new System.Windows.Forms.Button();
            this.korisnickoImeKorektnoLBL = new System.Windows.Forms.Label();
            this.errorLBL = new System.Windows.Forms.Label();
            this.jmbgTXT = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // imeLBL
            // 
            this.imeLBL.AutoSize = true;
            this.imeLBL.Location = new System.Drawing.Point(12, 24);
            this.imeLBL.Name = "imeLBL";
            this.imeLBL.Size = new System.Drawing.Size(27, 13);
            this.imeLBL.TabIndex = 0;
            this.imeLBL.Text = "Ime:";
            // 
            // prezimeLBL
            // 
            this.prezimeLBL.AutoSize = true;
            this.prezimeLBL.Location = new System.Drawing.Point(12, 61);
            this.prezimeLBL.Name = "prezimeLBL";
            this.prezimeLBL.Size = new System.Drawing.Size(47, 13);
            this.prezimeLBL.TabIndex = 1;
            this.prezimeLBL.Text = "Prezime:";
            // 
            // korisnickoImeLBL
            // 
            this.korisnickoImeLBL.AutoSize = true;
            this.korisnickoImeLBL.Location = new System.Drawing.Point(12, 98);
            this.korisnickoImeLBL.Name = "korisnickoImeLBL";
            this.korisnickoImeLBL.Size = new System.Drawing.Size(78, 13);
            this.korisnickoImeLBL.TabIndex = 2;
            this.korisnickoImeLBL.Text = "Korisničko ime:";
            // 
            // lozinkaLBL
            // 
            this.lozinkaLBL.AutoSize = true;
            this.lozinkaLBL.Location = new System.Drawing.Point(12, 155);
            this.lozinkaLBL.Name = "lozinkaLBL";
            this.lozinkaLBL.Size = new System.Drawing.Size(47, 13);
            this.lozinkaLBL.TabIndex = 3;
            this.lozinkaLBL.Text = "Lozinka:";
            // 
            // jmbgLBL
            // 
            this.jmbgLBL.AutoSize = true;
            this.jmbgLBL.Location = new System.Drawing.Point(12, 194);
            this.jmbgLBL.Name = "jmbgLBL";
            this.jmbgLBL.Size = new System.Drawing.Size(39, 13);
            this.jmbgLBL.TabIndex = 4;
            this.jmbgLBL.Text = "JMBG:";
            // 
            // nazivUlogeLBL
            // 
            this.nazivUlogeLBL.AutoSize = true;
            this.nazivUlogeLBL.Location = new System.Drawing.Point(12, 238);
            this.nazivUlogeLBL.Name = "nazivUlogeLBL";
            this.nazivUlogeLBL.Size = new System.Drawing.Size(66, 13);
            this.nazivUlogeLBL.TabIndex = 6;
            this.nazivUlogeLBL.Text = "Naziv uloge:";
            // 
            // imeTXT
            // 
            this.imeTXT.Location = new System.Drawing.Point(104, 24);
            this.imeTXT.Name = "imeTXT";
            this.imeTXT.Size = new System.Drawing.Size(203, 20);
            this.imeTXT.TabIndex = 7;
            // 
            // prezimeTXT
            // 
            this.prezimeTXT.Location = new System.Drawing.Point(104, 61);
            this.prezimeTXT.Name = "prezimeTXT";
            this.prezimeTXT.Size = new System.Drawing.Size(203, 20);
            this.prezimeTXT.TabIndex = 8;
            // 
            // korisnickoImeTXT
            // 
            this.korisnickoImeTXT.Location = new System.Drawing.Point(104, 98);
            this.korisnickoImeTXT.Name = "korisnickoImeTXT";
            this.korisnickoImeTXT.Size = new System.Drawing.Size(203, 20);
            this.korisnickoImeTXT.TabIndex = 9;
            this.korisnickoImeTXT.TextChanged += new System.EventHandler(this.korisnickoImeTXT_TextChanged);
            // 
            // lozinkaTXT
            // 
            this.lozinkaTXT.Location = new System.Drawing.Point(104, 152);
            this.lozinkaTXT.Name = "lozinkaTXT";
            this.lozinkaTXT.Size = new System.Drawing.Size(203, 20);
            this.lozinkaTXT.TabIndex = 10;
            // 
            // nazivUlogeCB
            // 
            this.nazivUlogeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nazivUlogeCB.FormattingEnabled = true;
            this.nazivUlogeCB.Location = new System.Drawing.Point(104, 235);
            this.nazivUlogeCB.Name = "nazivUlogeCB";
            this.nazivUlogeCB.Size = new System.Drawing.Size(203, 21);
            this.nazivUlogeCB.TabIndex = 12;
            this.nazivUlogeCB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nazivUlogeCB_MouseClick);
            // 
            // aktivanUcesnikCB
            // 
            this.aktivanUcesnikCB.AutoSize = true;
            this.aktivanUcesnikCB.Location = new System.Drawing.Point(245, 271);
            this.aktivanUcesnikCB.Name = "aktivanUcesnikCB";
            this.aktivanUcesnikCB.Size = new System.Drawing.Size(62, 17);
            this.aktivanUcesnikCB.TabIndex = 14;
            this.aktivanUcesnikCB.Text = "Aktivan";
            this.aktivanUcesnikCB.UseVisualStyleBackColor = true;
            // 
            // dodatiBTN
            // 
            this.dodatiBTN.Location = new System.Drawing.Point(232, 333);
            this.dodatiBTN.Name = "dodatiBTN";
            this.dodatiBTN.Size = new System.Drawing.Size(75, 23);
            this.dodatiBTN.TabIndex = 16;
            this.dodatiBTN.Text = "Sačuvaj";
            this.dodatiBTN.UseVisualStyleBackColor = true;
            this.dodatiBTN.Click += new System.EventHandler(this.dodatiBTN_Click);
            // 
            // korisnickoImeKorektnoLBL
            // 
            this.korisnickoImeKorektnoLBL.AutoSize = true;
            this.korisnickoImeKorektnoLBL.Location = new System.Drawing.Point(246, 121);
            this.korisnickoImeKorektnoLBL.Name = "korisnickoImeKorektnoLBL";
            this.korisnickoImeKorektnoLBL.Size = new System.Drawing.Size(0, 13);
            this.korisnickoImeKorektnoLBL.TabIndex = 17;
            // 
            // errorLBL
            // 
            this.errorLBL.AutoSize = true;
            this.errorLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorLBL.Location = new System.Drawing.Point(127, 303);
            this.errorLBL.Name = "errorLBL";
            this.errorLBL.Size = new System.Drawing.Size(180, 17);
            this.errorLBL.TabIndex = 18;
            this.errorLBL.Text = "Unešeni podaci nisu validni";
            this.errorLBL.Visible = false;
            // 
            // jmbgTXT
            // 
            this.jmbgTXT.Location = new System.Drawing.Point(104, 194);
            this.jmbgTXT.Mask = "0000000000000";
            this.jmbgTXT.Name = "jmbgTXT";
            this.jmbgTXT.Size = new System.Drawing.Size(203, 20);
            this.jmbgTXT.TabIndex = 19;
            // 
            // UčesnikFormular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 368);
            this.Controls.Add(this.jmbgTXT);
            this.Controls.Add(this.errorLBL);
            this.Controls.Add(this.korisnickoImeKorektnoLBL);
            this.Controls.Add(this.dodatiBTN);
            this.Controls.Add(this.aktivanUcesnikCB);
            this.Controls.Add(this.nazivUlogeCB);
            this.Controls.Add(this.lozinkaTXT);
            this.Controls.Add(this.korisnickoImeTXT);
            this.Controls.Add(this.prezimeTXT);
            this.Controls.Add(this.imeTXT);
            this.Controls.Add(this.nazivUlogeLBL);
            this.Controls.Add(this.jmbgLBL);
            this.Controls.Add(this.lozinkaLBL);
            this.Controls.Add(this.korisnickoImeLBL);
            this.Controls.Add(this.prezimeLBL);
            this.Controls.Add(this.imeLBL);
            this.MaximizeBox = false;
            this.Name = "UčesnikFormular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
		private System.Windows.Forms.Label nazivUlogeLBL;
		private System.Windows.Forms.TextBox imeTXT;
		private System.Windows.Forms.TextBox prezimeTXT;
		private System.Windows.Forms.TextBox korisnickoImeTXT;
		private System.Windows.Forms.TextBox lozinkaTXT;
		private System.Windows.Forms.ComboBox nazivUlogeCB;
		private System.Windows.Forms.CheckBox aktivanUcesnikCB;
		private System.Windows.Forms.Button dodatiBTN;
		private System.Windows.Forms.Label korisnickoImeKorektnoLBL;
        private System.Windows.Forms.Label errorLBL;
        private System.Windows.Forms.MaskedTextBox jmbgTXT;
    }
}