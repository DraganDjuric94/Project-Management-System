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
            this.dostupniUcesniciListBox = new System.Windows.Forms.ListBox();
            this.ucesniciZadatkaListBox = new System.Windows.Forms.ListBox();
            this.ucesniciLabel = new System.Windows.Forms.Label();
            this.ubaciUcesnikaButton = new System.Windows.Forms.Button();
            this.izbaciUcesnikaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.brojPotrebnihCovjekCasovaNumericUpDown)).BeginInit();
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
            // dostupniUcesniciListBox
            // 
            this.dostupniUcesniciListBox.FormattingEnabled = true;
            this.dostupniUcesniciListBox.Location = new System.Drawing.Point(15, 131);
            this.dostupniUcesniciListBox.Name = "dostupniUcesniciListBox";
            this.dostupniUcesniciListBox.Size = new System.Drawing.Size(120, 95);
            this.dostupniUcesniciListBox.TabIndex = 6;
            // 
            // ucesniciZadatkaListBox
            // 
            this.ucesniciZadatkaListBox.FormattingEnabled = true;
            this.ucesniciZadatkaListBox.Location = new System.Drawing.Point(283, 131);
            this.ucesniciZadatkaListBox.Name = "ucesniciZadatkaListBox";
            this.ucesniciZadatkaListBox.Size = new System.Drawing.Size(120, 95);
            this.ucesniciZadatkaListBox.TabIndex = 7;
            // 
            // ucesniciLabel
            // 
            this.ucesniciLabel.AutoSize = true;
            this.ucesniciLabel.Location = new System.Drawing.Point(12, 115);
            this.ucesniciLabel.Name = "ucesniciLabel";
            this.ucesniciLabel.Size = new System.Drawing.Size(48, 13);
            this.ucesniciLabel.TabIndex = 8;
            this.ucesniciLabel.Text = "Učesnici";
            this.ucesniciLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ubaciUcesnikaButton
            // 
            this.ubaciUcesnikaButton.Location = new System.Drawing.Point(168, 150);
            this.ubaciUcesnikaButton.Name = "ubaciUcesnikaButton";
            this.ubaciUcesnikaButton.Size = new System.Drawing.Size(75, 23);
            this.ubaciUcesnikaButton.TabIndex = 9;
            this.ubaciUcesnikaButton.Text = "Ubaci";
            this.ubaciUcesnikaButton.UseVisualStyleBackColor = true;
            // 
            // izbaciUcesnikaButton
            // 
            this.izbaciUcesnikaButton.Location = new System.Drawing.Point(168, 179);
            this.izbaciUcesnikaButton.Name = "izbaciUcesnikaButton";
            this.izbaciUcesnikaButton.Size = new System.Drawing.Size(75, 23);
            this.izbaciUcesnikaButton.TabIndex = 10;
            this.izbaciUcesnikaButton.Text = "Izbaci";
            this.izbaciUcesnikaButton.UseVisualStyleBackColor = true;
            // 
            // ZadatakFormular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 252);
            this.Controls.Add(this.izbaciUcesnikaButton);
            this.Controls.Add(this.ubaciUcesnikaButton);
            this.Controls.Add(this.ucesniciLabel);
            this.Controls.Add(this.ucesniciZadatkaListBox);
            this.Controls.Add(this.dostupniUcesniciListBox);
            this.Controls.Add(this.brojPotrebnihCovjekCasovaNumericUpDown);
            this.Controls.Add(this.brojPotrebnihCovjekCasovaLabel);
            this.Controls.Add(this.rokDateTimePicker);
            this.Controls.Add(this.rokLabel);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(this.nazivLabel);
            this.Name = "ZadatakFormular";
            this.Text = "Formular za zadatak";
            ((System.ComponentModel.ISupportInitialize)(this.brojPotrebnihCovjekCasovaNumericUpDown)).EndInit();
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
        private System.Windows.Forms.ListBox dostupniUcesniciListBox;
        private System.Windows.Forms.ListBox ucesniciZadatkaListBox;
        private System.Windows.Forms.Label ucesniciLabel;
        private System.Windows.Forms.Button ubaciUcesnikaButton;
        private System.Windows.Forms.Button izbaciUcesnikaButton;
    }
}