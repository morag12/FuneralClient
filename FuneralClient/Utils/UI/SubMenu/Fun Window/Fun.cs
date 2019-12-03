using FuneralClient.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using VRCSDK2;
using static VRCSDK2.VRC_EventHandler;

namespace FuneralClient.Utils.UI.SubMenu.Fun_Window
{
    public class Fun : SubUI
    {
        public override void Setup()
        {
            GUIStyle style = new GUIStyle(GUI.skin.box);
            Create("Funeral Client - Fun", 1, style, 100f, 30f, 200f, 300f);

            Enabled = false;
        }

        public override void OnRender(int id)
        {
            var style = new GUIStyle(GUI.skin.box);
            string headflip_1 = GeneralUtils.HeadFlipper ? "cyan" : "red";
            string headflipText = GeneralUtils.HeadFlipper ? "Disable HeadFlipper" : "Enable HeadFlipper";
            if (GUILayout.Button(CustomColorHTML(headflip_1, headflipText), style))
            {
                GeneralUtils.HeadFlipper = !GeneralUtils.HeadFlipper;

                if (!GeneralUtils.HeadFlipper)
                {
                    VRCVrCamera.GetInstance().GetComponentInChildren<NeckMouseRotator>().rotationRange.x = GeneralUtils.RotationRangeX;
                    VRCVrCamera.GetInstance().GetComponentInChildren<NeckMouseRotator>().rotationRange.y = GeneralUtils.RotationRangeY;
                }
            }
            string spinBot = GeneralUtils.SpinBot ? "Disable SpinBot" : "Enable SpinBot";
            string SpinColor = GeneralUtils.SpinBot ? "cyan" : "#90ee90";
            if (GUILayout.Button(CustomColorHTML(SpinColor, spinBot), style))
            {
                GeneralUtils.SpinBot = !GeneralUtils.SpinBot;
            }
            if (GUILayout.Button(CustomColorHTML("red", "Drop C00l Portal"), style))
            {
                var position = GeneralUtils.Selected.transform.position;
                //var forward = GeneralUtils.Selected.transform.forward;
                //string worldid = RoomManager.currentRoom.id;
                //string worldidwithtags = RoomManager.currentRoom.currentInstanceIdWithTags;
                GameObject gameObject = Networking.Instantiate(0, "PortalInternalDynamic", position, GeneralUtils.Selected.transform.rotation);
                Networking.RPC((VrcTargetType)7, gameObject, "ConfigurePortal", new object[]
                {
                    "wrld_496b11e8-25a0-4f35-976d-faae5e00d60e",
                    "<b><size=3.6>\n" + $"<color=cyan>T</color><color=red>u</color>p<color=yellow>p</color><color=green>e</color><color=blue>r</color>" + "<size=0></b>~hidden",
                    0
                });
            }
            if (GUILayout.Button(CustomColorHTML("white", "Back"), style))
            {
                Enabled = false;
                GeneralUtils.UIHelper.UIMenu[0].Enabled = true;
            }
        }
    }
}
