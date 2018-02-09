namespace ProjectManagementSystem {
    partial class IzvjestajForma {
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
            this.sacuvajKaoPdfBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sacuvajKaoPdfBTN
            // 
            this.sacuvajKaoPdfBTN.Location = new System.Drawing.Point(618, 583);
            this.sacuvajKaoPdfBTN.Name = "sacuvajKaoPdfBTN";
            this.sacuvajKaoPdfBTN.Size = new System.Drawing.Size(107, 23);
            this.sacuvajKaoPdfBTN.TabIndex = 0;
            this.sacuvajKaoPdfBTN.Text = "Sačuvaj kao PDF";
            this.sacuvajKaoPdfBTN.UseVisualStyleBackColor = true;
            // 
            // IzvjestajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 618);
            this.Controls.Add(this.sacuvajKaoPdfBTN);
            this.Name = "IzvjestajForma";
            this.Text = "IzvjestajForma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sacuvajKaoPdfBTN;
    }
}