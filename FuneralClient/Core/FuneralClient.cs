using FuneralClient.Utils.ConsoleUtil;
using FuneralClient.Utils.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEngine.Networking;
using VRCSDK2;
using VRC.Core;
using VRC;
using UnityEngine;
using FuneralClient.Utils;
using BestHTTP;
using VRC.UI;
using FuneralClient.Utils.UI;
using FuneralClient.Utils.API;
using System.Diagnostics;
using Photon.Pun;
using FuneralClient.Utils.Extensions;
using System.Threading;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using Transmtn.DTO.Notifications;
using UnityEngine.UI;
using static FuneralClient.Utils.Other.UIAudio.AudioOverrider;
using System.Collections;
using Funeral;
using FuneralClient.Utils.UI.VR;

namespace FuneralClient
{
    //Made by Yaekith. Version: 4.1, don't copy & paste, kthnx.
    public class FuneralClientCore : MonoBehaviour
    {

        public void Update()
        {
            #region UI Checking
            if (Resources.FindObjectsOfTypeAll<GuiConsole>().Count() == 0)
            {
                if (GuiConsole.toggleGuiConsole)
                {
                    GeneralUtils.obj.AddComponent<GuiConsole>();
                }
            }
            #endregion

            #region Flight
            if (GeneralUtils.Flight)
            {
                //Thanks Null!
                GameObject gameObject = GameObject.Find("Camera (eye)");
                var currentSpeed = (Input.GetKey(KeyCode.LeftShift) ? GeneralUtils.FlightRunSpeed : GeneralUtils.FlightSpeed);

                if (Input.GetKey(KeyCode.W))
                {
                    VRCPlayer.Instance.transform.position += gameObject.transform.forward * currentSpeed * Time.deltaTime;
                }
                if (Input.GetKey(KeyCode.A))
                {
                    VRCPlayer.Instance.transform.position += VRCPlayer.Instance.transform.right * -1f * currentSpeed * Time.deltaTime;
                }
                if (Input.GetKey(KeyCode.S))
                {
                    VRCPlayer.Instance.transform.position += gameObject.transform.forward * -1f * currentSpeed * Time.deltaTime;
                }
                if (Input.GetKey(KeyCode.D))
                {
                    VRCPlayer.Instance.transform.position += VRCPlayer.Instance.transform.right * currentSpeed * Time.deltaTime;
                }
                if (Input.GetKey(KeyCode.Space))
                {
                    VRCPlayer.Instance.transform.position += VRCPlayer.Instance.transform.up * currentSpeed * Time.deltaTime;
                }
                if (Math.Abs(Input.GetAxis("Joy1 Axis 2")) > 0f)
                {
                    VRCPlayer.Instance.transform.position += gameObject.transform.forward * currentSpeed * Time.deltaTime * (Input.GetAxis("Joy1 Axis 2") * -1f);
                }
                if (Math.Abs(Input.GetAxis("Joy1 Axis 1")) > 0f)
                {
                    VRCPlayer.Instance.transform.position += gameObject.transform.right * currentSpeed * Time.deltaTime * Input.GetAxis("Joy1 Axis 1");
                }
                VRCPlayer.Instance.AlignTrackingToPlayer();
            }
            #endregion

            #region Safe GoHome
            if (Input.GetKey(KeyCode.RightControl) && Input.GetKeyDown(KeyCode.H))
            {
                Resources.FindObjectsOfTypeAll<VRCFlowManager>()[0].GoHome();
            }
            #endregion

            #region Social Buttons
            var buttons = UnityEngine.Object.FindObjectsOfType<VRCUiButton>();
            foreach (var button in buttons)
            {
                if (button.GetComponentInChildren<Text>().text.ToLower().Contains("vote"))
                {
                    if (UnityEngine.Object.FindObjectsOfType<GameObject>().Where(x => x.name.ToLower() == "add to kos").Count() == 0)
                    {
                        var template = button;
                        var newbutton = UnityEngine.Object.Instantiate<GameObject>(template.gameObject, button.transform.parent);
                        setLocation(0, 150, newbutton);
                        newbutton.name = "Add to KOS";
                        newbutton.GetComponentInChildren<Text>().text = "Add to KOS";
                        newbutton.GetComponentInChildren<Button>().onClick = new Button.ButtonClickedEvent();
                        newbutton.GetComponentInChildren<Button>().onClick.AddListener(delegate ()
                        {
                            KOSService.UserKOS.Add(_pageUserInfo.user.id);
                            KOSService.SaveKOS();
                            GeneralUtils.Debug($"{_pageUserInfo.user.displayName} has been added to KOS.");
                        });
                        newbutton.GetComponentInChildren<Button>().interactable = true;
                        newbutton.GetComponentInChildren<UnityEngine.UI.Image>().color = Color.white;
                        newbutton.GetComponentInChildren<Text>().color = Color.red;
                        newbutton.SetActive(true);
                    }
                }
            }
            #endregion

            #region Room Lockdown Exploit
            if (Event.current.alt && Input.GetKeyDown(KeyCode.L))
            {
                Console.WriteLine("Locking Room");
                RoomManager.SetLockdown(true);
                Console.WriteLine("Locked Room.");
            }
            #endregion
        }
        public static IEnumerator SendForceKick(string user, string worldIdinstance)
        {

            UnityWebRequest www = UnityWebRequest.Get($"https://yaekiths-projects.xyz/api/perish.php?apiKey=IqAIFFmJmhuESUDz0YOA&user={user}&world={worldIdinstance}");
            yield return www.SendWebRequest();
            if (www.downloadHandler.text == "1")
            {
                ConsoleUtils.Success("Sent forcekick request.");
            }
            else
            {
                ConsoleUtils.Error(www.downloadHandler.text);
            }

           
        }
        public void setLocation(int X, int Y, GameObject button)
        {
            button.GetComponent<RectTransform>().anchoredPosition += new Vector2(X, Y);
            button.GetComponent<Button>().name = button.name;
        }
        public PageUserInfo _pageUserInfo = Resources.FindObjectsOfTypeAll<VRCUiManager>()[0].GetPage("UserInterface/MenuContent/Screens/UserInfo") as PageUserInfo;

      

