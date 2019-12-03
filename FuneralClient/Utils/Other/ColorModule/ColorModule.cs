using FuneralClient.Utils.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Funeral
{
    // Token: 0x0200039E RID: 926
    public class ColorModule : MonoBehaviour
    {
        // Token: 0x06001A11 RID: 6673 RVA: 0x00033B98 File Offset: 0x00031D98
        private void Start()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Colored UI connected");
            Console.ForegroundColor = ConsoleColor.White;
            ColorModule.instance = this;
            ColorModule.syncColors = false;
            ColorModule.setColors = false;
        }

        // Token: 0x06001A12 RID: 6674 RVA: 0x00033BD0 File Offset: 0x00031DD0
        public static void SetColorSlider(float colorHue, float colorSaturation, float colorValue, float textColorHue, float textColorSaturation, float textColorValue, float opac)
        {
            Color color = Color.HSVToRGB(colorHue, colorSaturation, colorValue);
            Color textColor = Color.HSVToRGB(textColorHue, textColorSaturation, textColorValue);
            ColorModule.SetColorTheme(color, textColor, opac);
        }

        // Token: 0x06001A13 RID: 6675 RVA: 0x00033BF8 File Offset: 0x00031DF8
        public static void CleanupUI()
        {
            Color textColor = new Color(Configuration.config.NotifyColor.R, Configuration.config.NotifyColor.G, Configuration.config.NotifyColor.B);
            GameObject gameObject = GameObject.Find("MenuContent");
            if (ColorModule.CachedTransforms == null)
            {
                ColorModule.CachedTransforms = (from x in gameObject.GetComponentsInChildren<Transform>(true)
                                                where x.name.Contains("TitleText")
                                                select x).ToList<Transform>();
            }
            if (ColorModule.CachedText == null)
            {
                ColorModule.CachedText = gameObject.GetComponentsInChildren<Text>(true).ToList<Text>();
            }
            gameObject.transform.Find("Screens").Find("Worlds").Find("Vertical Scroll View").GetComponentsInChildren<Text>().ToList<Text>().ForEach(delegate (Text x)
            {
                x.color = textColor;
            });
            gameObject.transform.Find("Screens").Find("Avatar").Find("Vertical Scroll View").GetComponentsInChildren<Text>().ToList<Text>().ForEach(delegate (Text x)
            {
                x.color = textColor;
            });
            for (int i = 0; i < ColorModule.CachedText.Count; i++)
            {
                Color rhs = new Color(Configuration.config.NotifyColor.R, Configuration.config.NotifyColor.G, Configuration.config.NotifyColor.B); ;
                Color rhs2 = new Color(Configuration.config.NotifyColor.R, Configuration.config.NotifyColor.G, Configuration.config.NotifyColor.B); ;
                Color clear = Color.clear;
                if (ColorModule.CachedText[i].color == rhs || ColorModule.CachedText[i].color == rhs2 || ColorModule.CachedText[i].color == clear || ColorModule.CachedText[i].text == "You Are In" || ColorModule.CachedText[i].text == "Edit Status")
                {
                    ColorModule.CachedText[i].color = textColor;
                }
            }
            for (int j = 0; j < ColorModule.CachedTransforms.Count; j++)
            {
                Transform transform = ColorModule.CachedTransforms[j];
                Text text = (transform != null) ? transform.GetComponent<Text>() : null;
                if (text != null)
                {
                    text.color = textColor;
                }
            }
        }

        public void Update()
        {
            CleanupUI();
        }

        // Token: 0x06001A14 RID: 6676 RVA: 0x00033E24 File Offset: 0x00032024
        public static void SetColorTheme(Color color, Color textColor, float opacity)
        {
            ColorModule.colorr = color;
            ColorModule.DisplayClass6 locals1 = new ColorModule.DisplayClass6();
            locals1.color = color;
            locals1.textColor = textColor;
            locals1.color.a = opacity;
            Color color2 = new Color(locals1.color.r / 2.5f, locals1.color.g / 2.5f, locals1.color.b / 2.5f, locals1.color.a);
            GameObject gameObject = GameObject.Find("MenuContent");
            gameObject.transform.Find("Screens").Find("UserInfo").Find("User Panel").Find("Panel (1)").GetComponent<Image>().color = locals1.color;
            gameObject.transform.Find("Screens").Find("UserInfo").Find("User Panel").Find("WorldImage").Find("WorldBorder").GetComponent<Image>().color = locals1.color;
            gameObject.transform.Find("Screens").Find("UserInfo").Find("AvatarImage").Find("AvatarBorder").GetComponent<Image>().color = locals1.color;
            gameObject.transform.Find("Screens").Find("WorldInfo").Find("WorldImage").Find("RoomBorder").GetComponent<Image>().color = locals1.color;
            gameObject.transform.Find("Popups").Find("InputPopup").Find("Keyboard").Find("Keys").GetComponentsInChildren<Text>(true).ToList<Text>().ForEach(delegate (Text x)
            {
                x.color = locals1.color;
            });
            gameObject.transform.Find("Popups").Find("InputPopup").Find("InputField").GetComponent<Image>().color = locals1.color;
            Transform transform = gameObject.transform.Find("Popups").Find("InputPopup");
            color2.a = opacity;
            transform.Find("Rectangle").GetComponent<Image>().color = color2;
            color2.a = 0.5f;
            locals1.color.a = opacity;
            transform.Find("Rectangle").Find("Panel").GetComponent<Image>().color = locals1.color;
            locals1.color.a = 0.5f;
            Transform transform2 = gameObject.transform.Find("Backdrop").Find("Header").Find("Tabs").Find("ViewPort").Find("Content").Find("Search");
            transform2.Find("SearchTitle").GetComponent<Text>().color = locals1.color;
            transform2.Find("InputField").GetComponent<Image>().color = locals1.color;
            ColorModule.ColorOfTypeIfExists(gameObject, "Panel_Header", locals1.color, locals1.color.a, true);
            ColorModule.ColorOfTypeIfExists(gameObject, "Fill", locals1.color, 0.7f, true);
            ColorModule.ColorOfTypeIfExists(gameObject, "Handle", locals1.color, 1f, true);
            ColorModule.ColorOfTypeIfExists(gameObject, "Background", color2, opacity, true);
            ColorModule.ColorOfTypeIfExists(gameObject, "TitleText", locals1.textColor, 1f, false);
            ColorModule.DisplayClass6 locals = locals1;
            ColorBlock theme = default(ColorBlock);
            theme.colorMultiplier = 1f;
            theme.disabledColor = Color.grey;
            theme.highlightedColor = color;
            theme.normalColor = locals1.color;
            theme.pressedColor = Color.white;
            locals.theme = theme;
            gameObject.GetComponentsInChildren<Transform>(true).First((Transform x) => x.name == "Row:4 Column:0").GetComponent<Button>().colors = locals1.theme;
            locals1.color.a = 0.5f;
            color2.a = 1f;
            locals1.theme.normalColor = color2;
            gameObject.GetComponentsInChildren<Slider>(true).ToList<Slider>().ForEach(delegate (Slider x)
            {
                x.colors = locals1.theme;
            });
            color2.a = 0.5f;
            locals1.theme.normalColor = locals1.color;
            gameObject.GetComponentsInChildren<Button>(true).ToList<Button>().ForEach(delegate (Button x)
            {
                x.colors = locals1.theme;
            });
            gameObject.GetComponentsInChildren<Text>(true).ToList<Text>().ForEach(delegate (Text x)
            {
                x.color = locals1.textColor;

                if (x.text == "Get Players")
                {
                    x.color = locals1.textColor;
                }
            });
            GameObject gameObject2 = GameObject.Find("QuickMenu");
            gameObject2.GetComponentsInChildren<Button>(true).ToList<Button>().ForEach(delegate (Button x)
            {
                x.colors = locals1.theme;
            });
            gameObject2.GetComponentsInChildren<Text>(true).ToList<Text>().ForEach(delegate (Text x)
            {
              
                    x.color = locals1.textColor;
            });
            gameObject2.GetComponentsInChildren<UiToggleButton>(true).ToList<UiToggleButton>().ForEach(delegate (UiToggleButton x)
            {
                List<Image> list = x.GetComponentsInChildren<Image>(true).ToList<Image>();
                Action<Image> action;
                if ((action = locals1.images) == null)
                {
                    action = (locals1.images = delegate (Image f)
                    {
                        f.color = locals1.color;
                    });
                }
                list.ForEach(action);
            });
        }

        // Token: 0x06001A15 RID: 6677 RVA: 0x000343F4 File Offset: 0x000325F4
        internal static void ColorOfTypeIfExists(GameObject parent, string contains, Color clr, float opacityToUse, bool useImg)
        {
            clr.a = opacityToUse;
            (from x in parent.GetComponentsInChildren<Transform>(true)
             where x.name.Contains(contains)
             select x).ToList<Transform>().ForEach(delegate (Transform x)
             {
                 if (useImg)
                 {
                     Image image = (x != null) ? x.GetComponent<Image>() : null;
                     if (image != null)
                     {
                         image.color = clr;
                         return;
                     }
                 }
                 else
                 {
                     Text text = (x != null) ? x.GetComponent<Text>() : null;
                     if (text != null)
                     {
                         text.color = clr;
                     }
                 }
             });
            clr.a = 0.5f;
        }

       

		// Token: 0x04000BDD RID: 3037
		private static ColorModule instance;

// Token: 0x04000BDE RID: 3038
        internal static Color colorr;

        // Token: 0x04000BDF RID: 3039
        internal static bool syncColors;

        // Token: 0x04000BE0 RID: 3040
        internal static bool setColors;

        // Token: 0x04000BE1 RID: 3041
        private static IList<Transform> CachedTransforms;

        // Token: 0x04000BE2 RID: 3042
        private static IList<Text> CachedText;

        // Token: 0x04000BE3 RID: 3043
        private static readonly List<string> TrustedRanksExc = new List<string>
                {
                    "Trust Level",
                    "Friend",
                    "Legend-",
                    "VRChat Team / VIP",
                    "Troll",
                    "Nuisance",
                    "Veteran User",
                    "Trusted User",
                    "Known User",
                    "User",
                    "New User+",
                    "New User",
                    "Visitor"
                };

        // Token: 0x0200039F RID: 927
        private sealed class DisplayClass6
        {
            // Token: 0x06001A1C RID: 6684 RVA: 0x00034510 File Offset: 0x00032710
            internal void SetColorTheme1(Text x)
            {
                x.color = this.color;
            }

            // Token: 0x06001A1D RID: 6685 RVA: 0x0003452C File Offset: 0x0003272C
            internal void SetColorTheme3(Slider x)
            {
                x.colors = this.theme;
            }

            // Token: 0x06001A1E RID: 6686 RVA: 0x0003452C File Offset: 0x0003272C
            internal void SetColorTheme4(Button x)
            {
                x.colors = this.theme;
            }

            // Token: 0x06001A1F RID: 6687 RVA: 0x00034548 File Offset: 0x00032748
            internal void SetColorTheme5(Text x)
            {
                Color rhs = new Color(Configuration.config.NotifyColor.R, Configuration.config.NotifyColor.G, Configuration.config.NotifyColor.B);
                Color rhs2 = new Color(Configuration.config.NotifyColor.R, Configuration.config.NotifyColor.G, Configuration.config.NotifyColor.B); ;
                Color clear = Color.clear;
                if (x.color == rhs || x.color == rhs2 || x.color == clear || x.text == "You Are In" || x.text == "Edit Status")
                {
                    x.color = this.textColor;
                }
            }

            // Token: 0x06001A20 RID: 6688 RVA: 0x0003452C File Offset: 0x0003272C
            internal void SetColorTheme6(Button x)
            {
                x.colors = this.theme;
            }

            // Token: 0x06001A21 RID: 6689 RVA: 0x000345D0 File Offset: 0x000327D0
            internal void SetColorTheme7(UiToggleButton x)
            {
                List<Image> list = x.GetComponentsInChildren<Image>(true).ToList<Image>();
                Action<Image> action;
                if ((action = this.images) == null)
                {
                    action = (this.images = delegate (Image f)
                    {
                        f.color = this.color;
                    });
                }
                list.ForEach(action);
            }

            // Token: 0x06001A22 RID: 6690 RVA: 0x00034510 File Offset: 0x00032710
            internal void SetColorTheme10(Image f)
            {
                f.color = this.color;
            }


            // Token: 0x04000BE4 RID: 3044
            public Color color;

            // Token: 0x04000BE5 RID: 3045
            public ColorBlock theme;

            // Token: 0x04000BE6 RID: 3046
            public Color textColor;

            // Token: 0x04000BE7 RID: 3047
            public Action<Image> images;
		}
	}
}
