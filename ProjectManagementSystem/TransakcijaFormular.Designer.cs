﻿namespace ProjectManagementSystem {
    partial class TransakcijaFormular {
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
            this.rashodRBT = new System.Windows.Forms.RadioButton();
            this.prihodRBT = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.opisTBX = new System.Windows.Forms.TextBox();
            this.datumTransakcijeDTP = new System.Windows.Forms.DateTimePicker();
            this.sacuvajBTN = new System.Windows.Forms.Button();
            this.iznosTBX = new System.Windows.Forms.NumericUpDown();
            this.errorLBL = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iznosTBX)).BeginInit();
            this.SuspendLayout();
            // 
            // rashodRBT
            // 
            this.rashodRBT.AutoSize = true;
            this.rashodRBT.Location = new System.Drawing.Point(17, 64);
            this.rashodRBT.Name = "rashodRBT";
            this.rashodRBT.Size = new System.Drawing.Size(62, 17);
            this.rashodRBT.TabIndex = 1;
            this.rashodRBT.TabStop = true;
            this.rashodRBT.Text = "Rashod";
            this.rashodRBT.UseVisualStyleBackColor = true;
            // 
            // prihodRBT
            // 
            this.prihodRBT.AutoSize = true;
            this.prihodRBT.Checked = true;
            this.prihodRBT.Location = new System.Drawing.Point(17, 30);
            this.prihodRBT.Name = "prihodRBT";
            this.prihodRBT.Size = new System.Drawing.Size(55, 17);
            this.prihodRBT.TabIndex = 0;
            this.prihodRBT.TabStop = true;
            this.prihodRBT.Text = "Prihod";
            this.prihodRBT.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rashodRBT);
            this.groupBox1.Controls.Add(this.prihodRBT);
            this.groupBox1.Location = new System.Drawing.Point(15, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vrsta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Opis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Datum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Iznos:";
            // 
            // opisTBX
            // 
            this.opisTBX.Location = new System.Drawing.Point(15, 36);
            this.opisTBX.Multiline = true;
            this.opisTBX.Name = "opisTBX";
            this.opisTBX.Size = new System.Drawing.Size(474, 117);
            this.opisTBX.TabIndex = 0;
            // 
            // datumTransakcijeDTP
            // 
            this.datumTransakcijeDTP.Location = new System.Drawing.Point(59, 179);
            this.datumTransakcijeDTP.Name = "datumTransakcijeDTP";
            this.datumTransakcijeDTP.Size = new System.Drawing.Size(200, 20);
            this.datumTransakcijeDTP.TabIndex = 1;
            // 
            // sacuvajBTN
            // 
            this.sacuvajBTN.Location = new System.Drawing.Point(414, 431);
            this.sacuvajBTN.Name = "sacuvajBTN";
            this.sacuvajBTN.Size = new System.Drawing.Size(75, 23);
            this.sacuvajBTN.TabIndex = 4;
            this.sacuvajBTN.Text = "Sačuvaj";
            this.sacuvajBTN.UseVisualStyleBackColor = true;
            this.sacuvajBTN.Click += new System.EventHandler(this.sacuvajBTN_Click);
            // 
            // iznosTBX
            // 
            this.iznosTBX.DecimalPlaces = 4;
            this.iznosTBX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.iznosTBX.Location = new System.Drawing.Point(59, 232);
            this.iznosTBX.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.iznosTBX.Name = "iznosTBX";
            this.iznosTBX.Size = new System.Drawing.Size(200, 20);
            this.iznosTBX.TabIndex = 2;
            // 
            // errorLBL
            // 
            this.errorLBL.AutoSize = true;
            this.errorLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorLBL.Location = new System.Drawing.Point(309, 400);
            this.errorLBL.Name = "errorLBL";
            this.errorLBL.Size = new System.Drawing.Size(180, 17);
            this.errorLBL.TabIndex = 8;
            this.errorLBL.Text = "Unešeni podaci nisu validni";
            this.errorLBL.Visible = false;
            // 
            // TransakcijaFormular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 466);
            this.Controls.Add(this.errorLBL);
            this.Controls.Add(this.iznosTBX);
            this.Controls.Add(this.sacuvajBTN);
            this.Controls.Add(this.datumTransakcijeDTP);
            this.Controls.Add(this.opisTBX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransakcijaFormular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formular za transakciju";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iznosTBX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rashodRBT;
        private System.Windows.Forms.RadioButton prihodRBT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox opisTBX;
        private System.Windows.Forms.DateTimePicker datumTransakcijeDTP;
        private System.Windows.Forms.Button sacuvajBTN;
        private System.Windows.Forms.NumericUpDown iznosTBX;
        private System.Windows.Forms.Label errorLBL;
    }
}