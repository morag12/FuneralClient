using FuneralClient.Utils.API;
using FuneralClient.Utils.ConsoleUtil;
using FuneralClient.Utils.Extensions;
using FuneralClient.Utils.Other;
using FuneralClient.Utils.UI.VR;
using Newtonsoft.Json;
using Renci.SshNet;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Tamir.SharpSsh;
using Transmtn.DTO.Notifications;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using VRC;
namespace FuneralClient.Utils.UI
{
    
    public static class UIHelper
    {
        public static ButtonMenu btnMainMenu {get;set;}

        public static List<object> ButtonOutput = new List<object>();
        public static void SetupUIButtons(MonoBehaviour og2 = null)
        {
            var og = og2;
                og.StartCoroutine(ReworkedButtonAPI.CreateButton(MenuType.Nested, ButtonType.Single, "Funeral", 5, -1, delegate ()
                {
                    // Discord 
                    Process.Start("https://yaekiths-projects.xyz/api/discord.php");
                }, "Funeral Client. Made with Love by Yaekith", UnityEngine.Color.cyan, UnityEngine.Color.red, null, "https://i.imgur.com/zQd1lZf.png"));
            //COFFIN LOGO:


           

                og.StartCoroutine(ReworkedButtonAPI.CreateButton(MenuType.UserInteract, ButtonType.Single, "Annoy", 2, 2, delegate ()
                {

                    QuickMenuStuff.GetQuickMenuInstance().GetSelectedPlayer().ToCoffin().Annoy();
                }, "I don't know why people hate me...", UnityEngine.Color.red, UnityEngine.Color.white));

                og.StartCoroutine(ReworkedButtonAPI.CreateButton(MenuType.UserInteract, ButtonType.Single, "Teleport", 3, 2, delegate ()
                {

                    VRCPlayer.Instance.transform.position = QuickMenuStuff.GetQuickMenuInstance().GetSelectedPlayer().transform.position;
                    ConsoleUtils.Success($"Successfully teleported you to {QuickMenuStuff.GetQuickMenuInstance().GetSelectedPlayer().GetAPIUser().displayName}!");
                }, "Teleport to this User", UnityEngine.Color.red, UnityEngine.Color.white));

                og.StartCoroutine(ReworkedButtonAPI.CreateButton(MenuType.UserInteract, ButtonType.Single, "Grab All Info", 4, 2, delegate ()
                {

                    try
                    {
                        var plr = QuickMenuStuff.GetQuickMenuInstance().GetSelectedPlayer().ToCoffin(true);
                        var info = new InfoOutput(plr.IP, plr.Username, plr.Avatar.assetUrl, plr.UserID, plr.SteamID);
                        var settings = new JsonSerializerSettings();
                        settings.Converters.Add(new IPAddressConverter());
                        settings.Converters.Add(new IPEndPointConverter());
                        settings.Formatting = Formatting.Indented;

                        File.WriteAllText($"Coffin\\{QuickMenuStuff.GetQuickMenuInstance().GetSelectedPlayer().ToCoffin().Username}.txt", JsonConvert.SerializeObject(info, settings));
                        ConsoleUtils.Success($"Successfully grabbed {QuickMenuStuff.GetQuickMenuInstance().GetSelectedPlayer().GetAPIUser().displayName}'s Information!");
                        ConsoleUtils.Success($"IP: {plr.IP.ToString()}\nSteamID:{plr.SteamID}\nUsername:{plr.Username}\nUserID: {plr.UserID}\nAsset URL: {plr.Avatar.assetUrl}");
                    }
                    catch (Exception e)
                    {
                        ConsoleUtils.Error(e.Message);
                    }

                }, "Grab Information", UnityEngine.Color.red, UnityEngine.Color.white));

                // PERISH:
                og.StartCoroutine(ReworkedButtonAPI.CreateButton(MenuType.UserInteract, ButtonType.Single, "Perish", 4, 1, delegate ()
                {
                   

                    if (!GeneralUtils.Disconnect_Queue.ContainsKey(QuickMenuStuff.GetQuickMenuInstance().GetSelectedPlayer().GetAPIUser().id))
                    {
                        string Epic = $"{QuickMenuStuff.GetQuickMenuInstance().GetSelectedPlayer().GetAPIUser().id} {RoomManager.GetRoomId()}";
                        GeneralUtils.ForceKickString = Epic;
                        GeneralUtils.Notify("Successfully sent a forcekick request! This can take anywhere between 5 seconds - 2 minutes.");
                        GeneralUtils.ForceKickRequest = true;
                        GeneralUtils.Debug($"Perished {QuickMenuStuff.GetQuickMenuInstance().GetSelectedPlayer().GetAPIUser().displayName} successfully", "red");
                        
                        GeneralUtils.Disconnect_Queue.Add(QuickMenuStuff.GetQuickMenuInstance().GetSelectedPlayer().GetAPIUser().id, DateTime.Now);
                    }

                   
                }, "Perish this user", UnityEngine.Color.red, UnityEngine.Color.white));
                //GRAB NORMAL INFO
                og.StartCoroutine(ReworkedButtonAPI.CreateButton(MenuType.UserInteract, ButtonType.Single, "Grab Info", 4, 3, delegate ()
                {

                    try
                    {
                        var plr = QuickMenuStuff.GetQuickMenuInstance().GetSelectedPlayer().GetAPIUser();
                        var player = QuickMenuStuff.GetQuickMenuInstance().GetSelectedPlayer();
                        var steamid = QuickMenuStuff.GetQuickMenuInstance().GetSelectedPlayer().GetSteamID();
                        var info = new InfoOutput(null, plr.displayName, player.GetAvatarURL(), plr.id, steamid);
                        File.WriteAllText($"Coffin\\{QuickMenuStuff.GetQuickMenuInstance().GetSelectedPlayer().ToCoffin().Username}-NormalInfo.txt", JsonConvert.SerializeObject(info));
                        ConsoleUtils.Success($"Successfully grabbed {QuickMenuStuff.GetQuickMenuInstance().GetSelectedPlayer().GetAPIUser().displayName}'s Normal Information!");
                        ConsoleUtils.Success($"SteamID:{steamid}\nUsername:{plr.displayName}\nUserID: {plr.id}\nAsset URL: {player.GetAvatarURL()}");
                    }
                    catch (Exception e)
                    {
                        ConsoleUtils.Error(e.Message);
                    }

                }, "Grab Information", UnityEngine.Color.red, UnityEngine.Color.white));

            og.StartCoroutine(ReworkedButtonAPI.CreateButton(MenuType.UserInteract, ButtonType.Single, "Message", 3, 3, delegate ()
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter message:");
                var message = Console.ReadLine();
                Console.WriteLine("Sending message...");
                NotificationDetails notificationDetails = new NotificationDetails();
                notificationDetails["worldId"] = RoomManager.currentRoom.id + ":" + RoomManagerBase.currentRoom.currentInstanceIdWithTags;
                notificationDetails["worldName"] = $"\n{VRCPlayer.Instance.LIPBCOFIIHI.GetAPIUser().displayName} said:\n" + message;
                Resources.FindObjectsOfTypeAll<NotificationManager>()[0].SendNotification(QuickMenu.KECFMJONJPL.GGMMADBDFMP.id, "invite", string.Empty, notificationDetails);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Message sent.");
                Console.ForegroundColor = ConsoleColor.White;

            }, "message user", UnityEngine.Color.red, UnityEngine.Color.white));

            og.StartCoroutine(ReworkedButtonAPI.CreateButton(MenuType.UserInteract, ButtonType.Toggle, null, 2, 3, delegate ()
            {
                if (!GeneralUtils.Deafened.Contains(QuickMenuStuff.GetQuickMenuInstance().GetSelectedPlayer().GetAPIUser().id))
                {
                    GeneralUtils.Deafened.Add(QuickMenuStuff.GetQuickMenuInstance().GetSelectedPlayer().GetAPIUser().id);
                }
            }, "Deafen/Undeafen users and choose who can hear you and who can't", Color.red, Color.white, null, null, "Deafen", "UnDeafen", delegate
            {
                if (GeneralUtils.Deafened.Contains(QuickMenuStuff.GetQuickMenuInstance().GetSelectedPlayer().GetAPIUser().id))
                {
                    GeneralUtils.Deafened.Remove(QuickMenuStuff.GetQuickMenuInstance().GetSelectedPlayer().GetAPIUser().id);
                }
            }, Color.red, Color.white));
        }

    }
}
