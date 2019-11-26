using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200016F RID: 367
	public static class SteamMatchmakingServers
	{
		// Token: 0x060007B7 RID: 1975 RVA: 0x00005C82 File Offset: 0x00003E82
		public static HServerListRequest RequestInternetServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			InteropHelp.TestIfAvailableClient();
			return (HServerListRequest)NativeMethods.ISteamMatchmakingServers_RequestInternetServerList(CSteamAPIContext.GetSteamMatchmakingServers(), iApp, new MMKVPMarshaller(ppchFilters), nFilters, (IntPtr)pRequestServersResponse);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00005CAB File Offset: 0x00003EAB
		public static HServerListRequest RequestLANServerList(AppId_t iApp, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			InteropHelp.TestIfAvailableClient();
			return (HServerListRequest)NativeMethods.ISteamMatchmakingServers_RequestLANServerList(CSteamAPIContext.GetSteamMatchmakingServers(), iApp, (IntPtr)pRequestServersResponse);
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00005CC8 File Offset: 0x00003EC8
		public static HServerListRequest RequestFriendsServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			InteropHelp.TestIfAvailableClient();
			return (HServerListRequest)NativeMethods.ISteamMatchmakingServers_RequestFriendsServerList(CSteamAPIContext.GetSteamMatchmakingServers(), iApp, new MMKVPMarshaller(ppchFilters), nFilters, (IntPtr)pRequestServersResponse);
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00005CF1 File Offset: 0x00003EF1
		public static HServerListRequest RequestFavoritesServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			InteropHelp.TestIfAvailableClient();
			return (HServerListRequest)NativeMethods.ISteamMatchmakingServers_RequestFavoritesServerList(CSteamAPIContext.GetSteamMatchmakingServers(), iApp, new MMKVPMarshaller(ppchFilters), nFilters, (IntPtr)pRequestServersResponse);
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00005D1A File Offset: 0x00003F1A
		public static HServerListRequest RequestHistoryServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			InteropHelp.TestIfAvailableClient();
			return (HServerListRequest)NativeMethods.ISteamMatchmakingServers_RequestHistoryServerList(CSteamAPIContext.GetSteamMatchmakingServers(), iApp, new MMKVPMarshaller(ppchFilters), nFilters, (IntPtr)pRequestServersResponse);
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00005D43 File Offset: 0x00003F43
		public static HServerListRequest RequestSpectatorServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			InteropHelp.TestIfAvailableClient();
			return (HServerListRequest)NativeMethods.ISteamMatchmakingServers_RequestSpectatorServerList(CSteamAPIContext.GetSteamMatchmakingServers(), iApp, new MMKVPMarshaller(ppchFilters), nFilters, (IntPtr)pRequestServersResponse);
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00005D6C File Offset: 0x00003F6C
		public static void ReleaseRequest(HServerListRequest hServerListRequest)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmakingServers_ReleaseRequest(CSteamAPIContext.GetSteamMatchmakingServers(), hServerListRequest);
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00005D7E File Offset: 0x00003F7E
		public static gameserveritem_t GetServerDetails(HServerListRequest hRequest, int iServer)
		{
			InteropHelp.TestIfAvailableClient();
			return (gameserveritem_t)Marshal.PtrToStructure(NativeMethods.ISteamMatchmakingServers_GetServerDetails(CSteamAPIContext.GetSteamMatchmakingServers(), hRequest, iServer), typeof(gameserveritem_t));
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00005DA5 File Offset: 0x00003FA5
		public static void CancelQuery(HServerListRequest hRequest)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmakingServers_CancelQuery(CSteamAPIContext.GetSteamMatchmakingServers(), hRequest);
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00005DB7 File Offset: 0x00003FB7
		public static void RefreshQuery(HServerListRequest hRequest)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmakingServers_RefreshQuery(CSteamAPIContext.GetSteamMatchmakingServers(), hRequest);
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00005DC9 File Offset: 0x00003FC9
		public static bool IsRefreshing(HServerListRequest hRequest)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmakingServers_IsRefreshing(CSteamAPIContext.GetSteamMatchmakingServers(), hRequest);
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x00005DDB File Offset: 0x00003FDB
		public static int GetServerCount(HServerListRequest hRequest)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmakingServers_GetServerCount(CSteamAPIContext.GetSteamMatchmakingServers(), hRequest);
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x00005DED File Offset: 0x00003FED
		public static void RefreshServer(HServerListRequest hRequest, int iServer)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmakingServers_RefreshServer(CSteamAPIContext.GetSteamMatchmakingServers(), hRequest, iServer);
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00005E00 File Offset: 0x00004000
		public static HServerQuery PingServer(uint unIP, ushort usPort, ISteamMatchmakingPingResponse pRequestServersResponse)
		{
			InteropHelp.TestIfAvailableClient();
			return (HServerQuery)NativeMethods.ISteamMatchmakingServers_PingServer(CSteamAPIContext.GetSteamMatchmakingServers(), unIP, usPort, (IntPtr)pRequestServersResponse);
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00005E1E File Offset: 0x0000401E
		public static HServerQuery PlayerDetails(uint unIP, ushort usPort, ISteamMatchmakingPlayersResponse pRequestServersResponse)
		{
			InteropHelp.TestIfAvailableClient();
			return (HServerQuery)NativeMethods.ISteamMatchmakingServers_PlayerDetails(CSteamAPIContext.GetSteamMatchmakingServers(), unIP, usPort, (IntPtr)pRequestServersResponse);
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00005E3C File Offset: 0x0000403C
		public static HServerQuery ServerRules(uint unIP, ushort usPort, ISteamMatchmakingRulesResponse pRequestServersResponse)
		{
			InteropHelp.TestIfAvailableClient();
			return (HServerQuery)NativeMethods.ISteamMatchmakingServers_ServerRules(CSteamAPIContext.GetSteamMatchmakingServers(), unIP, usPort, (IntPtr)pRequestServersResponse);
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00005E5A File Offset: 0x0000405A
		public static void CancelServerQuery(HServerQuery hServerQuery)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmakingServers_CancelServerQuery(CSteamAPIContext.GetSteamMatchmakingServers(), hServerQuery);
		}
	}
}
