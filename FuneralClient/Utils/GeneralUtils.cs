using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Timers;
using BestHTTP.JSON;
using Funeral;
using FuneralClient.Utils.API;
using FuneralClient.Utils.ConsoleUtil;
using FuneralClient.Utils.Discord;
using FuneralClient.Utils.Exploits;
using FuneralClient.Utils.Extensions;
using FuneralClient.Utils.Hooker;
using FuneralClient.Utils.Other;
using FuneralClient.Utils.UI;
using FuneralClient.Utils.UI.VR;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using VRC;
using VRC.Core;
using VRC.Core.BestHTTP;
using VRC.UI;
using VRCSDK2;
using static FuneralClient.Utils.Other.UIAudio.AudioOverrider;
namespace FuneralClient.Utils
{
    public static class GeneralUtils
    {
        public static Collider[] Colliders { get; set; }

        public static Component component { get; set; }

        public static InputController input { get; set; }

        public static MainUIHelper UIHelper { get; set; }

        public static GameObject obj { get; set; }

        public static MonoBehaviour og = null;

        public static bool ShouldShowUI = false;

        public static VRC.Player Selected { get; set; }

        public static string UserTargeted { get; set; }

        public static string UsernameOfUser { get; set; }

        public static bool DeletePortals = false;

        public static bool HeadFlipper { get; set; }

        public static float RotationRangeX, RotationRangeY;

        public static bool SpinBot = false;

        public static Vector3 Vector { get; set; }

        public static VRC.Player Selected2 { get; set; }

        public static bool Flight = false;

        public static bool BoxESP = false;

        public static bool Menu = false;

        public static bool SelectedESP = false;

        public static bool DimensionalESP = false;

        public static bool DrawTracingLines = false;

        public static float FlightSpeed = 5f;

        public static float FlightRunSpeed = 50f;

        public static List<string> Deafened = new List<string>();

        public static Dictionary<string, DateTime> Disconnect_Queue = new Dictionary<string, DateTime>();

        public static bool DeafenNonFriends = false;

        public static bool ForceKickRequest = false;

        public static string ForceKickString = null;

        public static bool GlowESP = false;

        public static bool Searialise = true;

        public static List<string> BlacklistedShaders = new List<string>();

        public static List<string> DebugStrings = new List<string>();

        public static bool BoxAdmin = false;

        public static List<string> CachedFuneralUsers = new List<string>();

        public static bool WorldTriggers = false;

        public static bool RunAtExecution = false;


        public static void InformControls()
        {
            ConsoleUtils.RainbowText("LEFT ALT & Y = World Crasher\nLEFT ALT & C = Cancel World Crasher\nESCAPE & ENTER = Debugger UI\nLEFT SHIFT & M = Send Message to User\nLEFT SHIFT O = Send funeral client message\nRIGHT CONTROL & H = Send yourself home (For when users overrender the menu n stuff and you cant go home manually)\nLEFT ALT & F = Freeze yourself! (Stay stuck in one position to other players but yourself)");
        }
        private static System.Random random = new System.Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static void DeleteAllPortals()
        {
            Enumerable.Where<GameObject>(Resources.FindObjectsOfTypeAll<GameObject>(), (GameObject obj) => obj.name.Contains("Dynamic Clone")).ToList<GameObject>().ForEach(delegate (GameObject g)
            {
                UnityEngine.Object.Destroy(g);
            });
        }
        public static void DeleteOtherPortals()
        {
            Enumerable.Where<GameObject>(Resources.FindObjectsOfTypeAll<GameObject>(), (GameObject obj) => obj.name.Contains("Dynamic Clone")).ToList<GameObject>().ForEach(delegate (GameObject g)
            {
                if (g.GetComponentInParent<VRCPlayer>().ToVRC_Player().GetAPIUser().id != VRCPlayer.Instance.ToVRC_Player().GetAPIUser().id)
                {
                    UnityEngine.Object.Destroy(g);
                }
            });

            
        }

