using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using VRC;
using VRC.Core;
using VRCSDK2;
using UnityEngine.Events;
using VRC.UI;
using System.Collections;
using System.Reflection;
using FuneralClient.Utils.UI;
using UnityEngine.UI;

namespace FuneralClient.Utils.API
{
    public enum ButtonType
    {
        Default,
        Single,
        Nested,
        Toggle
    }
    public enum MenuType
    {
        ShortCut,
        UserInteract,
        Nested,
        UserInfo
    }
    [Obsolete]
    [System.Reflection.Obfuscation(Exclude = false, ApplyToMembers = true, Feature = "+ctrl flow;+rename;+constants;+anti debug;+anti ildasm;+ref proxy;+resources")]
    public static class ReworkedButtonAPI
    {
        //BtnMenu -> this has 3 possible types, "ShortcutMenu", "UserInteractMenu" or a QMNestedButton (button that opens up to other buttons)
        //ShortcutMenu -> main quick menu with worlds/avatars
        
        public static IEnumerator CreateButton(MenuType Menu, ButtonType type, string ButtonText, int X, int Y, UnityAction action, string buttonTooltip, Color color, Color BtnText, QMNestedButton MainButton = null, string SpriteImage = null, string OnText = null, string OffText = null, UnityAction OffAction = null, Color? BackButtonColor = null, Color? BackButtonTextColor = null)
        {
            string MenuString = "ShortcutMenu";
            
            switch(Menu)
            {
                default: MenuString = "ShortcutMenu"; break;
                case MenuType.ShortCut: MenuString = "ShortcutMenu"; break;
                case MenuType.UserInteract: MenuString = "UserInteractMenu"; break;
                case MenuType.UserInfo: MenuString = "UserInfo"; break;
            }

            switch (type)
            {
                default: break;
                case ButtonType.Single:
                    QMSingleButton x = null;
                    if (MainButton != null)
                    {
                        x = new QMSingleButton(MainButton, X, Y, ButtonText, action, buttonTooltip, color, BtnText);
                    }
                    else
                    {
                        x = new QMSingleButton(MenuString, X, Y, ButtonText, action, buttonTooltip, color, BtnText);
                    }

                    if (SpriteImage != null)
                    {
                        var sprite = new Sprite();

                        using (WWW www = new WWW(SpriteImage))
                        {
                            yield return www;
                            sprite = Sprite.Create(www.texture, new Rect(0, 0, www.texture.width, www.texture.height),
                                new Vector2(0, 0));
                        }

                        x.getGameObject().GetComponentInChildren<UnityEngine.UI.Image>().sprite = sprite;
                        Material logoMaterial = new Material(x.getGameObject().GetComponentInChildren<UnityEngine.UI.Image>().material);
                        logoMaterial.shader = Shader.Find("Unlit/Transparent");
                        x.getGameObject().GetComponentInChildren<UnityEngine.UI.Image>().material = logoMaterial;
                    }
                    UIHelper.ButtonOutput.Add(x);
                    break;

                case ButtonType.Toggle:
                    QMToggleButton y = null;
                    if (MainButton != null)
                    {
                        y = new QMToggleButton(MainButton, X, Y, OnText, action, OffText, OffAction, buttonTooltip, color, BtnText);
                    }
                    else
                    {
                        y = new QMToggleButton(MenuString, X, Y, OnText, action, OffText, OffAction, buttonTooltip, color, BtnText);
                    }
                    

                    if (SpriteImage != null)
                    {
                        var sprite = new Sprite();

                        using (WWW www = new WWW(SpriteImage))
                        {

                            sprite = Sprite.Create(www.texture, new Rect(0, 0, www.texture.width, www.texture.height),
                                new Vector2(0, 0));
                        }

                        y.getGameObject().GetComponentInChildren<UnityEngine.UI.Image>().sprite = sprite;
                        Material logoMaterial = new Material(y.getGameObject().GetComponentInChildren<UnityEngine.UI.Image>().material);
                        logoMaterial.shader = Shader.Find("Unlit/Transparent");
                        y.getGameObject().GetComponentInChildren<UnityEngine.UI.Image>().material = logoMaterial;
                    }
                    UIHelper.ButtonOutput.Add(y);
                    break;

                case ButtonType.Nested:
                    if (MainButton != null)
                    {
                        var f = new QMNestedButton(MainButton, X, Y, ButtonText, buttonTooltip, color, BtnText, (Color)BackButtonColor, (Color)BackButtonTextColor);
                        UIHelper.ButtonOutput.Add(f);
                    }
                    else
                    {
                        var z = new QMNestedButton(MenuString, X, Y, ButtonText, buttonTooltip, color, BtnText, (Color)BackButtonColor, (Color)BackButtonTextColor);
                        UIHelper.ButtonOutput.Add(z);
                    }
                    break;
            }
        }
    }
    [System.Reflection.Obfuscation(Exclude = false, ApplyToMembers = true, Feature = "+ctrl flow;+rename;+constants;+anti debug;+anti ildasm;+ref proxy;+resources")]
    public class QMButtonBase
    {
        protected GameObject button;
        protected string btnQMLoc;
        protected string btnType;
        protected string btnTag;
        protected int[] initShift = { 0, 0 };

