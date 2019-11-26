using FuneralClient.Utils;
using System;
using System.Collections;
using System.Linq;
using UnityEngine;

namespace Funeral
{

    public class GuiConsole : MonoBehaviour
    {
        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                toggleGuiConsole = !toggleGuiConsole;
            }

        }
        public IEnumerator Start()
        {
                GuiConsole.GUIColor = "yellow";
                GuiConsole.dateColor = "ffffff";
                GuiConsole.vrcPlColor = "417df4";
                GuiConsole.photonPlColor = "dc42f4";
                GuiConsole.BoxColor = new Color(0.25f, 0.25f, 0.25f, 0.35f);

            while (RoomManagerBase.currentRoom == null)
            {
                yield return null;
            }
            if (VRCTrackingManager.IsInVRMode())
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("[log] ");
                Console.Write(DateTime.Now.ToString("dd/MM/yyyy h:mm:ss.fff tt "));
                Console.WriteLine("Console was disabled because you're in VR-mode");
                Console.ForegroundColor = ConsoleColor.White;
                GuiConsole.toggleGuiConsole = false;
            }
            yield break;
        }
        internal static void GetGUIColor(Color color)
        {
            GuiConsole.GUIColor = ColorUtility.ToHtmlStringRGB(color);
        }
        internal static void GetDateColor(Color color)
        {
            GuiConsole.dateColor = ColorUtility.ToHtmlStringRGB(color);
        }

        internal static void GetVrcPlColor(Color color)
        {
            GuiConsole.vrcPlColor = ColorUtility.ToHtmlStringRGB(color);
        }

        internal static void GetPhotonPlColor(Color color)
        {
            GuiConsole.photonPlColor = ColorUtility.ToHtmlStringRGB(color);
        }

        public void OnGUI()
        {
            if (RoomManagerBase.currentRoom == null)
            {
                return;
            }

            if (GuiConsole.toggleGuiConsole)
            {
                this.InitStyles();
                GUI.Box(new Rect((float)(Screen.width - 455), 49f, 440f, 695f), "<i><size=20><color=#" + GuiConsole.GUIColor + @">Funeral - Debug Window ¯\_(ツ)_/¯</color></size></i>", GuiConsole.currentStyle);
                float PreviousPosition = 89f;
                foreach(var debug in GeneralUtils.DebugStrings.ToList())
                {
                    PreviousPosition = PreviousPosition + 20f;  
                    if (PreviousPosition > 500f)
                    {
                        PreviousPosition = 89f;
                        int deleteIndex = 10;

                        for(int i = deleteIndex; i < GeneralUtils.DebugStrings.ToList().Count; i++)
                        {
                            GeneralUtils.DebugStrings.RemoveAt(i);
                        }
                    }
                    else
                    {
                        GUI.Label(new Rect((float)(Screen.width - 445), PreviousPosition, (float)Screen.width, (float)Screen.height), "<i><size=15>" + debug.ToString() + "</size></i>");
                    }
                    
                }
            }
        }

        private void InitStyles()
        {
            if (GuiConsole.currentStyle == null)
            {
                GuiConsole.currentStyle = new GUIStyle(GUI.skin.box);
            }
            GuiConsole.currentStyle.normal.background = this.MakeTex(2, 2, GuiConsole.BoxColor);
        }

        private Texture2D MakeTex(int width, int height, Color col)
        {
            Color[] array = new Color[width * height];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = col;
            }
            Texture2D texture2D = new Texture2D(width, height);
            texture2D.SetPixels(array);
            texture2D.Apply();
            return texture2D;
        }

        internal static Color BoxColor;

        private static string GUIColor;

        private static string dateColor;

        private static string vrcPlColor;

        private static string photonPlColor;

        private static GUIStyle currentStyle;

        internal static bool toggleGuiConsole;
    }
}
