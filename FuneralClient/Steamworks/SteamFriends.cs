using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000155 RID: 341
	public static class SteamFriends
	{
		// Token: 0x06000597 RID: 1431 RVA: 0x00003E0C File Offset: 0x0000200C
		public static string GetPersonaName()
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetPersonaName(CSteamAPIContext.GetSteamFriends()));
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0000BEF0 File Offset: 0x0000A0F0
		public static SteamAPICall_t SetPersonaName(string pchPersonaName)
		{
			InteropHelp.TestIfAvailableClient();
			SteamAPICall_t result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchPersonaName))
			{
				result = (SteamAPICall_t)NativeMethods.ISteamFriends_SetPersonaName(CSteamAPIContext.GetSteamFriends(), utf8StringHandle);
			}
			return result;
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00003E22 File Offset: 0x00002022
		public static EPersonaState GetPersonaState()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetPersonaState(CSteamAPIContext.GetSteamFriends());
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00003E33 File Offset: 0x00002033
		public static int GetFriendCount(EFriendFlags iFriendFlags)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetFriendCount(CSteamAPIContext.GetSteamFriends(), iFriendFlags);
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00003E45 File Offset: 0x00002045
		public static CSteamID GetFriendByIndex(int iFriend, EFriendFlags iFriendFlags)
		{
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamFriends_GetFriendByIndex(CSteamAPIContext.GetSteamFriends(), iFriend, iFriendFlags);
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00003E5D File Offset: 0x0000205D
		public static EFriendRelationship GetFriendRelationship(CSteamID steamIDFriend)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetFriendRelationship(CSteamAPIContext.GetSteamFriends(), steamIDFriend);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00003E6F File Offset: 0x0000206F
		public static EPersonaState GetFriendPersonaState(CSteamID steamIDFriend)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetFriendPersonaState(CSteamAPIContext.GetSteamFriends(), steamIDFriend);
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00003E81 File Offset: 0x00002081
		public static string GetFriendPersonaName(CSteamID steamIDFriend)
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetFriendPersonaName(CSteamAPIContext.GetSteamFriends(), steamIDFriend));
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00003E98 File Offset: 0x00002098
		public static bool GetFriendGamePlayed(CSteamID steamIDFriend, out FriendGameInfo_t pFriendGameInfo)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetFriendGamePlayed(CSteamAPIContext.GetSteamFriends(), steamIDFriend, out pFriendGameInfo);
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00003EAB File Offset: 0x000020AB
		public static string GetFriendPersonaNameHistory(CSteamID steamIDFriend, int iPersonaName)
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetFriendPersonaNameHistory(CSteamAPIContext.GetSteamFriends(), steamIDFriend, iPersonaName));
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00003EC3 File Offset: 0x000020C3
		public static int GetFriendSteamLevel(CSteamID steamIDFriend)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetFriendSteamLevel(CSteamAPIContext.GetSteamFriends(), steamIDFriend);
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00003ED5 File Offset: 0x000020D5
		public static string GetPlayerNickname(CSteamID steamIDPlayer)
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetPlayerNickname(CSteamAPIContext.GetSteamFriends(), steamIDPlayer));
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00003EEC File Offset: 0x000020EC
		public static int GetFriendsGroupCount()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetFriendsGroupCount(CSteamAPIContext.GetSteamFriends());
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00003EFD File Offset: 0x000020FD
		public static FriendsGroupID_t GetFriendsGroupIDByIndex(int iFG)
		{
			InteropHelp.TestIfAvailableClient();
			return (FriendsGroupID_t)NativeMethods.ISteamFriends_GetFriendsGroupIDByIndex(CSteamAPIContext.GetSteamFriends(), iFG);
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00003F14 File Offset: 0x00002114
		public static string GetFriendsGroupName(FriendsGroupID_t friendsGroupID)
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetFriendsGroupName(CSteamAPIContext.GetSteamFriends(), friendsGroupID));
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00003F2B File Offset: 0x0000212B
		public static int GetFriendsGroupMembersCount(FriendsGroupID_t friendsGroupID)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetFriendsGroupMembersCount(CSteamAPIContext.GetSteamFriends(), friendsGroupID);
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00003F3D File Offset: 0x0000213D
		public static void GetFriendsGroupMembersList(FriendsGroupID_t friendsGroupID, CSteamID[] pOutSteamIDMembers, int nMembersCount)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamFriends_GetFriendsGroupMembersList(CSteamAPIContext.GetSteamFriends(), friendsGroupID, pOutSteamIDMembers, nMembersCount);
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00003F51 File Offset: 0x00002151
		public static bool HasFriend(CSteamID steamIDFriend, EFriendFlags iFriendFlags)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_HasFriend(CSteamAPIContext.GetSteamFriends(), steamIDFriend, iFriendFlags);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00003F64 File Offset: 0x00002164
		public static int GetClanCount()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetClanCount(CSteamAPIContext.GetSteamFriends());
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00003F75 File Offset: 0x00002175
		public static CSteamID GetClanByIndex(int iClan)
		{
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamFriends_GetClanByIndex(CSteamAPIContext.GetSteamFriends(), iClan);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00003F8C File Offset: 0x0000218C
		public static string GetClanName(CSteamID steamIDClan)
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetClanName(CSteamAPIContext.GetSteamFriends(), steamIDClan));
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00003FA3 File Offset: 0x000021A3
		public static string GetClanTag(CSteamID steamIDClan)
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetClanTag(CSteamAPIContext.GetSteamFriends(), steamIDClan));
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00003FBA File Offset: 0x000021BA
		public static bool GetClanActivityCounts(CSteamID steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetClanActivityCounts(CSteamAPIContext.GetSteamFriends(), steamIDClan, out pnOnline, out pnInGame, out pnChatting);
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00003FCF File Offset: 0x000021CF
		public static SteamAPICall_t DownloadClanActivityCounts(CSteamID[] psteamIDClans, int cClansToRequest)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamFriends_DownloadClanActivityCounts(CSteamAPIContext.GetSteamFriends(), psteamIDClans, cClansToRequest);
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00003FE7 File Offset: 0x000021E7
		public static int GetFriendCountFromSource(CSteamID steamIDSource)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetFriendCountFromSource(CSteamAPIContext.GetSteamFriends(), steamIDSource);
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00003FF9 File Offset: 0x000021F9
		public static CSteamID GetFriendFromSourceByIndex(CSteamID steamIDSource, int iFriend)
		{
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamFriends_GetFriendFromSourceByIndex(CSteamAPIContext.GetSteamFriends(), steamIDSource, iFriend);
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00004011 File Offset: 0x00002211
		public static bool IsUserInSource(CSteamID steamIDUser, CSteamID steamIDSource)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_IsUserInSource(CSteamAPIContext.GetSteamFriends(), steamIDUser, steamIDSource);
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00004024 File Offset: 0x00002224
		public static void SetInGameVoiceSpeaking(CSteamID steamIDUser, bool bSpeaking)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamFriends_SetInGameVoiceSpeaking(CSteamAPIContext.GetSteamFriends(), steamIDUser, bSpeaking);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0000BF38 File Offset: 0x0000A138
		public static void ActivateGameOverlay(string pchDialog)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchDialog))
			{
				NativeMethods.ISteamFriends_ActivateGameOverlay(CSteamAPIContext.GetSteamFriends(), utf8StringHandle);
			}
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0000BF78 File Offset: 0x0000A178
		public static void ActivateGameOverlayToUser(string pchDialog, CSteamID steamID)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchDialog))
			{
				NativeMethods.ISteamFriends_ActivateGameOverlayToUser(CSteamAPIContext.GetSteamFriends(), utf8StringHandle, steamID);
			}
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0000BFBC File Offset: 0x0000A1BC
		public static void ActivateGameOverlayToWebPage(string pchURL)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchURL))
			{
				NativeMethods.ISteamFriends_ActivateGameOverlayToWebPage(CSteamAPIContext.GetSteamFriends(), utf8StringHandle);
			}
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00004037 File Offset: 0x00002237
		public static void ActivateGameOverlayToStore(AppId_t nAppID, EOverlayToStoreFlag eFlag)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamFriends_ActivateGameOverlayToStore(CSteamAPIContext.GetSteamFriends(), nAppID, eFlag);
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0000404A File Offset: 0x0000224A
		public static void SetPlayedWith(CSteamID steamIDUserPlayedWith)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamFriends_SetPlayedWith(CSteamAPIContext.GetSteamFriends(), steamIDUserPlayedWith);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0000405C File Offset: 0x0000225C
		public static void ActivateGameOverlayInviteDialog(CSteamID steamIDLobby)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamFriends_ActivateGameOverlayInviteDialog(CSteamAPIContext.GetSteamFriends(), steamIDLobby);
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0000406E File Offset: 0x0000226E
		public static int GetSmallFriendAvatar(CSteamID steamIDFriend)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetSmallFriendAvatar(CSteamAPIContext.GetSteamFriends(), steamIDFriend);
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00004080 File Offset: 0x00002280
		public static int GetMediumFriendAvatar(CSteamID steamIDFriend)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetMediumFriendAvatar(CSteamAPIContext.GetSteamFriends(), steamIDFriend);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00004092 File Offset: 0x00002292
		public static int GetLargeFriendAvatar(CSteamID steamIDFriend)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetLargeFriendAvatar(CSteamAPIContext.GetSteamFriends(), steamIDFriend);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x000040A4 File Offset: 0x000022A4
		public static bool RequestUserInformation(CSteamID steamIDUser, bool bRequireNameOnly)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_RequestUserInformation(CSteamAPIContext.GetSteamFriends(), steamIDUser, bRequireNameOnly);
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x000040B7 File Offset: 0x000022B7
		public static SteamAPICall_t RequestClanOfficerList(CSteamID steamIDClan)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamFriends_RequestClanOfficerList(CSteamAPIContext.GetSteamFriends(), steamIDClan);
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x000040CE File Offset: 0x000022CE
		public static CSteamID GetClanOwner(CSteamID steamIDClan)
		{
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamFriends_GetClanOwner(CSteamAPIContext.GetSteamFriends(), steamIDClan);
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x000040E5 File Offset: 0x000022E5
		public static int GetClanOfficerCount(CSteamID steamIDClan)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetClanOfficerCount(CSteamAPIContext.GetSteamFriends(), steamIDClan);
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x000040F7 File Offset: 0x000022F7
		public static CSteamID GetClanOfficerByIndex(CSteamID steamIDClan, int iOfficer)
		{
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamFriends_GetClanOfficerByIndex(CSteamAPIContext.GetSteamFriends(), steamIDClan, iOfficer);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0000410F File Offset: 0x0000230F
		public static uint GetUserRestrictions()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetUserRestrictions(CSteamAPIContext.GetSteamFriends());
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0000BFFC File Offset: 0x0000A1FC
		public static bool SetRichPresence(string pchKey, string pchValue)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchKey))
			{
				using (InteropHelp.UTF8StringHandle utf8StringHandle2 = new InteropHelp.UTF8StringHandle(pchValue))
				{
					result = NativeMethods.ISteamFriends_SetRichPresence(CSteamAPIContext.GetSteamFriends(), utf8StringHandle, utf8StringHandle2);
				}
			}
			return result;
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00004120 File Offset: 0x00002320
		public static void ClearRichPresence()
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamFriends_ClearRichPresence(CSteamAPIContext.GetSteamFriends());
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0000C05C File Offset: 0x0000A25C
		public static string GetFriendRichPresence(CSteamID steamIDFriend, string pchKey)
		{
			InteropHelp.TestIfAvailableClient();
			string result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchKey))
			{
				result = InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetFriendRichPresence(CSteamAPIContext.GetSteamFriends(), steamIDFriend, utf8StringHandle));
			}
			return result;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00004131 File Offset: 0x00002331
		public static int GetFriendRichPresenceKeyCount(CSteamID steamIDFriend)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetFriendRichPresenceKeyCount(CSteamAPIContext.GetSteamFriends(), steamIDFriend);
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00004143 File Offset: 0x00002343
		public static string GetFriendRichPresenceKeyByIndex(CSteamID steamIDFriend, int iKey)
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetFriendRichPresenceKeyByIndex(CSteamAPIContext.GetSteamFriends(), steamIDFriend, iKey));
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0000415B File Offset: 0x0000235B
		public static void RequestFriendRichPresence(CSteamID steamIDFriend)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamFriends_RequestFriendRichPresence(CSteamAPIContext.GetSteamFriends(), steamIDFriend);
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0000C0A4 File Offset: 0x0000A2A4
		public static bool InviteUserToGame(CSteamID steamIDFriend, string pchConnectString)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchConnectString))
			{
				result = NativeMethods.ISteamFriends_InviteUserToGame(CSteamAPIContext.GetSteamFriends(), steamIDFriend, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0000416D File Offset: 0x0000236D
		public static int GetCoplayFriendCount()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetCoplayFriendCount(CSteamAPIContext.GetSteamFriends());
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x0000417E File Offset: 0x0000237E
		public static CSteamID GetCoplayFriend(int iCoplayFriend)
		{
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamFriends_GetCoplayFriend(CSteamAPIContext.GetSteamFriends(), iCoplayFriend);
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00004195 File Offset: 0x00002395
		public static int GetFriendCoplayTime(CSteamID steamIDFriend)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetFriendCoplayTime(CSteamAPIContext.GetSteamFriends(), steamIDFriend);
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x000041A7 File Offset: 0x000023A7
		public static AppId_t GetFriendCoplayGame(CSteamID steamIDFriend)
		{
			InteropHelp.TestIfAvailableClient();
			return (AppId_t)NativeMethods.ISteamFriends_GetFriendCoplayGame(CSteamAPIContext.GetSteamFriends(), steamIDFriend);
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x000041BE File Offset: 0x000023BE
		public static SteamAPICall_t JoinClanChatRoom(CSteamID steamIDClan)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamFriends_JoinClanChatRoom(CSteamAPIContext.GetSteamFriends(), steamIDClan);
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x000041D5 File Offset: 0x000023D5
		public static bool LeaveClanChatRoom(CSteamID steamIDClan)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_LeaveClanChatRoom(CSteamAPIContext.GetSteamFriends(), steamIDClan);
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x000041E7 File Offset: 0x000023E7
		public static int GetClanChatMemberCount(CSteamID steamIDClan)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetClanChatMemberCount(CSteamAPIContext.GetSteamFriends(), steamIDClan);
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x000041F9 File Offset: 0x000023F9
		public static CSteamID GetChatMemberByIndex(CSteamID steamIDClan, int iUser)
		{
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamFriends_GetChatMemberByIndex(CSteamAPIContext.GetSteamFriends(), steamIDClan, iUser);
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x0000C0E8 File Offset: 0x0000A2E8
		public static bool SendClanChatMessage(CSteamID steamIDClanChat, string pchText)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchText))
			{
				result = NativeMethods.ISteamFriends_SendClanChatMessage(CSteamAPIContext.GetSteamFriends(), steamIDClanChat, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0000C12C File Offset: 0x0000A32C
		public static int GetClanChatMessage(CSteamID steamIDClanChat, int iMessage, out string prgchText, int cchTextMax, out EChatEntryType peChatEntryType, out CSteamID psteamidChatter)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal(cchTextMax);
			int num = NativeMethods.ISteamFriends_GetClanChatMessage(CSteamAPIContext.GetSteamFriends(), steamIDClanChat, iMessage, intPtr, cchTextMax, out peChatEntryType, out psteamidChatter);
			prgchText = ((num != 0) ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return num;
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00004211 File Offset: 0x00002411
		public static bool IsClanChatAdmin(CSteamID steamIDClanChat, CSteamID steamIDUser)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_IsClanChatAdmin(CSteamAPIContext.GetSteamFriends(), steamIDClanChat, steamIDUser);
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00004224 File Offset: 0x00002424
		public static bool IsClanChatWindowOpenInSteam(CSteamID steamIDClanChat)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_IsClanChatWindowOpenInSteam(CSteamAPIContext.GetSteamFriends(), steamIDClanChat);
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00004236 File Offset: 0x00002436
		public static bool OpenClanChatWindowInSteam(CSteamID steamIDClanChat)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_OpenClanChatWindowInSteam(CSteamAPIContext.GetSteamFriends(), steamIDClanChat);
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00004248 File Offset: 0x00002448
		public static bool CloseClanChatWindowInSteam(CSteamID steamIDClanChat)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_CloseClanChatWindowInSteam(CSteamAPIContext.GetSteamFriends(), steamIDClanChat);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0000425A File Offset: 0x0000245A
		public static bool SetListenForFriendsMessages(bool bInterceptEnabled)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_SetListenForFriendsMessages(CSteamAPIContext.GetSteamFriends(), bInterceptEnabled);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0000C170 File Offset: 0x0000A370
		public static bool ReplyToFriendMessage(CSteamID steamIDFriend, string pchMsgToSend)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchMsgToSend))
			{
				result = NativeMethods.ISteamFriends_ReplyToFriendMessage(CSteamAPIContext.GetSteamFriends(), steamIDFriend, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x0000C1B4 File Offset: 0x0000A3B4
		public static int GetFriendMessage(CSteamID steamIDFriend, int iMessageID, out string pvData, int cubData, out EChatEntryType peChatEntryType)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal(cubData);
			int num = NativeMethods.ISteamFriends_GetFriendMessage(CSteamAPIContext.GetSteamFriends(), steamIDFriend, iMessageID, intPtr, cubData, out peChatEntryType);
			pvData = ((num != 0) ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return num;
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0000426C File Offset: 0x0000246C
		public static SteamAPICall_t GetFollowerCount(CSteamID steamID)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamFriends_GetFollowerCount(CSteamAPIContext.GetSteamFriends(), steamID);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00004283 File Offset: 0x00002483
		public static SteamAPICall_t IsFollowing(CSteamID steamID)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamFriends_IsFollowing(CSteamAPIContext.GetSteamFriends(), steamID);
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0000429A File Offset: 0x0000249A
		public static SteamAPICall_t EnumerateFollowingList(uint unStartIndex)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamFriends_EnumerateFollowingList(CSteamAPIContext.GetSteamFriends(), unStartIndex);
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x000042B1 File Offset: 0x000024B1
		public static bool IsClanPublic(CSteamID steamIDClan)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_IsClanPublic(CSteamAPIContext.GetSteamFriends(), steamIDClan);
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x000042C3 File Offset: 0x000024C3
		public static bool IsClanOfficialGameGroup(CSteamID steamIDClan)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_IsClanOfficialGameGroup(CSteamAPIContext.GetSteamFriends(), steamIDClan);
		}
	}
}
