using MInject;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Funeral_Loader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Funeral Loader";
            Console.WriteLine("Trying to find VRChat.exe");
            Console.WriteLine("Checking for Updates...");
            GetCurrentVersion();
           
            if (Process.GetProcessesByName("VRChat").Count() > 0)
            {
                Process targetProcess = Process.GetProcessesByName("VRChat")[0];
                MonoProcess monoProcess;

                try
                {
                    Console.WriteLine("Found VRChat.exe Injecting...");
                    if (MonoProcess.Attach(targetProcess, out monoProcess))
                    {
                        if (File.Exists($"FuneralClient-{new WebClient().DownloadString("http://yaekiths-projects.xyz/funeralver.txt")}.dll"))
                        {
                            Console.WriteLine("Attaching to VRChat's Handle..");
                            byte[] assemblyBytes = File.ReadAllBytes($"FuneralClient-{new WebClient().DownloadString("http://yaekiths-projects.xyz/funeralver.txt")}.dll");

                            IntPtr monoDomain = monoProcess.GetRootDomain();
                            monoProcess.ThreadAttach(monoDomain);
                            monoProcess.SecuritySetMode(0);


                            monoProcess.DisableAssemblyLoadCallback();

                            IntPtr rawAssemblyImage = monoProcess.ImageOpenFromDataFull(assemblyBytes);
                            IntPtr assemblyPointer = monoProcess.AssemblyLoadFromFull(rawAssemblyImage);
                            IntPtr assemblyImage = monoProcess.AssemblyGetImage(assemblyPointer);
                            IntPtr classPointer = monoProcess.ClassFromName(assemblyImage, "Funeral", "Loader");
                            IntPtr methodPointer = monoProcess.ClassGetMethodFromName(classPointer, "Init");


                            monoProcess.RuntimeInvoke(methodPointer);


                            monoProcess.EnableAssemblyLoadCallback();


                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[Funeral Client] Injected.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(3000);
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"[Funeral Client] FuneralClient-{new WebClient().DownloadString("http://yaekiths-projects.xyz/funeralver.txt")}.dll not found");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Failed to Inject. Details: " + e.ToString());
                }
            }
            else
            {
                Console.WriteLine("[Funeral Client] Failed to find VRChat.exe press any key to retry.");
                Console.ReadKey();
                Console.Clear();
                Main(null);
            }
            Console.ReadLine();
        }

        private static void GetCurrentVersion()
        {
            try
            {
                foreach (var file in Directory.GetFiles(Directory.GetCurrentDirectory()))
                {
                    if (Path.GetFileNameWithoutExtension(file) != null && Path.GetFileNameWithoutExtension(file).ToLower().Contains("funeralclient"))
                    {
                        var version = Path.GetFileNameWithoutExtension(file).Split('-')[1].ToString();

                        if (version != new WebClient().DownloadString("http://yaekiths-projects.xyz/funeralver.txt"))
                        {
                            File.Delete(file);
                            File.Delete("changelog.txt");
                            new WebClient().DownloadFile($"http://yaekiths-projects.xyz/FuneralClient-{new WebClient().DownloadString("http://yaekiths-projects.xyz/funeralver.txt")}.dll", $"FuneralClient-{new WebClient().DownloadString("http://yaekiths-projects.xyz/funeralver.txt")}.dll");
                            File.WriteAllText("changelog.txt", new WebClient().DownloadString("http://yaekiths-projects.xyz/changelog.txt"));

                            Console.WriteLine("Updated... continuing with injection...");
                        }
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("An error occurred while trying to get the latest update!");
                Console.WriteLine(e.ToString());
            }
          
        }
    }
}
