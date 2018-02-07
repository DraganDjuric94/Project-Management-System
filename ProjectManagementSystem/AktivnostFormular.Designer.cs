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
            this.ucesniciListBox = new System.Windows.Forms.ListBox();
            this.ucesceUcesnikaLBL = new System.Windows.Forms.Label();
            this.dodajButton = new System.Windows.Forms.Button();
            this.izmijeniButton = new System.Windows.Forms.Button();
            this.obrisiButton = new System.Windows.Forms.Button();
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
            this.opisLabel.Location = new System.Drawing.Point(12, 193);
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
            this.opisRichTextBox.Location = new System.Drawing.Point(12, 209);
            this.opisRichTextBox.Name = "opisRichTextBox";
            this.opisRichTextBox.Size = new System.Drawing.Size(327, 143);
            this.opisRichTextBox.TabIndex = 3;
            this.opisRichTextBox.Text = "";
            // 
            // ucesniciListBox
            // 
            this.ucesniciListBox.FormattingEnabled = true;
            this.ucesniciListBox.Location = new System.Drawing.Point(15, 70);
            this.ucesniciListBox.Name = "ucesniciListBox";
            this.ucesniciListBox.Size = new System.Drawing.Size(243, 108);
            this.ucesniciListBox.TabIndex = 4;
            // 
            // ucesceUcesnikaLBL
            // 
            this.ucesceUcesnikaLBL.AutoSize = true;
            this.ucesceUcesnikaLBL.Location = new System.Drawing.Point(12, 54);
            this.ucesceUcesnikaLBL.Name = "ucesceUcesnikaLBL";
            this.ucesceUcesnikaLBL.Size = new System.Drawing.Size(90, 13);
            this.ucesceUcesnikaLBL.TabIndex = 5;
            this.ucesceUcesnikaLBL.Text = "Učešće učesnika";
            this.ucesceUcesnikaLBL.Click += new System.EventHandler(this.ucesceUcesnikaLBL_Click);
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(264, 70);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(75, 23);
            this.dodajButton.TabIndex = 6;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            // 
            // izmijeniButton
            // 
            this.izmijeniButton.Location = new System.Drawing.Point(264, 113);
            this.izmijeniButton.Name = "izmijeniButton";
            this.izmijeniButton.Size = new System.Drawing.Size(75, 23);
            this.izmijeniButton.TabIndex = 7;
            this.izmijeniButton.Text = "Izmijeni";
            this.izmijeniButton.UseVisualStyleBackColor = true;
            // 
            // obrisiButton
            // 
            this.obrisiButton.Location = new System.Drawing.Point(264, 155);
            this.obrisiButton.Name = "obrisiButton";
            this.obrisiButton.Size = new System.Drawing.Size(75, 23);
            this.obrisiButton.TabIndex = 8;
            this.obrisiButton.Text = "Obriši";
            this.obrisiButton.UseVisualStyleBackColor = true;
            // 
            // AktivnostFormular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 364);
            this.Controls.Add(this.obrisiButton);
            this.Controls.Add(this.izmijeniButton);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.ucesceUcesnikaLBL);
            this.Controls.Add(this.ucesniciListBox);
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
        private System.Windows.Forms.ListBox ucesniciListBox;
        private System.Windows.Forms.Label ucesceUcesnikaLBL;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button izmijeniButton;
        private System.Windows.Forms.Button obrisiButton;
    }
}