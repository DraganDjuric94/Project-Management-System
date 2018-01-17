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
            this.detaljiPNL = new System.Windows.Forms.Panel();
            this.projekat = new System.Windows.Forms.Button();
            this.zadatak = new System.Windows.Forms.Button();
            this.aktivnost = new System.Windows.Forms.Button();
            this.mojiProjektiPNL.SuspendLayout();
            this.SuspendLayout();
            // 
            // mojiProjektiPNL
            // 
            this.mojiProjektiPNL.Controls.Add(this.aktivnost);
            this.mojiProjektiPNL.Controls.Add(this.zadatak);
            this.mojiProjektiPNL.Controls.Add(this.projekat);
            this.mojiProjektiPNL.Location = new System.Drawing.Point(12, 12);
            this.mojiProjektiPNL.Name = "mojiProjektiPNL";
            this.mojiProjektiPNL.Size = new System.Drawing.Size(200, 557);
            this.mojiProjektiPNL.TabIndex = 0;
            // 
            // detaljiPNL
            // 
            this.detaljiPNL.Location = new System.Drawing.Point(218, 12);
            this.detaljiPNL.Name = "detaljiPNL";
            this.detaljiPNL.Size = new System.Drawing.Size(924, 557);
            this.detaljiPNL.TabIndex = 1;
            // 
            // projekat
            // 
            this.projekat.Location = new System.Drawing.Point(56, 26);
            this.projekat.Name = "projekat";
            this.projekat.Size = new System.Drawing.Size(75, 23);
            this.projekat.TabIndex = 0;
            this.projekat.Text = "button1";
            this.projekat.UseVisualStyleBackColor = true;
            this.projekat.Click += new System.EventHandler(this.projekat_Click);
            // 
            // zadatak
            // 
            this.zadatak.Location = new System.Drawing.Point(83, 66);
            this.zadatak.Name = "zadatak";
            this.zadatak.Size = new System.Drawing.Size(75, 23);
            this.zadatak.TabIndex = 1;
            this.zadatak.Text = "button2";
            this.zadatak.UseVisualStyleBackColor = true;
            this.zadatak.Click += new System.EventHandler(this.zadatak_Click);
            // 
            // aktivnost
            // 
            this.aktivnost.Location = new System.Drawing.Point(83, 115);
            this.aktivnost.Name = "aktivnost";
            this.aktivnost.Size = new System.Drawing.Size(75, 23);
            this.aktivnost.TabIndex = 2;
            this.aktivnost.Text = "button3";
            this.aktivnost.UseVisualStyleBackColor = true;
            this.aktivnost.Click += new System.EventHandler(this.aktivnost_Click);
            // 
            // ProjektiSefs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 581);
            this.Controls.Add(this.detaljiPNL);
            this.Controls.Add(this.mojiProjektiPNL);
            this.Name = "ProjektiSefs";
            this.Text = "Projects";
            this.mojiProjektiPNL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mojiProjektiPNL;
        private System.Windows.Forms.Panel detaljiPNL;
        private System.Windows.Forms.Button aktivnost;
        private System.Windows.Forms.Button zadatak;
        private System.Windows.Forms.Button projekat;
    }
}