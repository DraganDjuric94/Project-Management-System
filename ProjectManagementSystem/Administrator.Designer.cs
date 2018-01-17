namespace ProjectManagementSystem
{
	partial class Administrator
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
			this.administratorTC = new System.Windows.Forms.TabControl();
			this.usersTP = new System.Windows.Forms.TabPage();
			this.projectsTP = new System.Windows.Forms.TabPage();
			this.usersDGW = new System.Windows.Forms.DataGridView();
			this.projectsDGW = new System.Windows.Forms.DataGridView();
			this.addBTN = new System.Windows.Forms.Button();
			this.updateBTN = new System.Windows.Forms.Button();
			this.deleteBTN = new System.Windows.Forms.Button();
			this.administratorTC.SuspendLayout();
			this.usersTP.SuspendLayout();
			this.projectsTP.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.usersDGW)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.projectsDGW)).BeginInit();
			this.SuspendLayout();
			// 
			// administratorTC
			// 
			this.administratorTC.Controls.Add(this.usersTP);
			this.administratorTC.Controls.Add(this.projectsTP);
			this.administratorTC.Location = new System.Drawing.Point(-1, 0);
			this.administratorTC.Name = "administratorTC";
			this.administratorTC.SelectedIndex = 0;
			this.administratorTC.Size = new System.Drawing.Size(282, 178);
			this.administratorTC.TabIndex = 0;
			// 
			// usersTP
			// 
			this.usersTP.Controls.Add(this.usersDGW);
			this.usersTP.Location = new System.Drawing.Point(4, 22);
			this.usersTP.Name = "usersTP";
			this.usersTP.Padding = new System.Windows.Forms.Padding(3);
			this.usersTP.Size = new System.Drawing.Size(274, 152);
			this.usersTP.TabIndex = 0;
			this.usersTP.Text = "Users";
			this.usersTP.UseVisualStyleBackColor = true;
			// 
			// projectsTP
			// 
			this.projectsTP.Controls.Add(this.projectsDGW);
			this.projectsTP.Location = new System.Drawing.Point(4, 22);
			this.projectsTP.Name = "projectsTP";
			this.projectsTP.Padding = new System.Windows.Forms.Padding(3);
			this.projectsTP.Size = new System.Drawing.Size(274, 152);
			this.projectsTP.TabIndex = 1;
			this.projectsTP.Text = "Projects";
			this.projectsTP.UseVisualStyleBackColor = true;
			// 
			// usersDGW
			// 
			this.usersDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.usersDGW.Location = new System.Drawing.Point(0, 0);
			this.usersDGW.Name = "usersDGW";
			this.usersDGW.Size = new System.Drawing.Size(274, 150);
			this.usersDGW.TabIndex = 0;
			// 
			// projectsDGW
			// 
			this.projectsDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.projectsDGW.Location = new System.Drawing.Point(0, 0);
			this.projectsDGW.Name = "projectsDGW";
			this.projectsDGW.Size = new System.Drawing.Size(274, 150);
			this.projectsDGW.TabIndex = 0;
			// 
			// addBTN
			// 
			this.addBTN.Location = new System.Drawing.Point(3, 218);
			this.addBTN.Name = "addBTN";
			this.addBTN.Size = new System.Drawing.Size(75, 23);
			this.addBTN.TabIndex = 1;
			this.addBTN.Text = "ADD";
			this.addBTN.UseVisualStyleBackColor = true;
			this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
			// 
			// updateBTN
			// 
			this.updateBTN.Location = new System.Drawing.Point(104, 218);
			this.updateBTN.Name = "updateBTN";
			this.updateBTN.Size = new System.Drawing.Size(75, 23);
			this.updateBTN.TabIndex = 2;
			this.updateBTN.Text = "UPDATE";
			this.updateBTN.UseVisualStyleBackColor = true;
			this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
			// 
			// deleteBTN
			// 
			this.deleteBTN.Location = new System.Drawing.Point(202, 218);
			this.deleteBTN.Name = "deleteBTN";
			this.deleteBTN.Size = new System.Drawing.Size(75, 23);
			this.deleteBTN.TabIndex = 3;
			this.deleteBTN.Text = "DELETE";
			this.deleteBTN.UseVisualStyleBackColor = true;
			this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
			// 
			// Administrator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(281, 276);
			this.Controls.Add(this.deleteBTN);
			this.Controls.Add(this.updateBTN);
			this.Controls.Add(this.addBTN);
			this.Controls.Add(this.administratorTC);
			this.Name = "Administrator";
			this.Text = "Administrator";
			this.administratorTC.ResumeLayout(false);
			this.usersTP.ResumeLayout(false);
			this.projectsTP.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.usersDGW)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.projectsDGW)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl administratorTC;
		private System.Windows.Forms.TabPage usersTP;
		private System.Windows.Forms.TabPage projectsTP;
		private System.Windows.Forms.DataGridView usersDGW;
		private System.Windows.Forms.DataGridView projectsDGW;
		private System.Windows.Forms.Button addBTN;
		private System.Windows.Forms.Button updateBTN;
		private System.Windows.Forms.Button deleteBTN;
	}
}