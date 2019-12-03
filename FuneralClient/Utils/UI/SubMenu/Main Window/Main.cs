using FuneralClient.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using VRC;

namespace FuneralClient.Utils.UI.SubMenu.MainWindow
{
    public class Main : SubUI
    {
        public override void OnRender(int id)
        {
            var style = new GUIStyle(GUI.skin.box);
            if (GUILayout.Button(CustomColorHTML("red", "Annoy All"), style))
            {
                GeneralUtils.AnnoyAll();
            }

            if (GUILayout.Button(CustomColorHTML("#90ee90", "Delete Portals"), style))
            {
                GeneralUtils.DeleteAllPortals();
            }

            if (GUILayout.Button(CustomColorHTML("white", "Utils"), style))
            {
                Enabled = false;
                GeneralUtils.UIHelper.UIMenu[1].Enabled = true; //UI Menu
            }

            if (GUILayout.Button(CustomColorHTML("white", "Settings"), style))
            {
                Enabled = false;
                GeneralUtils.UIHelper.UIMenu[2].Enabled = true; //Settings Menu
            }

            if (GUILayout.Button(CustomColorHTML("white", "Players"), style))
            {
                Enabled = false;
                GeneralUtils.UIHelper.UIMenu[3].Enabled = true; //Players Menu
            }

            if (GUILayout.Button(CustomColorHTML("white", "Lobby"), style))
            {
                Enabled = false;
                GeneralUtils.UIHelper.UIMenu[5].Enabled = true; //Lobby Menu
            }

            if (GUILayout.Button(CustomColorHTML("white", "Fun"), style))
            {
                Enabled = false;
                GeneralUtils.UIHelper.UIMenu[6].Enabled = true; //Fun Menu
            }

        }

        public override void Setup()
        {
            GUIStyle style = new GUIStyle(GUI.skin.box);
            Create("Funeral Client", 1, style, 100f, 30f, 200f, 600f);

            Enabled = true;
        }
    }
}
