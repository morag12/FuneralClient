using FuneralClient.Utils.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuneralClient.Utils.ConsoleUtil
{
    [System.Reflection.Obfuscation(Exclude = false, ApplyToMembers = true, Feature = "+ctrl flow;+rename;+constants;+anti debug;+anti ildasm;+ref proxy;+resources")]

    public static class ConsoleUtils
    {
        public static void ColorOutput(ConsoleColor NewColor, ConsoleColor GoBack, string text)
        {
            Console.ForegroundColor = NewColor;
            Console.WriteLine($"[Funeral Labor] [ver {Server.ClientVersion}] {text}");
            Console.ForegroundColor = GoBack;
        }

        public static void Error(string text, string Debug = null)
        {
            if (Debug != null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[Funeral] [Error] {text} || Debug Info: {Debug}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[Funeral] [Error] {text}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public static void Success(string text)
        {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[Funeral] [Success] {text}");
                Console.ForegroundColor = ConsoleColor.White;
        }
        public static void RainbowText(string text)
        {
            var colors = new List<ConsoleColor>()
            {
                ConsoleColor.Red,
                ConsoleColor.Green,
                ConsoleColor.Blue,
                ConsoleColor.Green,
                ConsoleColor.Cyan,
                ConsoleColor.Magenta
            };

            foreach(char c in text)
            {
                Console.ForegroundColor = colors[new Random().Next(1, colors.Count())];
                Console.Write(c);
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine("\n");
        }

        public static void Info(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[Info] " + text);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
