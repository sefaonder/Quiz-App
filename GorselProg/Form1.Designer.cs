﻿
namespace GorselProg
{
    partial class formLoginRegister
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
            this.txtLoginPassword = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.txtLoginEmail = new System.Windows.Forms.MaskedTextBox();
            this.lblLoginWarning = new System.Windows.Forms.Label();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.txtRegMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRetLogin = new System.Windows.Forms.Label();
            this.lblRegWarning = new System.Windows.Forms.Label();
            this.txtRegUsername = new System.Windows.Forms.TextBox();
            this.txtRegPassword2 = new System.Windows.Forms.MaskedTextBox();
            this.txtRegPassword = new System.Windows.Forms.MaskedTextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
            this.pnlRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLoginPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(144)))), ((int)(((byte)(124)))));
            this.txtLoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLoginPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.txtLoginPassword.Location = new System.Drawing.Point(88, 265);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '*';
            this.txtLoginPassword.Size = new System.Drawing.Size(272, 38);
            this.txtLoginPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(88, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mail";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(88, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(50)))));
            this.label3.Location = new System.Drawing.Point(85, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giriş Yap";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.btnLogin.Location = new System.Drawing.Point(88, 344);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(272, 42);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(50)))));
            this.label4.Location = new System.Drawing.Point(233, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hesabınız yok mu?";
            this.label4.Click += new System.EventHandler(this.lblNoAcc_click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.txtLoginEmail);
            this.pnlLogin.Controls.Add(this.lblLoginWarning);
            this.pnlLogin.Controls.Add(this.label4);
            this.pnlLogin.Controls.Add(this.txtLoginPassword);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.label3);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(459, 543);
            this.pnlLogin.TabIndex = 7;
            this.pnlLogin.Visible = false;
            // 
            // txtLoginEmail
            // 
            this.txtLoginEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLoginEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(144)))), ((int)(((byte)(124)))));
            this.txtLoginEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLoginEmail.Location = new System.Drawing.Point(88, 200);
            this.txtLoginEmail.Name = "txtLoginEmail";
            this.txtLoginEmail.Size = new System.Drawing.Size(272, 38);
            this.txtLoginEmail.TabIndex = 8;
            // 
            // lblLoginWarning
            // 
            this.lblLoginWarning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoginWarning.AutoSize = true;
            this.lblLoginWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLoginWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(50)))));
            this.lblLoginWarning.Location = new System.Drawing.Point(88, 315);
            this.lblLoginWarning.Name = "lblLoginWarning";
            this.lblLoginWarning.Size = new System.Drawing.Size(0, 17);
            this.lblLoginWarning.TabIndex = 7;
            // 
            // pnlRegister
            // 
            this.pnlRegister.Controls.Add(this.txtRegMail);
            this.pnlRegister.Controls.Add(this.label5);
            this.pnlRegister.Controls.Add(this.lblRetLogin);
            this.pnlRegister.Controls.Add(this.lblRegWarning);
            this.pnlRegister.Controls.Add(this.txtRegUsername);
            this.pnlRegister.Controls.Add(this.txtRegPassword2);
            this.pnlRegister.Controls.Add(this.txtRegPassword);
            this.pnlRegister.Controls.Add(this.btnRegister);
            this.pnlRegister.Controls.Add(this.label6);
            this.pnlRegister.Controls.Add(this.label9);
            this.pnlRegister.Controls.Add(this.label7);
            this.pnlRegister.Controls.Add(this.label8);
            this.pnlRegister.Location = new System.Drawing.Point(307, 20);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(92, 78);
            this.pnlRegister.TabIndex = 8;
            this.pnlRegister.Visible = false;
            // 
            // txtRegMail
            // 
            this.txtRegMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRegMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(144)))), ((int)(((byte)(124)))));
            this.txtRegMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRegMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.txtRegMail.Location = new System.Drawing.Point(-83, -25);
            this.txtRegMail.Name = "txtRegMail";
            this.txtRegMail.Size = new System.Drawing.Size(272, 38);
            this.txtRegMail.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(50)))));
            this.label5.Location = new System.Drawing.Point(-83, -47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mail";
            // 
            // lblRetLogin
            // 
            this.lblRetLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRetLogin.AutoSize = true;
            this.lblRetLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRetLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(50)))));
            this.lblRetLogin.Location = new System.Drawing.Point(62, 224);
            this.lblRetLogin.Name = "lblRetLogin";
            this.lblRetLogin.Size = new System.Drawing.Size(127, 17);
            this.lblRetLogin.TabIndex = 8;
            this.lblRetLogin.Text = "Giriş Ekranına Dön";
            this.lblRetLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblRetLogin_MouseClick);
            // 
            // lblRegWarning
            // 
            this.lblRegWarning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegWarning.AutoSize = true;
            this.lblRegWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRegWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(50)))));
            this.lblRegWarning.Location = new System.Drawing.Point(-86, 153);
            this.lblRegWarning.Name = "lblRegWarning";
            this.lblRegWarning.Size = new System.Drawing.Size(0, 17);
            this.lblRegWarning.TabIndex = 7;
            // 
            // txtRegUsername
            // 
            this.txtRegUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRegUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(144)))), ((int)(((byte)(124)))));
            this.txtRegUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRegUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.txtRegUsername.Location = new System.Drawing.Point(-83, -90);
            this.txtRegUsername.Name = "txtRegUsername";
            this.txtRegUsername.Size = new System.Drawing.Size(272, 38);
            this.txtRegUsername.TabIndex = 0;
            // 
            // txtRegPassword2
            // 
            this.txtRegPassword2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRegPassword2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(144)))), ((int)(((byte)(124)))));
            this.txtRegPassword2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRegPassword2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.txtRegPassword2.Location = new System.Drawing.Point(-83, 105);
            this.txtRegPassword2.Name = "txtRegPassword2";
            this.txtRegPassword2.PasswordChar = '*';
            this.txtRegPassword2.Size = new System.Drawing.Size(272, 38);
            this.txtRegPassword2.TabIndex = 1;
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRegPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(144)))), ((int)(((byte)(124)))));
            this.txtRegPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRegPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.txtRegPassword.Location = new System.Drawing.Point(-83, 40);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.PasswordChar = '*';
            this.txtRegPassword.Size = new System.Drawing.Size(272, 38);
            this.txtRegPassword.TabIndex = 1;
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.btnRegister.Location = new System.Drawing.Point(-83, 179);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(272, 42);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Kayıt Ol";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(50)))));
            this.label6.Location = new System.Drawing.Point(-83, -112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Kullanıcı Adı";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(50)))));
            this.label9.Location = new System.Drawing.Point(-83, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Şifre Tekrar";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(50)))));
            this.label7.Location = new System.Drawing.Point(-86, -164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 31);
            this.label7.TabIndex = 4;
            this.label7.Text = "Kayıt Ol";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(50)))));
            this.label8.Location = new System.Drawing.Point(-83, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Şifre";
            // 
            // formLoginRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(459, 543);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlRegister);
            this.Name = "formLoginRegister";
            this.Text = "Bilgi Yarışması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.formLoginRegister_Shown);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txtLoginPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.Label lblRegWarning;
        private System.Windows.Forms.TextBox txtRegUsername;
        private System.Windows.Forms.MaskedTextBox txtRegPassword2;
        private System.Windows.Forms.MaskedTextBox txtRegPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRetLogin;
        private System.Windows.Forms.Label lblLoginWarning;
        private System.Windows.Forms.MaskedTextBox txtLoginEmail;
        private System.Windows.Forms.TextBox txtRegMail;
        private System.Windows.Forms.Label label5;
    }
}

