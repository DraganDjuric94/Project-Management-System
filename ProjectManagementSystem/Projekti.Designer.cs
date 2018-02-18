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
            this.projektiTVW = new System.Windows.Forms.TreeView();
            this.slikeProjektiIML = new System.Windows.Forms.ImageList(this.components);
            this.detaljiPNL = new System.Windows.Forms.Panel();
            this.projektiSPL = new System.Windows.Forms.SplitContainer();
            this.mojiProjektiPNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projektiSPL)).BeginInit();
            this.projektiSPL.Panel1.SuspendLayout();
            this.projektiSPL.Panel2.SuspendLayout();
            this.projektiSPL.SuspendLayout();
            this.SuspendLayout();
            // 
            // mojiProjektiPNL
            // 
            this.mojiProjektiPNL.Controls.Add(this.projektiTVW);
            this.mojiProjektiPNL.Location = new System.Drawing.Point(0, 0);
            this.mojiProjektiPNL.Name = "mojiProjektiPNL";
            this.mojiProjektiPNL.Size = new System.Drawing.Size(279, 557);
            this.mojiProjektiPNL.TabIndex = 0;
            // 
            // projektiTVW
            // 
            this.projektiTVW.ImageIndex = 0;
            this.projektiTVW.ImageList = this.slikeProjektiIML;
            this.projektiTVW.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.projektiTVW.Location = new System.Drawing.Point(16, 16);
            this.projektiTVW.Name = "projektiTVW";
            this.projektiTVW.SelectedImageIndex = 0;
            this.projektiTVW.Size = new System.Drawing.Size(248, 519);
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
            this.detaljiPNL.Location = new System.Drawing.Point(3, 0);
            this.detaljiPNL.Name = "detaljiPNL";
            this.detaljiPNL.Size = new System.Drawing.Size(867, 557);
            this.detaljiPNL.TabIndex = 1;
            // 
            // projektiSPL
            // 
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
            this.projektiSPL.Size = new System.Drawing.Size(1130, 557);
            this.projektiSPL.SplitterDistance = 294;
            this.projektiSPL.TabIndex = 3;
            // 
            // Projekti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 581);
            this.Controls.Add(this.projektiSPL);
            this.Name = "Projekti";
            this.Text = "Projects";
            this.Load += new System.EventHandler(this.Projekti_Load);
            this.mojiProjektiPNL.ResumeLayout(false);
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
    }
}