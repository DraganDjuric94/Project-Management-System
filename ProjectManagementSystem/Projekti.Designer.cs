namespace ProjectManagementSystem {
    partial class Projekti {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Projekti));
            this.mojiProjektiPNL = new System.Windows.Forms.Panel();
            this.komandeTSR = new System.Windows.Forms.ToolStrip();
            this.azrirajTSB = new System.Windows.Forms.ToolStripButton();
            this.obrisiTSB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dodajZadatakTSB = new System.Windows.Forms.ToolStripButton();
            this.dodajAktivnostTSB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.prikaziIzvjestajTSB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.dodajUcesnikaTSB = new System.Windows.Forms.ToolStripButton();
            this.projektiTVW = new System.Windows.Forms.TreeView();
            this.slikeProjektiIML = new System.Windows.Forms.ImageList(this.components);
            this.detaljiPNL = new System.Windows.Forms.Panel();
            this.projektiSPL = new System.Windows.Forms.SplitContainer();
            this.mojiProjektiPNL.SuspendLayout();
            this.komandeTSR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projektiSPL)).BeginInit();
            this.projektiSPL.Panel1.SuspendLayout();
            this.projektiSPL.Panel2.SuspendLayout();
            this.projektiSPL.SuspendLayout();
            this.SuspendLayout();
            // 
            // mojiProjektiPNL
            // 
            this.mojiProjektiPNL.Controls.Add(this.komandeTSR);
            this.mojiProjektiPNL.Controls.Add(this.projektiTVW);
            this.mojiProjektiPNL.Location = new System.Drawing.Point(3, 3);
            this.mojiProjektiPNL.Name = "mojiProjektiPNL";
            this.mojiProjektiPNL.Size = new System.Drawing.Size(297, 557);
            this.mojiProjektiPNL.TabIndex = 0;
            // 
            // komandeTSR
            // 
            this.komandeTSR.AutoSize = false;
            this.komandeTSR.BackColor = System.Drawing.SystemColors.Control;
            this.komandeTSR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.komandeTSR.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.komandeTSR.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.azrirajTSB,
            this.obrisiTSB,
            this.toolStripSeparator1,
            this.dodajZadatakTSB,
            this.dodajAktivnostTSB,
            this.toolStripSeparator2,
            this.prikaziIzvjestajTSB,
            this.toolStripSeparator4,
            this.dodajUcesnikaTSB});
            this.komandeTSR.Location = new System.Drawing.Point(0, 0);
            this.komandeTSR.Name = "komandeTSR";
            this.komandeTSR.Size = new System.Drawing.Size(297, 38);
            this.komandeTSR.TabIndex = 4;
            this.komandeTSR.Text = "toolStrip1";
            // 
            // azrirajTSB
            // 
            this.azrirajTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.azrirajTSB.Enabled = false;
            this.azrirajTSB.Image = global::ProjectManagementSystem.Properties.Resources.edit;
            this.azrirajTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.azrirajTSB.Name = "azrirajTSB";
            this.azrirajTSB.Size = new System.Drawing.Size(29, 35);
            this.azrirajTSB.Text = "Ažuriraj";
            this.azrirajTSB.Click += new System.EventHandler(this.azrirajTSB_Click);
            // 
            // obrisiTSB
            // 
            this.obrisiTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.obrisiTSB.Enabled = false;
            this.obrisiTSB.Image = global::ProjectManagementSystem.Properties.Resources.delete;
            this.obrisiTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.obrisiTSB.Name = "obrisiTSB";
            this.obrisiTSB.Size = new System.Drawing.Size(29, 35);
            this.obrisiTSB.Text = "Obriši";
            this.obrisiTSB.Click += new System.EventHandler(this.obrisiTSB_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // dodajZadatakTSB
            // 
            this.dodajZadatakTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dodajZadatakTSB.Enabled = false;
            this.dodajZadatakTSB.Image = global::ProjectManagementSystem.Properties.Resources.dodajZ;
            this.dodajZadatakTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dodajZadatakTSB.Name = "dodajZadatakTSB";
            this.dodajZadatakTSB.Size = new System.Drawing.Size(29, 35);
            this.dodajZadatakTSB.Text = "Dodaj zadatak";
            this.dodajZadatakTSB.Click += new System.EventHandler(this.dodajZadatakTSB_Click);
            // 
            // dodajAktivnostTSB
            // 
            this.dodajAktivnostTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dodajAktivnostTSB.Enabled = false;
            this.dodajAktivnostTSB.Image = global::ProjectManagementSystem.Properties.Resources.dodajA;
            this.dodajAktivnostTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dodajAktivnostTSB.Name = "dodajAktivnostTSB";
            this.dodajAktivnostTSB.Size = new System.Drawing.Size(29, 35);
            this.dodajAktivnostTSB.Text = "Dodaj aktivnost";
            this.dodajAktivnostTSB.Click += new System.EventHandler(this.dodajAktivnostTSB_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // prikaziIzvjestajTSB
            // 
            this.prikaziIzvjestajTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prikaziIzvjestajTSB.Enabled = false;
            this.prikaziIzvjestajTSB.Image = global::ProjectManagementSystem.Properties.Resources.print;
            this.prikaziIzvjestajTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.prikaziIzvjestajTSB.Name = "prikaziIzvjestajTSB";
            this.prikaziIzvjestajTSB.Size = new System.Drawing.Size(29, 35);
            this.prikaziIzvjestajTSB.Text = "Prikaži izvještaj";
            this.prikaziIzvjestajTSB.Click += new System.EventHandler(this.prikaziIzvjestajTSB_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // dodajUcesnikaTSB
            // 
            this.dodajUcesnikaTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dodajUcesnikaTSB.Enabled = false;
            this.dodajUcesnikaTSB.Image = global::ProjectManagementSystem.Properties.Resources.add_user;
            this.dodajUcesnikaTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dodajUcesnikaTSB.Name = "dodajUcesnikaTSB";
            this.dodajUcesnikaTSB.Size = new System.Drawing.Size(29, 35);
            this.dodajUcesnikaTSB.Text = "Dodaj učesnika";
            this.dodajUcesnikaTSB.Click += new System.EventHandler(this.dodajUcesnikaTSB_Click);
            // 
            // projektiTVW
            // 
            this.projektiTVW.ImageIndex = 0;
            this.projektiTVW.ImageList = this.slikeProjektiIML;
            this.projektiTVW.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.projektiTVW.Location = new System.Drawing.Point(12, 41);
            this.projektiTVW.Name = "projektiTVW";
            this.projektiTVW.SelectedImageIndex = 0;
            this.projektiTVW.Size = new System.Drawing.Size(271, 510);
            this.projektiTVW.TabIndex = 3;
            this.projektiTVW.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.projektiTVW_AfterSelect);
            // 
            // slikeProjektiIML
            // 
            this.slikeProjektiIML.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("slikeProjektiIML.ImageStream")));
            this.slikeProjektiIML.TransparentColor = System.Drawing.Color.Transparent;
            this.slikeProjektiIML.Images.SetKeyName(0, "a.png");
            this.slikeProjektiIML.Images.SetKeyName(1, "c.png");
            this.slikeProjektiIML.Images.SetKeyName(2, "p.png");
            // 
            // detaljiPNL
            // 
            this.detaljiPNL.Location = new System.Drawing.Point(3, 3);
            this.detaljiPNL.Name = "detaljiPNL";
            this.detaljiPNL.Size = new System.Drawing.Size(900, 550);
            this.detaljiPNL.TabIndex = 1;
            // 
            // projektiSPL
            // 
            this.projektiSPL.IsSplitterFixed = true;
            this.projektiSPL.Location = new System.Drawing.Point(12, 12);
            this.projektiSPL.Name = "projektiSPL";
            // 
            // projektiSPL.Panel1
            // 
            this.projektiSPL.Panel1.Controls.Add(this.mojiProjektiPNL);
            // 
            // projektiSPL.Panel2
            // 
            this.projektiSPL.Panel2.Controls.Add(this.detaljiPNL);
            this.projektiSPL.Size = new System.Drawing.Size(1211, 557);
            this.projektiSPL.SplitterDistance = 305;
            this.projektiSPL.TabIndex = 3;
            // 
            // Projekti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 581);
            this.Controls.Add(this.projektiSPL);
            this.MaximizeBox = false;
            this.Name = "Projekti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projekti";
            this.Load += new System.EventHandler(this.Projekti_Load);
            this.mojiProjektiPNL.ResumeLayout(false);
            this.komandeTSR.ResumeLayout(false);
            this.komandeTSR.PerformLayout();
            this.projektiSPL.Panel1.ResumeLayout(false);
            this.projektiSPL.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projektiSPL)).EndInit();
            this.projektiSPL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mojiProjektiPNL;
        private System.Windows.Forms.Panel detaljiPNL;
        private System.Windows.Forms.TreeView projektiTVW;
        private System.Windows.Forms.SplitContainer projektiSPL;
        private System.Windows.Forms.ImageList slikeProjektiIML;
        private System.Windows.Forms.ToolStrip komandeTSR;
        private System.Windows.Forms.ToolStripButton azrirajTSB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton dodajZadatakTSB;
        private System.Windows.Forms.ToolStripButton dodajAktivnostTSB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton prikaziIzvjestajTSB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton dodajUcesnikaTSB;
        private System.Windows.Forms.ToolStripButton obrisiTSB;
    }
}