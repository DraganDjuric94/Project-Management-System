namespace ProjectManagementSystem {
    partial class UcesnikProjekatDetalji {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.nazivProjektaLBL = new System.Windows.Forms.Label();
            this.sefProjektaLBL = new System.Windows.Forms.Label();
            this.procenatIzvrsenostiLBL = new System.Windows.Forms.Label();
            this.procenatIzvrsenostiPBR = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // nazivProjektaLBL
            // 
            this.nazivProjektaLBL.AutoSize = true;
            this.nazivProjektaLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazivProjektaLBL.Location = new System.Drawing.Point(23, 23);
            this.nazivProjektaLBL.Name = "nazivProjektaLBL";
            this.nazivProjektaLBL.Size = new System.Drawing.Size(273, 46);
            this.nazivProjektaLBL.TabIndex = 0;
            this.nazivProjektaLBL.Text = "Naziv projekta";
            // 
            // sefProjektaLBL
            // 
            this.sefProjektaLBL.AutoSize = true;
            this.sefProjektaLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sefProjektaLBL.Location = new System.Drawing.Point(27, 162);
            this.sefProjektaLBL.Name = "sefProjektaLBL";
            this.sefProjektaLBL.Size = new System.Drawing.Size(111, 22);
            this.sefProjektaLBL.TabIndex = 1;
            this.sefProjektaLBL.Text = "Šef projekta:";
            // 
            // procenatIzvrsenostiLBL
            // 
            this.procenatIzvrsenostiLBL.AutoSize = true;
            this.procenatIzvrsenostiLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procenatIzvrsenostiLBL.Location = new System.Drawing.Point(519, 98);
            this.procenatIzvrsenostiLBL.Name = "procenatIzvrsenostiLBL";
            this.procenatIzvrsenostiLBL.Size = new System.Drawing.Size(61, 29);
            this.procenatIzvrsenostiLBL.TabIndex = 2;
            this.procenatIzvrsenostiLBL.Text = "32%";
            // 
            // procenatIzvrsenostiPBR
            // 
            this.procenatIzvrsenostiPBR.Location = new System.Drawing.Point(31, 98);
            this.procenatIzvrsenostiPBR.Name = "procenatIzvrsenostiPBR";
            this.procenatIzvrsenostiPBR.Size = new System.Drawing.Size(482, 29);
            this.procenatIzvrsenostiPBR.TabIndex = 3;
            // 
            // UcesnikProjekatDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.procenatIzvrsenostiPBR);
            this.Controls.Add(this.procenatIzvrsenostiLBL);
            this.Controls.Add(this.sefProjektaLBL);
            this.Controls.Add(this.nazivProjektaLBL);
            this.Name = "UcesnikProjekatDetalji";
            this.Size = new System.Drawing.Size(900, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nazivProjektaLBL;
        private System.Windows.Forms.Label sefProjektaLBL;
        private System.Windows.Forms.Label procenatIzvrsenostiLBL;
        private System.Windows.Forms.ProgressBar procenatIzvrsenostiPBR;
    }
}
