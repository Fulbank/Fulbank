﻿
namespace projet_Fulbank
{
    partial class Virement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Virement));
            this.quelcompte = new System.Windows.Forms.Label();
            this.toaccount = new System.Windows.Forms.Label();
            this.VirementLastName = new System.Windows.Forms.Label();
            this.VirementAccountNumber = new System.Windows.Forms.Label();
            this.retour = new System.Windows.Forms.Button();
            this.titre = new System.Windows.Forms.Label();
            this.deb_current = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TransfertSum = new System.Windows.Forms.TextBox();
            this.transfert = new System.Windows.Forms.Button();
            this.deb_booklet = new System.Windows.Forms.RadioButton();
            this.cred_current = new System.Windows.Forms.RadioButton();
            this.cred_booklet = new System.Windows.Forms.RadioButton();
            this.beneficiary = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.cred_compte = new System.Windows.Forms.GroupBox();
            this.deb_compte = new System.Windows.Forms.GroupBox();
            this.test = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.cred_compte.SuspendLayout();
            this.deb_compte.SuspendLayout();
            this.SuspendLayout();
            // 
            // quelcompte
            // 
            this.quelcompte.AutoSize = true;
            this.quelcompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quelcompte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.quelcompte.Location = new System.Drawing.Point(82, 215);
            this.quelcompte.Name = "quelcompte";
            this.quelcompte.Size = new System.Drawing.Size(183, 20);
            this.quelcompte.TabIndex = 52;
            this.quelcompte.Text = "Depuis quel compte ?";
            // 
            // toaccount
            // 
            this.toaccount.AutoSize = true;
            this.toaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toaccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.toaccount.Location = new System.Drawing.Point(516, 215);
            this.toaccount.Name = "toaccount";
            this.toaccount.Size = new System.Drawing.Size(169, 20);
            this.toaccount.TabIndex = 53;
            this.toaccount.Text = "Vers quel compte ? ";
            // 
            // VirementLastName
            // 
            this.VirementLastName.AutoSize = true;
            this.VirementLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VirementLastName.Location = new System.Drawing.Point(12, 9);
            this.VirementLastName.Name = "VirementLastName";
            this.VirementLastName.Size = new System.Drawing.Size(0, 15);
            this.VirementLastName.TabIndex = 47;
            this.VirementLastName.Click += new System.EventHandler(this.label13_Click);
            // 
            // VirementAccountNumber
            // 
            this.VirementAccountNumber.AutoSize = true;
            this.VirementAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VirementAccountNumber.Location = new System.Drawing.Point(12, 24);
            this.VirementAccountNumber.Name = "VirementAccountNumber";
            this.VirementAccountNumber.Size = new System.Drawing.Size(0, 15);
            this.VirementAccountNumber.TabIndex = 48;
            this.VirementAccountNumber.Click += new System.EventHandler(this.label14_Click);
            // 
            // retour
            // 
            this.retour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.retour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retour.FlatAppearance.BorderSize = 0;
            this.retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retour.ForeColor = System.Drawing.Color.White;
            this.retour.Location = new System.Drawing.Point(12, 102);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(98, 23);
            this.retour.TabIndex = 50;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = false;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // titre
            // 
            this.titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.titre.Location = new System.Drawing.Point(296, 139);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(202, 52);
            this.titre.TabIndex = 51;
            this.titre.Text = "Virement";
            this.titre.Click += new System.EventHandler(this.titre_Click);
            // 
            // deb_current
            // 
            this.deb_current.AutoSize = true;
            this.deb_current.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deb_current.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.deb_current.Location = new System.Drawing.Point(6, 14);
            this.deb_current.Name = "deb_current";
            this.deb_current.Size = new System.Drawing.Size(140, 21);
            this.deb_current.TabIndex = 54;
            this.deb_current.Text = "Compte courant";
            this.deb_current.UseVisualStyleBackColor = true;
            this.deb_current.CheckedChanged += new System.EventHandler(this.deb_current_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(83, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.TabIndex = 55;
            this.label1.Text = "Somme du virement";
            // 
            // TransfertSum
            // 
            this.TransfertSum.BackColor = System.Drawing.SystemColors.Window;
            this.TransfertSum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TransfertSum.Location = new System.Drawing.Point(86, 396);
            this.TransfertSum.Name = "TransfertSum";
            this.TransfertSum.Size = new System.Drawing.Size(155, 20);
            this.TransfertSum.TabIndex = 56;
            this.TransfertSum.TextChanged += new System.EventHandler(this.somme_virement_TextChanged);
            // 
            // transfert
            // 
            this.transfert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.transfert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transfert.FlatAppearance.BorderSize = 0;
            this.transfert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transfert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transfert.ForeColor = System.Drawing.Color.White;
            this.transfert.Location = new System.Drawing.Point(548, 383);
            this.transfert.Name = "transfert";
            this.transfert.Size = new System.Drawing.Size(110, 33);
            this.transfert.TabIndex = 58;
            this.transfert.Text = "Virer";
            this.transfert.UseVisualStyleBackColor = false;
            this.transfert.Click += new System.EventHandler(this.transfert_Click);
            // 
            // deb_booklet
            // 
            this.deb_booklet.AutoSize = true;
            this.deb_booklet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deb_booklet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.deb_booklet.Location = new System.Drawing.Point(6, 41);
            this.deb_booklet.Name = "deb_booklet";
            this.deb_booklet.Size = new System.Drawing.Size(82, 21);
            this.deb_booklet.TabIndex = 59;
            this.deb_booklet.TabStop = true;
            this.deb_booklet.Text = "Livret A";
            this.deb_booklet.UseVisualStyleBackColor = true;
            this.deb_booklet.CheckedChanged += new System.EventHandler(this.deb_booklet_CheckedChanged);
            // 
            // cred_current
            // 
            this.cred_current.AutoSize = true;
            this.cred_current.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cred_current.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.cred_current.Location = new System.Drawing.Point(6, 19);
            this.cred_current.Name = "cred_current";
            this.cred_current.Size = new System.Drawing.Size(140, 21);
            this.cred_current.TabIndex = 60;
            this.cred_current.TabStop = true;
            this.cred_current.Text = "Compte courant";
            this.cred_current.UseVisualStyleBackColor = true;
            this.cred_current.CheckedChanged += new System.EventHandler(this.cred_current_CheckedChanged);
            // 
            // cred_booklet
            // 
            this.cred_booklet.AutoSize = true;
            this.cred_booklet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cred_booklet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.cred_booklet.Location = new System.Drawing.Point(6, 46);
            this.cred_booklet.Name = "cred_booklet";
            this.cred_booklet.Size = new System.Drawing.Size(82, 21);
            this.cred_booklet.TabIndex = 61;
            this.cred_booklet.TabStop = true;
            this.cred_booklet.Text = "Livret A";
            this.cred_booklet.UseVisualStyleBackColor = true;
            // 
            // beneficiary
            // 
            this.beneficiary.BackColor = System.Drawing.SystemColors.Control;
            this.beneficiary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.beneficiary.FlatAppearance.BorderSize = 0;
            this.beneficiary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beneficiary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beneficiary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.beneficiary.Location = new System.Drawing.Point(520, 340);
            this.beneficiary.Name = "beneficiary";
            this.beneficiary.Size = new System.Drawing.Size(154, 23);
            this.beneficiary.TabIndex = 62;
            this.beneficiary.Text = "Autre bénéficiares";
            this.beneficiary.UseVisualStyleBackColor = false;
            this.beneficiary.Click += new System.EventHandler(this.beneficiary_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(518, 369);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(167, 60);
            this.pictureBox3.TabIndex = 57;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 44);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // logo
            // 
            this.logo.BackgroundImage = global::projet_Fulbank.Properties.Resources.Logo_avec_bitcoin;
            this.logo.Location = new System.Drawing.Point(137, -7);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(521, 143);
            this.logo.TabIndex = 46;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // cred_compte
            // 
            this.cred_compte.Controls.Add(this.cred_current);
            this.cred_compte.Controls.Add(this.cred_booklet);
            this.cred_compte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cred_compte.ForeColor = System.Drawing.Color.White;
            this.cred_compte.Location = new System.Drawing.Point(520, 238);
            this.cred_compte.Name = "cred_compte";
            this.cred_compte.Size = new System.Drawing.Size(154, 87);
            this.cred_compte.TabIndex = 63;
            this.cred_compte.TabStop = false;
            this.cred_compte.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // deb_compte
            // 
            this.deb_compte.Controls.Add(this.deb_current);
            this.deb_compte.Controls.Add(this.deb_booklet);
            this.deb_compte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deb_compte.Location = new System.Drawing.Point(86, 238);
            this.deb_compte.Name = "deb_compte";
            this.deb_compte.Size = new System.Drawing.Size(148, 81);
            this.deb_compte.TabIndex = 64;
            this.deb_compte.TabStop = false;
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(304, 390);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(100, 20);
            this.test.TabIndex = 65;
            this.test.TextChanged += new System.EventHandler(this.test_TextChanged);
            // 
            // Virement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.test);
            this.Controls.Add(this.deb_compte);
            this.Controls.Add(this.cred_compte);
            this.Controls.Add(this.beneficiary);
            this.Controls.Add(this.transfert);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.TransfertSum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toaccount);
            this.Controls.Add(this.quelcompte);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.VirementAccountNumber);
            this.Controls.Add(this.VirementLastName);
            this.Controls.Add(this.logo);
            this.Name = "Virement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Virement";
            this.Load += new System.EventHandler(this.Virement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.cred_compte.ResumeLayout(false);
            this.cred_compte.PerformLayout();
            this.deb_compte.ResumeLayout(false);
            this.deb_compte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label quelcompte;
        private System.Windows.Forms.Label toaccount;
        private System.Windows.Forms.Label VirementLastName;
        private System.Windows.Forms.Label VirementAccountNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.RadioButton deb_current;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TransfertSum;
        private System.Windows.Forms.Button transfert;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton deb_booklet;
        private System.Windows.Forms.RadioButton cred_current;
        private System.Windows.Forms.RadioButton cred_booklet;
        private System.Windows.Forms.Button beneficiary;
        private System.Windows.Forms.GroupBox cred_compte;
        private System.Windows.Forms.GroupBox deb_compte;
        private System.Windows.Forms.TextBox test;
    }
}