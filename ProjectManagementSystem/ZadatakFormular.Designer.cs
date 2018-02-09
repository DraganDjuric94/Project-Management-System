namespace ProjectManagementSystem
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
            ((System.ComponentModel.ISupportInitialize)(this.brojPotrebnihCovjekCasovaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procenatIzvrsenostiNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // nazivLabel
            // 
            this.nazivLabel.AutoSize = true;
            this.nazivLabel.Location = new System.Drawing.Point(12, 9);
            this.nazivLabel.Name = "nazivLabel";
            this.nazivLabel.Size = new System.Drawing.Size(34, 13);
            this.nazivLabel.TabIndex = 0;
            this.nazivLabel.Text = "Naziv";
            this.nazivLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.Location = new System.Drawing.Point(52, 6);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(351, 20);
            this.nazivTextBox.TabIndex = 1;
            // 
            // rokLabel
            // 
            this.rokLabel.AutoSize = true;
            this.rokLabel.Location = new System.Drawing.Point(12, 38);
            this.rokLabel.Name = "rokLabel";
            this.rokLabel.Size = new System.Drawing.Size(27, 13);
            this.rokLabel.TabIndex = 2;
            this.rokLabel.Text = "Rok";
            // 
            // rokDateTimePicker
            // 
            this.rokDateTimePicker.Location = new System.Drawing.Point(52, 32);
            this.rokDateTimePicker.Name = "rokDateTimePicker";
            this.rokDateTimePicker.Size = new System.Drawing.Size(351, 20);
            this.rokDateTimePicker.TabIndex = 3;
            // 
            // brojPotrebnihCovjekCasovaLabel
            // 
            this.brojPotrebnihCovjekCasovaLabel.AutoSize = true;
            this.brojPotrebnihCovjekCasovaLabel.Location = new System.Drawing.Point(12, 71);
            this.brojPotrebnihCovjekCasovaLabel.Name = "brojPotrebnihCovjekCasovaLabel";
            this.brojPotrebnihCovjekCasovaLabel.Size = new System.Drawing.Size(147, 13);
            this.brojPotrebnihCovjekCasovaLabel.TabIndex = 4;
            this.brojPotrebnihCovjekCasovaLabel.Text = "Broj potrebnih čovjek/časova";
            // 
            // brojPotrebnihCovjekCasovaNumericUpDown
            // 
            this.brojPotrebnihCovjekCasovaNumericUpDown.Location = new System.Drawing.Point(168, 69);
            this.brojPotrebnihCovjekCasovaNumericUpDown.Name = "brojPotrebnihCovjekCasovaNumericUpDown";
            this.brojPotrebnihCovjekCasovaNumericUpDown.Size = new System.Drawing.Size(235, 20);
            this.brojPotrebnihCovjekCasovaNumericUpDown.TabIndex = 5;
            // 
            // ucesniciLabel
            // 
            this.ucesniciLabel.AutoSize = true;
            this.ucesniciLabel.Location = new System.Drawing.Point(12, 124);
            this.ucesniciLabel.Name = "ucesniciLabel";
            this.ucesniciLabel.Size = new System.Drawing.Size(48, 13);
            this.ucesniciLabel.TabIndex = 8;
            this.ucesniciLabel.Text = "Učesnici";
            this.ucesniciLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ubaciUcesnikaButton
            // 
            this.ubaciUcesnikaButton.Location = new System.Drawing.Point(168, 159);
            this.ubaciUcesnikaButton.Name = "ubaciUcesnikaButton";
            this.ubaciUcesnikaButton.Size = new System.Drawing.Size(75, 23);
            this.ubaciUcesnikaButton.TabIndex = 9;
            this.ubaciUcesnikaButton.Text = "Ubaci";
            this.ubaciUcesnikaButton.UseVisualStyleBackColor = true;
            this.ubaciUcesnikaButton.Click += new System.EventHandler(this.ubaciUcesnikaButton_Click);
            // 
            // izbaciUcesnikaButton
            // 
            this.izbaciUcesnikaButton.Location = new System.Drawing.Point(168, 188);
            this.izbaciUcesnikaButton.Name = "izbaciUcesnikaButton";
            this.izbaciUcesnikaButton.Size = new System.Drawing.Size(75, 23);
            this.izbaciUcesnikaButton.TabIndex = 10;
            this.izbaciUcesnikaButton.Text = "Izbaci";
            this.izbaciUcesnikaButton.UseVisualStyleBackColor = true;
            this.izbaciUcesnikaButton.Click += new System.EventHandler(this.izbaciUcesnikaButton_Click);
            // 
            // sacuvajBTN
            // 
            this.sacuvajBTN.Location = new System.Drawing.Point(327, 252);
            this.sacuvajBTN.Name = "sacuvajBTN";
            this.sacuvajBTN.Size = new System.Drawing.Size(75, 23);
            this.sacuvajBTN.TabIndex = 11;
            this.sacuvajBTN.Text = "Sačuvaj";
            this.sacuvajBTN.UseVisualStyleBackColor = true;
            this.sacuvajBTN.Click += new System.EventHandler(this.sacuvajBTN_Click);
            // 
            // procenatIzvrsenostiNUD
            // 
            this.procenatIzvrsenostiNUD.Location = new System.Drawing.Point(168, 95);
            this.procenatIzvrsenostiNUD.Name = "procenatIzvrsenostiNUD";
            this.procenatIzvrsenostiNUD.Size = new System.Drawing.Size(235, 20);
            this.procenatIzvrsenostiNUD.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Procenat izvršenosti:";
            // 
            // dostupniUcesniciListBox
            // 
            this.dostupniUcesniciListBox.Location = new System.Drawing.Point(15, 141);
            this.dostupniUcesniciListBox.Name = "dostupniUcesniciListBox";
            this.dostupniUcesniciListBox.Size = new System.Drawing.Size(121, 97);
            this.dostupniUcesniciListBox.TabIndex = 14;
            this.dostupniUcesniciListBox.UseCompatibleStateImageBehavior = false;
            // 
            // ucesniciZadatkaListBox
            // 
            this.ucesniciZadatkaListBox.Location = new System.Drawing.Point(272, 141);
            this.ucesniciZadatkaListBox.Name = "ucesniciZadatkaListBox";
            this.ucesniciZadatkaListBox.Size = new System.Drawing.Size(121, 97);
            this.ucesniciZadatkaListBox.TabIndex = 15;
            this.ucesniciZadatkaListBox.UseCompatibleStateImageBehavior = false;
            // 
            // ZadatakFormular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 294);
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
            this.Name = "ZadatakFormular";
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
    }
}