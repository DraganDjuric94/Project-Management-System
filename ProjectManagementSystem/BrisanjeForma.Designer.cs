﻿namespace ProjectManagementSystem {
    partial class BrisanjeForma {
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
            this.label2 = new System.Windows.Forms.Label();
            this.odustaniBTN = new System.Windows.Forms.Button();
            this.obrisiBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Da li ste sigurni da želite obrisati izabrane podatke?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ova operacija čini izabrane podatke nedostupnim i ostalim korisnicima.";
            // 
            // odustaniBTN
            // 
            this.odustaniBTN.Location = new System.Drawing.Point(370, 111);
            this.odustaniBTN.Name = "odustaniBTN";
            this.odustaniBTN.Size = new System.Drawing.Size(75, 23);
            this.odustaniBTN.TabIndex = 2;
            this.odustaniBTN.Text = "Odustani";
            this.odustaniBTN.UseVisualStyleBackColor = true;
            this.odustaniBTN.Click += new System.EventHandler(this.odustaniBTN_Click);
            // 
            // obrisiBTN
            // 
            this.obrisiBTN.Location = new System.Drawing.Point(289, 111);
            this.obrisiBTN.Name = "obrisiBTN";
            this.obrisiBTN.Size = new System.Drawing.Size(75, 23);
            this.obrisiBTN.TabIndex = 3;
            this.obrisiBTN.Text = "Obriši";
            this.obrisiBTN.UseVisualStyleBackColor = true;
            this.obrisiBTN.Click += new System.EventHandler(this.obrisiBTN_Click);
            // 
            // BrisanjeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 146);
            this.Controls.Add(this.obrisiBTN);
            this.Controls.Add(this.odustaniBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BrisanjeForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brisanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button odustaniBTN;
        private System.Windows.Forms.Button obrisiBTN;
    }
}