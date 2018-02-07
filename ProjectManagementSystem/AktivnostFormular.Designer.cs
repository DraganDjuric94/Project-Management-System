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
            this.opisLabel.Location = new System.Drawing.Point(12, 38);
            this.opisLabel.Name = "opisLabel";
            this.opisLabel.Size = new System.Drawing.Size(28, 13);
            this.opisLabel.TabIndex = 1;
            this.opisLabel.Text = "Opis";
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.Location = new System.Drawing.Point(52, 6);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(220, 20);
            this.nazivTextBox.TabIndex = 2;
            // 
            // opisRichTextBox
            // 
            this.opisRichTextBox.Location = new System.Drawing.Point(12, 54);
            this.opisRichTextBox.Name = "opisRichTextBox";
            this.opisRichTextBox.Size = new System.Drawing.Size(260, 196);
            this.opisRichTextBox.TabIndex = 3;
            this.opisRichTextBox.Text = "";
            // 
            // AktivnostFormular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
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
    }
}