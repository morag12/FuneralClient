using FuneralClient.Utils.ConsoleUtil;
using FuneralClient.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using UnityEngine;
using VRC.Core;
using VRC;
using VRC.UI;
using static VRC.Core.API;
using FuneralClient.Utils.API;
using System.Threading;

namespace FuneralClient.Utils.Other
{
    [System.Reflection.Obfuscation(Exclude = false, ApplyToMembers = true, Feature = "+ctrl flow;+rename;+constants;+anti debug;+anti ildasm;+ref proxy;+resources")]
    public class CoffinUser
    {
        public VRC.Player Plr { get; set; }

        public string Username { get; set; }

        public string UserID { get; set; }

        public string AvtrID { get; set; }

        public ulong SteamID { get; set; }

        public ApiAvatar Avatar { get; set; }

        public IPAddress IP { get; set; }

        public CoffinUser(VRC.Player player, bool LogSteamStuff = true)
        {
            Plr = player;
            Username = player.GetUsername();
            UserID = player.GetUserID();
            AvtrID = player.GetAvatarID();
            Avatar = player.ToVRCPlayer().GetAvatar();
            if (LogSteamStuff)
            {
                IP = player.GetIP();
                SteamID = player.GetSteamID();
            }
        }
        public void BecomeAvatar()
        {
            if (Avatar.releaseStatus != "public")
            {
                GeneralUtils.Swap(AvtrID);
                ConsoleUtils.Success($"Successfully swapped into {Username}'s Avatar!");
            }
            else
            {
                ConsoleUtils.Error($"Couldn't swap into {Username}'s Avatar! Their Avatar isn't public!");
            }
        }
        public void Logout()
        {
            if (this.UserID == PlayerManager.GetCurrentPlayer().GetUserID())
            {
                APIUser.Logout();
            }
            else
            {
                    for (var i = 0; i < 9999; i++)
                    {
                        var steamID = this.SteamID == 0 ? 0 : this.SteamID;
                        //SteamNetworkingAPI.BLIOJBDGJKA.IJCOPIHGDJB(new byte[20000], new byte[2000].Length, steamID);
                    }
            }
        }
        public void BecomeAvatar(string AvtrID)
        {
            ApiAvatar ApiAvi = new ApiAvatar();
            ApiAvi.id = AvtrID;

            if (ApiAvi.releaseStatus != "public")
            {
                GeneralUtils.Swap(AvtrID);
                ConsoleUtils.Success($"Successfully swapped into AvtrID: {AvtrID}");
            }
            else
            {
                ConsoleUtils.Error($"Couldn't swap into {ApiAvi.authorName}'s Avatar ({ApiAvi.name})! Their Avatar isn't public!");
            }
        }
        public void UploadAviDetails()
        {
    
        }
        public void SaveAvatar()
        {
            /*
            ServicePointManager.ServerCertificateValidationCallback = ((object a, X509Certificate b, X509Chain c, SslPolicyErrors d) => true);
            using (WebClient webClient = new WebClient())
            {
                string text = Guid.NewGuid().ToString();
                string text2 = "Avatar-" + Avatar.name + "-Asset-bundle-5.6.3p1_";
                string str = ".file_" + text + ".1.vrca";
                text2 = text2.Remove(32);
                if (!Directory.Exists(@"Coffin\Avatars")) Directory.CreateDirectory(@"Coffin\Avatars");
                string text3 = "Coffin\\Avatars\\" + text2 + str;
                string[] downloadThis = File.ReadAllLines(@"Coffin\Avatars\UploadAvatar.txt");
                try
                {
                    webClient.DownloadFile(downloadThis[0], text3);
                    ApiFileHelper.UploadFileAsync(text3, null, text, delegate (ApiFile apiFile, string message)
                    {
                        apiFile.Get(delegate
                        {
                            ApiAvatar apiAvatar = new ApiAvatar();
                            apiAvatar.Init(downloadThis[1], APIUser.CurrentUser, Avatar.name, downloadThis[2], apiFile.GetFileURL(), "my disappointment is immeasurable and my day is ruined", "public", null, null);
                            apiAvatar.Post(delegate (ApiContainer c)
                            {
                                ConsoleUtils.Success($"Saved ${Username}'s Avatar successfully.\n=======================Avatar Information:=======================\nAvatar Name: {Avatar.name}\nAvatarID: {Avatar.id}\nAvatar Author: ({Avatar.authorName}) {Avatar.authorId}\nAssetURL: {Avatar.assetUrl}\n=======================");
                                Debug.Log(((ApiAvatar)c.Model).id);
                            }, delegate (ApiContainer c)
                            {
                                Debug.Log(string.Format("Error saving avatar: {0}. {1}. | ", c.Error + " | ", c.Text));
                            }, null);
                        }, delegate (ApiContainer f)
                        {
                            Debug.Log(string.Format("Error saving avatar: {0}. {1}. | ", f.Error + " | ", f.Text));
                        }, null, false);
                    }, delegate (ApiFile apiFile, string error)
                    {
                        Debug.Log(string.Format("Error saving avatar: {0} | ", error));
                    }, delegate (ApiFile p0, string p1, string p2, float p3)
        
                        {
                    }, (ApiFile _) => false);
                }
                catch (Exception ex)
                {
                    Debug.Log(string.Format("Error saving avatar: {0} | ", ex.Message));
                }
            }
            */
        }

        public void Annoy()
        {
            GeneralUtils.SendNotification(Plr.GetAPIUser().id, ApiNotification.NotificationType.Invite, "wha memes?", null, null, null);
            ConsoleUtils.Success($"Successfully annoyed User: {Plr.GetAPIUser().displayName}.");
        }
    }
}
