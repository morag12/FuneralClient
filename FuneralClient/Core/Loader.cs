using System;
using System.IO;
using System.Runtime.InteropServices;
using FuneralClient;
using FuneralClient.Utils.ConsoleUtil;
using FuneralClient.Utils.Other;
using UnityEngine;

namespace Funeral
{
    public class Loader
    {

        [DllImport("kernel32.dll")]
        private static extern int AllocConsole();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetWindowText(IntPtr hwnd, string lpString);

        public static GameObject Initialise { get; set; }

        public static void Init()
        {
            AllocConsole();
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput())
            {
                AutoFlush = true
            });
            Console.SetIn(new StreamReader(Console.OpenStandardInput()));
            Console.Clear();
            Console.Title = "Funeral Client by Yaekith (v4.1)";
            Console.ForegroundColor = ConsoleColor.White;
            Initialise = new GameObject();
            Initialise.AddComponent<FuneralClientCore>();
            UnityEngine.Object.DontDestroyOnLoad(Initialise);
        }
    }
}
