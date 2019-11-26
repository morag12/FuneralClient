using FuneralClient.Utils.ConsoleUtil;
using FuneralClient.Utils.Extensions;
using FuneralClient.Utils.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using VRC;
using VRC.Core;

namespace FuneralClient.Utils.UI
{
    public class BoxESP : MonoBehaviour
    {
        public ConfigColor color = Configuration.config.NotifyColor;
        public void DrawTraceLines()
        {
            Player[] allPlayers = PlayerManager.GetAllPlayers();
            for (int i = 0; i < allPlayers.Length; i++)
            {
                APIUser apiuser = allPlayers[i].GetAPIUser();
               
                if (apiuser != null && !(apiuser.id == APIUser.CurrentUser.id))
                {
                    Vector3 vector = VRCVrCamera.GetInstance().screenCamera.WorldToScreenPoint(allPlayers[i].transform.position);
                    if ((double)vector.z > 0.0)
                    {
                        Vector3 vector2 = GUIUtility.ScreenToGUIPoint(vector);
                        vector2.y = (float)Screen.height - vector2.y;
                        Color draw = new Color((float)color.R, (float)color.G, (float)color.B);
                        GUIHelper.DrawLine(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)), vector2, draw);
                    }
                }
            }
        }

        public void Draw3DBoundingBoxes()
        {
            foreach (Player player in PlayerManager.GetAllPlayers())
            {
                APIUser apiuser = player.GetAPIUser();
                if (apiuser != null && !(apiuser.id == APIUser.CurrentUser.id))
                {
                    Color c = new Color((float)color.R, (float)color.G, (float)color.B);
                    Vector3 position = player.transform.position;
                    Vector3 vector = position;
                    vector.y += 1.7f;
                    Vector3 min = new Vector3(position.x - 0.5f, position.y, position.z - 0.5f);
                    Vector3 max = new Vector3(position.x + 0.5f, vector.y, position.z + 0.5f);
                    this.Draw3DBox(position, min, max, Quaternion.Euler(player.transform.rotation.eulerAngles), c);
                }
            }
        }

        public void Draw3DBox(Vector3 center, Vector3 min, Vector3 max, Quaternion rot, Color c)
        {
            Vector3 point = new Vector3(min.x, max.y, min.z);
            Vector3 point2 = new Vector3(max.x, max.y, min.z);
            Vector3 point3 = new Vector3(min.x, max.y, max.z);
            Vector3 point4 = new Vector3(min.x, min.y, max.z);
            Vector3 point5 = new Vector3(max.x, min.y, min.z);
            Vector3 point6 = new Vector3(max.x, min.y, max.z);
            min = RotateAroundPoint(min, center, rot);
            max = RotateAroundPoint(max, center, rot);
            Vector3 position = RotateAroundPoint(point, center, rot);
            Vector3 position2 = RotateAroundPoint(point2, center, rot);
            Vector3 position3 = RotateAroundPoint(point3, center, rot);
            Vector3 position4 = RotateAroundPoint(point4, center, rot);
            Vector3 position5 = RotateAroundPoint(point5, center, rot);
            Vector3 position6 = RotateAroundPoint(point6, center, rot);
            Vector3 vector = VRCVrCamera.GetInstance().screenCamera.WorldToScreenPoint(min);
            Vector3 vector2 = VRCVrCamera.GetInstance().screenCamera.WorldToScreenPoint(max);
            Vector3 vector3 = VRCVrCamera.GetInstance().screenCamera.WorldToScreenPoint(position);
            Vector3 vector4 = VRCVrCamera.GetInstance().screenCamera.WorldToScreenPoint(position2);
            Vector3 vector5 = VRCVrCamera.GetInstance().screenCamera.WorldToScreenPoint(position3);
            Vector3 vector6 = VRCVrCamera.GetInstance().screenCamera.WorldToScreenPoint(position4);
            Vector3 vector7 = VRCVrCamera.GetInstance().screenCamera.WorldToScreenPoint(position5);
            Vector3 vector8 = VRCVrCamera.GetInstance().screenCamera.WorldToScreenPoint(position6);
            if ((double)vector.z <= 0.0 || (double)vector2.z <= 0.0 || (double)vector3.z <= 0.0 || (double)vector4.z <= 0.0 || (double)vector5.z <= 0.0 || (double)vector6.z <= 0.0 || (double)vector7.z <= 0.0 || (double)vector8.z <= 0.0)
            {
                return;
            }
            Vector3 vector9 = GUIUtility.ScreenToGUIPoint(vector);
            vector9.y = (float)Screen.height - vector9.y;
            Vector3 vector10 = GUIUtility.ScreenToGUIPoint(vector2);
            vector10.y = (float)Screen.height - vector10.y;
            Vector3 vector11 = GUIUtility.ScreenToGUIPoint(vector3);
            vector11.y = (float)Screen.height - vector11.y;
            Vector3 vector12 = GUIUtility.ScreenToGUIPoint(vector4);
            vector12.y = (float)Screen.height - vector12.y;
            Vector3 vector13 = GUIUtility.ScreenToGUIPoint(vector5);
            vector13.y = (float)Screen.height - vector13.y;
            Vector3 vector14 = GUIUtility.ScreenToGUIPoint(vector6);
            vector14.y = (float)Screen.height - vector14.y;
            Vector3 vector15 = GUIUtility.ScreenToGUIPoint(vector7);
            vector15.y = (float)Screen.height - vector15.y;
            Vector3 vector16 = GUIUtility.ScreenToGUIPoint(vector8);
            vector16.y = (float)Screen.height - vector16.y;
            GUIHelper.DrawLine(vector9, vector15, c);
            GUIHelper.DrawLine(vector9, vector14, c);
            GUIHelper.DrawLine(vector16, vector15, c);
            GUIHelper.DrawLine(vector16, vector14, c);
            GUIHelper.DrawLine(vector11, vector12, c);
            GUIHelper.DrawLine(vector11, vector13, c);
            GUIHelper.DrawLine(vector10, vector12, c);
            GUIHelper.DrawLine(vector10, vector13, c);
            GUIHelper.DrawLine(vector9, vector11, c);
            GUIHelper.DrawLine(vector14, vector13, c);
            GUIHelper.DrawLine(vector15, vector12, c);
            GUIHelper.DrawLine(vector16, vector10, c);
        }

        public void Draw2DBoundingBoxes()
        {
            Player[] allPlayers = PlayerManager.GetAllPlayers();
            for (int i = 0; i < allPlayers.Length; i++)
            {
                APIUser apiuser = allPlayers[i].GetAPIUser();
                if (apiuser != null && !(apiuser.id == APIUser.CurrentUser.id))
                {
                    Vector3 position = allPlayers[i].transform.position;
                    Vector3 position2 = position;
                    position2.y += 1.7f;
                    Vector3 vector = VRCVrCamera.GetInstance().screenCamera.WorldToScreenPoint(position);
                    Vector3 vector2 = VRCVrCamera.GetInstance().screenCamera.WorldToScreenPoint(position2);
                    if ((double)vector.z > 0.0 && (double)vector2.z > 0.0)
                    {
                        Vector3 vector3 = GUIUtility.ScreenToGUIPoint(vector);
                        vector3.y = (float)Screen.height - vector3.y;
                        Vector3 vector4 = GUIUtility.ScreenToGUIPoint(vector2);
                        vector4.y = (float)Screen.height - vector4.y;
                        float num = (float)((double)Math.Abs(vector3.y - vector4.y) / 2.20000004768372 / 2.0);
                        Vector3 v = new Vector3(vector4.x - num, vector4.y);
                        Vector3 v2 = new Vector3(vector4.x + num, vector4.y);
                        Vector3 v3 = new Vector3(vector4.x - num, vector3.y);
                        Vector3 v4 = new Vector3(vector4.x + num, vector3.y);
                        Color c = new Color((float)color.R, (float)color.G, (float)color.B);
                        GUIHelper.DrawLine(v, v2, c);
                        GUIHelper.DrawLine(v, v3, c);
                        GUIHelper.DrawLine(v3, v4, c);
                        GUIHelper.DrawLine(v2, v4, c);
                    }
                }
            }
        }

        public void DrawNames()
        {
            foreach (Player player in PlayerManager.GetAllPlayers())
            {
                APIUser apiuser = player.GetAPIUser();
                if (apiuser != null && !(apiuser.id == APIUser.CurrentUser.id))
                {
                    Vector3 position = player.transform.position;
                    position.y += 2.5f;
                    Vector3 vector = VRCVrCamera.GetInstance().screenCamera.WorldToScreenPoint(position);
                    if ((double)vector.z > 0.0)
                    {
                        Vector3 vector2 = GUIUtility.ScreenToGUIPoint(vector);
                        vector2.y = (float)Screen.height - vector2.y;
                        GUI.Label(new Rect(vector2.x, vector2.y, 125f, 25f), "<size=10><b><color=white>" + apiuser.displayName + "</color></b></size>");
                    }
                }
            }
        }

        public static Texture2D CreatePlainTexture(float r, float g, float b, float a)
        {
            Texture2D texture2D = new Texture2D(1, 1);
            texture2D.SetPixel(0, 0, new Color(r, g, b, a));
            texture2D.Apply();
            return texture2D;
        }

        public static Vector3 RotateAroundPoint(Vector3 point, Vector3 pivot, Quaternion angle)
        {
            return angle * (point - pivot) + pivot;
        }

        public void OnGUI()
        {
            if (GeneralUtils.BoxESP)
            {
                Draw3DBoundingBoxes();
                DrawNames();
            }

            if (GeneralUtils.DimensionalESP)
            {
                Draw2DBoundingBoxes();
                DrawNames();
            }

            if (GeneralUtils.DrawTracingLines)
            {
                DrawTraceLines();
            }
        }
        public void Start()
        {
            ConsoleUtils.Info("ESP has Loaded.");
        }
    }
}
