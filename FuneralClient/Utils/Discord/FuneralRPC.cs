using Funeral.Discord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using UnityEngine;
using VRC;

namespace FuneralClient.Utils.Discord
{
    public static class FuneralRPC
    {
        public static DiscordRPC.RichPresence Presence = new DiscordRPC.RichPresence();

        public static void Start()
        {
            new Thread(() =>
            {
                DiscordRPC.EventHandlers eventHandler = default(DiscordRPC.EventHandlers);
                DiscordRPC.Initialize("639595027089063957", ref eventHandler, false, null);
                Console.WriteLine("DiscordRPC Started.");
                for (; ; )
                {
                    Thread.Sleep(30000);
                    CustomUpdate();
                }
            })
            { IsBackground = true }.Start();
        }

        public static void CustomUpdate()
        {
            Console.WriteLine("Update Called for DiscordRPC (30 seconds have past)");
            if (RoomManagerBase.JMAONLCKPFH)
            {
                //In world
                //Search get_inRoom
                Presence.details = "Kickin' away with hax";
                Presence.largeImageKey = "kyle";
                Presence.smallImageKey = "vr_crap_logo";
                Presence.largeImageText = "Ruining kids lives";
                Presence.smallImageText = $"with {PlayerManager.GetAllPlayers().Count()} other player(s)";
                
                var roomType = RoomManagerBase.currentWorldInstance.InstanceType;
                switch(roomType)
                {
                    default:
                        Presence.state = "Hacking away into an Unknown World";
                        break;
                    case VRC.Core.ApiWorldInstance.AccessType.Public:
                        Presence.state = "In a Public Instance";
                        break;
                    case VRC.Core.ApiWorldInstance.AccessType.Counter:
                        Presence.state = "In a Counter Instance";
                        break;
                    case VRC.Core.ApiWorldInstance.AccessType.FriendsOfGuests:
                        Presence.state = "In a Friends Of Guests Instance";
                        break;
                    case VRC.Core.ApiWorldInstance.AccessType.FriendsOnly:
                        Presence.state = "In a Friends Only Instance";
                        break;
                    case VRC.Core.ApiWorldInstance.AccessType.InviteOnly:
                        Presence.state = "In an Invite Only Instance";
                        break;
                    case VRC.Core.ApiWorldInstance.AccessType.InvitePlus:
                        Presence.state = "In an Invite+ Instance";
                        break;
                }
            }
            else
            {
                Presence.details = "A Perish God.";
                Presence.state ="Not In a world? (Loading World)";
                Presence.largeImageKey = "bruh";
                Presence.smallImageKey = "vr_crap_logo";
                Presence.largeImageText = "Is somehow hacking in a loading world";
                Presence.smallImageText = "What the fuck";
            }
        }
    }
}