        public GameObject getGameObject()
        {
            return button;
        }

        public void setActive(bool isActive)
        {
            button.gameObject.SetActive(isActive);
        }

        public void setLocation(int buttonXLoc, int buttonYLoc)
        {
            button.GetComponent<RectTransform>().anchoredPosition += Vector2.right * (420 * (buttonXLoc + initShift[0]));
            button.GetComponent<RectTransform>().anchoredPosition += Vector2.down * (420 * (buttonYLoc + initShift[1]));

            btnTag = "(" + buttonXLoc + "," + buttonYLoc + ")";
            button.name = btnQMLoc + "/" + btnType + btnTag;
            button.GetComponent<Button>().name = btnType + btnTag;
        }

        public void setToolTip(string buttonToolTip)
        {
            button.GetComponent<UiTooltip>().text = buttonToolTip;
            button.GetComponent<UiTooltip>().alternateText = buttonToolTip;
        }
    }
    [System.Reflection.Obfuscation(Exclude = false, ApplyToMembers = true, Feature = "+ctrl flow;+rename;+constants;+anti debug;+anti ildasm;+ref proxy;+resources")]
    public class QMSingleButton : QMButtonBase
    {

        public QMSingleButton(QMNestedButton btnMenu, int btnXLocation, int btnYLocation, String btnText, UnityAction btnAction, String btnToolTip, Color btnBackgroundColor, Color btnTextColor)
        {
            btnQMLoc = btnMenu.getMenuName();
            btnType = "SingleButton";
            initButton(btnXLocation, btnYLocation, btnText, btnAction, btnToolTip, btnBackgroundColor, btnTextColor);
        }

        public QMSingleButton(string btnMenu, int btnXLocation, int btnYLocation, String btnText, UnityAction btnAction, String btnToolTip, Color btnBackgroundColor, Color btnTextColor)
        {
            btnQMLoc = btnMenu;
            btnType = "SingleButton";
            initButton(btnXLocation, btnYLocation, btnText, btnAction, btnToolTip, btnBackgroundColor, btnTextColor);
        }


        public void initButton(int btnXLocation, int btnYLocation, String btnText, UnityAction btnAction, String btnToolTip, Color btnBackgroundColor, Color btnTextColor)
        {
            Transform btnTemplate = null;
            btnTemplate = QuickMenuStuff.GetQuickMenuInstance().transform.Find("ShortcutMenu/WorldsButton");

            button = UnityEngine.Object.Instantiate<GameObject>(btnTemplate.gameObject, QuickMenuStuff.GetQuickMenuInstance().transform.Find(btnQMLoc), true);
            button.name = btnText.ToLower().ToString();
            initShift[0] = -1;
            initShift[1] = 0;
            setLocation(btnXLocation, btnYLocation);
            setButtonText(btnText);
            setToolTip(btnToolTip);
            setAction(btnAction);
            setBackgroundColor(btnBackgroundColor);
            setTextColor(btnTextColor);

            setActive(true);
        }

        public void setButtonText(string buttonText)
        {
            button.GetComponentInChildren<Text>().text = buttonText;
        }

        public void setAction(UnityAction buttonAction)
        {
            button.GetComponent<Button>().onClick = new Button.ButtonClickedEvent();
            button.GetComponent<Button>().onClick.AddListener(buttonAction);
        }

        public void setBackgroundColor(Color buttonBackgroundColor)
        {
            button.GetComponentInChildren<UnityEngine.UI.Image>().color = buttonBackgroundColor;
        }

        public void setTextColor(Color buttonTextColor)
        {
            button.GetComponentInChildren<Text>().color = buttonTextColor;
        }
    }

    [System.Reflection.Obfuscation(Exclude = false, ApplyToMembers = true, Feature = "+ctrl flow;+rename;+constants;+anti debug;+anti ildasm;+ref proxy;+resources")]
    public class QMToggleButton : QMButtonBase
    {

        public GameObject btnOn;
        public GameObject btnOff;


