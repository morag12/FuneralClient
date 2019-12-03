using FuneralClient.Utils.API;
using FuneralClient.Utils.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FuneralClient.Utils.UI.VR
{
    public class SettingsVRMenu : QMNestedButton
    {
        public SettingsVRMenu(QMNestedButton parent) : base(parent, 2, 2, "Settings", "Configure the client's settings here", Color.black, Color.white, Color.black, Color.cyan)
        {

            new QMToggleButton(this, 2, 0, "Enable Moderation Logger", delegate
            {
                Configuration.config.LogModeration = true;
                Configuration.SaveConfig();
            }, "Disable Moderation Logger", delegate
            {
                Configuration.config.LogModeration = false;
                Configuration.SaveConfig();
            }, "Enable/Disable Moderation Logger.", Color.red, Color.white);

            new QMToggleButton(this, 3, 0, "Enable AntiMod", delegate
            {
                Configuration.config.AntiMod = true;
                Configuration.SaveConfig();
            }, "Disable AntiMod", delegate
            {
                Configuration.config.AntiMod = false;
                Configuration.SaveConfig();
            }, "Enable/Disable AntiMod", Color.red, Color.white);

            new QMToggleButton(this, 4, 0, "Enable FPS Uncapper", delegate
            {
                Configuration.config.UncapFPS = true;
                Configuration.SaveConfig();
            }, "Disable FPS Uncapper", delegate
            {
                Configuration.config.UncapFPS = false;
                Configuration.SaveConfig();
            }, "Enable/Disable FPS Uncapper", Color.red, Color.white);

            new QMToggleButton(this, 4, 1, "Enable AutoFriender", delegate
            {
                Configuration.config.AutoFriend = true;
                Configuration.SaveConfig();
            }, "Disable AutoFriender", delegate
            {
                Configuration.config.AutoFriend = false;
                Configuration.SaveConfig();
            }, "Enable/Disable the option to auto friend people on join", Color.red, Color.white);

            new QMToggleButton(this, 1, 1, "Show FPS Counter", delegate
            {
                Configuration.config.ShowFPS = true;
                Configuration.SaveConfig();
            }, "Hide FPS Uncapper", delegate
            {
                Configuration.config.ShowFPS = false;
                Configuration.SaveConfig();
            }, "Show/Hide FPS Counter", Color.red, Color.white);

            new QMToggleButton(this, 2, 2, "Enable AntiCrash", delegate
            {
                Configuration.config.AntiCrash = true;
                Configuration.SaveConfig();
            }, "Disable AntiCrash", delegate
            {
                Configuration.config.AntiCrash = false;
                Configuration.SaveConfig();
            }, "Enable/Disable AntiCrash", Color.red, Color.white);

            new QMToggleButton(this, 1, 2, "Enable VR Notifications", delegate
            {
                Configuration.config.VRNotifications = true;
                Configuration.SaveConfig();
            }, "Disable AntiCrash", delegate
            {
                Configuration.config.VRNotifications = false;
                Configuration.SaveConfig();
            }, "Enable/Disable friendly vr notifications", Color.red, Color.white);
        }
    }
}
