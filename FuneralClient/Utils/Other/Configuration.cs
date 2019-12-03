using FuneralClient.Utils.ConsoleUtil;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FuneralClient.Utils.Other
{
    [System.Reflection.Obfuscation(Exclude = false, ApplyToMembers = true, Feature = "+ctrl flow;+rename;+constants;+anti debug;+anti ildasm;+ref proxy;+resources")]
    public static class Configuration
    {
        public static Config config { get; set; }

        public static void ReloadConfig(bool silent = false)
        {
            if (!Directory.Exists("Coffin"))
            {
                Directory.CreateDirectory("Coffin");
            }

            if (!File.Exists(@"Coffin\Config.json"))
            {
                File.WriteAllText(@"Coffin\Config.json", JsonConvert.SerializeObject(new Config()));
            }

            config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(@"Coffin\Config.json"));

            if (!silent)
            {
                ConsoleUtils.ColorOutput(ConsoleColor.Yellow, ConsoleColor.White, "Config has (Re)loaded.");
            }
        }
        public static void SaveConfig()
        {
            File.WriteAllText(@"Coffin\Config.json", JsonConvert.SerializeObject(config));
        }
    }
}