        public QMToggleButton(QMNestedButton btnMenu, int btnXLocation, int btnYLocation, String btnTextOn, UnityAction btnActionOn, String btnTextOff, UnityAction btnActionOff, String btnToolTip, Nullable<Color> btnBackgroundColor = null, Nullable<Color> btnTextColor = null)
        {
            btnQMLoc = btnMenu.getMenuName();
            btnType = "ToggleButton";
            initButton(btnXLocation, btnYLocation, btnTextOn, btnActionOn, btnTextOff, btnActionOff, btnToolTip, btnBackgroundColor, btnTextColor);
        }

        public QMToggleButton(string btnMenu, int btnXLocation, int btnYLocation, String btnTextOn, UnityAction btnActionOn, String btnTextOff, UnityAction btnActionOff, String btnToolTip, Nullable<Color> btnBackgroundColor = null, Nullable<Color> btnTextColor = null)
        {
            btnQMLoc = btnMenu;
            btnType = "ToggleButton";
            initButton(btnXLocation, btnYLocation, btnTextOn, btnActionOn, btnTextOff, btnActionOff, btnToolTip, btnBackgroundColor, btnTextColor);
        }

        public void initButton(int btnXLocation, int btnYLocation, String btnTextOn, UnityAction btnActionOn, String btnTextOff, UnityAction btnActionOff, String btnToolTip, Nullable<Color> btnBackgroundColor = null, Nullable<Color> btnTextColor = null)
        {
            Transform btnTemplate = null;
            btnTemplate = QuickMenuStuff.GetQuickMenuInstance().transform.Find("UserInteractMenu/BlockButton");

            button = UnityEngine.Object.Instantiate<GameObject>(btnTemplate.gameObject, QuickMenuStuff.GetQuickMenuInstance().transform.Find(btnQMLoc), true);
            button.name = btnTextOn.ToLower().ToString();
            btnOn = button.transform.Find("Toggle_States_Visible/ON").gameObject;
            btnOff = button.transform.Find("Toggle_States_Visible/OFF").gameObject;

            initShift[0] = -4;
            initShift[1] = 0;
            setLocation(btnXLocation, btnYLocation);

            setOnText(btnTextOn);
            setOffText(btnTextOff);
            Text[] btnTextsOn = btnOn.GetComponentsInChildren<Text>();
            btnTextsOn[0].name = "Text_ON";
            btnTextsOn[1].name = "Text_OFF";
            Text[] btnTextsOff = btnOff.GetComponentsInChildren<Text>();
            btnTextsOff[0].name = "Text_ON";
            btnTextsOff[1].name = "Text_OFF";

            setToolTip(btnToolTip);
            button.transform.GetComponentInChildren<UiTooltip>().SetToolTipBasedOnToggle();

            setAction(btnActionOn, btnActionOff);
            btnOn.SetActive(false);
            btnOff.SetActive(true);

            if (btnBackgroundColor != null)
                setBackgroundColor((Color)btnBackgroundColor);

            if (btnTextColor != null)
                setTextColor((Color)btnTextColor);

            setActive(true);

        }

        public void setBackgroundColor(Color buttonBackgroundColor)
        {
            UnityEngine.UI.Image[] btnBgColorList = ((btnOn.GetComponentsInChildren<UnityEngine.UI.Image>()).Concat(btnOff.GetComponentsInChildren<UnityEngine.UI.Image>()).ToArray()).Concat(button.GetComponentsInChildren<UnityEngine.UI.Image>()).ToArray();
            foreach (UnityEngine.UI.Image btnBackground in btnBgColorList) btnBackground.color = buttonBackgroundColor;
        }

        public void setTextColor(Color buttonTextColor)
        {
            Text[] btnTxtColorList = (btnOn.GetComponentsInChildren<Text>()).Concat(btnOff.GetComponentsInChildren<Text>()).ToArray();
            foreach (Text btnText in btnTxtColorList) btnText.color = buttonTextColor;
        }

        public void setAction(UnityAction buttonOnAction, UnityAction buttonOffAction)
        {
            button.GetComponent<Button>().onClick = new Button.ButtonClickedEvent();
            button.GetComponent<Button>().onClick.AddListener(delegate ()
            {
                if (btnOn.activeSelf)
                {
                    buttonOffAction.Invoke();
                    btnOn.SetActive(false);
                    btnOff.SetActive(true);
                }
                else
                {
                    buttonOnAction.Invoke();
                    btnOff.SetActive(false);
                    btnOn.SetActive(true);
                }
            });
        }

