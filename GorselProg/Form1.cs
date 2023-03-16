﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProg
{
    public partial class formLoginRegister : Form
    {
        public formLoginRegister()
        {
            InitializeComponent();
        }

        PanelHandler ph = new PanelHandler();

        private void Form1_Load(object sender, EventArgs e)
        {
            ph.showPanel(pnlLogin);
            ph.hidePanel(pnlRegister);
            this.MaximizeBox = false;
        }

        private void lblNoAcc_click(object sender, EventArgs e)
        {
            ph.hidePanel(pnlLogin);
            ph.showPanel(pnlRegister);
        }

        private void lblRetLogin_MouseClick(object sender, MouseEventArgs e)
        {
            ph.hidePanel(pnlRegister);
            ph.showPanel(pnlLogin);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        { 

            if (txtLoginUsername.Text == "")
            {
                lblLoginWarning.Text = "Kullanıcı adı boş bırakılamaz!";
                return;
            }
            if(txtLoginPassword.Text == "")
            {
                lblLoginWarning.Text = "Şifre alanı boş bırakılamaz!";
                return;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtRegUsername.Text == "")
            {
                lblRegWarning.Text = "Kullanıcı adı boş bırakılamaz!";
                return;
            }
            if (txtRegPassword.Text == "")
            {
                lblRegWarning.Text = "Şifre alanı boş bırakılamaz!";
                return;
            }
            if (txtRegPassword2.Text == "")
            {
                lblRegWarning.Text = "Şifreyi tekrar girmelisiniz!";
                return;
            }
            if (!txtRegPassword.Equals(txtRegPassword2))
            {
                lblRegWarning.Text = "Şifreler Uyuşmuyor!";
                return;
            }
        }
    }
}
