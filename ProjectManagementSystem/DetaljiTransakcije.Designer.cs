namespace ProjectManagementSystem {
    partial class DetaljiTransakcije {
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
            this.label1 = new System.Windows.Forms.Label();
            this.iznosLBL = new System.Windows.Forms.Label();
            this.vrstaLBL = new System.Windows.Forms.Label();
            this.datumLBL = new System.Windows.Forms.Label();
            this.opisTXT = new System.Windows.Forms.TextBox();
            this.zatvoriBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opis:";
            // 
            // iznosLBL
            // 
            this.iznosLBL.AutoSize = true;
            this.iznosLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iznosLBL.Location = new System.Drawing.Point(12, 241);
            this.iznosLBL.Name = "iznosLBL";
            this.iznosLBL.Size = new System.Drawing.Size(83, 17);
            this.iznosLBL.TabIndex = 2;
            this.iznosLBL.Text = "Iynosssssss";
            // 
            // vrstaLBL
            // 
            this.vrstaLBL.AutoSize = true;
            this.vrstaLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vrstaLBL.Location = new System.Drawing.Point(12, 207);
            this.vrstaLBL.Name = "vrstaLBL";
            this.vrstaLBL.Size = new System.Drawing.Size(165, 17);
            this.vrstaLBL.TabIndex = 3;
            this.vrstaLBL.Text = "Vrsta transakcije:            ";
            // 
            // datumLBL
            // 
            this.datumLBL.AutoSize = true;
            this.datumLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datumLBL.Location = new System.Drawing.Point(12, 173);
            this.datumLBL.Name = "datumLBL";
            this.datumLBL.Size = new System.Drawing.Size(154, 17);
            this.datumLBL.TabIndex = 4;
            this.datumLBL.Text = "DAtum transakcije:       ";
            // 
            // opisTXT
            // 
            this.opisTXT.Location = new System.Drawing.Point(15, 40);
            this.opisTXT.Multiline = true;
            this.opisTXT.Name = "opisTXT";
            this.opisTXT.ReadOnly = true;
            this.opisTXT.Size = new System.Drawing.Size(343, 114);
            this.opisTXT.TabIndex = 5;
            // 
            // zatvoriBTN
            // 
            this.zatvoriBTN.Location = new System.Drawing.Point(283, 349);
            this.zatvoriBTN.Name = "zatvoriBTN";
            this.zatvoriBTN.Size = new System.Drawing.Size(75, 23);
            this.zatvoriBTN.TabIndex = 6;
            this.zatvoriBTN.Text = "Zatvori";
            this.zatvoriBTN.UseVisualStyleBackColor = true;
            this.zatvoriBTN.Click += new System.EventHandler(this.zatvoriBTN_Click);
            // 
            // DetaljiTransakcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 384);
            this.Controls.Add(this.zatvoriBTN);
            this.Controls.Add(this.opisTXT);
            this.Controls.Add(this.datumLBL);
            this.Controls.Add(this.vrstaLBL);
            this.Controls.Add(this.iznosLBL);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetaljiTransakcije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalji transakcije";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label iznosLBL;
        private System.Windows.Forms.Label vrstaLBL;
        private System.Windows.Forms.Label datumLBL;
        private System.Windows.Forms.TextBox opisTXT;
        private System.Windows.Forms.Button zatvoriBTN;
    }
}