using FuneralClient.Utils.API;
using FuneralClient.Utils.ConsoleUtil;
using FuneralClient.Utils.Extensions;
using FuneralClient.Utils.Other;
using Newtonsoft.Json;
using PlayHooky;
using Steamworks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;
using VRC;

namespace FuneralClient.Utils.Hooker
{
    public static class HookManager
    {
        #region OnPlayerJoin
        private static Type OnPlrJoinType;
        private static FieldInfo OnPlrJoinInstance, OnPlayerJoinEvent;
        #endregion
        #region OnPlayerLeave
        private static Type OnPlrLeaveType;
        private static FieldInfo OnPlrLeaveInstance, OnPlayerLeaveEvent;
        #endregion

        static HookManager()
        {
            #region Player Join And Leave
            OnPlrJoinType = typeof(PlayerModManager).Assembly.GetType("NetworkManager");
            OnPlrJoinInstance = OnPlrJoinType.GetField("Instance", BindingFlags.Static | BindingFlags.Public);
            OnPlayerJoinEvent = OnPlrJoinType.GetField("OnPlayerJoinedEvent", BindingFlags.Instance | BindingFlags.Public);
            OnPlrLeaveType = typeof(PlayerModManager).Assembly.GetType("NetworkManager");
            OnPlrLeaveInstance = OnPlrLeaveType.GetField("Instance", BindingFlags.Static | BindingFlags.Public);
            OnPlayerLeaveEvent = OnPlrLeaveType.GetField("OnPlayerLeftEvent", BindingFlags.Instance | BindingFlags.Public);
            #endregion
        }
        #region OnPlayerJoin/Leave
        public static void HookPlayerJoin(UnityAction<Player> overrider)
        {
            new UnityActionReflection<Player>(OnPlayerJoinEvent.FieldType, OnPlayerJoinEvent.GetValue(OnPlrJoinInstance.GetValue(null))).Add(overrider);
        }

        public static void HookPlayerLeave(UnityAction<Player> overrider)
        {
            new UnityActionReflection<Player>(OnPlayerLeaveEvent.FieldType, OnPlayerLeaveEvent.GetValue(OnPlrLeaveInstance.GetValue(null))).Add(overrider);
        }
        #endregion
        public static void OnPlayerJoin(Player player)
        {  
            if (KOSService.UserKOS.Contains(player.GetAPIUser().id))
            {

               if (!GeneralUtils.Disconnect_Queue.ContainsKey(QuickMenuStuff.GetQuickMenuInstance().GetSelectedPlayer().GetAPIUser().id))
               {
                        GeneralUtils.Debug($"{player.GetAPIUser().displayName} GET HERE NOW");
                        string Epic = $"{player.GetAPIUser().id} {RoomManager.GetRoomId()}";
                        GeneralUtils.ForceKickString = Epic;
                        GeneralUtils.ForceKickRequest = true;

                        GeneralUtils.Disconnect_Queue.Add(QuickMenuStuff.GetQuickMenuInstance().GetSelectedPlayer().GetAPIUser().id, DateTime.Now);
               }
            }
            else if (Configuration.config.LogModeration)
            {
                if (Configuration.config.VRNotifications)
                {
                    GeneralUtils.Notify($"{player.GetAPIUser().displayName} has joined");
                }

                GeneralUtils.Debug($"{player.GetAPIUser().displayName} has joined. || @" + DateTime.Now.ToShortTimeString(), "cyan");

                if (player.GetIP() != null)
                {
                    var plr = GeneralUtils.Selected.GetAPIUser();
                    var player2 = GeneralUtils.Selected;
                    var steamid = GeneralUtils.Selected.GetSteamID();
                    var ip = player.GetIP();
                    var info = new InfoOutput(ip, plr.displayName, player2.GetAvatarURL(), plr.id, steamid);
                    var settings = new JsonSerializerSettings();
                    settings.Converters.Add(new IPAddressConverter());
                    settings.Converters.Add(new IPEndPointConverter());
                    settings.Formatting = Formatting.Indented;

                    File.WriteAllText($"Coffin\\{plr.displayName}-AutoLogger.txt", JsonConvert.SerializeObject(info, settings));
                }
                else
                {
                    var plr = GeneralUtils.Selected.GetAPIUser();
                    var player2 = GeneralUtils.Selected;
                    var steamid = GeneralUtils.Selected.GetSteamID();
                    var ip = player.GetIP();
                    var info = new InfoOutput(null, plr.displayName, player2.GetAvatarURL(), plr.id, steamid);
                    var settings = new JsonSerializerSettings();
                    settings.Converters.Add(new IPAddressConverter());
                    settings.Converters.Add(new IPEndPointConverter());
                    settings.Formatting = Formatting.Indented;

                    File.WriteAllText($"Coffin\\{plr.displayName}-AutoLogger.txt", JsonConvert.SerializeObject(info, settings));
                }
            }
            else if (Configuration.config.AntiMod)
            {
                if (player.GetAPIUser().hasSuperPowers || player.GetAPIUser().hasModerationPowers || player.GetAPIUser().hasScriptingAccess)
                {
                    ConsoleUtils.Info("Detected a moderator/developer, so we sent you home. Ez clap <3 - Yaekith");

                    if (Configuration.config.VRNotifications)
                    {
                        GeneralUtils.Notify($"Detected a moderator/developer, so we sent you home. Ez clap <3 - Yaekith");
                    }

                    Resources.FindObjectsOfTypeAll<VRCFlowManager>()[0].GoHome();
                }
            }
            else if (Configuration.config.AutoFriend)
            {
                if (!player.IsFriended() && player.GetAPIUser().id != PlayerManager.GetCurrentPlayer().GetAPIUser().id)
                {
                    player.Friend();
                }
            }

        }
        public static void OnPlayerLeave(Player player)
        {
            if (Configuration.config.LogModeration)
            {
                if (GeneralUtils.Disconnect_Queue.ContainsKey(player.GetAPIUser().id))
                {
                    DateTime res = default;

                    if (GeneralUtils.Disconnect_Queue.TryGetValue(player.GetAPIUser().id, out res))
                    {
                        double result = DateTime.Now.Subtract(res).TotalSeconds;
                        GeneralUtils.Debug($"Force-Kick Succeeded on: {player.GetAPIUser().displayName} || Took {Math.Round(result, 0)} second(s)", "#98fb98");
                        GeneralUtils.Disconnect_Queue.Remove(player.GetAPIUser().id);
                    }
                }
                else
                {
                    if (Configuration.config.VRNotifications)
                    {
                        GeneralUtils.Notify($"{player.GetAPIUser().displayName} has left the lobby.");
                    }

                    GeneralUtils.Debug($"{player.GetAPIUser().displayName} has left || @" + DateTime.Now.ToShortTimeString(), "yellow");
                }
            }
        }
        public static void Hook()
        {
            HookPlayerJoin(OnPlayerJoin);
            HookPlayerLeave(OnPlayerLeave);
        }
    }
}
