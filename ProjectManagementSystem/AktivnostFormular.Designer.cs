namespace ProjectManagementSystem
{
    partial class AktivnostFormular
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
            this.opisLabel = new System.Windows.Forms.Label();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.opisRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ucesceUcesnikaLBL = new System.Windows.Forms.Label();
            this.dodajButton = new System.Windows.Forms.Button();
            this.izmijeniButton = new System.Windows.Forms.Button();
            this.obrisiButton = new System.Windows.Forms.Button();
            this.sacuvajBTN = new System.Windows.Forms.Button();
            this.ucesniciListBox = new System.Windows.Forms.ListView();
            this.zavrsenaAktivnostCBX = new System.Windows.Forms.CheckBox();
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
            // 
            // opisLabel
            // 
            this.opisLabel.AutoSize = true;
            this.opisLabel.Location = new System.Drawing.Point(15, 229);
            this.opisLabel.Name = "opisLabel";
            this.opisLabel.Size = new System.Drawing.Size(28, 13);
            this.opisLabel.TabIndex = 1;
            this.opisLabel.Text = "Opis";
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.Location = new System.Drawing.Point(52, 6);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(287, 20);
            this.nazivTextBox.TabIndex = 2;
            // 
            // opisRichTextBox
            // 
            this.opisRichTextBox.Location = new System.Drawing.Point(15, 245);
            this.opisRichTextBox.Name = "opisRichTextBox";
            this.opisRichTextBox.Size = new System.Drawing.Size(327, 143);
            this.opisRichTextBox.TabIndex = 3;
            this.opisRichTextBox.Text = "";
            // 
            // ucesceUcesnikaLBL
            // 
            this.ucesceUcesnikaLBL.AutoSize = true;
            this.ucesceUcesnikaLBL.Location = new System.Drawing.Point(12, 49);
            this.ucesceUcesnikaLBL.Name = "ucesceUcesnikaLBL";
            this.ucesceUcesnikaLBL.Size = new System.Drawing.Size(90, 13);
            this.ucesceUcesnikaLBL.TabIndex = 5;
            this.ucesceUcesnikaLBL.Text = "Učešće učesnika";
            this.ucesceUcesnikaLBL.Click += new System.EventHandler(this.ucesceUcesnikaLBL_Click);
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(264, 65);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(75, 23);
            this.dodajButton.TabIndex = 6;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // izmijeniButton
            // 
            this.izmijeniButton.Location = new System.Drawing.Point(264, 108);
            this.izmijeniButton.Name = "izmijeniButton";
            this.izmijeniButton.Size = new System.Drawing.Size(75, 23);
            this.izmijeniButton.TabIndex = 7;
            this.izmijeniButton.Text = "Izmijeni";
            this.izmijeniButton.UseVisualStyleBackColor = true;
            this.izmijeniButton.Click += new System.EventHandler(this.izmijeniButton_Click);
            // 
            // obrisiButton
            // 
            this.obrisiButton.Location = new System.Drawing.Point(264, 150);
            this.obrisiButton.Name = "obrisiButton";
            this.obrisiButton.Size = new System.Drawing.Size(75, 23);
            this.obrisiButton.TabIndex = 8;
            this.obrisiButton.Text = "Obriši";
            this.obrisiButton.UseVisualStyleBackColor = true;
            this.obrisiButton.Click += new System.EventHandler(this.obrisiButton_Click);
            // 
            // sacuvajBTN
            // 
            this.sacuvajBTN.Location = new System.Drawing.Point(267, 404);
            this.sacuvajBTN.Name = "sacuvajBTN";
            this.sacuvajBTN.Size = new System.Drawing.Size(75, 23);
            this.sacuvajBTN.TabIndex = 9;
            this.sacuvajBTN.Text = "Sacuvaj";
            this.sacuvajBTN.UseVisualStyleBackColor = true;
            this.sacuvajBTN.Click += new System.EventHandler(this.sacuvajBTN_Click);
            // 
            // ucesniciListBox
            // 
            this.ucesniciListBox.Location = new System.Drawing.Point(15, 65);
            this.ucesniciListBox.MultiSelect = false;
            this.ucesniciListBox.Name = "ucesniciListBox";
            this.ucesniciListBox.Size = new System.Drawing.Size(243, 108);
            this.ucesniciListBox.TabIndex = 10;
            this.ucesniciListBox.UseCompatibleStateImageBehavior = false;
            // 
            // zavrsenaAktivnostCBX
            // 
            this.zavrsenaAktivnostCBX.AutoSize = true;
            this.zavrsenaAktivnostCBX.Location = new System.Drawing.Point(15, 195);
            this.zavrsenaAktivnostCBX.Name = "zavrsenaAktivnostCBX";
            this.zavrsenaAktivnostCBX.Size = new System.Drawing.Size(116, 17);
            this.zavrsenaAktivnostCBX.TabIndex = 11;
            this.zavrsenaAktivnostCBX.Text = "Aktivnost završena";
            this.zavrsenaAktivnostCBX.UseVisualStyleBackColor = true;
            // 
            // AktivnostFormular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 435);
            this.Controls.Add(this.zavrsenaAktivnostCBX);
            this.Controls.Add(this.ucesniciListBox);
            this.Controls.Add(this.sacuvajBTN);
            this.Controls.Add(this.obrisiButton);
            this.Controls.Add(this.izmijeniButton);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.ucesceUcesnikaLBL);
            this.Controls.Add(this.opisRichTextBox);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(this.opisLabel);
            this.Controls.Add(this.nazivLabel);
            this.Name = "AktivnostFormular";
            this.Text = "Formular za aktivnost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nazivLabel;
        private System.Windows.Forms.Label opisLabel;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.RichTextBox opisRichTextBox;
        private System.Windows.Forms.Label ucesceUcesnikaLBL;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button izmijeniButton;
        private System.Windows.Forms.Button obrisiButton;
        private System.Windows.Forms.Button sacuvajBTN;
        private System.Windows.Forms.ListView ucesniciListBox;
        private System.Windows.Forms.CheckBox zavrsenaAktivnostCBX;
    }
}