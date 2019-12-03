using FuneralClient.Utils.ConsoleUtil;
using FuneralClient.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using VRC;

namespace FuneralClient.Utils.UI.SubMenu.Lobby_Window
{
    public class Lobby : SubUI
    {
        public override void Setup()
        {
            GUIStyle style = new GUIStyle(GUI.skin.box);
            Create($"Funeral Client - World Options", 1, style, 100f, 30f, 200f, 600f);

            Enabled = false;
        }

        public override void OnRender(int id)
        {
            GUIStyle style = new GUIStyle(GUI.skin.box);
            if (GUILayout.Button(CustomColorHTML("red", "Crash Lobby"), style))
            {
                GeneralUtils.Swap("avtr_56674e13-8e5f-4eae-be53-21980ec4e965");
            }

            if (GUILayout.Button(CustomColorHTML("red", "Get Information"), style))
            {
                var ins = RoomManager.currentWorldInstance;
                string text = $"Instance Name: {ins.instanceName}\nInstance Owner: {PlayerManager.GetPlayer(ins.instanceCreator).GetAPIUser().displayName}\nPlayer Count: {ins.count}";
                ConsoleUtils.Info(text);
            }
            string color = GeneralUtils.DeletePortals ? "#90ee90" : "red";
            string enable = GeneralUtils.DeletePortals ? "Disable" : "Enable";

            if (GUILayout.Button(CustomColorHTML(color, $"{enable} Portal Disabler"), style))
            {
                GeneralUtils.DeletePortals = !GeneralUtils.DeletePortals;
            }

            if (GUILayout.Button(CustomColorHTML("white", "Back"), style))
            {
                Enabled = false;

                GeneralUtils.UIHelper.UIMenu[0].Enabled = true;
            }
        }
    }
}