        public void setOnText(string buttonOnText)
        {
            Text[] btnTextsOn = btnOn.GetComponentsInChildren<Text>();
            btnTextsOn[0].text = buttonOnText;
            Text[] btnTextsOff = btnOff.GetComponentsInChildren<Text>();
            btnTextsOff[0].text = buttonOnText;
        }

        public void setOffText(string buttonOffText)
        {
            Text[] btnTextsOn = btnOn.GetComponentsInChildren<Text>();
            btnTextsOn[1].text = buttonOffText;
            Text[] btnTextsOff = btnOff.GetComponentsInChildren<Text>();
            btnTextsOff[1].text = buttonOffText;
        }
    }
    [System.Reflection.Obfuscation(Exclude = false, ApplyToMembers = true, Feature = "+ctrl flow;+rename;+constants;+anti debug;+anti ildasm;+ref proxy;+resources")]
    public class QMNestedButton
    {
        protected QMSingleButton mainButton;
        protected QMSingleButton backButton;
        protected string menuName;
        protected string btnQMLoc;
        protected string btnType;

        public QMNestedButton(QMNestedButton btnMenu, int btnXLocation, int btnYLocation, String btnText, String btnToolTip, Color btnBackgroundColor, Color btnTextColor, Color backbtnBackgroundColor, Color backbtnTextColor)
        {
            btnQMLoc = btnMenu.getMenuName();
            btnType = "NestedButton";
            initButton(btnXLocation, btnYLocation, btnText, btnToolTip, btnBackgroundColor, btnTextColor, backbtnBackgroundColor, backbtnTextColor);
        }

        public QMNestedButton(string btnMenu, int btnXLocation, int btnYLocation, String btnText, String btnToolTip, Color btnBackgroundColor, Color btnTextColor, Color backbtnBackgroundColor, Color backbtnTextColor)
        {
            btnQMLoc = btnMenu;
            btnType = "NestedButton";
            initButton(btnXLocation, btnYLocation, btnText, btnToolTip, btnBackgroundColor, btnTextColor, backbtnBackgroundColor, backbtnTextColor);
        }

        public void initButton(int btnXLocation, int btnYLocation, String btnText, String btnToolTip, Color btnBackgroundColor, Color btnTextColor, Color backbtnBackgroundColor, Color backbtnTextColor)
        {
            Transform menu = UnityEngine.Object.Instantiate<Transform>(QuickMenuStuff.GetQuickMenuInstance().transform.Find("CameraMenu"), QuickMenuStuff.GetQuickMenuInstance().transform);
            menuName = "CustomMenu" + btnQMLoc + "_" + btnXLocation + "_" + btnYLocation;
            menu.name = menuName;

            mainButton = new QMSingleButton(btnQMLoc, btnXLocation, btnYLocation, btnText, delegate () { QuickMenuStuff.ShowQuickmenuPage(menuName); }, btnToolTip, btnBackgroundColor, btnTextColor);

            IEnumerator enumerator = menu.transform.GetEnumerator();
            while (enumerator.MoveNext())
            {
                object obj = enumerator.Current;
                Transform btnEnum = (Transform)obj;
                if (btnEnum != null)
                {
                    UnityEngine.Object.Destroy(btnEnum.gameObject);
                }
            }

            if (backbtnTextColor == null)
            {
                backbtnTextColor = Color.yellow;
            }
            backButton = new QMSingleButton(this, 4, 2, "Back", delegate () { QuickMenuStuff.ShowQuickmenuPage(btnQMLoc); }, "Go Back", backbtnBackgroundColor, backbtnTextColor);
        }

        public string getMenuName()
        {
            return menuName;
        }

        public QMSingleButton getMainButton()
        {
            return mainButton;
        }

        public QMSingleButton getBackButton()
        {
            return backButton;
        }
    }
    [System.Reflection.Obfuscation(Exclude = false, ApplyToMembers = true, Feature = "+ctrl flow;+rename;+constants;+anti debug;+anti ildasm;+ref proxy;+resources")]
    public class QuickMenuStuff : MonoBehaviour
    {
        public static VRCUiManager vrcuimInstance;
        public static VRCUiManager GetVRCUiMInstance()
        {
            if (vrcuimInstance == null)
            {
                MethodInfo method = typeof(VRCUiManager).GetMethod("get_Instance", BindingFlags.Static | BindingFlags.Public);
                if (method == null)
                {
                    return null;
                }
                vrcuimInstance = (VRCUiManager)method.Invoke(null, new object[0]);
            }
            return vrcuimInstance;
        }


