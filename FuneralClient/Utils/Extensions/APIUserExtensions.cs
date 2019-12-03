using FuneralClient.Utils.API;
using FuneralClient.Utils.ConsoleUtil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using VRC;
using VRC.Core;
using static Analytics;

namespace FuneralClient.Utils.Extensions
{
    [System.Reflection.Obfuscation(Exclude = false, ApplyToMembers = true, Feature = "+ctrl flow;+rename;+constants;+anti debug;+anti ildasm;+ref proxy;+resources")]
    public static class APIUserExtensions
    {
        public static void Friend(this Player player)
        {
            var UserID = player.GetAPIUser().id;
            Resources.FindObjectsOfTypeAll<ModerationManager>()[0].UnmuteUser(UserID);
            Resources.FindObjectsOfTypeAll<ModerationManager>()[0].UnblockUser(UserID);
            Resources.FindObjectsOfTypeAll<NotificationManager>()[0].SendNotification(UserID, "friendRequest", string.Empty, null);

            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary["targetUserId"] = UserID;
            Analytics.Send(EFIMMFOLPIP.Social_SendFriendRequest, dictionary, null);
        }
    }
}
