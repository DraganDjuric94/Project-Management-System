namespace ProjectManagementSystem {
    partial class UtrosenoSatiUcesnikFormular {
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
            this.ucesniciLVW = new System.Windows.Forms.ListView();
            this.utrosenoSatiNUD = new System.Windows.Forms.NumericUpDown();
            this.sacuvajBTN = new System.Windows.Forms.Button();
            this.errorLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.utrosenoSatiNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Učesnik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Utrošeno sati:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ucesniciLVW
            // 
            this.ucesniciLVW.Location = new System.Drawing.Point(15, 29);
            this.ucesniciLVW.Name = "ucesniciLVW";
            this.ucesniciLVW.Size = new System.Drawing.Size(257, 153);
            this.ucesniciLVW.TabIndex = 2;
            this.ucesniciLVW.UseCompatibleStateImageBehavior = false;
            this.ucesniciLVW.View = System.Windows.Forms.View.List;
            // 
            // utrosenoSatiNUD
            // 
            this.utrosenoSatiNUD.Location = new System.Drawing.Point(16, 213);
            this.utrosenoSatiNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.utrosenoSatiNUD.Name = "utrosenoSatiNUD";
            this.utrosenoSatiNUD.Size = new System.Drawing.Size(256, 20);
            this.utrosenoSatiNUD.TabIndex = 3;
            // 
            // sacuvajBTN
            // 
            this.sacuvajBTN.Location = new System.Drawing.Point(197, 291);
            this.sacuvajBTN.Name = "sacuvajBTN";
            this.sacuvajBTN.Size = new System.Drawing.Size(75, 23);
            this.sacuvajBTN.TabIndex = 4;
            this.sacuvajBTN.Text = "Sačuvaj";
            this.sacuvajBTN.UseVisualStyleBackColor = true;
            this.sacuvajBTN.Click += new System.EventHandler(this.sacuvajBTN_Click);
            // 
            // errorLBL
            // 
            this.errorLBL.AutoSize = true;
            this.errorLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorLBL.Location = new System.Drawing.Point(89, 253);
            this.errorLBL.Name = "errorLBL";
            this.errorLBL.Size = new System.Drawing.Size(183, 17);
            this.errorLBL.TabIndex = 5;
            this.errorLBL.Text = "Morate selektovati učesnika";
            this.errorLBL.Visible = false;
            // 
            // UtrosenoSatiUcesnikFormular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 323);
            this.Controls.Add(this.errorLBL);
            this.Controls.Add(this.sacuvajBTN);
            this.Controls.Add(this.utrosenoSatiNUD);
            this.Controls.Add(this.ucesniciLVW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UtrosenoSatiUcesnikFormular";
            this.Text = "Utrošeno sati po učesnicima";
            ((System.ComponentModel.ISupportInitialize)(this.utrosenoSatiNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView ucesniciLVW;
        private System.Windows.Forms.NumericUpDown utrosenoSatiNUD;
        private System.Windows.Forms.Button sacuvajBTN;
        private System.Windows.Forms.Label errorLBL;
    }
}