        public static QuickMenu quickmenuInstance;
        public static QuickMenu GetQuickMenuInstance()
        {
            if (quickmenuInstance == null)
            {
                MethodInfo method = typeof(QuickMenu).GetMethod("get_Instance", BindingFlags.Static | BindingFlags.Public);
                if (method == null)
                {
                    return null;
                }
                quickmenuInstance = (QuickMenu)method.Invoke(null, new object[0]);
            }
            return quickmenuInstance;
        }

        public static FieldInfo currentPageGetter;
        public static FieldInfo quickmenuContextualDisplayGetter;
        public static void ShowQuickmenuPage(string pagename)
        {
            QuickMenu quickMenuInstance = GetQuickMenuInstance();
            Transform transform = (quickMenuInstance != null) ? quickMenuInstance.transform.Find(pagename) : null;
            if (transform == null)
            {
                Console.WriteLine("[QuickMenuUtils] pageTransform is null !");
            }
            if (currentPageGetter == null)
            {
                if (currentPageGetter == null)
                {
                    GameObject gameObject = quickMenuInstance.transform.Find("ShortcutMenu").gameObject;
                    FieldInfo[] array = (from fi in typeof(QuickMenu).GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                                         where fi.FieldType == typeof(GameObject)
                                         select fi).ToArray<FieldInfo>();
                    int num = 0;
                    foreach (FieldInfo fieldInfo in array)
                    {
                        if (fieldInfo.GetValue(quickMenuInstance) as GameObject == gameObject && ++num == 2)
                        {
                            currentPageGetter = fieldInfo;
                            break;
                        }
                    }
                }
                if (currentPageGetter == null)
                {
                    GameObject gameObject = quickMenuInstance.transform.Find("UserInteractMenu").gameObject;
                    FieldInfo[] array = (from fi in typeof(QuickMenu).GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                                         where fi.FieldType == typeof(GameObject)
                                         select fi).ToArray<FieldInfo>();

                    int num = 0;
                    foreach (FieldInfo fieldInfo in array)
                    {
                        if (fieldInfo.GetValue(quickMenuInstance) as GameObject == gameObject && ++num == 2)
                        {

                            currentPageGetter = fieldInfo;
                            break;
                        }
                    }
                }

                if (currentPageGetter == null)
                {
                    Console.WriteLine("[QuickMenuUtils] Unable to find field currentPage in QuickMenu");
                    return;
                }
            }
            GameObject gameObject2 = (GameObject)currentPageGetter.GetValue(quickMenuInstance);
            if (gameObject2 != null)
            {
                gameObject2.SetActive(false);
            }
            GetQuickMenuInstance().transform.Find("QuickMenu_NewElements/_InfoBar").gameObject.SetActive(false);
            if (quickmenuContextualDisplayGetter != null)
            {
                quickmenuContextualDisplayGetter = typeof(QuickMenu).GetFields(BindingFlags.Instance | BindingFlags.NonPublic).FirstOrDefault((FieldInfo fi) => fi.FieldType == typeof(QuickMenuContextualDisplay));
            }
            FieldInfo fieldInfo2 = quickmenuContextualDisplayGetter;
            QuickMenuContextualDisplay quickMenuContextualDisplay = ((fieldInfo2 != null) ? fieldInfo2.GetValue(quickMenuInstance) : null) as QuickMenuContextualDisplay;
            if (quickMenuContextualDisplay != null)
            {
                currentPageGetter.SetValue(quickMenuInstance, transform.gameObject);
                MethodBase method = typeof(QuickMenuContextualDisplay).GetMethod("SetDefaultContext", BindingFlags.Instance | BindingFlags.Public);
                object obj = quickMenuContextualDisplay;
                object[] array3 = new object[3];
                array3[0] = 0;
                method.Invoke(obj, array3);
            }
            currentPageGetter.SetValue(quickMenuInstance, transform.gameObject);
            MethodBase method2 = typeof(QuickMenu).GetMethod("SetContext", BindingFlags.Instance | BindingFlags.Public);
            object obj2 = quickMenuInstance;
            object[] array4 = new object[3];
            array4[0] = 1;
            method2.Invoke(obj2, array4);
            transform.gameObject.SetActive(true);
        }

        public VRCUiPage GetPage(string path)
        {
            GameObject gameObject = GameObject.Find(path);
            VRCUiPage vrcuiPage = null;
            if (gameObject != null)
            {
                vrcuiPage = gameObject.GetComponent<VRCUiPage>();
                if (vrcuiPage == null)
                {
                    UnityEngine.Debug.LogError("Screen Not Found - " + path);
                }
            }
            else
            {
                UnityEngine.Debug.LogWarning("Screen Not Found - " + path);
            }
            return vrcuiPage;
        }
    }

}
