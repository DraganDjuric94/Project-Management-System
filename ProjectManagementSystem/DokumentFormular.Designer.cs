﻿namespace ProjectManagementSystem {
    partial class DokumentFormular {
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
            this.putanjaLBL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.napomenaTBX = new System.Windows.Forms.TextBox();
            this.sacuvajBTN = new System.Windows.Forms.Button();
            this.izaberiDokumentBTN = new System.Windows.Forms.Button();
            this.errorLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Izaberite dokument:";
            // 
            // putanjaLBL
            // 
            this.putanjaLBL.AutoSize = true;
            this.putanjaLBL.Location = new System.Drawing.Point(12, 46);
            this.putanjaLBL.Name = "putanjaLBL";
            this.putanjaLBL.Size = new System.Drawing.Size(0, 13);
            this.putanjaLBL.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Napomena:";
            // 
            // napomenaTBX
            // 
            this.napomenaTBX.Location = new System.Drawing.Point(15, 102);
            this.napomenaTBX.Multiline = true;
            this.napomenaTBX.Name = "napomenaTBX";
            this.napomenaTBX.Size = new System.Drawing.Size(275, 113);
            this.napomenaTBX.TabIndex = 1;
            // 
            // sacuvajBTN
            // 
            this.sacuvajBTN.Location = new System.Drawing.Point(215, 267);
            this.sacuvajBTN.Name = "sacuvajBTN";
            this.sacuvajBTN.Size = new System.Drawing.Size(75, 23);
            this.sacuvajBTN.TabIndex = 2;
            this.sacuvajBTN.Text = "Sačuvaj";
            this.sacuvajBTN.UseVisualStyleBackColor = true;
            this.sacuvajBTN.Click += new System.EventHandler(this.sacuvajBTN_Click);
            // 
            // izaberiDokumentBTN
            // 
            this.izaberiDokumentBTN.Location = new System.Drawing.Point(118, 18);
            this.izaberiDokumentBTN.Name = "izaberiDokumentBTN";
            this.izaberiDokumentBTN.Size = new System.Drawing.Size(34, 23);
            this.izaberiDokumentBTN.TabIndex = 0;
            this.izaberiDokumentBTN.Text = "...";
            this.izaberiDokumentBTN.UseVisualStyleBackColor = true;
            this.izaberiDokumentBTN.Click += new System.EventHandler(this.izaberiDokumentBTN_Click);
            // 
            // errorLBL
            // 
            this.errorLBL.AutoSize = true;
            this.errorLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorLBL.Location = new System.Drawing.Point(115, 236);
            this.errorLBL.Name = "errorLBL";
            this.errorLBL.Size = new System.Drawing.Size(180, 17);
            this.errorLBL.TabIndex = 6;
            this.errorLBL.Text = "Unešeni podaci nisu validni";
            this.errorLBL.Visible = false;
            // 
            // DokumentFormular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 302);
            this.Controls.Add(this.errorLBL);
            this.Controls.Add(this.izaberiDokumentBTN);
            this.Controls.Add(this.sacuvajBTN);
            this.Controls.Add(this.napomenaTBX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.putanjaLBL);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DokumentFormular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formular za dokument";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label putanjaLBL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox napomenaTBX;
        private System.Windows.Forms.Button sacuvajBTN;
        private System.Windows.Forms.Button izaberiDokumentBTN;
        private System.Windows.Forms.Label errorLBL;
    }
}