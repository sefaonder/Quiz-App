﻿using GorselProg.Model;
using GorselProg.Services;
using GorselProg.Session;
using System;
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
    public partial class LobbyGame : Form
    {
        public LobbyGame()
        {
            InitializeComponent();
        }

        private String rank; //Geçici bir rank değişkeni.
        public LobbyGame(String rank) //Geçici bir constructor.
        {
            InitializeComponent();
            this.rank = rank;
        }
        
        Panel active_panel;

        private void LobbyGame_Load(object sender, EventArgs e)
        {
            string room_code = RoomSession.Instance.GetCurrentRoom().Code;
            string room_name = RoomSession.Instance.GetCurrentRoom().Name;
            lblPlayerRoomName.Text = $"{room_name} #{room_code}";
            lblLeaderRoomName.Text = $"{room_name} #{room_code}";

            User currentuser = UserSession.Instance.GetCurrentUser();
            Room room = RoomSession.Instance.GetCurrentRoom();

            if (currentuser.Id.Equals(room.AdminId))
            {
                timerForChatLeader.Start();
                timerForPlayersLeader.Start();
            }
            else
            {
                timerForChat.Start();
                timerForPlayers.Start();
            }

            //Lobi lideriyse:
            if (rank.Equals("Leader"))
            {
                active_panel = pnlLobbyLeader;
                PanelHandler.setPanelFill(active_panel, pnlLobbyLeader);
            }
            //Oyuncuysa:
            else if ( rank.Equals("Player")) 
            {
                active_panel = pnlLobbyPlayer;
                PanelHandler.setPanelFill(active_panel, pnlLobbyPlayer);
            }

            ThemeHandler.changeFormsColor(this);
            ThemeHandler.changeAllControlsColor(this);
            this.WindowState = FormWindowState.Maximized;
        }

        private async void btnPlayerLeave_Click(object sender, EventArgs e)
        {
            timerForChat.Stop();
            timerForPlayers.Stop();
            Guid room_id = RoomSession.Instance.GetCurrentRoom().Id;
            User current = UserSession.Instance.GetCurrentUser();
            await RoomService.ExitRoom(room_id, current);

            formMainMenu mainmenu = new formMainMenu();
            mainmenu.Show();
            this.Hide();
        }

        private void btnLeaderLeave_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Oda dağıtılacaktır. Yine de ayrılmak istiyor musunuz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(cevap == DialogResult.Yes)
            {
                formMainMenu mainmenu = new formMainMenu();
                mainmenu.Show();
                this.Hide();
            }            
        }

        bool[] categoryButtons = new bool[] { false,false,false,false,false };

        private void toggleButtons(object sender, int buttonIndex)
        {

            Button button = (Button)sender;

            if (button.ForeColor != Color.Green)
            {
                button.ForeColor = Color.Green;
                Helper.AddSelectedCategory(buttonIndex);
            }
            else
            {
                button.ForeColor = ThemeHandler.color_texts;
                Helper.RemoveSelectedCategory(buttonIndex);
            }

        }

        private void btnLeaderSpor_Click(object sender, EventArgs e)
        {
            toggleButtons(sender, 0);
        }

        private void btnLeaderBilim_Click(object sender, EventArgs e)
        {
            toggleButtons(sender, 1);
        }

        private void btnLeaderTarih_Click(object sender, EventArgs e)
        {
            toggleButtons(sender, 2);
        }

        private void btnLeaderSanat_Click(object sender, EventArgs e)
        {
            toggleButtons(sender, 3);
        }

        private void btnLeaderEglence_Click(object sender, EventArgs e)
        {
            toggleButtons(sender, 4);
        }

        private async void btnLeaderBaslat_ClickAsync(object sender, EventArgs e)
        {
            

             // Get the selected categories
             
             List<Category> categories = RoomSession.Instance.GetSelectedCategories();

             Room room = RoomSession.Instance.GetCurrentRoom();
             // Call the StartGame method
             var result = await GameService.StartGame(room.Id, categories, DateTime.Now,DateTime.Now.AddMinutes(10));

             if (result != null)
             {
                 MessageBox.Show("Game started successfully!");
             }
             else
             {
                 MessageBox.Show("Failed to start game.");
             }
             



            PanelHandler.setPanelFill(active_panel, pnlGame);
            active_panel = pnlGame;
        }

        private void btnGameGeri_Click(object sender, EventArgs e)
        {
            PanelHandler.setPanelFill(active_panel, pnlLobbyLeader);
            active_panel = pnlLobbyLeader;
        }

        private void btnLeaderMsgSend_Click(object sender, EventArgs e)
        {
            sendMessageLeader();
        }

        private void txtLeaderMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                sendMessageLeader();
            }
        }
        private void txtPlayerMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendMessagePlayer();
            }
        }

        private async void sendMessagePlayer()
        {
            User current = UserSession.Instance.GetCurrentUser();
            Room room = RoomSession.Instance.GetCurrentRoom();
            string message = txtPlayerMsg.Text;
            txtPlayerMsg.Clear();
            await MessageService.SendMessageAsync(current.Id, message, room.Id);
        }

        private async void sendMessageLeader()
        {
            User current = UserSession.Instance.GetCurrentUser();
            Room room = RoomSession.Instance.GetCurrentRoom();
            string message = txtLeaderMsg.Text;
            txtLeaderMsg.Clear();
            await MessageService.SendMessageAsync(current.Id, message, room.Id);
        }

        private void LvPlayerPlayers_MouseClick(object sender, MouseEventArgs e)
        {
            timerForPlayers.Stop();
        }

        private void Panel1_MouseLeave(object sender, EventArgs e)
        {
            timerForPlayers.Start();
        }

        private async void btnPlayerSend_Click(object sender, EventArgs e)
        {
            User current = UserSession.Instance.GetCurrentUser();
            Room room = RoomSession.Instance.GetCurrentRoom();
            string message = txtPlayerMsg.Text;
            txtPlayerMsg.Clear();
            await MessageService.SendMessageAsync(current.Id, message, room.Id);
        }

        private async void timerForPlayersLeader_Tick(object sender, EventArgs e)
        {
            lvLeaderPlayers.Items.Clear();
            Room room = RoomSession.Instance.GetCurrentRoom();
            List<User> players = await RoomService.GetPlayers(room.Id);
            foreach (User u in players)
            {
                string guid = u.Id.ToString();
                string username = u.UserName;
                ListViewItem item = new ListViewItem(guid);
                item.SubItems.Add(username);
                lvLeaderPlayers.Items.Add(item);
            }
            lvLeaderPlayers.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private async void timerForChatLeader_Tick(object sender, EventArgs e)
        {
            lvLeaderChat.Items.Clear();
            Room room = RoomSession.Instance.GetCurrentRoom();
            List<Model.Message> messages = await MessageService.GetMessagesByRoomId(room.Id);
            foreach (Model.Message m in messages)
            {
                string user = m.User.UserName;
                string message = m.MessageText;
                ListViewItem item = new ListViewItem(user);
                item.SubItems.Add(message);
                lvLeaderChat.Items.Add(item);
            }
            lvLeaderChat.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void lvPlayerPlayers_MouseClick(object sender, MouseEventArgs e)
        {
            timerForPlayers.Stop();
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            timerForPlayers.Start();
        }


        private void btnShowSum_Click(object sender, EventArgs e)
        {
            PanelHandler.setPanelFill(active_panel, pnlSum);
            active_panel = pnlSum;
            prgSumXP.Value = 50;
        }

        #region Cevaplar
        private void btnOption1_Click(object sender, EventArgs e)
        {
            // option 1
            textBox1.Text = "Sorunun kendisi";
            btnOption1.Text = "A";
        }

        private void btnOption2_Click(object sender, EventArgs e)
        {
            // option 2
            btnOption2.Text = "B";
        }

        private void btnOption3_Click(object sender, EventArgs e)
        {
            // option 3
            btnOption3.Text = "C";
        }

        private void btnOption4_Click(object sender, EventArgs e)
        {
            // option 4
            btnOption4.Text = "D";
        }

        #endregion
    }
}
