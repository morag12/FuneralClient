using Funeral;
using FuneralClient.Utils;
using FuneralClient.Utils.API;
using FuneralClient.Utils.ConsoleUtil;
using FuneralClient.Utils.Extensions;
using FuneralClient.Utils.Other;
using Photon.Pun;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using Transmtn.DTO.Notifications;
using UnityEngine;
using UnityEngine.Networking;
using VRC;
using VRCSDK2;
using static VRCSDK2.VRC_EventHandler;

namespace FuneralClient
{
    public class InputController : MonoBehaviour
    {

        private static List<string> DebugLogs = new List<string>();

        private static List<string> Cached = new List<string>();
        public void Update()
        {
            #region Debugger UI
            if (Input.GetKey(KeyCode.Escape) && Input.GetKeyDown(KeyCode.Return))
            {
                GuiConsole.toggleGuiConsole = !GuiConsole.toggleGuiConsole;
                string Notify = GuiConsole.toggleGuiConsole ? "Debugger UI Enabled." : "Debugger UI Disabled.";
                ConsoleUtils.Info(Notify);
            }
            #endregion

            #region Keybinds
            if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKeyDown(KeyCode.Y))
            {
                GeneralUtils.Swap("avtr_56674e13-8e5f-4eae-be53-21980ec4e965");
            }

            if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKeyDown(KeyCode.C))
            {
                GeneralUtils.Swap("avtr_c38a1615-5bf5-42b4-84eb-a8b6c37cbd11");
            }

