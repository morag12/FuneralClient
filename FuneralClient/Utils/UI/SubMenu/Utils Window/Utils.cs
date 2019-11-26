using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using VRC.Core;
using VRC.UI;

namespace FuneralClient.Utils.UI.SubMenu.Utils_Window
{
    public class Utils : SubUI
    {
        public override void OnRender(int id)
        {
            string flight2 = GeneralUtils.Flight ? "Disable Flight" : "Enable Flight";
            string flightColor = GeneralUtils.Flight ? "#90ee90" : "red";
            var style = new GUIStyle(GUI.skin.box);
            if (GUILayout.Button(CustomColorHTML(flightColor, flight2), style))
            {
                Physics.gravity = !GeneralUtils.Flight ? Vector3.zero : GeneralUtils.Grav;
                GeneralUtils.Flight = !GeneralUtils.Flight;
            }

            var ESP = GeneralUtils.BoxESP;
            string ESPText = ESP ? "Disable ESP" : "Enable ESP";
            string ESPColor = ESP ? "#90ee90" : "red";
            if (GUILayout.Button(CustomColorHTML(ESPColor, ESPText), style))
            {
                GeneralUtils.BoxESP = !GeneralUtils.BoxESP;
            }

            if (GUILayout.Button(CustomColorHTML("white", "Back"), style))
            {
                Enabled = false;
                GeneralUtils.UIHelper.UIMenu[0].Enabled = true;
            }
        }

        public override void Setup()
        {
            GUIStyle style = new GUIStyle(GUI.skin.box);
            Create("Funeral Client - Utils", 1, style, 100f, 30f, 200f, 300f);

            Enabled = false;
        }
    }
}
