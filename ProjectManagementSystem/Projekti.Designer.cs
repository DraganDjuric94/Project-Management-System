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
            this.mojiProjektiPNL = new System.Windows.Forms.Panel();
            this.aktivnost = new System.Windows.Forms.Button();
            this.zadatak = new System.Windows.Forms.Button();
            this.projekat = new System.Windows.Forms.Button();
            this.detaljiPNL = new System.Windows.Forms.Panel();
            this.projektiTVW = new System.Windows.Forms.TreeView();
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
            this.mojiProjektiPNL.Controls.Add(this.aktivnost);
            this.mojiProjektiPNL.Controls.Add(this.zadatak);
            this.mojiProjektiPNL.Controls.Add(this.projekat);
            this.mojiProjektiPNL.Controls.Add(this.projektiTVW);
            this.mojiProjektiPNL.Location = new System.Drawing.Point(0, 0);
            this.mojiProjektiPNL.Name = "mojiProjektiPNL";
            this.mojiProjektiPNL.Size = new System.Drawing.Size(253, 557);
            this.mojiProjektiPNL.TabIndex = 0;
            // 
            // aktivnost
            // 
            this.aktivnost.Location = new System.Drawing.Point(97, 487);
            this.aktivnost.Name = "aktivnost";
            this.aktivnost.Size = new System.Drawing.Size(75, 23);
            this.aktivnost.TabIndex = 2;
            this.aktivnost.Text = "button3";
            this.aktivnost.UseVisualStyleBackColor = true;
            this.aktivnost.Click += new System.EventHandler(this.aktivnost_Click);
            // 
            // zadatak
            // 
            this.zadatak.Location = new System.Drawing.Point(63, 516);
            this.zadatak.Name = "zadatak";
            this.zadatak.Size = new System.Drawing.Size(75, 23);
            this.zadatak.TabIndex = 1;
            this.zadatak.Text = "button2";
            this.zadatak.UseVisualStyleBackColor = true;
            this.zadatak.Click += new System.EventHandler(this.zadatak_Click);
            // 
            // projekat
            // 
            this.projekat.Location = new System.Drawing.Point(16, 487);
            this.projekat.Name = "projekat";
            this.projekat.Size = new System.Drawing.Size(75, 23);
            this.projekat.TabIndex = 0;
            this.projekat.Text = "button1";
            this.projekat.UseVisualStyleBackColor = true;
            this.projekat.Click += new System.EventHandler(this.projekat_Click);
            // 
            // detaljiPNL
            // 
            this.detaljiPNL.Location = new System.Drawing.Point(3, 0);
            this.detaljiPNL.Name = "detaljiPNL";
            this.detaljiPNL.Size = new System.Drawing.Size(867, 557);
            this.detaljiPNL.TabIndex = 1;
            // 
            // projektiTVW
            // 
            this.projektiTVW.Location = new System.Drawing.Point(16, 16);
            this.projektiTVW.Name = "projektiTVW";
            this.projektiTVW.Size = new System.Drawing.Size(219, 465);
            this.projektiTVW.TabIndex = 3;
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
            this.projektiSPL.SplitterDistance = 256;
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
        private System.Windows.Forms.Button aktivnost;
        private System.Windows.Forms.Button zadatak;
        private System.Windows.Forms.Button projekat;
        private System.Windows.Forms.TreeView projektiTVW;
        private System.Windows.Forms.SplitContainer projektiSPL;
    }
}