            if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.F))
            {
                GeneralUtils.Flight = !GeneralUtils.Flight;
                Physics.gravity = GeneralUtils.Flight ? Vector3.zero : GeneralUtils.Grav;
            }
            #endregion

            #region HeadFlipper
            if (GeneralUtils.HeadFlipper)
            {
              VRCVrCamera.GetInstance().GetComponentInChildren<NeckMouseRotator>().rotationRange.x = float.MinValue;
              VRCVrCamera.GetInstance().GetComponentInChildren<NeckMouseRotator>().rotationRange.z = float.MaxValue;
            }
            #endregion

            #region SpinBot
            if (GeneralUtils.SpinBot)
            {
                //VRCPlayer.Instance.gameObject.transform.position = GeneralUtils.Vector;
                VRCPlayer.Instance.gameObject.transform.Rotate(0f, 20f, 0f);
            }
            #endregion

            #region Send Messages
            if (Event.current.shift && Input.GetKeyDown(KeyCode.F))
            {
                if (!VRCTrackingManager.IsInVRMode())
                {
                    //Funeral Message Sending
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Enter message:");
                    var msg = Console.ReadLine();
                    Console.WriteLine("Enter Receiver User ID:");
                    string userid = Console.ReadLine();
                    var author = VRCPlayer.Instance.LIPBCOFIIHI.GetAPIUser().displayName;
                    var authorUserId = VRCPlayer.Instance.LIPBCOFIIHI.GetAPIUser().id;
                    var date = DateTime.UtcNow.Date.ToShortDateString();
                    base.StartCoroutine(SendFMessage(author, authorUserId, msg, userid, date));
                }
            }
            #endregion

            #region Send Normal Messages
            if (Event.current.shift && Input.GetKeyDown(KeyCode.M))
            {
                if (!VRCTrackingManager.IsInVRMode())
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Enter message:");
                    var message = Console.ReadLine();
                    Console.WriteLine("Enter ReceiverUserID: ");
                    var user = Console.ReadLine();
                    Console.WriteLine("Sending message...");
                    NotificationDetails notificationDetails = new NotificationDetails();
                    notificationDetails["worldId"] = RoomManager.currentRoom.id + ":" + RoomManagerBase.currentRoom.currentInstanceIdWithTags;
                    notificationDetails["worldName"] = $"\n{VRCPlayer.Instance.LIPBCOFIIHI.GetAPIUser().displayName} said:\n" + message;
                    Resources.FindObjectsOfTypeAll<NotificationManager>()[0].SendNotification(user, "invite", string.Empty, notificationDetails);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Message sent.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            #endregion

            #region Force Mute
            PlayerManager.GetAllPlayers().ToList().ForEach(X =>
            {
                if (GeneralUtils.Deafened.Contains(X.GetAPIUser().id))
                {
                    X.vrcPlayer.canHear = false;
                }
                else if (GeneralUtils.DeafenNonFriends)
                {
                    if (!X.IsFriended())
                    {
                        X.vrcPlayer.canHear = false;
                    }
                }
                else
                {
                    X.vrcPlayer.canHear = true;
                }
            });
            #endregion

            #region ForceKick Check
            if (GeneralUtils.ForceKickRequest)
            {
                if (GeneralUtils.ForceKickString != null)
                {
                    var user = GeneralUtils.ForceKickString.ToString().Split(' ')[0];
                    var world = GeneralUtils.ForceKickString.ToString().Split(' ')[1];
                    base.StartCoroutine(SendForceKickRequest(user, world));
                    GeneralUtils.ForceKickRequest = false;
                    GeneralUtils.ForceKickString = null;
                }
            }
            #endregion

            #region SpinBot Disabler
            if (Event.current.alt && Input.GetKeyDown(KeyCode.S))
            {
                GeneralUtils.SpinBot = !GeneralUtils.SpinBot;
            }
            #endregion

            #region Freeze Keybind
            if (Event.current.alt && Input.GetKey(KeyCode.F))
            {
                GeneralUtils.Searialise = !GeneralUtils.Searialise;
            }
            #endregion
        }

      

        public IEnumerator SendForceKickRequest(string userid, string worldid)
        {
            UnityWebRequest www = UnityWebRequest.Get($"https://yaekiths-projects.xyz/api/perish.php?apiKey=IqAIFFmJmhuESUDz0YOA&user={userid}&world={worldid}");
            yield return www.SendWebRequest();
            if (www.downloadHandler.text != "0")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Request to ForceKick User has been sent.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ForceKick failed to be sent. Contact Yaekith for more information.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public IEnumerator SendFMessage(string author, string authorUserId, string msg, string userid, string date)
        {
            UnityWebRequest www = UnityWebRequest.Get($"https://yaekiths-projects.xyz/submitmessage.php?ausername={author}&authoruserId={authorUserId}&message={msg}&username=Blank&receiverId={userid}&date={date}");
            yield return www.SendWebRequest();
            if (www.downloadHandler.text != "0")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Message sent to funeral client user.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Message failed to be sent. Contact Yaekith for more information.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void Start()
        {
            GeneralUtils.RotationRangeX = VRCVrCamera.GetInstance().GetComponentInChildren<NeckMouseRotator>().rotationRange.x;
            GeneralUtils.RotationRangeX = VRCVrCamera.GetInstance().GetComponentInChildren<NeckMouseRotator>().rotationRange.x;
            GeneralUtils.Vector = VRCPlayer.Instance.gameObject.transform.position;

            new Thread(() =>
            {
                GeneralUtils.CachedFuneralUsers = FetchUsersOnline();

                System.Timers.Timer timer = new System.Timers.Timer(60000);
                timer.Elapsed += Timer_Elapsed;
                timer.AutoReset = true;
                timer.Enabled = true;
            })
            { IsBackground = true }.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            base.StartCoroutine(FetchUsers());
        }

        private List<string> FetchUsersOnline()
        {
            base.StartCoroutine(FetchUsers());

            return Cached;
        }

        private IEnumerator FetchUsers()
        {
            UnityWebRequest www = UnityWebRequest.Get($"https://yaekiths-projects.xyz/api/isonline.php");
            yield return www.SendWebRequest();
            if (www.downloadHandler.text != "0")
            {
                var users = www.downloadHandler.text.Split(' ');
                
                foreach(var user in users)
                {
                    Cached.Add(user);
                    GeneralUtils.CachedFuneralUsers.Add(user);
                }

            }
        }
    }
}