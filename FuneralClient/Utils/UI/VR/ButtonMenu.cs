using FuneralClient.Utils.API;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FuneralClient.Utils.UI.VR
{
    public class ButtonMenu : QMNestedButton
    {
        public UtilsVRMenu UtilsMenu {  get;  set;}
        public FunVRMenu FunMenu { get; set; }
        public SettingsVRMenu SettingsMenu { get; set; }

        public LobbyVRMenu LobbyMenu { get; set; }

        public ButtonMenu() : base("ShortcutMenu", 5, 2, "Coffin", "See what's inside", Color.red, Color.white, Color.red, Color.cyan)
        {
            new QMSingleButton(this, 1, 0, "Discord", delegate ()
            {
                Process.Start("https://yaekiths-projects.xyz/api/discord.php");
            }, "Come join us!", Color.red, Color.white);

            new QMSingleButton(this, 1, 1, "Delete Portals", delegate ()    
            {
                GeneralUtils.DeleteAllPortals();
            }, "Delete all portals existent", Color.red, Color.white);

            new QMSingleButton(this, 1, 2, "Annoy All", delegate ()
            {
                GeneralUtils.AnnoyAll();
            }, "Annoy everyone", Color.red, Color.white);

            new QMToggleButton(this, 3, 2, "Show SubUI", delegate ()
            {
                UnityEngine.Object.DontDestroyOnLoad(GeneralUtils.obj);
                GeneralUtils.UIHelper = GeneralUtils.obj.AddComponent<MainUIHelper>();
                GeneralUtils.UIHelper.Setup();
                GeneralUtils.ShouldShowUI = true;
            }, "Hide SubUI", delegate ()
            {
                var UI = GeneralUtils.obj.GetComponent<MainUIHelper>();
                UnityEngine.GameObject.Destroy(UI);
                GeneralUtils.ShouldShowUI = false;
            }, "Show/Hide the SubUI", Color.red, Color.white);
                
            UtilsMenu = new UtilsVRMenu(this);
            FunMenu = new FunVRMenu(this);
            SettingsMenu = new SettingsVRMenu(this);
            LobbyMenu = new LobbyVRMenu(this);
            new QMSingleButton(this, 3, 1, "Credits", delegate
            {
                GeneralUtils.Notify("Credits:\nYaekith - Main Client Developer & Creator");
                Resources.FindObjectsOfTypeAll < VRCUiManager>()[0].CloseUi();
            }, "Show who made this client", Color.black, Color.white);
        }
    }
}
