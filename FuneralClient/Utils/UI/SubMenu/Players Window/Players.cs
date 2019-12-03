using FuneralClient.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using VRC;

namespace FuneralClient.Utils.UI.SubMenu.Players_Window
{
    public class Players : SubUI
    {
        public override void Setup()
        {
            GUIStyle style = new GUIStyle(GUI.skin.box);
            Create("Funeral Client - Players", 1, style, 100f, 30f, 200f, 600f);

            Enabled = false;
        }

        public override void OnRender(int id)
        {
            var style = new GUIStyle(GUI.skin.box);

            if (GUILayout.Button(CustomColorHTML("white", "Go Back"), style))
            {
                Enabled = false;
                GeneralUtils.UIHelper.UIMenu[0].Enabled = true;
            }

            if (PlayerManager.GetAllPlayers().Count() > 0)
            {
                foreach(var plr in PlayerManager.GetAllPlayers())
                {
                    string username = plr.GetAPIUser().displayName;

                    if (GUILayout.Button(CustomColorHTML("cyan", username), style))
                    {
                        GeneralUtils.Selected = plr;
                        Enabled = false;
                        GeneralUtils.UIHelper.UIMenu[4].Enabled = true;
                    }
                }
            }
        }
    }
}
