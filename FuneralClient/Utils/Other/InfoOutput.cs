using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace FuneralClient.Utils.Other
{
    public class InfoOutput
    {
        public IPAddress IP { get; set; }
        public string Username { get; set; }
        public string AvatarURL { get; set; }
        public string UserID { get; set; }
        public ulong SteamID { get; set; }

        public InfoOutput(IPAddress ip, string username, string avatar, string userid, ulong SteamID)
        {
            IP = ip;
            Username = username;
            AvatarURL = avatar;
            UserID = userid;
            this.SteamID = SteamID;
        }
    }
}
