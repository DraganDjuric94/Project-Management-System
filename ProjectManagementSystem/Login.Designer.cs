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
			this.usernameLBL = new System.Windows.Forms.Label();
			this.passwordLBL = new System.Windows.Forms.Label();
			this.loginBTN = new System.Windows.Forms.Button();
			this.usernameTXT = new System.Windows.Forms.TextBox();
			this.passwordTXT = new System.Windows.Forms.TextBox();
			this.wlecomeLBL = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// usernameLBL
			// 
			this.usernameLBL.AutoSize = true;
			this.usernameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernameLBL.Location = new System.Drawing.Point(51, 88);
			this.usernameLBL.Name = "usernameLBL";
			this.usernameLBL.Size = new System.Drawing.Size(65, 15);
			this.usernameLBL.TabIndex = 0;
			this.usernameLBL.Text = "Username";
			// 
			// passwordLBL
			// 
			this.passwordLBL.AutoSize = true;
			this.passwordLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordLBL.Location = new System.Drawing.Point(51, 135);
			this.passwordLBL.Name = "passwordLBL";
			this.passwordLBL.Size = new System.Drawing.Size(61, 15);
			this.passwordLBL.TabIndex = 1;
			this.passwordLBL.Text = "Password";
			// 
			// loginBTN
			// 
			this.loginBTN.Location = new System.Drawing.Point(179, 199);
			this.loginBTN.Name = "loginBTN";
			this.loginBTN.Size = new System.Drawing.Size(75, 23);
			this.loginBTN.TabIndex = 2;
			this.loginBTN.Text = "LOGIN";
			this.loginBTN.UseVisualStyleBackColor = true;
			this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
			// 
			// usernameTXT
			// 
			this.usernameTXT.Location = new System.Drawing.Point(116, 88);
			this.usernameTXT.Name = "usernameTXT";
			this.usernameTXT.Size = new System.Drawing.Size(138, 20);
			this.usernameTXT.TabIndex = 4;
			// 
			// passwordTXT
			// 
			this.passwordTXT.Location = new System.Drawing.Point(116, 135);
			this.passwordTXT.Name = "passwordTXT";
			this.passwordTXT.Size = new System.Drawing.Size(138, 20);
			this.passwordTXT.TabIndex = 5;
			// 
			// wlecomeLBL
			// 
			this.wlecomeLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.wlecomeLBL.Location = new System.Drawing.Point(54, 24);
			this.wlecomeLBL.Name = "wlecomeLBL";
			this.wlecomeLBL.Size = new System.Drawing.Size(178, 41);
			this.wlecomeLBL.TabIndex = 6;
			this.wlecomeLBL.Text = "WELCOME";
			this.wlecomeLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.wlecomeLBL);
			this.Controls.Add(this.passwordTXT);
			this.Controls.Add(this.usernameTXT);
			this.Controls.Add(this.loginBTN);
			this.Controls.Add(this.passwordLBL);
			this.Controls.Add(this.usernameLBL);
			this.Name = "Login";
			this.Text = "Project Management System";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label usernameLBL;
		private System.Windows.Forms.Label passwordLBL;
		private System.Windows.Forms.Button loginBTN;
		private System.Windows.Forms.TextBox usernameTXT;
		private System.Windows.Forms.TextBox passwordTXT;
		private System.Windows.Forms.Label wlecomeLBL;
	}
}

