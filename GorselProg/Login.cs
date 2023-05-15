﻿using GorselProg.Model;
using GorselProg.Services;
using GorselProg.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        //PanelHandler ph = new PanelHandler();
        //ThemeHandler themeHandler = new ThemeHandler();
        Panel[] panels;
        TextBox[] textboxes;
        MaskedTextBox[] maskedtextboxes;
        Label[] labels;
        Button[] buttons;
        GroupBox[] groupBoxes;

        Panel active_panel;



        private void Form1_Load(object sender, EventArgs e)
        {
            active_panel = pnlLogin;
            PanelHandler.setPanelFill(active_panel, pnlLogin);

            ThemeHandler.changeAllControlsColor(this);
            ThemeHandler.changeFormsColor(this);
            this.WindowState = FormWindowState.Maximized;

            /*
            ph.showPanel(pnlLogin);
            ph.hidePanel(pnlRegister);
            this.MaximizeBox = false;
            */

            /*
            panels = new Panel[] { pnlLogin,pnlRegister };
            textboxes = new TextBox[] { txtRegUsername, txtRegMail };
            maskedtextboxes = new MaskedTextBox[] { txtLoginPassword, txtRegPassword, txtRegPassword2, txtLoginEmail };
            labels = new Label[] { lblLoginWarning,lblRegWarning,lblRetLogin,label1,label2,label3,label4,label5,label6,label7,label8,label9 };
            buttons = new Button[] { btnLogin,btnRegister };
            groupBoxes = new GroupBox[] {};
            */

            //themeHandler.applyTheme(this, buttons, labels, textboxes,maskedtextboxes, groupBoxes);
        }

        private void lblNoAcc_click(object sender, EventArgs e)
        {
            PanelHandler.setPanelFill(active_panel, pnlRegister);
            active_panel = pnlRegister;

            /*
            ph.hidePanel(pnlLogin);
            ph.showPanel(pnlRegister);
            */
        }

        private void lblRetLogin_MouseClick(object sender, MouseEventArgs e)
        {
            PanelHandler.setPanelFill(active_panel, pnlLogin);
            active_panel = pnlLogin;

            /*
            ph.hidePanel(pnlRegister);
            ph.showPanel(pnlLogin);
            */
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLoginEmail.Text == "")
            {
                lblLoginWarning.Text = "Email alanı boş bırakılamaz!";
                return;
            }
            if(txtLoginPassword.Text == "")
            {
                lblLoginWarning.Text = "Şifre alanı boş bırakılamaz!";
                return;
            }


            #region Login

           
            #endregion

            bool isValid = await UserService.LoginUser(txtLoginEmail.Text, txtLoginPassword.Text);

            // TODO: Loading işlemleri buraya eklenebilir

            if (!isValid) {
                MessageBox.Show("Kullanıcı adı veya şifre yanlıştır.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                formMainMenu game = new formMainMenu();
                this.Hide();
                game.Show();
                game.WindowState = FormWindowState.Maximized;
            }
            
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            Application.UseWaitCursor = true;
            if (txtRegUsername.Text == "")
            {
                lblRegWarning.Text = "Kullanıcı adı boş bırakılamaz!";
                return;
            }
            if (txtRegMail.Text == "")
            {
                lblRegWarning.Text = "Email alanı boş bırakılamaz!";
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
            if (!txtRegPassword.Text.Equals(txtRegPassword2.Text))
            {
                lblRegWarning.Text = "Şifreler Uyuşmuyor!";
                return;
            }

            User user = new User { UserName = txtRegUsername.Text, Email = txtRegMail.Text,Password = txtRegPassword.Text };
            
            bool isSucces = await UserService.AddUser(user);

            if(isSucces)
            {
                MessageBox.Show("Başarılı bir şekilde kayıt oluşturulmuştur.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı vardır", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // TODO: buraya belki bi loading gibi birşey gelebilir

            txtRegUsername.Text = "";
            txtRegMail.Text = "";
            txtRegPassword.Text = "";
            txtRegPassword2.Text = "";

            PanelHandler.setPanelFill(active_panel, pnlLogin);
            active_panel = pnlLogin;
        }

        public void updateTheme()
        {
            //themeHandler.applyTheme(this, buttons, labels, textboxes, maskedtextboxes, groupBoxes);
        }

        private void formLoginRegister_Shown(object sender, EventArgs e)
        {
            /*
            themeHandler.darkTheme();
            themeHandler.applyTheme(this, buttons, labels, textboxes, maskedtextboxes, groupBoxes);
            */
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
