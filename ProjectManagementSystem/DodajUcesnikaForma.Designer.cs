﻿namespace ProjectManagementSystem {
    partial class DodajUcesnikaForma {
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
            this.moguciUcesniciCBX = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dodajBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // moguciUcesniciCBX
            // 
            this.moguciUcesniciCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.moguciUcesniciCBX.Location = new System.Drawing.Point(62, 17);
            this.moguciUcesniciCBX.Name = "moguciUcesniciCBX";
            this.moguciUcesniciCBX.Size = new System.Drawing.Size(246, 21);
            this.moguciUcesniciCBX.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Učesnik:";
            // 
            // dodajBTN
            // 
            this.dodajBTN.Location = new System.Drawing.Point(233, 56);
            this.dodajBTN.Name = "dodajBTN";
            this.dodajBTN.Size = new System.Drawing.Size(75, 23);
            this.dodajBTN.TabIndex = 2;
            this.dodajBTN.Text = "Dodaj";
            this.dodajBTN.UseVisualStyleBackColor = true;
            this.dodajBTN.Click += new System.EventHandler(this.dodajBTN_Click);
            // 
            // DodajUcesnikaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 98);
            this.Controls.Add(this.dodajBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moguciUcesniciCBX);
            this.Name = "DodajUcesnikaForma";
            this.Text = "DodajUcesnikaForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox moguciUcesniciCBX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dodajBTN;
    }
}