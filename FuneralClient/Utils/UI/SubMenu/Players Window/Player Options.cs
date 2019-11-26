using FuneralClient.Utils.ConsoleUtil;
using FuneralClient.Utils.Extensions;
using FuneralClient.Utils.Other;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Tamir.SharpSsh;
using UnityEngine;
using VRC;
using VRCSDK2;

namespace FuneralClient.Utils.UI.SubMenu.Players_Window
{
    public class Player_Options : SubUI
    {
        public override void Setup()
        {
            GUIStyle style = new GUIStyle(GUI.skin.box);
            Create($"Funeral Client - Player Options", 1, style, 100f, 30f, 200f, 600f);

            Enabled = false;
        }

        public override void OnRender(int id)
        {
            var style = new GUIStyle(GUI.skin.box);
            if (GUILayout.Button(CustomColorHTML("white", "Go Back"), style))
            {
                GeneralUtils.Selected = null;
                Enabled = false;
                GeneralUtils.UIHelper.UIMenu[3].Enabled = true;
            }

            if (GUILayout.Button(CustomColorHTML("red", "Teleport"), style))
            {
                VRCPlayer.Instance.transform.position = GeneralUtils.Selected.transform.position;
            }


            if (GUILayout.Button(CustomColorHTML("red", "Annoy"), style))
            {
                GeneralUtils.Selected.ToCoffin(false).Annoy();
            }

            if (GeneralUtils.Selected.GetIP() != null)
            {
                if (GUILayout.Button(CustomColorHTML("red", "Test Send Home"), style))
                {
                   
                    //Specify the character that denotes the end of response
                }
            }

            if (GUILayout.Button(CustomColorHTML("red", "Drop Portal"), style))
            {
                var position = GeneralUtils.Selected.transform.position;
                var forward = GeneralUtils.Selected.transform.forward;
                string worldid = "wrld_496b11e8-25a0-4f35-976d-faae5e00d60e";
                string worldidwithtags = "<size=1.5>\n" + GeneralUtils.Selected.GetAPIUser().displayName + "<size=0>~hidden";
                //GameObject fgdgcpmmclc = FOHKEHPKGIC.BNOOAIOEMCM(VRC_EventHandler.VrcBroadcastType.Always, "Portals/PortalInternalDynamic", position + Vector3.down, Quaternion.FromToRotation(Vector3.forward, forward));
                /*
                FOHKEHPKGIC.EIOOIBBKFNH(VRC_EventHandler.VrcTargetType.AllBufferOne, fgdgcpmmclc, "ConfigurePortal", new object[]
                {
                    worldid,
                    string.Concat(new string[]
                    {
                        "\n",
                        GeneralUtils.Selected.GetAPIUser().displayName,
                        "\n",
                        GeneralUtils.Selected.GetAPIUser().displayName,
                        "\n",
                         GeneralUtils.Selected.GetAPIUser().displayName,
                        "\n",
                         GeneralUtils.Selected.GetAPIUser().displayName,
                        "~hidden"
                    }),
                    0,
                });
                */
            }
            if (GUILayout.Button(CustomColorHTML("red", "Delete All Portals from player"), style))
            {
                GeneralUtils.DeleteAllPortalsFromPlayer(GeneralUtils.Selected);
            }
            if (GeneralUtils.Selected.ToVRCPlayer().GetAvatar().releaseStatus != "private")
            {
                if (GUILayout.Button(CustomColorHTML("red", "Clone Avatar"), style))
                {
                    var avi = GeneralUtils.Selected.ToVRCPlayer().GetAvatar().id;
                    GeneralUtils.Swap(avi);
                }
            }
           
                if (GUILayout.Button(CustomColorHTML("red", "Save Avatar"), style))
                {
                    var avi = GeneralUtils.Selected.ToVRCPlayer().GetAvatar();
                    GeneralUtils.SaveAvatar(avi);
                }
            if (GUILayout.Button(CustomColorHTML("red", "Grab Info"), style))
            {
                try
                {
                    var plr = GeneralUtils.Selected.GetAPIUser();
                    var player = GeneralUtils.Selected;
                    var steamid = GeneralUtils.Selected.GetSteamID();
                    var info = new InfoOutput(null, plr.displayName, player.GetAvatarURL(), plr.id, steamid);
                    File.WriteAllText($"Coffin\\{plr.displayName}-NormalInfo.txt", JsonConvert.SerializeObject(info));
                    ConsoleUtils.Success($"Successfully grabbed {plr.displayName}'s Normal Information!");
                    ConsoleUtils.Success($"SteamID:{steamid}\nUsername:{plr.displayName}\nUserID: {plr.id}\nAsset URL: {player.GetAvatarURL()}");
                }
                catch (Exception e)
                {
                    ConsoleUtils.Error(e.Message);
                }
            }

            if (GUILayout.Button(CustomColorHTML("red", "Grab All Info"), style))
            {
                try
                {
                    var plr = GeneralUtils.Selected.GetAPIUser();
                    var player = GeneralUtils.Selected;
                    var steamid = GeneralUtils.Selected.GetSteamID();
                    var ip = player.GetIP();
                    var info = new InfoOutput(ip, plr.displayName, player.GetAvatarURL(), plr.id, steamid);
                    var settings = new JsonSerializerSettings();
                    settings.Converters.Add(new IPAddressConverter());
                    settings.Converters.Add(new IPEndPointConverter());
                    settings.Formatting = Formatting.Indented;

                    File.WriteAllText($"Coffin\\{plr.displayName}.txt", JsonConvert.SerializeObject(info, settings));
                    ConsoleUtils.Success($"Successfully grabbed {plr.displayName}'s Information!");
                    ConsoleUtils.Success($"IP:{ip}\nSteamID:{steamid}\nUsername:{plr.displayName}\nUserID: {plr.id}\nAsset URL: {player.GetAvatarURL()}");
                }
                catch (Exception e)
                {
                    ConsoleUtils.Error(e.Message);
                }
            }
        }
    }
}
