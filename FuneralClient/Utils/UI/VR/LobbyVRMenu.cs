using FuneralClient.Utils.API;
using FuneralClient.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using VRC;

namespace FuneralClient.Utils.UI.VR
{
    public class LobbyVRMenu : QMNestedButton
    {
        public LobbyVRMenu(QMNestedButton parent) : base(parent, 3, 0, "Lobby", "Do what you want to the current lobby", Color.black, Color.white, Color.black, Color.cyan)
        {
            new QMSingleButton(this, 1, 0, "Crash Lobby", delegate
            {
                GeneralUtils.Swap("avtr_56674e13-8e5f-4eae-be53-21980ec4e965");
            }, "Crash the current lobby", Color.black, Color.white);

            new QMSingleButton(this, 1, 1, "Get Information", delegate
            {
                var ins = RoomManager.currentWorldInstance;
                string text = $"Instance Name: {ins.instanceName}\nInstance Owner: {PlayerManager.GetPlayer(ins.instanceCreator).GetAPIUser().displayName}\nPlayer Count: {ins.count}";
                GeneralUtils.Notify(text);
            }, "Get the current information of the current lobby", Color.black, Color.white);


            new QMToggleButton(this, 1, 2, "Enable Portal Disabler", delegate
            {
                GeneralUtils.DeletePortals = true;
            }, "Disable Portal Disabler", delegate
            {
                GeneralUtils.DeletePortals = false;
            }, "Enable/Disable Portal Disabler", Color.red, Color.white);
        }
    }
}
