using FuneralClient.Utils.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FuneralClient.Utils.UI.VR
{
    public class UtilsVRMenu : QMNestedButton
    {
        public static QMToggleButton GlowESPButton;

        public UtilsVRMenu(QMNestedButton Parent) : base(Parent, 2, 0, "Utils", "All the utilities you would possibly ever need!", Color.red, Color.white, Color.black, Color.cyan)
        {
            new QMToggleButton(this, 1, 0, "Enable Flight", delegate ()
            {
                Physics.gravity = Vector3.zero;
                GeneralUtils.Flight = true;
            }, "Disable Flight", delegate ()
            {
                Physics.gravity = GeneralUtils.Grav;
                GeneralUtils.Flight = false;
            }, "Enable/Disable flight and become a haxxor!11", Color.red, Color.white);

            new QMToggleButton(this, 1, 1, "Enable BoxESP", delegate ()
            {
                GeneralUtils.BoxESP = true;
            }, "Disable BoxESP", delegate ()
            {
                GeneralUtils.BoxESP = false;
            }, "Enable/Disable BoxESP and become a haxxor!11", Color.red, Color.white);

            new QMToggleButton(this, 1, 2, "Enable 2D ESP", delegate ()
            {
                GeneralUtils.DimensionalESP = true;
            }, "Disable 2D ESP", delegate ()
            {
                GeneralUtils.DimensionalESP = false;
            }, "Enable/Disable 2D ESP and become a haxxor!11", Color.red, Color.white);

            new QMToggleButton(this, 2, 0, "Enable ESP TraceLines", delegate ()
            {
                GeneralUtils.DrawTracingLines = true;
            }, "Disable ESP TraceLines", delegate ()
            {
                GeneralUtils.DrawTracingLines = false;
            }, "Enable/Disable tracelines for ESP and become a haxxor!11", Color.red, Color.white);

            new QMSingleButton(this, 2, 1, "Increase Flight Speed (+2)", delegate
            {
                if (GeneralUtils.Flight)
                {
                    GeneralUtils.FlightSpeed = GeneralUtils.FlightSpeed + 2;
                }
            }, "Increase your walking flight speed if flight is enabled", Color.red, Color.white);

            new QMSingleButton(this, 2, 2, "Decrease Flight Speed (-2)", delegate
            {
                      if (GeneralUtils.Flight)
                      {
                          GeneralUtils.FlightSpeed = GeneralUtils.FlightSpeed - 2;
                      }
            }, "Decrease the walking flight speed", Color.black, Color.white);

            new QMSingleButton(this, 3, 0, "Increase Flight Run Speed (+2)", delegate
            {
                if (GeneralUtils.Flight)
                {
                    GeneralUtils.FlightRunSpeed = GeneralUtils.FlightRunSpeed + 2;
                }
            }, "Increase your running flight speed if flight is enabled", Color.red, Color.white);

            new QMSingleButton(this, 3, 1, "Decrease Flight Run Speed (+2)", delegate
            {
                if (GeneralUtils.Flight)
                {
                    GeneralUtils.FlightRunSpeed = GeneralUtils.FlightRunSpeed - 2;
                }
            }, "Decrease your running flight speed if flight is enabled", Color.red, Color.white);

            GlowESPButton = new QMToggleButton(this, 3, 2, "Enable GlowESP", delegate
            {
                GeneralUtils.GlowESP = true;
            }, "Disable GlowESP", delegate
            {
                GeneralUtils.GlowESP = false;
            }, "Enable/Disable GlowESP", Color.red, Color.white);

            new QMSingleButton(this, 4, 0, "Fix Tracking (Experimental)", delegate ()
            {
                VRCPlayer.Instance.AlignTrackingToPlayer();
            }, "Attempt to fix your tracking issues", Color.red, Color.white);
        }
    }
}
