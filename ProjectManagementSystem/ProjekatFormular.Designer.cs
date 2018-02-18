namespace ProjectManagementSystem
{
	partial class ProjekatFormular
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
			this.nazivLBL = new System.Windows.Forms.Label();
			this.datumKreiranjaLBL = new System.Windows.Forms.Label();
			this.nazivTXT = new System.Windows.Forms.TextBox();
			this.datumKreiranjaDTP = new System.Windows.Forms.DateTimePicker();
			this.dodatiBTN = new System.Windows.Forms.Button();
			this.nazivKorektnoLBL = new System.Windows.Forms.Label();
			this.sefProjektaLBL = new System.Windows.Forms.Label();
			this.sefProjektaCB = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// nazivLBL
			// 
			this.nazivLBL.AutoSize = true;
			this.nazivLBL.Location = new System.Drawing.Point(24, 24);
			this.nazivLBL.Name = "nazivLBL";
			this.nazivLBL.Size = new System.Drawing.Size(34, 13);
			this.nazivLBL.TabIndex = 0;
			this.nazivLBL.Text = "Naziv";
			// 
			// datumKreiranjaLBL
			// 
			this.datumKreiranjaLBL.AutoSize = true;
			this.datumKreiranjaLBL.Location = new System.Drawing.Point(24, 79);
			this.datumKreiranjaLBL.Name = "datumKreiranjaLBL";
			this.datumKreiranjaLBL.Size = new System.Drawing.Size(81, 13);
			this.datumKreiranjaLBL.TabIndex = 1;
			this.datumKreiranjaLBL.Text = "Datum kreiranja";
			// 
			// nazivTXT
			// 
			this.nazivTXT.Location = new System.Drawing.Point(111, 24);
			this.nazivTXT.Name = "nazivTXT";
			this.nazivTXT.Size = new System.Drawing.Size(200, 20);
			this.nazivTXT.TabIndex = 3;
			this.nazivTXT.TextChanged += new System.EventHandler(this.nazivTXT_TextChanged);
			// 
			// datumKreiranjaDTP
			// 
			this.datumKreiranjaDTP.Location = new System.Drawing.Point(111, 72);
			this.datumKreiranjaDTP.Name = "datumKreiranjaDTP";
			this.datumKreiranjaDTP.Size = new System.Drawing.Size(200, 20);
			this.datumKreiranjaDTP.TabIndex = 5;
			// 
			// dodatiBTN
			// 
			this.dodatiBTN.Location = new System.Drawing.Point(236, 222);
			this.dodatiBTN.Name = "dodatiBTN";
			this.dodatiBTN.Size = new System.Drawing.Size(75, 23);
			this.dodatiBTN.TabIndex = 6;
			this.dodatiBTN.Text = "Dodati";
			this.dodatiBTN.UseVisualStyleBackColor = true;
			this.dodatiBTN.Click += new System.EventHandler(this.dodatiBTN_Click);
			// 
			// nazivKorektnoLBL
			// 
			this.nazivKorektnoLBL.AutoSize = true;
			this.nazivKorektnoLBL.Location = new System.Drawing.Point(111, 53);
			this.nazivKorektnoLBL.Name = "nazivKorektnoLBL";
			this.nazivKorektnoLBL.Size = new System.Drawing.Size(0, 13);
			this.nazivKorektnoLBL.TabIndex = 7;
			// 
			// sefProjektaLBL
			// 
			this.sefProjektaLBL.AutoSize = true;
			this.sefProjektaLBL.Location = new System.Drawing.Point(24, 131);
			this.sefProjektaLBL.Name = "sefProjektaLBL";
			this.sefProjektaLBL.Size = new System.Drawing.Size(65, 13);
			this.sefProjektaLBL.TabIndex = 8;
			this.sefProjektaLBL.Text = "Šef Projekta";
			// 
			// sefProjektaCB
			// 
			this.sefProjektaCB.FormattingEnabled = true;
			this.sefProjektaCB.Location = new System.Drawing.Point(114, 128);
			this.sefProjektaCB.Name = "sefProjektaCB";
			this.sefProjektaCB.Size = new System.Drawing.Size(197, 21);
			this.sefProjektaCB.TabIndex = 9;
			this.sefProjektaCB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sefProjektaCB_MouseClick);
			// 
			// ProjekatFormular
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(325, 289);
			this.Controls.Add(this.sefProjektaCB);
			this.Controls.Add(this.sefProjektaLBL);
			this.Controls.Add(this.nazivKorektnoLBL);
			this.Controls.Add(this.dodatiBTN);
			this.Controls.Add(this.datumKreiranjaDTP);
			this.Controls.Add(this.nazivTXT);
			this.Controls.Add(this.datumKreiranjaLBL);
			this.Controls.Add(this.nazivLBL);
			this.Name = "ProjekatFormular";
			this.Text = "Folmular za projekat";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label nazivLBL;
		private System.Windows.Forms.Label datumKreiranjaLBL;
		private System.Windows.Forms.TextBox nazivTXT;
		private System.Windows.Forms.DateTimePicker datumKreiranjaDTP;
		private System.Windows.Forms.Button dodatiBTN;
		private System.Windows.Forms.Label nazivKorektnoLBL;
		private System.Windows.Forms.Label sefProjektaLBL;
		private System.Windows.Forms.ComboBox sefProjektaCB;
	}
}