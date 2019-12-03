using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200016E RID: 366
	public static class SteamMatchmaking
	{
		// Token: 0x06000791 RID: 1937 RVA: 0x00005A30 File Offset: 0x00003C30
		public static int GetFavoriteGameCount()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_GetFavoriteGameCount(CSteamAPIContext.GetSteamMatchmaking());
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00005A41 File Offset: 0x00003C41
		public static bool GetFavoriteGame(int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_GetFavoriteGame(CSteamAPIContext.GetSteamMatchmaking(), iGame, out pnAppID, out pnIP, out pnConnPort, out pnQueryPort, out punFlags, out pRTime32LastPlayedOnServer);
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00005A5C File Offset: 0x00003C5C
		public static int AddFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_AddFavoriteGame(CSteamAPIContext.GetSteamMatchmaking(), nAppID, nIP, nConnPort, nQueryPort, unFlags, rTime32LastPlayedOnServer);
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00005A75 File Offset: 0x00003C75
		public static bool RemoveFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_RemoveFavoriteGame(CSteamAPIContext.GetSteamMatchmaking(), nAppID, nIP, nConnPort, nQueryPort, unFlags);
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00005A8C File Offset: 0x00003C8C
		public static SteamAPICall_t RequestLobbyList()
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamMatchmaking_RequestLobbyList(CSteamAPIContext.GetSteamMatchmaking());
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x0000E22C File Offset: 0x0000C42C
		public static void AddRequestLobbyListStringFilter(string pchKeyToMatch, string pchValueToMatch, ELobbyComparison eComparisonType)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchKeyToMatch))
			{
				using (InteropHelp.UTF8StringHandle utf8StringHandle2 = new InteropHelp.UTF8StringHandle(pchValueToMatch))
				{
					NativeMethods.ISteamMatchmaking_AddRequestLobbyListStringFilter(CSteamAPIContext.GetSteamMatchmaking(), utf8StringHandle, utf8StringHandle2, eComparisonType);
				}
			}
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x0000E28C File Offset: 0x0000C48C
		public static void AddRequestLobbyListNumericalFilter(string pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchKeyToMatch))
			{
				NativeMethods.ISteamMatchmaking_AddRequestLobbyListNumericalFilter(CSteamAPIContext.GetSteamMatchmaking(), utf8StringHandle, nValueToMatch, eComparisonType);
			}
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0000E2D0 File Offset: 0x0000C4D0
		public static void AddRequestLobbyListNearValueFilter(string pchKeyToMatch, int nValueToBeCloseTo)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchKeyToMatch))
			{
				NativeMethods.ISteamMatchmaking_AddRequestLobbyListNearValueFilter(CSteamAPIContext.GetSteamMatchmaking(), utf8StringHandle, nValueToBeCloseTo);
			}
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00005AA2 File Offset: 0x00003CA2
		public static void AddRequestLobbyListFilterSlotsAvailable(int nSlotsAvailable)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmaking_AddRequestLobbyListFilterSlotsAvailable(CSteamAPIContext.GetSteamMatchmaking(), nSlotsAvailable);
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00005AB4 File Offset: 0x00003CB4
		public static void AddRequestLobbyListDistanceFilter(ELobbyDistanceFilter eLobbyDistanceFilter)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmaking_AddRequestLobbyListDistanceFilter(CSteamAPIContext.GetSteamMatchmaking(), eLobbyDistanceFilter);
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00005AC6 File Offset: 0x00003CC6
		public static void AddRequestLobbyListResultCountFilter(int cMaxResults)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmaking_AddRequestLobbyListResultCountFilter(CSteamAPIContext.GetSteamMatchmaking(), cMaxResults);
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00005AD8 File Offset: 0x00003CD8
		public static void AddRequestLobbyListCompatibleMembersFilter(CSteamID steamIDLobby)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmaking_AddRequestLobbyListCompatibleMembersFilter(CSteamAPIContext.GetSteamMatchmaking(), steamIDLobby);
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00005AEA File Offset: 0x00003CEA
		public static CSteamID GetLobbyByIndex(int iLobby)
		{
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamMatchmaking_GetLobbyByIndex(CSteamAPIContext.GetSteamMatchmaking(), iLobby);
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00005B01 File Offset: 0x00003D01
		public static SteamAPICall_t CreateLobby(ELobbyType eLobbyType, int cMaxMembers)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamMatchmaking_CreateLobby(CSteamAPIContext.GetSteamMatchmaking(), eLobbyType, cMaxMembers);
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00005B19 File Offset: 0x00003D19
		public static SteamAPICall_t JoinLobby(CSteamID steamIDLobby)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamMatchmaking_JoinLobby(CSteamAPIContext.GetSteamMatchmaking(), steamIDLobby);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00005B30 File Offset: 0x00003D30
		public static void LeaveLobby(CSteamID steamIDLobby)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmaking_LeaveLobby(CSteamAPIContext.GetSteamMatchmaking(), steamIDLobby);
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00005B42 File Offset: 0x00003D42
		public static bool InviteUserToLobby(CSteamID steamIDLobby, CSteamID steamIDInvitee)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_InviteUserToLobby(CSteamAPIContext.GetSteamMatchmaking(), steamIDLobby, steamIDInvitee);
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00005B55 File Offset: 0x00003D55
		public static int GetNumLobbyMembers(CSteamID steamIDLobby)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_GetNumLobbyMembers(CSteamAPIContext.GetSteamMatchmaking(), steamIDLobby);
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00005B67 File Offset: 0x00003D67
		public static CSteamID GetLobbyMemberByIndex(CSteamID steamIDLobby, int iMember)
		{
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamMatchmaking_GetLobbyMemberByIndex(CSteamAPIContext.GetSteamMatchmaking(), steamIDLobby, iMember);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x0000E314 File Offset: 0x0000C514
		public static string GetLobbyData(CSteamID steamIDLobby, string pchKey)
		{
			InteropHelp.TestIfAvailableClient();
			string result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchKey))
			{
				result = InteropHelp.PtrToStringUTF8(NativeMethods.ISteamMatchmaking_GetLobbyData(CSteamAPIContext.GetSteamMatchmaking(), steamIDLobby, utf8StringHandle));
			}
			return result;
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0000E35C File Offset: 0x0000C55C
		public static bool SetLobbyData(CSteamID steamIDLobby, string pchKey, string pchValue)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchKey))
			{
				using (InteropHelp.UTF8StringHandle utf8StringHandle2 = new InteropHelp.UTF8StringHandle(pchValue))
				{
					result = NativeMethods.ISteamMatchmaking_SetLobbyData(CSteamAPIContext.GetSteamMatchmaking(), steamIDLobby, utf8StringHandle, utf8StringHandle2);
				}
			}
			return result;
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00005B7F File Offset: 0x00003D7F
		public static int GetLobbyDataCount(CSteamID steamIDLobby)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_GetLobbyDataCount(CSteamAPIContext.GetSteamMatchmaking(), steamIDLobby);
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0000E3C0 File Offset: 0x0000C5C0
		public static bool GetLobbyDataByIndex(CSteamID steamIDLobby, int iLobbyData, out string pchKey, int cchKeyBufferSize, out string pchValue, int cchValueBufferSize)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal(cchKeyBufferSize);
			IntPtr intPtr2 = Marshal.AllocHGlobal(cchValueBufferSize);
			bool flag = NativeMethods.ISteamMatchmaking_GetLobbyDataByIndex(CSteamAPIContext.GetSteamMatchmaking(), steamIDLobby, iLobbyData, intPtr, cchKeyBufferSize, intPtr2, cchValueBufferSize);
			pchKey = (flag ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			pchValue = (flag ? InteropHelp.PtrToStringUTF8(intPtr2) : null);
			Marshal.FreeHGlobal(intPtr2);
			return flag;
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x0000E420 File Offset: 0x0000C620
		public static bool DeleteLobbyData(CSteamID steamIDLobby, string pchKey)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchKey))
			{
				result = NativeMethods.ISteamMatchmaking_DeleteLobbyData(CSteamAPIContext.GetSteamMatchmaking(), steamIDLobby, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0000E464 File Offset: 0x0000C664
		public static string GetLobbyMemberData(CSteamID steamIDLobby, CSteamID steamIDUser, string pchKey)
		{
			InteropHelp.TestIfAvailableClient();
			string result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchKey))
			{
				result = InteropHelp.PtrToStringUTF8(NativeMethods.ISteamMatchmaking_GetLobbyMemberData(CSteamAPIContext.GetSteamMatchmaking(), steamIDLobby, steamIDUser, utf8StringHandle));
			}
			return result;
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x0000E4B0 File Offset: 0x0000C6B0
		public static void SetLobbyMemberData(CSteamID steamIDLobby, string pchKey, string pchValue)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchKey))
			{
				using (InteropHelp.UTF8StringHandle utf8StringHandle2 = new InteropHelp.UTF8StringHandle(pchValue))
				{
					NativeMethods.ISteamMatchmaking_SetLobbyMemberData(CSteamAPIContext.GetSteamMatchmaking(), steamIDLobby, utf8StringHandle, utf8StringHandle2);
				}
			}
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00005B91 File Offset: 0x00003D91
		public static bool SendLobbyChatMsg(CSteamID steamIDLobby, byte[] pvMsgBody, int cubMsgBody)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_SendLobbyChatMsg(CSteamAPIContext.GetSteamMatchmaking(), steamIDLobby, pvMsgBody, cubMsgBody);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00005BA5 File Offset: 0x00003DA5
		public static int GetLobbyChatEntry(CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, byte[] pvData, int cubData, out EChatEntryType peChatEntryType)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_GetLobbyChatEntry(CSteamAPIContext.GetSteamMatchmaking(), steamIDLobby, iChatID, out pSteamIDUser, pvData, cubData, out peChatEntryType);
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00005BBE File Offset: 0x00003DBE
		public static bool RequestLobbyData(CSteamID steamIDLobby)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_RequestLobbyData(CSteamAPIContext.GetSteamMatchmaking(), steamIDLobby);
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00005BD0 File Offset: 0x00003DD0
		public static void SetLobbyGameServer(CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmaking_SetLobbyGameServer(CSteamAPIContext.GetSteamMatchmaking(), steamIDLobby, unGameServerIP, unGameServerPort, steamIDGameServer);
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00005BE5 File Offset: 0x00003DE5
		public static bool GetLobbyGameServer(CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_GetLobbyGameServer(CSteamAPIContext.GetSteamMatchmaking(), steamIDLobby, out punGameServerIP, out punGameServerPort, out psteamIDGameServer);
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00005BFA File Offset: 0x00003DFA
		public static bool SetLobbyMemberLimit(CSteamID steamIDLobby, int cMaxMembers)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_SetLobbyMemberLimit(CSteamAPIContext.GetSteamMatchmaking(), steamIDLobby, cMaxMembers);
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00005C0D File Offset: 0x00003E0D
		public static int GetLobbyMemberLimit(CSteamID steamIDLobby)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_GetLobbyMemberLimit(CSteamAPIContext.GetSteamMatchmaking(), steamIDLobby);
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00005C1F File Offset: 0x00003E1F
		public static bool SetLobbyType(CSteamID steamIDLobby, ELobbyType eLobbyType)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_SetLobbyType(CSteamAPIContext.GetSteamMatchmaking(), steamIDLobby, eLobbyType);
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00005C32 File Offset: 0x00003E32
		public static bool SetLobbyJoinable(CSteamID steamIDLobby, bool bLobbyJoinable)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_SetLobbyJoinable(CSteamAPIContext.GetSteamMatchmaking(), steamIDLobby, bLobbyJoinable);
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00005C45 File Offset: 0x00003E45
		public static CSteamID GetLobbyOwner(CSteamID steamIDLobby)
		{
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamMatchmaking_GetLobbyOwner(CSteamAPIContext.GetSteamMatchmaking(), steamIDLobby);
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00005C5C File Offset: 0x00003E5C
		public static bool SetLobbyOwner(CSteamID steamIDLobby, CSteamID steamIDNewOwner)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_SetLobbyOwner(CSteamAPIContext.GetSteamMatchmaking(), steamIDLobby, steamIDNewOwner);
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00005C6F File Offset: 0x00003E6F
		public static bool SetLinkedLobby(CSteamID steamIDLobby, CSteamID steamIDLobbyDependent)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_SetLinkedLobby(CSteamAPIContext.GetSteamMatchmaking(), steamIDLobby, steamIDLobbyDependent);
		}
	}
}
