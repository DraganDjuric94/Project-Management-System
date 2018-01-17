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
            this.nazivZadatkaLBL = new System.Windows.Forms.Label();
            this.opisZadatkaLBL = new System.Windows.Forms.Label();
            this.ucesniciLBL = new System.Windows.Forms.Label();
            this.procenatZadatakLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nazivZadatkaLBL
            // 
            this.nazivZadatkaLBL.AutoSize = true;
            this.nazivZadatkaLBL.Location = new System.Drawing.Point(375, 33);
            this.nazivZadatkaLBL.Name = "nazivZadatkaLBL";
            this.nazivZadatkaLBL.Size = new System.Drawing.Size(75, 13);
            this.nazivZadatkaLBL.TabIndex = 0;
            this.nazivZadatkaLBL.Text = "Naziv zadatka";
            // 
            // opisZadatkaLBL
            // 
            this.opisZadatkaLBL.AutoSize = true;
            this.opisZadatkaLBL.Location = new System.Drawing.Point(109, 117);
            this.opisZadatkaLBL.Name = "opisZadatkaLBL";
            this.opisZadatkaLBL.Size = new System.Drawing.Size(69, 13);
            this.opisZadatkaLBL.TabIndex = 1;
            this.opisZadatkaLBL.Text = "Opis zadatka";
            // 
            // ucesniciLBL
            // 
            this.ucesniciLBL.AutoSize = true;
            this.ucesniciLBL.Location = new System.Drawing.Point(109, 264);
            this.ucesniciLBL.Name = "ucesniciLBL";
            this.ucesniciLBL.Size = new System.Drawing.Size(51, 13);
            this.ucesniciLBL.TabIndex = 2;
            this.ucesniciLBL.Text = "Učesnici:";
            // 
            // procenatZadatakLBL
            // 
            this.procenatZadatakLBL.AutoSize = true;
            this.procenatZadatakLBL.Location = new System.Drawing.Point(109, 458);
            this.procenatZadatakLBL.Name = "procenatZadatakLBL";
            this.procenatZadatakLBL.Size = new System.Drawing.Size(27, 13);
            this.procenatZadatakLBL.TabIndex = 3;
            this.procenatZadatakLBL.Text = "45%";
            this.procenatZadatakLBL.Click += new System.EventHandler(this.label4_Click);
            // 
            // UcesnikProjekatDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.procenatZadatakLBL);
            this.Controls.Add(this.ucesniciLBL);
            this.Controls.Add(this.opisZadatkaLBL);
            this.Controls.Add(this.nazivZadatkaLBL);
            this.Name = "UcesnikProjekatDetalji";
            this.Size = new System.Drawing.Size(900, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nazivZadatkaLBL;
        private System.Windows.Forms.Label opisZadatkaLBL;
        private System.Windows.Forms.Label ucesniciLBL;
        private System.Windows.Forms.Label procenatZadatakLBL;
    }
}