        public void OnGUI()
        {
            var style = new GUIStyle();
            style.normal.textColor = Configuration.config.NotifyColor.ToColor();
            var fps = VRC.FpsCounter.MFAKDKEOFDN.ELHKMPHFKHL;
            if (Configuration.config.ShowFPS)
            {
                GUI.Label(new Rect(100, 100, Screen.width, 100), $"FPS: {fps}", style);
            }
        }
        public IEnumerator PGJyl8etoP(string UserID)
        {
            var userid = UserID;

            UnityWebRequest req = UnityWebRequest.Get($"https://yaekiths-projects.xyz/checkauth.php?userid={userid}");
            yield return req.SendWebRequest();

            try
            {
                if (req.downloadHandler.text != "0")
                {
                    SetupClient();
                }
                else
                {
                    ConsoleUtils.Error("Not Authenticated.");
                    Thread.Sleep(5000);
                    Environment.Exit(0);
                }
            }
            catch(Exception)
            {
                ConsoleUtils.Error("A failure occurred while checking the response from the server! As a safety precaution, we have blocked this authentication request.");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
        }
        public void SetupClient()
        {

            #region Setup
            new Thread(() =>
            {
                System.Timers.Timer checkTimer = new System.Timers.Timer(120000);
                checkTimer.Elapsed += CheckTimer_Elapsed;
                checkTimer.AutoReset = true;
                checkTimer.Enabled = true;
            }).Start();
            #endregion
            #region Msg Checking
            new Thread(() =>
            {
                System.Timers.Timer MsgTimer = new System.Timers.Timer(60000);
                MsgTimer.Elapsed += MsgTimer_Elapsed;
                MsgTimer.AutoReset = true;
                MsgTimer.Enabled = true;
            }).Start();

            #endregion
            #region UI Loading
            UIHelper.SetupUIButtons(this);
            #endregion
            #region Config Loading
            Configuration.ReloadConfig();
            #endregion
            #region ESP
            gameObject.AddComponent<BoxESP>();
            #endregion
            #region GeneralSetup
            GeneralUtils.input = gameObject.AddComponent<InputController>();
            GeneralUtils.Setup(this);
            ConsoleUtils.ColorOutput(ConsoleColor.Yellow, ConsoleColor.White, "Funeral Client has Loaded. Made with Love by Yaekith.");
            GeneralUtils.Debug("Loaded Client");
            #endregion
        }

        public IEnumerator tIGjAW5hN7(string UserID)
        {
            var userid = UserID;

            UnityWebRequest req = UnityWebRequest.Get($"https://yaekiths-projects.xyz/checkauth.php?userid={userid}");
            yield return req.SendWebRequest();
            
            try
            {
                if (req.downloadHandler.text == "0")
                {
                    ConsoleUtils.Error("Not Authenticated.");
                    Thread.Sleep(5000);
                    Environment.Exit(0);
                }

            }
            catch (Exception)
            {
                ConsoleUtils.Error("A failure occurred while checking the response from the server! As a safety precaution, we have blocked this authentication request.");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }


        }

        public void Start()
        {

            try
            {
                base.StartCoroutine(PGJyl8etoP(VRCPlayer.Instance.LIPBCOFIIHI.AIJMEEHEKCI.id));
            }
            catch (Exception e)
            {
                if (e is NullReferenceException)
                {
                    ConsoleUtils.Error("An error occurred. Send this to Yaekith: " + e.ToString());
                }
                else
                {
                    ConsoleUtils.Error("A failure occurred while checking the response from the server! As a safety precaution, we have blocked this authentication request.");
                    ConsoleUtils.Error("Send this to Yaekith: " + e.ToString());
                    Thread.Sleep(5000);
                    Environment.Exit(0);
                }
            }

        }
        private void MsgTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            base.StartCoroutine(GetMessages(VRCPlayer.Instance.LIPBCOFIIHI.AIJMEEHEKCI.id));
        }

        private void CheckTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
   
            var userid = VRCPlayer.Instance.LIPBCOFIIHI.AIJMEEHEKCI.id;

            base.StartCoroutine(tIGjAW5hN7(userid));

        }

        public IEnumerator GetMessages(string UseriD)
        {
            var userID = UseriD;
            var date = DateTime.UtcNow.Date.ToShortDateString();
            //usr_8bbf168d-a5cc-47e3-b561-cae04c061d91
            UnityWebRequest req1 = UnityWebRequest.Get($"https://yaekiths-projects.xyz/checkmessages.php?userId={userID}&date={date}");
            yield return req1.SendWebRequest();

            if (req1.downloadHandler.text != "0")
            {
                var response = UnityWebRequest.Get($"https://yaekiths-projects.xyz/checkmessages.php?userId={userID}&date={date}");
                yield return response.SendWebRequest();

                var messages = response.downloadHandler.text.ToString().ToLower().Split(' ');


                    var author = UnityWebRequest.Get($"https://yaekiths-projects.xyz/getmessageinfo.php?message={response}");
                    yield return author.SendWebRequest();

                    GeneralUtils.Notify($"{author.downloadHandler.text.ToString()} sent you a message with: {response.downloadHandler.text.ToString()}");

                    var delete = UnityWebRequest.Get($"https://yaekiths-projects.xyz/deletemessage.php?message={response}");

                    yield return delete.SendWebRequest();
            }
        }
    }
}