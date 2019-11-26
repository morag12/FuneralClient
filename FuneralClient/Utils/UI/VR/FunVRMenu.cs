using FuneralClient.Utils.API;
using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using VRCSDK2;
using static VRCSDK2.VRC_EventHandler;

namespace FuneralClient.Utils.UI.VR
{
    public class FunVRMenu : QMNestedButton
    {
        public FunVRMenu(QMNestedButton parent) : base(parent, 2, 1, "Fun", "A menu full of fun stuff!", Color.black, Color.white, Color.black, Color.cyan)
        {
            new QMToggleButton(this, 1, 0, "Enable HeadFlipper", delegate ()
            {
                GeneralUtils.HeadFlipper = true;

            }, "Disable HeadFlipper", delegate ()
            {
                GeneralUtils.HeadFlipper = false;

                VRCVrCamera.GetInstance().GetComponentInChildren<NeckMouseRotator>().rotationRange.x = GeneralUtils.RotationRangeX;
                VRCVrCamera.GetInstance().GetComponentInChildren<NeckMouseRotator>().rotationRange.y = GeneralUtils.RotationRangeY;
            }, "Enable/Disable the Headflipper", Color.red, Color.white);

            new QMToggleButton(this, 2, 0, "Enable SpinBot", delegate ()
            {
                GeneralUtils.SpinBot = true;
            }, "Disable SpinBot", delegate ()
            {
                GeneralUtils.SpinBot = false;
            }, "Enable/Disable the SpinBot", Color.red, Color.white);

            new QMToggleButton(this, 3, 0, "Deafen others", delegate ()
            {
                GeneralUtils.DeafenNonFriends = true;
            }, "Undeafen others", delegate
            {
                GeneralUtils.DeafenNonFriends = false;
            }, "Choose if people but your friends should hear you", Color.red, Color.white);

            new QMToggleButton(this, 4, 0, "Freeze", delegate
            {
                GeneralUtils.Searialise = false;
            }, "Unfreeze", delegate
            {
                GeneralUtils.Searialise = true;
            }, "Choose if you want people to see you move around or not", Color.red, Color.white);

            new QMToggleButton(this, 4, 1, "Global Interaction", delegate
            {
                GeneralUtils.WorldTriggers = true;
            }, "Disable Global Interaction", delegate
            {
                GeneralUtils.WorldTriggers = false;
            }, "Choose if you want others to see what you interact with", Color.red, Color.white);
        }
    }
}
