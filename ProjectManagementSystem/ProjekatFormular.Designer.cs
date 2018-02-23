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
            this.nazivTXT = new System.Windows.Forms.TextBox();
            this.dodatiBTN = new System.Windows.Forms.Button();
            this.nazivKorektnoLBL = new System.Windows.Forms.Label();
            this.sefProjektaLBL = new System.Windows.Forms.Label();
            this.sefProjektaCB = new System.Windows.Forms.ComboBox();
            this.errorLBL = new System.Windows.Forms.Label();
            this.aktivanCBX = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // nazivLBL
            // 
            this.nazivLBL.AutoSize = true;
            this.nazivLBL.Location = new System.Drawing.Point(12, 27);
            this.nazivLBL.Name = "nazivLBL";
            this.nazivLBL.Size = new System.Drawing.Size(37, 13);
            this.nazivLBL.TabIndex = 3;
            this.nazivLBL.Text = "Naziv:";
            // 
            // nazivTXT
            // 
            this.nazivTXT.Location = new System.Drawing.Point(102, 24);
            this.nazivTXT.Name = "nazivTXT";
            this.nazivTXT.Size = new System.Drawing.Size(238, 20);
            this.nazivTXT.TabIndex = 0;
            this.nazivTXT.TextChanged += new System.EventHandler(this.nazivTXT_TextChanged);
            // 
            // dodatiBTN
            // 
            this.dodatiBTN.Location = new System.Drawing.Point(265, 161);
            this.dodatiBTN.Name = "dodatiBTN";
            this.dodatiBTN.Size = new System.Drawing.Size(75, 23);
            this.dodatiBTN.TabIndex = 2;
            this.dodatiBTN.Text = "Sačuvaj";
            this.dodatiBTN.UseVisualStyleBackColor = true;
            this.dodatiBTN.Click += new System.EventHandler(this.dodatiBTN_Click);
            // 
            // nazivKorektnoLBL
            // 
            this.nazivKorektnoLBL.AutoSize = true;
            this.nazivKorektnoLBL.Location = new System.Drawing.Point(279, 47);
            this.nazivKorektnoLBL.Name = "nazivKorektnoLBL";
            this.nazivKorektnoLBL.Size = new System.Drawing.Size(0, 13);
            this.nazivKorektnoLBL.TabIndex = 5;
            // 
            // sefProjektaLBL
            // 
            this.sefProjektaLBL.AutoSize = true;
            this.sefProjektaLBL.Location = new System.Drawing.Point(12, 75);
            this.sefProjektaLBL.Name = "sefProjektaLBL";
            this.sefProjektaLBL.Size = new System.Drawing.Size(67, 13);
            this.sefProjektaLBL.TabIndex = 4;
            this.sefProjektaLBL.Text = "Šef projekta:";
            // 
            // sefProjektaCB
            // 
            this.sefProjektaCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sefProjektaCB.FormattingEnabled = true;
            this.sefProjektaCB.Location = new System.Drawing.Point(102, 72);
            this.sefProjektaCB.Name = "sefProjektaCB";
            this.sefProjektaCB.Size = new System.Drawing.Size(238, 21);
            this.sefProjektaCB.TabIndex = 1;
            this.sefProjektaCB.SelectedIndexChanged += new System.EventHandler(this.sefProjektaCB_SelectedIndexChanged);
            this.sefProjektaCB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sefProjektaCB_MouseClick);
            // 
            // errorLBL
            // 
            this.errorLBL.AutoSize = true;
            this.errorLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorLBL.Location = new System.Drawing.Point(160, 131);
            this.errorLBL.Name = "errorLBL";
            this.errorLBL.Size = new System.Drawing.Size(180, 17);
            this.errorLBL.TabIndex = 6;
            this.errorLBL.Text = "Unešeni podaci nisu validni";
            this.errorLBL.Visible = false;
            // 
            // aktivanCBX
            // 
            this.aktivanCBX.AutoSize = true;
            this.aktivanCBX.Checked = true;
            this.aktivanCBX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aktivanCBX.Location = new System.Drawing.Point(278, 111);
            this.aktivanCBX.Name = "aktivanCBX";
            this.aktivanCBX.Size = new System.Drawing.Size(62, 17);
            this.aktivanCBX.TabIndex = 7;
            this.aktivanCBX.Text = "Aktivan";
            this.aktivanCBX.UseVisualStyleBackColor = true;
            // 
            // ProjekatFormular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 196);
            this.Controls.Add(this.aktivanCBX);
            this.Controls.Add(this.errorLBL);
            this.Controls.Add(this.sefProjektaCB);
            this.Controls.Add(this.sefProjektaLBL);
            this.Controls.Add(this.nazivKorektnoLBL);
            this.Controls.Add(this.dodatiBTN);
            this.Controls.Add(this.nazivTXT);
            this.Controls.Add(this.nazivLBL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjekatFormular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folmular za projekat";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label nazivLBL;
		private System.Windows.Forms.TextBox nazivTXT;
		private System.Windows.Forms.Button dodatiBTN;
		private System.Windows.Forms.Label nazivKorektnoLBL;
		private System.Windows.Forms.Label sefProjektaLBL;
		private System.Windows.Forms.ComboBox sefProjektaCB;
        private System.Windows.Forms.Label errorLBL;
        private System.Windows.Forms.CheckBox aktivanCBX;
    }
}