using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FuneralClient.Utils.Other
{
    [System.Reflection.Obfuscation(Exclude = false, ApplyToMembers = true, Feature = "+ctrl flow;+rename;+constants;+anti debug;+anti ildasm;+ref proxy;+resources")]
    public class Config
    {

        public bool LogModeration = false;

        public bool AntiMod = true;

        public bool UncapFPS = false;

        public bool SpoofSteamID = false;

        public ConfigColor NotifyColor = new ConfigColor(255, 255, 0);

        public bool ShowFPS = true;

        public bool AvatarSearcher = false;

        public bool AutoFriend = false;

        public bool AntiCrash = false;

        public bool VRNotifications = false;
    }
    public class ConfigColor
    {
        public int R;
        public int G;
        public int B;

        public ConfigColor(int r, int g, int b)
        {
            this.R = r;
            this.G = g;
            this.B = b;
        }
    }
}
