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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        ThemeHandler themeHandler = new ThemeHandler();
        PanelHandler panelHandler = new PanelHandler();
        Panel[] panels;
        TextBox[] textboxes;
        Label[] labels;
        Button[] buttons;
        GroupBox[] groupBoxes;

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            formLoginRegister form = new formLoginRegister();
            form.Show();
            this.Hide();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //DESIGN

            setPanel(pnlBuildAGame);
            
            //CODE
        }

        private void Game_Load(object sender, EventArgs e)
        {
            //DESIGN

            /*
            panels = new Panel[] { pnlBuildAGame, pnlCreateAGame, pnlHowToPlay, pnlJoinAGame, pnlPreferences };
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = false;
            */
            panels = new Panel[] { pnlMainMenu, pnlBuildAGame, pnlCreateAGame, pnlJoinAGame, pnlPreferences, pnlHowToPlay };
            textboxes = new TextBox[] { txtCAGRoomName, txtCAGRoomPassword, txtJoinCode};
            labels = new Label[] { lblHowToPlay, label1,label2,label3};
            buttons = new Button[] {btnBAGBack,btnCAGCreateRoom,btnCAGGeri,btnCreateAGame,btnDarkMode,btnHowToPlay,btnJAGGeri,btnJoinAGame,btnLightMode,btnPlay,btnPreferences,btnSignOut,button2 };
            groupBoxes = new GroupBox[] {grpHowToPlay,grpCreateAGame,grpJoinAGame};
            themeHandler.applyTheme(this, buttons, labels, textboxes,groupBoxes);

            setPanel(pnlMainMenu);

            //CODE
        }

        private void btnCreateAGame_Click(object sender, EventArgs e)
        {
            //DESIGN

            setPanel(pnlCreateAGame);

            //CODE

        }

        private void btnJoinAGame_Click(object sender, EventArgs e)
        {
            //DESIGN

            setPanel(pnlJoinAGame);

            //CODE

        }

        private void btnHowToPlay_Click(object sender, EventArgs e)
        {

            //DESIGN

            setPanel(pnlHowToPlay);

            //CODE
        }

        private void btnPreferences_Click(object sender, EventArgs e)
        {
            //DESIGN

            setPanel(pnlPreferences);

            //CODE
        }

        private void btnLightMode_Click(object sender, EventArgs e)
        {
            btnLightMode.Enabled = false;
            btnLightMode.BackColor = Color.FromArgb(104, 93, 82);
            btnDarkMode.Enabled = true;
            btnDarkMode.BackColor = Color.FromArgb(195, 180, 163);
        }

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            btnLightMode.Enabled = true;
            btnDarkMode.BackColor = Color.FromArgb(104, 93, 82);
            btnDarkMode.Enabled = false;
            btnLightMode.BackColor = Color.FromArgb(195, 180, 163);
        }

        private void setPanel(Panel panel)
        {
            panelHandler.hidePanels(panels);
            panel.Visible = true;
            panel.Size = new Size(450,350);
            panel.Left = (this.Width - panel.Width) / 2;
            panel.Top = (this.Height - panel.Height) / 2;
        }

        private void btnBAGBack_Click(object sender, EventArgs e)
        {
            setPanel(pnlMainMenu);
        }

        private void btnJAGGeri_Click(object sender, EventArgs e)
        {
            //DESIGN
            setPanel(pnlBuildAGame);

            //CODE
        }

        private void btnCAGGeri_Click(object sender, EventArgs e)
        {
            //DESIGN
            setPanel(pnlBuildAGame);

            //CODE
        }

        private void btnHTPGeri_Click(object sender, EventArgs e)
        {
            setPanel(pnlMainMenu);
        }

        private void btnPreferencesGeri_Click(object sender, EventArgs e)
        {
            setPanel(pnlMainMenu);
        }
    }
}
