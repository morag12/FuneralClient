using ExitGames.Client.Photon;
using FuneralClient.Utils.API;
using FuneralClient.Utils.ConsoleUtil;
using FuneralClient.Utils.Other;
using Steamworks2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using UnityEngine;
using VRC;
using VRC.Core;

namespace FuneralClient.Utils.Extensions
{
 
    
    public static class UserExtensions
    {
        public static MethodInfo GetAPIUser2, GetAvatar2, GetSelectedPlayer2, GetSteamID2, PhotonPlayer2;

        static UserExtensions()
        {
            /*
            GetAPIUser2 = typeof(VRC.Player).GetProperties().FirstOrDefault(z => z.Name.ToLower() == "get_user").GetGetMethod();
            GetAvatar2 = typeof(VRCPlayer).GetProperties().FirstOrDefault(x => x.Name.ToLower() == "get_avatarmodel").GetGetMethod();
            GetSelectedPlayer2 = typeof(QuickMenu).GetProperties().FirstOrDefault(z => z.Name.ToLower() == "get_selecteduser").GetGetMethod();
            GetSteamID2 = typeof(VRC.Player).GetProperties().FirstOrDefault(z => z.Name.ToLower() == "get_steamuseridulong").GetGetMethod();
            PhotonPlayer2 = typeof(VRC.Player).GetProperties().FirstOrDefault(f => f.Name.ToLower() == "get_photonplayer").GetGetMethod();
            */
        }
        public static APIUser GetAPIUser(this VRC.Player player)
        {
            return (APIUser)player.AIJMEEHEKCI;
        }

        public static ApiAvatar GetAvatar(this VRCPlayer player)
        {
            return (ApiAvatar)player.JNPEIKGHBEC;
        }

        public static string GetUsername(this VRC.Player player)
        {
            return GetAPIUser(player).displayName;
        }

        public static string GetUserID(this VRC.Player player)
        {
            return GetAPIUser(player).id;
        }

        public static string GetAvatarID(this VRC.Player player)
        {
            return GetAPIUser(player).avatarId;
        }
        public static string GetAvatarURL(this VRC.Player player)
        {
            return player.ToVRCPlayer().GetAvatar().assetUrl;
        }
        public static VRC.Player GetSelectedPlayer(this QuickMenu ins)
        {
            //var x = (APIUser)SelectedUser.Invoke(ins, null);
            var x = (APIUser)ins.GGMMADBDFMP;
            return x.ToVRCPlayer();
        }

        public static VRC.Player ToVRCPlayer(this APIUser user)
        {
            return (VRC.Player)PlayerManager.GetPlayer(user.id);
        }

        public static ulong GetSteamID(this VRC.Player player)
        {
            //Second on the right is player's photon class hash table, you'll see it when vrchat updates.
            ulong steamID = player.ToVRCPlayer().DBHGDAHAJIP;
            var photonplr = player.BILIBAMEKKJ;
            var hashtable = (Hashtable)photonplr.BDDEGEDBBLE;
            ulong steamID2 = ulong.Parse(hashtable["steamUserID"].ToString());
            return steamID > 10000000000000000 ? steamID : steamID2;
        }
        public static OKHDIEKIBPI GetPhotonPlayer(this VRC.Player player)
        {
            return player.BILIBAMEKKJ;
        }
        public static VRCPlayer ToVRCPlayer(this VRC.Player player)
        {
            return player.vrcPlayer;
        }

        internal static IPAddress ToIPAddress(this uint ip)
        {
            return new IPAddress(new byte[]
            {
                (byte)(ip >> 24 & 0xff),
                (byte)(ip >> 16 & 0xff),
                (byte)(ip >> 8 & 0xff),
                (byte)(ip & 0xff)
            });
        }

      
        public static IPAddress GetIP(this VRC.Player player)
        {
            try
            {
                P2PSessionState_t _p2pSessionState;
                if (SteamNetworking.GetP2PSessionState(new Steamworks2.CSteamID(player.GetSteamID()), out _p2pSessionState) && _p2pSessionState.m_nRemoteIP != 0u && GeneralUtils.IsNotPrivate(_p2pSessionState.m_nRemoteIP.ToIPAddress().ToString()) && _p2pSessionState.m_nRemoteIP.ToIPAddress() != null)
                    return _p2pSessionState.m_nRemoteIP.ToIPAddress();
                else
                {
                    if (player.GetSteamID() > 10000000000000000)
                    {
                        if (PEBFMFGNNNE.KBHJDGDAEGK(new Steamworks.CSteamID(player.GetSteamID()), out FGEAPNMLDBB epic))
                        {
                            return epic.MACLMIEOBKD.ToIPAddress();
                        }
                    }
                    else
                    {
                        ConsoleUtils.Info($"{player.GetAPIUser().displayName} is using a SteamID Spoofer. Their SteamID was {player.GetSteamID()}");
                    }
                    return null;
                }
            }
            catch (Exception e)
            {
                if (PEBFMFGNNNE.KBHJDGDAEGK(new Steamworks.CSteamID(player.GetSteamID()), out FGEAPNMLDBB epic))
                {
                    return epic.MACLMIEOBKD.ToIPAddress();
                }
                ConsoleUtils.Error($"Couldn't get {player.GetAPIUser().displayName}'s IP. Details: " + e.ToString());
                return null;
            }
        }

        public static bool IsFriended(this Player player)
        {
            return APIUser.IsFriendsWith(player.GetAPIUser().id);
        }

        public static VRC.Player ToVRC_Player(this VRCPlayer player)
        {
            return (VRC.Player)player.LIPBCOFIIHI;
        }

        public static CoffinUser ToCoffin(this VRC.Player player, bool LogInfo = false)
        {
            return new CoffinUser(player, LogInfo);
        }


        public static void Attack(this VRC.Player player)
        {
            ExploitAPI.CalledInAttacks.Add(new Exploits.Attack(player.ToCoffin(), PlayerManager.GetCurrentPlayer().ToCoffin()));
        }
    }
}