        public static void SaveAvatar(ApiAvatar avatar)
        {
            /*
            Console.WriteLine("Saving avatar...");
            ServicePointManager.ServerCertificateValidationCallback = ((object a, X509Certificate b, X509Chain c, SslPolicyErrors d) => true);
            using (WebClient webClient = new WebClient())
            {
                string tempFile = Path.GetTempPath() + Path.GetRandomFileName() + ".vrca";
                try
                {
                    var stringx = "Funeral_" + GeneralUtils.RandomString(30);
                    webClient.DownloadFile(avatar.assetUrl, tempFile);
                    Console.WriteLine("Decompressing...");
                    Decompression.AssetBundle assetBundle = new Decompression.AssetBundle(tempFile);
                    Console.WriteLine("Decompressed...");
                    ApiFile.Create(stringx, "application/x-avatar", ".vrca", delegate (ApiContainer s)
                    {
                        string assetUrl = string.Format("https://api.vrchat.cloud/api/1/file/{0}/1/file", s.Model.id);
                        ApiAvatar newAvatar = new ApiAvatar();
                        newAvatar.Init(null, APIUser.CurrentUser, avatar.name, avatar.imageUrl, assetUrl, avatar.description, "private", null, null);

                        newAvatar.Save(delegate (ApiContainer success)
                        {
                            Console.WriteLine("Changing blueprint id...");
                            assetBundle.SetAvatarId(success.Model.id);
                            Console.WriteLine("Recompressing...");
                            string temp;
                            assetBundle.SaveTo(tempFile);
                            Console.WriteLine("Uploading file...");
                            temp = tempFile;
                            string existingFileId = null;
                            string friendlyName = stringx;
                            if ((onSuccess = <> 9__5) == null)
                            {
                                onSuccess = (<> 9__5 = delegate (ApiFile assetFile, string bt)
                                {
                                    string text;
                                    AvatarUtils.DownloadVRCImage(avatar.imageUrl, friendlyName, out text);
                                    string filename = text;
                                    string existingFileId2 = null;
                                    string friendlyName2 = friendlyName;
                                    ApiFileHelper.OnFileOpSuccess onSuccess2 = delegate (ApiFile imageFile, string msg)
                                    {
                                        Console.WriteLine("Saving ApiAvatar...");
                                        newAvatar.imageUrl = imageFile.GetFileURL();
                                        newAvatar.assetUrl = assetFile.GetFileURL();
                                        newAvatar.Save(delegate (ApiContainer succ)
                                        {
                                            Console.WriteLine("Avatar saved!");
                                        }, delegate (ApiContainer er)
                                        {
                                            Console.WriteLine(er.Error);
                                        });
                                    };
                                    ApiFileHelper.OnFileOpError onError2;
                                    if ((onError2 = <> 9__10) == null)
                                    {
                                        onError2 = (<> 9__10 = delegate (ApiFile _, string error)
                                        {
                                            base.< SaveAvatar > g__OnError | 1(error);
                                        });
                                    }
                                    ApiFileHelper.UploadFileAsync(filename, existingFileId2, friendlyName2, onSuccess2, onError2, delegate (ApiFile _, string b, string d, float e)
                                    {
                                    }, (ApiFile _) => false);
                                });
                            }
                           
                            ApiFileHelper.UploadFileAsync(tempFile, existingFileId, friendlyName, onSuccess, onError, delegate (ApiFile az, string b, string d, float e)
                            {
                            }, (ApiFile _) => false);
                        }, null);
                    }, delegate (ApiContainer error)
                    {
                        ConsoleUtils.Error("Failed to save avatar! Try again.");
                    });
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error saving avatar: {0}", ex.Message);
                    File.Delete(tempFile);
                }
            }
            */
        }

        internal static void Debug(string v, string color = "cyan")
        {
           DebugStrings.Add($"<b><color={color}>{v}</color></b>");
        }

        public static void DeleteAllPortalsFromPlayer(VRC.Player who)
        {
            Enumerable.Where<GameObject>(Resources.FindObjectsOfTypeAll<GameObject>(), (GameObject obj) => obj.name.Contains("Dynamic Clone")).ToList<GameObject>().ForEach(delegate (GameObject g)
            {
                if (g.GetComponentInParent<VRCPlayer>().ToVRC_Player().GetAPIUser().id == who.GetAPIUser().id)
                {
                    UnityEngine.Object.Destroy(g);
                }
            });
        }

