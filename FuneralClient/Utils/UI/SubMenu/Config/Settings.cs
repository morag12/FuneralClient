using FuneralClient.Utils.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FuneralClient.Utils.UI.SubMenu.Config
{
    public class Settings : SubUI
    {
        public override void Setup()
        {
            GUIStyle style = new GUIStyle(GUI.skin.box);
            Create("Funeral Client - Settings", 1, style, 100f, 30f, 200f, 300f);

            Enabled = false;
        }

        public override void OnRender(int id)
        {
            var style = new GUIStyle(GUI.skin.box);
            if (GUILayout.Button(CustomColorHTML("white", "Back"), style))
            {
                Enabled = false;
                GeneralUtils.UIHelper.UIMenu[0].Enabled = true;
            }
            string LogModerationcolor = Configuration.config.LogModeration ? "#90ee90" : "red";
            string LogModeration = Configuration.config.LogModeration ? "Disable Moderation Logger" : "Enable Moderation Logger";
            if (GUILayout.Button(CustomColorHTML(LogModerationcolor, LogModeration), style))
            {
                Configuration.config.LogModeration = !Configuration.config.LogModeration;
                Configuration.SaveConfig();
            }
            string AntiModColor = Configuration.config.AntiMod ? "#90ee90" : "red";
            string AntiMod = Configuration.config.AntiMod ? "Disable AntiMod" : "Enable AntiMod";
            if (GUILayout.Button(CustomColorHTML(AntiModColor, AntiMod), style))
            {
                Configuration.config.AntiMod = !Configuration.config.AntiMod;
                Configuration.SaveConfig();
            }
            string FPSUncap = Configuration.config.UncapFPS ? "Disable FPS Uncapper" : "Enable FPS Uncapper";
            if (GUILayout.Button(CustomColorHTML("cyan", FPSUncap), style))
            {
                Configuration.config.UncapFPS = !Configuration.config.UncapFPS;
                Configuration.SaveConfig();
            }
            string ShowFPS = Configuration.config.ShowFPS ? "Show FPS Counter" : "Hide FPS Counter";
            if (GUILayout.Button(CustomColorHTML("cyan", ShowFPS), style))
            {
                Configuration.config.ShowFPS = !Configuration.config.ShowFPS;
                Configuration.SaveConfig();
            }

            string AutoFriend = Configuration.config.AutoFriend ? "Don't Auto-friend people on Join" : "Auto-Friend people on Join";
            if (GUILayout.Button(CustomColorHTML("cyan", AutoFriend), style))
            {
                Configuration.config.AutoFriend = !Configuration.config.AutoFriend;
                Configuration.SaveConfig();
            }
        }
    }
}
