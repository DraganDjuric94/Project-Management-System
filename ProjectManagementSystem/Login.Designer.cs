namespace ProjectManagementSystem {
    partial class Login {
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
			this.korisnickoImeLBL = new System.Windows.Forms.Label();
			this.lozinkaLBL = new System.Windows.Forms.Label();
			this.prijavaBTN = new System.Windows.Forms.Button();
			this.korisnickoImeTXT = new System.Windows.Forms.TextBox();
			this.lozinkaTXT = new System.Windows.Forms.TextBox();
			this.dobrodosliLBL = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// korisnickoImeLBL
			// 
			this.korisnickoImeLBL.AutoSize = true;
			this.korisnickoImeLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.korisnickoImeLBL.Location = new System.Drawing.Point(24, 88);
			this.korisnickoImeLBL.Name = "korisnickoImeLBL";
			this.korisnickoImeLBL.Size = new System.Drawing.Size(88, 15);
			this.korisnickoImeLBL.TabIndex = 0;
			this.korisnickoImeLBL.Text = "Korisničko ime";
			// 
			// lozinkaLBL
			// 
			this.lozinkaLBL.AutoSize = true;
			this.lozinkaLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lozinkaLBL.Location = new System.Drawing.Point(51, 135);
			this.lozinkaLBL.Name = "lozinkaLBL";
			this.lozinkaLBL.Size = new System.Drawing.Size(50, 15);
			this.lozinkaLBL.TabIndex = 1;
			this.lozinkaLBL.Text = "Lozinka";
			// 
			// prijavaBTN
			// 
			this.prijavaBTN.Location = new System.Drawing.Point(179, 199);
			this.prijavaBTN.Name = "prijavaBTN";
			this.prijavaBTN.Size = new System.Drawing.Size(75, 23);
			this.prijavaBTN.TabIndex = 2;
			this.prijavaBTN.Text = "Prijava";
			this.prijavaBTN.UseVisualStyleBackColor = true;
			this.prijavaBTN.Click += new System.EventHandler(this.prijavaBTN_Click);
			// 
			// korisnickoImeTXT
			// 
			this.korisnickoImeTXT.Location = new System.Drawing.Point(116, 88);
			this.korisnickoImeTXT.Name = "korisnickoImeTXT";
			this.korisnickoImeTXT.Size = new System.Drawing.Size(138, 20);
			this.korisnickoImeTXT.TabIndex = 4;
			// 
			// lozinkaTXT
			// 
			this.lozinkaTXT.Location = new System.Drawing.Point(116, 135);
			this.lozinkaTXT.Name = "lozinkaTXT";
			this.lozinkaTXT.Size = new System.Drawing.Size(138, 20);
			this.lozinkaTXT.TabIndex = 5;
			// 
			// dobrodosliLBL
			// 
			this.dobrodosliLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dobrodosliLBL.Location = new System.Drawing.Point(54, 24);
			this.dobrodosliLBL.Name = "dobrodosliLBL";
			this.dobrodosliLBL.Size = new System.Drawing.Size(178, 41);
			this.dobrodosliLBL.TabIndex = 6;
			this.dobrodosliLBL.Text = "DOBRODOŠLI";
			this.dobrodosliLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.dobrodosliLBL);
			this.Controls.Add(this.lozinkaTXT);
			this.Controls.Add(this.korisnickoImeTXT);
			this.Controls.Add(this.prijavaBTN);
			this.Controls.Add(this.lozinkaLBL);
			this.Controls.Add(this.korisnickoImeLBL);
			this.Name = "Login";
			this.Text = "Project Management System";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label korisnickoImeLBL;
		private System.Windows.Forms.Label lozinkaLBL;
		private System.Windows.Forms.Button prijavaBTN;
		private System.Windows.Forms.TextBox korisnickoImeTXT;
		private System.Windows.Forms.TextBox lozinkaTXT;
		private System.Windows.Forms.Label dobrodosliLBL;
	}
}

