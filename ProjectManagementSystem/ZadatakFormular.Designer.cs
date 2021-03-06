﻿namespace ProjectManagementSystem
{
    partial class ZadatakFormular
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nazivLabel = new System.Windows.Forms.Label();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.rokLabel = new System.Windows.Forms.Label();
            this.rokDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.brojPotrebnihCovjekCasovaLabel = new System.Windows.Forms.Label();
            this.brojPotrebnihCovjekCasovaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ucesniciLabel = new System.Windows.Forms.Label();
            this.ubaciUcesnikaButton = new System.Windows.Forms.Button();
            this.izbaciUcesnikaButton = new System.Windows.Forms.Button();
            this.sacuvajBTN = new System.Windows.Forms.Button();
            this.procenatIzvrsenostiNUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dostupniUcesniciListBox = new System.Windows.Forms.ListView();
            this.ucesniciZadatkaListBox = new System.Windows.Forms.ListView();
            this.errorLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.brojPotrebnihCovjekCasovaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procenatIzvrsenostiNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // nazivLabel
            // 
            this.nazivLabel.AutoSize = true;
            this.nazivLabel.Location = new System.Drawing.Point(12, 9);
            this.nazivLabel.Name = "nazivLabel";
            this.nazivLabel.Size = new System.Drawing.Size(37, 13);
            this.nazivLabel.TabIndex = 9;
            this.nazivLabel.Text = "Naziv:";
            this.nazivLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.Location = new System.Drawing.Point(55, 6);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(425, 20);
            this.nazivTextBox.TabIndex = 0;
            // 
            // rokLabel
            // 
            this.rokLabel.AutoSize = true;
            this.rokLabel.Location = new System.Drawing.Point(12, 38);
            this.rokLabel.Name = "rokLabel";
            this.rokLabel.Size = new System.Drawing.Size(30, 13);
            this.rokLabel.TabIndex = 10;
            this.rokLabel.Text = "Rok:";
            // 
            // rokDateTimePicker
            // 
            this.rokDateTimePicker.Location = new System.Drawing.Point(55, 32);
            this.rokDateTimePicker.MinDate = new System.DateTime(2018, 2, 19, 10, 53, 20, 0);
            this.rokDateTimePicker.Name = "rokDateTimePicker";
            this.rokDateTimePicker.Size = new System.Drawing.Size(425, 20);
            this.rokDateTimePicker.TabIndex = 1;
            this.rokDateTimePicker.Value = new System.DateTime(2018, 2, 19, 10, 53, 24, 0);
            // 
            // brojPotrebnihCovjekCasovaLabel
            // 
            this.brojPotrebnihCovjekCasovaLabel.AutoSize = true;
            this.brojPotrebnihCovjekCasovaLabel.Location = new System.Drawing.Point(12, 71);
            this.brojPotrebnihCovjekCasovaLabel.Name = "brojPotrebnihCovjekCasovaLabel";
            this.brojPotrebnihCovjekCasovaLabel.Size = new System.Drawing.Size(150, 13);
            this.brojPotrebnihCovjekCasovaLabel.TabIndex = 11;
            this.brojPotrebnihCovjekCasovaLabel.Text = "Broj potrebnih čovjek/časova:";
            // 
            // brojPotrebnihCovjekCasovaNumericUpDown
            // 
            this.brojPotrebnihCovjekCasovaNumericUpDown.Location = new System.Drawing.Point(181, 69);
            this.brojPotrebnihCovjekCasovaNumericUpDown.Name = "brojPotrebnihCovjekCasovaNumericUpDown";
            this.brojPotrebnihCovjekCasovaNumericUpDown.Size = new System.Drawing.Size(299, 20);
            this.brojPotrebnihCovjekCasovaNumericUpDown.TabIndex = 2;
            // 
            // ucesniciLabel
            // 
            this.ucesniciLabel.AutoSize = true;
            this.ucesniciLabel.Location = new System.Drawing.Point(295, 141);
            this.ucesniciLabel.Name = "ucesniciLabel";
            this.ucesniciLabel.Size = new System.Drawing.Size(51, 13);
            this.ucesniciLabel.TabIndex = 13;
            this.ucesniciLabel.Text = "Učesnici:";
            this.ucesniciLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ubaciUcesnikaButton
            // 
            this.ubaciUcesnikaButton.Location = new System.Drawing.Point(229, 193);
            this.ubaciUcesnikaButton.Name = "ubaciUcesnikaButton";
            this.ubaciUcesnikaButton.Size = new System.Drawing.Size(46, 23);
            this.ubaciUcesnikaButton.TabIndex = 5;
            this.ubaciUcesnikaButton.Text = ">>";
            this.ubaciUcesnikaButton.UseVisualStyleBackColor = true;
            this.ubaciUcesnikaButton.Click += new System.EventHandler(this.ubaciUcesnikaButton_Click);
            // 
            // izbaciUcesnikaButton
            // 
            this.izbaciUcesnikaButton.Location = new System.Drawing.Point(229, 222);
            this.izbaciUcesnikaButton.Name = "izbaciUcesnikaButton";
            this.izbaciUcesnikaButton.Size = new System.Drawing.Size(46, 23);
            this.izbaciUcesnikaButton.TabIndex = 6;
            this.izbaciUcesnikaButton.Text = "<<";
            this.izbaciUcesnikaButton.UseVisualStyleBackColor = true;
            this.izbaciUcesnikaButton.Click += new System.EventHandler(this.izbaciUcesnikaButton_Click);
            // 
            // sacuvajBTN
            // 
            this.sacuvajBTN.Location = new System.Drawing.Point(405, 332);
            this.sacuvajBTN.Name = "sacuvajBTN";
            this.sacuvajBTN.Size = new System.Drawing.Size(75, 23);
            this.sacuvajBTN.TabIndex = 8;
            this.sacuvajBTN.Text = "Sačuvaj";
            this.sacuvajBTN.UseVisualStyleBackColor = true;
            this.sacuvajBTN.Click += new System.EventHandler(this.sacuvajBTN_Click);
            // 
            // procenatIzvrsenostiNUD
            // 
            this.procenatIzvrsenostiNUD.Location = new System.Drawing.Point(181, 95);
            this.procenatIzvrsenostiNUD.Name = "procenatIzvrsenostiNUD";
            this.procenatIzvrsenostiNUD.Size = new System.Drawing.Size(299, 20);
            this.procenatIzvrsenostiNUD.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Procenat izvršenosti:";
            // 
            // dostupniUcesniciListBox
            // 
            this.dostupniUcesniciListBox.Location = new System.Drawing.Point(15, 159);
            this.dostupniUcesniciListBox.Name = "dostupniUcesniciListBox";
            this.dostupniUcesniciListBox.Size = new System.Drawing.Size(191, 127);
            this.dostupniUcesniciListBox.TabIndex = 4;
            this.dostupniUcesniciListBox.UseCompatibleStateImageBehavior = false;
            this.dostupniUcesniciListBox.View = System.Windows.Forms.View.List;
            // 
            // ucesniciZadatkaListBox
            // 
            this.ucesniciZadatkaListBox.Location = new System.Drawing.Point(298, 159);
            this.ucesniciZadatkaListBox.Name = "ucesniciZadatkaListBox";
            this.ucesniciZadatkaListBox.Size = new System.Drawing.Size(182, 127);
            this.ucesniciZadatkaListBox.TabIndex = 7;
            this.ucesniciZadatkaListBox.UseCompatibleStateImageBehavior = false;
            this.ucesniciZadatkaListBox.View = System.Windows.Forms.View.List;
            // 
            // errorLBL
            // 
            this.errorLBL.AutoSize = true;
            this.errorLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorLBL.Location = new System.Drawing.Point(295, 302);
            this.errorLBL.Name = "errorLBL";
            this.errorLBL.Size = new System.Drawing.Size(180, 17);
            this.errorLBL.TabIndex = 14;
            this.errorLBL.Text = "Unešeni podaci nisu validni";
            this.errorLBL.Visible = false;
            // 
            // ZadatakFormular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 367);
            this.Controls.Add(this.errorLBL);
            this.Controls.Add(this.ucesniciZadatkaListBox);
            this.Controls.Add(this.dostupniUcesniciListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.procenatIzvrsenostiNUD);
            this.Controls.Add(this.sacuvajBTN);
            this.Controls.Add(this.izbaciUcesnikaButton);
            this.Controls.Add(this.ubaciUcesnikaButton);
            this.Controls.Add(this.ucesniciLabel);
            this.Controls.Add(this.brojPotrebnihCovjekCasovaNumericUpDown);
            this.Controls.Add(this.brojPotrebnihCovjekCasovaLabel);
            this.Controls.Add(this.rokDateTimePicker);
            this.Controls.Add(this.rokLabel);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(this.nazivLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ZadatakFormular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formular za zadatak";
            ((System.ComponentModel.ISupportInitialize)(this.brojPotrebnihCovjekCasovaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procenatIzvrsenostiNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nazivLabel;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.Label rokLabel;
        private System.Windows.Forms.DateTimePicker rokDateTimePicker;
        private System.Windows.Forms.Label brojPotrebnihCovjekCasovaLabel;
        private System.Windows.Forms.NumericUpDown brojPotrebnihCovjekCasovaNumericUpDown;
        private System.Windows.Forms.Label ucesniciLabel;
        private System.Windows.Forms.Button ubaciUcesnikaButton;
        private System.Windows.Forms.Button izbaciUcesnikaButton;
        private System.Windows.Forms.Button sacuvajBTN;
        private System.Windows.Forms.NumericUpDown procenatIzvrsenostiNUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView dostupniUcesniciListBox;
        private System.Windows.Forms.ListView ucesniciZadatkaListBox;
        private System.Windows.Forms.Label errorLBL;
    }
}