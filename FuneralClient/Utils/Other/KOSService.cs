using FuneralClient.Utils.ConsoleUtil;
using FuneralClient.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using VRC;
using FuneralClient.Utils.API;

namespace FuneralClient.Utils.Other
{
    public static class KOSService
    {
        public static List<string> UserKOS = new List<string>();

        public static void SaveKOS()
        {
            File.WriteAllLines(@"Coffin\\KOS.txt", UserKOS.ToArray());
        }

        public static void LoadKOS()
        {
            if (!File.Exists("Coffin\\KOS.txt"))
            {
                var defaultKOS = new List<string>()
                {
                    "usr_8c701e87-7c2c-4c9c-b455-224e9a0ecf0c",
                    "usr_c71cdbf2-f0a7-4f53-a7da-4027165491bd",
                    "usr_9e642e0f-1b7b-4e4b-ada7-94920c51eb2d"
                };

                File.WriteAllLines(@"Coffin\\KOS.txt", defaultKOS.ToArray());
            }


            UserKOS = File.ReadAllLines("Coffin\\KOS.txt").ToList();
        }
    }
}
