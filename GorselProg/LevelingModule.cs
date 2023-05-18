﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GorselProg.Session;

namespace GorselProg
{
    class LevelingModule
    {

        public static int getPlayerXP()
        {
            User current = Session.UserSession.Instance.GetCurrentUser();
            return current.Xp;
        }

        public static int getPlayerLevel()
        {
            User current = Session.UserSession.Instance.GetCurrentUser();
            return current.Level;
        }

        public static void setPlayerXP(int new_xp, int new_level)
        {
            User current = Session.UserSession.Instance.GetCurrentUser();
            current.Xp = new_xp;
            current.Level = new_level;
            Services.UserService.UpdateUser(current);
        }

        //Level sistemi 500xp de bir level artacak şekilde tasarlandı.
        public static void calcPlayerXP(int gained_xp) //XP hesaplanacak yer.
        {
            User current = Session.UserSession.Instance.GetCurrentUser();
            int xp = current.Xp + gained_xp;

            int level = current.Level + (xp / 500);
            int remainder = xp % 500;
            setPlayerXP(remainder, level);
        }

    }
}