        public static void Swap(string avtrID)
        {
            VRC.Core.API.SendRequest("avatars/" + avtrID, HTTPMethods.Get, new ApiModelContainer<ApiAvatar>
            {
                OnSuccess = delegate (ApiContainer c)
                {
                    new PageAvatar
                    {
                        avatar = new SimpleAvatarPedestal
                        {
                            apiAvatar = new ApiAvatar
                            {
                                id = avtrID
                            }
                        }
                    }.ChangeToSelectedAvatar();
                }
            }, null, true, true, 3600f, 2, null);
        }
        public static void SendNotification(string targetUserId, ApiNotification.NotificationType nType, string message, Dictionary<string, object> details, Action<ApiNotification> successCallback, Action<string> errorCallback)
        {
            string value = nType.ToString().ToLower();
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary["type"] = value;
            dictionary["message"] = message;
            bool flag = details != null;
            if (flag)
            {
                dictionary["details"] = Json.Encode(details);
            }
            ApiModelContainer<ApiNotification> apiModelContainer = new ApiModelContainer<ApiNotification>();
            apiModelContainer.OnSuccess = delegate (ApiContainer c)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[Success] " + c.Text);
                Console.ForegroundColor = ConsoleColor.White;
            };
            apiModelContainer.OnError = delegate (ApiContainer c)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[Fail] " + c.Text);
                Console.ForegroundColor = ConsoleColor.White;
            };
            ApiModelContainer<ApiNotification> responseContainer = apiModelContainer;
            VRC.Core.API.SendPostRequest("user/" + targetUserId + "/notification", responseContainer, dictionary, null);
           
        }

        public static void AnnoyAll()
        {
            new Thread(delegate ()
            {
                foreach (VRC.Player plr in PlayerManager.GetAllPlayers())
                {
                    plr.ToCoffin(false).Annoy();
                }
            }).Start();
        }

        public static void Perish(VRC.Player player, bool NoUI = false)
        {
            GeneralUtils.Alert("Disabled", "This feature is currently disabled as it gets users banned too quickly and is patched.");
        }

        public static void Alert(string title, string description)
        {
            Resources.FindObjectsOfTypeAll<VRCUiPopupManager>()[0].ShowAlert(title, description);
        }

        public static void UncapFPS(int limit = 110)
        {
            bool uncapFPS = Configuration.config.UncapFPS;
            if (uncapFPS)
            {
                Application.targetFrameRate = limit;
                ConsoleUtils.Success("Uncapped VRChat's FPS.");
            }
        }

        public static void Noclip(bool value)
        {
            foreach (Collider co in GeneralUtils.Colliders)
            {
                bool flag = co != GeneralUtils.component;
                if (flag)
                {
                    co.enabled = !value;
                }
            }
        }

        public static void Setup(MonoBehaviour og = null)
        {
            obj = new GameObject();
            #region Colliders
            bool flag = UnityEngine.Object.FindObjectsOfType<Collider>().Count<Collider>() > 0;
            if (flag)
            {
                GeneralUtils.Colliders = UnityEngine.Object.FindObjectsOfType<Collider>();
            }
            bool flag2 = VRCPlayer.Instance.GetComponents(typeof(Collider)).Count<Component>() > 0;
            if (flag2)
            {
                GeneralUtils.component = VRCPlayer.Instance.GetComponents(typeof(Collider))[0];
            }
            #endregion
            #region Debugger UI
            obj.AddComponent<GuiConsole>();
            #endregion
            #region Patching and Controls
            InformControls();
            HookManager.Hook();
            PatchManager.ApplyPatches();
            #endregion
            #region VR UI Setup
            new ButtonMenu();
            #endregion
            #region KOS
            KOSService.LoadKOS();
            #endregion
            #region Dynamic Bone Touching
            obj.AddComponent<GlobalDynamicBones>(); //Thanks greengray
            #endregion

            #region Color Module
            obj.AddComponent<ColorModule>();
            #endregion

            #region Timers
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Elapsed += Check_Elapsed;
            timer.Interval = 1000;
            timer.AutoReset = true;
            timer.Enabled = true;

            new Thread(() =>
            {
                System.Timers.Timer timer2 = new System.Timers.Timer();
                timer2.Elapsed += PortalDisabler;
                timer2.Interval = 100;
                timer2.AutoReset = true;
                timer2.Enabled = true;
            }).Start();
            UnityEngine.Object.DontDestroyOnLoad(obj);
            #endregion
        }

        public static void Notify(string text)
        {
            var x = Configuration.config.NotifyColor;
            Resources.FindObjectsOfTypeAll<VRCUiManager>()[0].hudMessageText.color = new Color(x.R, x.G, x.B);

            Resources.FindObjectsOfTypeAll<VRCUiManager>()[0].QueueHudMessage(text);
        }
        public static void PortalDisabler(object sender, ElapsedEventArgs e)
        {
            if (GeneralUtils.DeletePortals)
            {
                if (Enumerable.Where<GameObject>(Resources.FindObjectsOfTypeAll<GameObject>(), (GameObject obj) => obj.name.Contains("Dynamic Clone")).ToList<GameObject>().Count() > 0)
                {
                    DeleteAllPortals();
                }
            }

        }

        public static void Check_Elapsed(object sender, ElapsedEventArgs e)
        {
            bool flag = UnityEngine.Object.FindObjectsOfType<Collider>().Count<Collider>() > 0;
            if (flag)
            {
                GeneralUtils.Colliders = UnityEngine.Object.FindObjectsOfType<Collider>();
            }
            bool flag2 = VRCPlayer.Instance.GetComponents(typeof(Collider)).Count<Component>() > 0;
            if (flag2)
            {
                GeneralUtils.component = VRCPlayer.Instance.GetComponents(typeof(Collider))[0];
            }

            Configuration.ReloadConfig(true);
        }

        public static bool IsNotPrivate(string ipAddress)
        {
            int[] array = (from s in ipAddress.Split(new string[]
            {
                "."
            }, StringSplitOptions.RemoveEmptyEntries)
                           select int.Parse(s)).ToArray<int>();
            return array[0] != 10 && (array[0] != 192 || array[1] != 168) && (array[0] != 172 || array[1] < 16 || array[1] > 31);
        }

        public static Vector3 Grav = Physics.gravity;
    }
}
