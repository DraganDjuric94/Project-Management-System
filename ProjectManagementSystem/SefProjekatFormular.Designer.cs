namespace ProjectManagementSystem {
    partial class SefProjekatFormular {
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
            this.dodajBTN = new System.Windows.Forms.Button();
            this.izbaciBTN = new System.Windows.Forms.Button();
            this.uceniciZaDodatiLVW = new System.Windows.Forms.ListView();
            this.ucesniciNaProjektuLVW = new System.Windows.Forms.ListView();
            this.sacuvajBTN = new System.Windows.Forms.Button();
            this.nazivProjektaTBX = new System.Windows.Forms.TextBox();
            this.ucesnikRBT = new System.Windows.Forms.RadioButton();
            this.nadzorRBT = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Učesnici:";
            // 
            // dodajBTN
            // 
            this.dodajBTN.Location = new System.Drawing.Point(252, 166);
            this.dodajBTN.Name = "dodajBTN";
            this.dodajBTN.Size = new System.Drawing.Size(85, 23);
            this.dodajBTN.TabIndex = 2;
            this.dodajBTN.Text = ">>";
            this.dodajBTN.UseVisualStyleBackColor = true;
            this.dodajBTN.Click += new System.EventHandler(this.dodajBTN_Click);
            // 
            // izbaciBTN
            // 
            this.izbaciBTN.Location = new System.Drawing.Point(252, 195);
            this.izbaciBTN.Name = "izbaciBTN";
            this.izbaciBTN.Size = new System.Drawing.Size(85, 23);
            this.izbaciBTN.TabIndex = 3;
            this.izbaciBTN.Text = "<<";
            this.izbaciBTN.UseVisualStyleBackColor = true;
            this.izbaciBTN.Click += new System.EventHandler(this.izbaciBTN_Click);
            // 
            // uceniciZaDodatiLVW
            // 
            this.uceniciZaDodatiLVW.Location = new System.Drawing.Point(16, 84);
            this.uceniciZaDodatiLVW.Name = "uceniciZaDodatiLVW";
            this.uceniciZaDodatiLVW.Size = new System.Drawing.Size(167, 189);
            this.uceniciZaDodatiLVW.TabIndex = 4;
            this.uceniciZaDodatiLVW.UseCompatibleStateImageBehavior = false;
            this.uceniciZaDodatiLVW.View = System.Windows.Forms.View.List;
            // 
            // ucesniciNaProjektuLVW
            // 
            this.ucesniciNaProjektuLVW.Location = new System.Drawing.Point(422, 84);
            this.ucesniciNaProjektuLVW.Name = "ucesniciNaProjektuLVW";
            this.ucesniciNaProjektuLVW.Size = new System.Drawing.Size(159, 189);
            this.ucesniciNaProjektuLVW.TabIndex = 5;
            this.ucesniciNaProjektuLVW.UseCompatibleStateImageBehavior = false;
            this.ucesniciNaProjektuLVW.View = System.Windows.Forms.View.List;
            // 
            // sacuvajBTN
            // 
            this.sacuvajBTN.Location = new System.Drawing.Point(506, 293);
            this.sacuvajBTN.Name = "sacuvajBTN";
            this.sacuvajBTN.Size = new System.Drawing.Size(75, 23);
            this.sacuvajBTN.TabIndex = 6;
            this.sacuvajBTN.Text = "Sačuvaj";
            this.sacuvajBTN.UseVisualStyleBackColor = true;
            this.sacuvajBTN.Click += new System.EventHandler(this.sacuvajBTN_Click);
            // 
            // nazivProjektaTBX
            // 
            this.nazivProjektaTBX.Location = new System.Drawing.Point(56, 22);
            this.nazivProjektaTBX.Name = "nazivProjektaTBX";
            this.nazivProjektaTBX.Size = new System.Drawing.Size(405, 20);
            this.nazivProjektaTBX.TabIndex = 7;
            // 
            // ucesnikRBT
            // 
            this.ucesnikRBT.AutoSize = true;
            this.ucesnikRBT.Checked = true;
            this.ucesnikRBT.Location = new System.Drawing.Point(6, 19);
            this.ucesnikRBT.Name = "ucesnikRBT";
            this.ucesnikRBT.Size = new System.Drawing.Size(64, 17);
            this.ucesnikRBT.TabIndex = 8;
            this.ucesnikRBT.TabStop = true;
            this.ucesnikRBT.Text = "Učesnik";
            this.ucesnikRBT.UseVisualStyleBackColor = true;
            // 
            // nadzorRBT
            // 
            this.nadzorRBT.AutoSize = true;
            this.nadzorRBT.Location = new System.Drawing.Point(6, 42);
            this.nadzorRBT.Name = "nadzorRBT";
            this.nadzorRBT.Size = new System.Drawing.Size(59, 17);
            this.nadzorRBT.TabIndex = 9;
            this.nadzorRBT.Text = "Nadzor";
            this.nadzorRBT.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ucesnikRBT);
            this.groupBox1.Controls.Add(this.nadzorRBT);
            this.groupBox1.Location = new System.Drawing.Point(236, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 75);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uloga";
            // 
            // SefProjekatFormular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 339);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nazivProjektaTBX);
            this.Controls.Add(this.sacuvajBTN);
            this.Controls.Add(this.ucesniciNaProjektuLVW);
            this.Controls.Add(this.uceniciZaDodatiLVW);
            this.Controls.Add(this.izbaciBTN);
            this.Controls.Add(this.dodajBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SefProjekatFormular";
            this.Text = "SefProjekatFormular";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dodajBTN;
        private System.Windows.Forms.Button izbaciBTN;
        private System.Windows.Forms.ListView uceniciZaDodatiLVW;
        private System.Windows.Forms.ListView ucesniciNaProjektuLVW;
        private System.Windows.Forms.Button sacuvajBTN;
        private System.Windows.Forms.TextBox nazivProjektaTBX;
        private System.Windows.Forms.RadioButton ucesnikRBT;
        private System.Windows.Forms.RadioButton nadzorRBT;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}