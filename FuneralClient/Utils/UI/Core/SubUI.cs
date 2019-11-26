using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FuneralClient.Utils.UI
{
    public class SubUI : MonoBehaviour
    {
        public Rect Menu { get; set; }

        public GUIStyle Style { get; set; }

        public Texture2D UIImage { get; set; }

        public int ID { get; set; }

        public string Name { get; set; }

        public bool Enabled { get; set; }

        public bool IsSetup = false;

        public IEnumerator SetImage(string url)
        {
            UIImage = new Texture2D(5, 5);
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(UIImage);
            www.Dispose();
            yield break;
        }

        public void Create(string name, int id, GUIStyle style, float X, float Y, float Width, float Height)
        {
            Style = style;
            ID = id;
            Name = name;
            Menu = new Rect(X, Y, Width, Height); 
        }
        public void ShowUI()
        {
            GUIStyle style = new GUIStyle(GUI.skin.box);
            Menu = GUILayout.Window(ID, Menu, new GUI.WindowFunction(OnRender), Name, style);
        }
        public virtual void OnRender(int id)
        {

        }
        public virtual void Setup()
        {
            IsSetup = true;
        }

        public string CustomColorHTML(string color, string text, bool IsBold = true)
        {
            return IsBold ? $"<b><color={color}>{text}</color></b>" : $"<color={color}>{text}</color>";
        }
    }
}
