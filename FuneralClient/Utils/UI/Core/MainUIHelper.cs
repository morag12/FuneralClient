using FuneralClient.Utils.ConsoleUtil;
using FuneralClient.Utils.UI.SubMenu.Config;
using FuneralClient.Utils.UI.SubMenu.Fun_Window;
using FuneralClient.Utils.UI.SubMenu.Lobby_Window;
using FuneralClient.Utils.UI.SubMenu.MainWindow;
using FuneralClient.Utils.UI.SubMenu.Players_Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FuneralClient.Utils.UI
{
    public class MainUIHelper : MonoBehaviour
    {
        public List<SubUI> UIMenu = new List<SubUI>();

        public void Setup()
        {
            UIMenu.Add(new Main());//Main Menu
            UIMenu.Add(new Utils.UI.SubMenu.Utils_Window.Utils()); //UTILS MENU
            UIMenu.Add(new Settings()); //Settings Menu
            UIMenu.Add(new Players()); //Players Menu
            UIMenu.Add(new Player_Options()); //Player Options Menu
            UIMenu.Add(new Lobby()); //Lobby Menu
            UIMenu.Add(new Fun()); //Fun Menu
        }

        public void OnGUI()
        {
            if (GeneralUtils.ShouldShowUI)
            {
                foreach (var UI in UIMenu)
                {
                    if (UI.Enabled)
                    {
                        UI.ShowUI();
                    }
                    else
                    {
                        if (!UI.IsSetup)
                        {
                            UI.Setup();
                        }
                    }
                }
            }
        }

        public void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
