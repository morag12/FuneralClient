using FuneralClient.Utils.API;
using FuneralClient.Utils.ConsoleUtil;
using FuneralClient.Utils.Extensions;
using FuneralClient.Utils.Other;
using Harmony;
using IL;
using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using UnityEngine;
using UnityEngine.Events;
using VRC;
using VRC.Core;
using VRC.UI;
using VRCSDK2;

namespace FuneralClient.Utils
{
    public static class PatchManager
    {
        public static bool HWIDSpoofed = false;

        public static List<string> AttemptedVoteKickers = new List<string>();

        public static void ApplyPatch(Type x, string Method, string PatchMethod)
        {
            HarmonyInstance instance = HarmonyInstance.Create(string.Empty);

            instance.Patch(x.GetMethod(Method), GetPatch(PatchMethod), null, null);
        }

        public static HarmonyMethod GetPatch(string name)
        {
            return new HarmonyMethod(typeof(PatchManager).GetMethod(name, BindingFlags.Static | BindingFlags.NonPublic));
        }
        public static void ApplyPatches()
        {
            try
            {
                //ApplyPatch(typeof(VRC.Core.API), "get_DeviceID", "DeviceIDSpoofer");
                ApplyPatch(typeof(PhotonView), "SerializeView", "SerializeView");
                ApplyPatch(typeof(ModerationManager), "IsBlockedEitherWay", "BlockPatch");
                ApplyPatch(typeof(ModerationManager), "IsKicked", "KickPatch");
                ApplyPatch(typeof(ModerationManager), "IsKickedFromWorld", "IsKickedFromWorldPatch");
                ApplyPatch(typeof(ModerationManager), "IsBannedFromPublicOnly", "PublicBanPatch");
                ApplyPatch(typeof(UserInteractMenu), "Update", "CloneAvatarPrefix");
                ApplyPatch(typeof(VRCUiCurrentRoom), "EBABMBJIIML", "RespawnPrefix");
              
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " || " + e.ToString());
            }

            finally
            {
                if (Configuration.config.SpoofSteamID)
                {
                    if (ILLGPJMBPKA.OGFCDJPDDJO().m_SteamID == 0)
                    {
                        ConsoleUtils.Info("SteamID Spoofed Successfully.");
                    }
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Patched Successfully.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public static bool RespawnPrefix(ref VRCUiCurrentRoom __instance)
        {
            if (__instance.respawnButton != null)
            {
                __instance.respawnButton.onClick.AddListener(delegate ()
                {
                    typeof(QuickMenu).GetMethod("Respawn").Invoke(null, null);
                    Console.WriteLine("Fixed Respawning");
                });
            }

            return true;
        }
        private static float MaxValue(object pickup)
        {
            VRC_Pickup vrc_Pickup = pickup as VRC_Pickup;
            if (vrc_Pickup != null)
            {
                return vrc_Pickup.proximity;
            }
            VRC_Interactable vrc_Interactable = pickup as VRC_Interactable;
            if (vrc_Interactable == null)
            {
                return 0f;
            }
            return vrc_Interactable.proximity;
        }

        private static bool SerializeView()
        {
            return GeneralUtils.Searialise;
        }
        private static bool ReceiveVoteToKickInitiationPatch(string __0, VRC.Player __1)
        { 
            if (PlayerManager.GetPlayer(__0) == PlayerManager.GetPlayer(APIUser.CurrentUser.id))
            {
                GeneralUtils.Debug($"You were attempted to be vote kicked by {__1.GetAPIUser().displayName}! Blocked VoteKick.");
                __0 = null;
                return false;
            }
            else
            {
                return false;
            }
        }
        private static bool BlockPatch(ref string __0)
        {
            __0 = null;
            return false;
        }

        private static bool KickPatch(ref bool __result)
        {
            __result = false;
            return false;
        }
        private static void IsKickedFromWorldPatch(ref bool __result, string __0, string __1, string __2)
        {
            if (__result)
            {
                if (AttemptedVoteKickers.Count() > 0)
                {
                    GeneralUtils.Debug($"You were attempted to be votekicked from {AttemptedVoteKickers.Count()} other user(s)");
                }
                else
                {
                    GeneralUtils.Debug("You were attempted to be kicked from the current instance.", "yellow");
                }
            }

            __result = false;
        }

        private static bool PublicBanPatch(ref string __0)
        {
            __0 = null; 
            return false;
        }

        private static bool CloneAvatarPrefix(ref UserInteractMenu __instance)
        {
            bool flag = __instance.menuController.activeAvatar.releaseStatus == "private";
            bool result;
            if (flag)
            {
                __instance.cloneAvatarButton.gameObject.SetActive(true);
                __instance.cloneAvatarButton.interactable = false;
                __instance.cloneAvatarButtonText.color = Color.cyan;
                __instance.cloneAvatarButton.onClick.AddListener(delegate
                {
                    /*
                    var avi = QuickMenuStuff.GetQuickMenuInstance().GetSelectedPlayer().vrcPlayer.GetAvatar();

                    if (VRCTrackingManager.IsInVRMode())
                    {
                        avi.SaveAvatar(PlayerManager.GetCurrentPlayer().GetAPIUser(), avi.name, avi.description, avi.imageUrl);
                    }
                    else
                    {
                        Console.WriteLine("Avatar Name? ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Description? ");
                        string description = Console.ReadLine();

                        avi.SaveAvatar(PlayerManager.GetCurrentPlayer().GetAPIUser(), name, description, avi.imageUrl);
                    }
                    */
                });
                result = false;
            }
            else
            {
                bool flag2 = !__instance.menuController.activeUser.allowAvatarCopying;
                if (flag2)
                {
                    __instance.cloneAvatarButton.gameObject.SetActive(true);
                    __instance.cloneAvatarButton.interactable = true;
                    __instance.cloneAvatarButtonText.color = new Color(0.8117647f, 0f, 0f, 1f);
                    result = false;
                }
                else
                {
                    __instance.cloneAvatarButton.gameObject.SetActive(true);
                    __instance.cloneAvatarButton.interactable = true;
                    __instance.cloneAvatarButtonText.color = new Color(0.470588237f, 0f, 0.8117647f, 1f);
                    result = false;
                }
            }
            return result;
        }

        private static bool SteamIDSpoofer(ref ulong __0)
        {
            __0 = 0UL;
            return false;
        }
    }
}
