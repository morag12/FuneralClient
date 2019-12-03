using System;
using System.Collections.Generic;
using UnityEngine;
using VRC;
using VRC.Core;

namespace FuneralClient.Utils.UI
{
    public static class Render
    {
      
        public static GUIStyle StringStyle { get; set; } = new GUIStyle(GUI.skin.label);

        public static Color Color
        {
            get
            {
                return GUI.color;
            }
            set
            {
                GUI.color = value;
            }
        }

        public static void DrawLine(Vector2 from, Vector2 to, float thickness, Color color)
        {
            Render.Color = color;
            Render.DrawLine(from, to, thickness);
        }

        public static void DrawLine(Vector2 from, Vector2 to, float thickness)
        {
            Vector2 normalized = (to - from).normalized;
            float num = Mathf.Atan2(normalized.y, normalized.x) * 57.29578f;
            GUIUtility.RotateAroundPivot(num, from);
            Render.DrawBox(from, Vector2.right * (from - to).magnitude, thickness, false);
            GUIUtility.RotateAroundPivot(-num, from);
        }

        public static void DrawBox(Vector2 position, Vector2 size, float thickness, Color color, bool centered = true)
        {
            Render.Color = color;
            Render.DrawBox(position, size, thickness, centered);
        }

      
        public static void DrawBox(Vector2 position, Vector2 size, float thickness, bool centered = true)
        {
            if (centered)
            {
                position = position - size / 2f;
            }
            GUI.DrawTexture(new Rect(position.x, position.y, size.x, thickness), Texture2D.whiteTexture);
            GUI.DrawTexture(new Rect(position.x, position.y, thickness, size.y), Texture2D.whiteTexture);
            GUI.DrawTexture(new Rect(position.x + size.x, position.y, thickness, size.y), Texture2D.whiteTexture);
            GUI.DrawTexture(new Rect(position.x, position.y + size.y, size.x + thickness, thickness), Texture2D.whiteTexture);
        }

        public static void DrawCross(Vector2 position, Vector2 size, float thickness, Color color)
        {
            Render.Color = color;
            Render.DrawCross(position, size, thickness);
        }

        public static void DrawCross(Vector2 position, Vector2 size, float thickness)
        {
            GUI.DrawTexture(new Rect(position.x - size.x / 2f, position.y, size.x, thickness), Texture2D.whiteTexture);
            GUI.DrawTexture(new Rect(position.x, position.y - size.y / 2f, thickness, size.y), Texture2D.whiteTexture);
        }

        public static void DrawDot(Vector2 position, Color color)
        {
            Render.Color = color;
            Render.DrawDot(position);
        }

        public static void DrawDot(Vector2 position)
        {
            Render.DrawBox(position - Vector2.one, Vector2.one * 2f, 1f, true);
        }

        public static void DrawString(Vector2 position, string label, Color color, bool centered = true)
        {
            Render.Color = color;
            Render.DrawString(position, label, centered);
        }

        public static void DrawString(Vector2 position, string label, bool centered = true)
        {
            GUIContent guicontent = new GUIContent(label);
            Vector2 vector = Render.StringStyle.CalcSize(guicontent);
            GUI.Label(new Rect(centered ? (position - vector / 2f) : position, vector), guicontent);
        }

        public static void DrawCircle(Vector2 position, float radius, int numSides, bool centered = true, float thickness = 1f)
        {
            Render.DrawCircle(position, radius, numSides, Color.white, centered, thickness);
        }

        public static void DrawCircle(Vector2 position, float radius, int numSides, Color color, bool centered = true, float thickness = 1f)
        {
            Render.RingArray ringArray;
            if (Render.ringDict.ContainsKey(numSides))
            {
                ringArray = Render.ringDict[numSides];
            }
            else
            {
                ringArray = (Render.ringDict[numSides] = new Render.RingArray(numSides));
            }
            Vector2 a = centered ? position : (position + Vector2.one * radius);
            for (int i = 0; i < numSides - 1; i++)
            {
                Render.DrawLine(a + ringArray.Positions[i] * radius, a + ringArray.Positions[i + 1] * radius, thickness, color);
            }
            Render.DrawLine(a + ringArray.Positions[0] * radius, a + ringArray.Positions[ringArray.Positions.Length - 1] * radius, thickness, color);
        }

        public static Texture2D MakeTexture(int width, int height, Color col)
        {
            Color[] array = new Color[width * height];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = col;
            }
            Texture2D texture2D = new Texture2D(1, 1);
            texture2D.SetPixels(array);
            texture2D.Apply();
            return texture2D;
        }

    
        private static Dictionary<int, Render.RingArray> ringDict = new Dictionary<int, Render.RingArray>();

        private class RingArray
        {
         
            public Vector2[] Positions { get; private set; }

          
            public RingArray(int numSegments)
            {
                this.Positions = new Vector2[numSegments];
                float num = 360f / (float)numSegments;
                for (int i = 0; i < numSegments; i++)
                {
                    float f = 0.0174532924f * num * (float)i;
                    this.Positions[i] = new Vector2(Mathf.Sin(f), Mathf.Cos(f));
                }
            }
        }
    }
}
