using System;

namespace Steamworks2
{
	// Token: 0x02000172 RID: 370
	public static class SteamNetworking
	{
		// Token: 0x060007F1 RID: 2033 RVA: 0x000060E4 File Offset: 0x000042E4
		public static bool SendP2PPacket(CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel = 0)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_SendP2PPacket(CSteamAPIContext.GetSteamNetworking(), steamIDRemote, pubData, cubData, eP2PSendType, nChannel);
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x000060FB File Offset: 0x000042FB
		public static bool IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel = 0)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_IsP2PPacketAvailable(CSteamAPIContext.GetSteamNetworking(), out pcubMsgSize, nChannel);
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x0000610E File Offset: 0x0000430E
		public static bool ReadP2PPacket(byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel = 0)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_ReadP2PPacket(CSteamAPIContext.GetSteamNetworking(), pubDest, cubDest, out pcubMsgSize, out psteamIDRemote, nChannel);
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00006125 File Offset: 0x00004325
		public static bool AcceptP2PSessionWithUser(CSteamID steamIDRemote)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_AcceptP2PSessionWithUser(CSteamAPIContext.GetSteamNetworking(), steamIDRemote);
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00006137 File Offset: 0x00004337
		public static bool CloseP2PSessionWithUser(CSteamID steamIDRemote)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_CloseP2PSessionWithUser(CSteamAPIContext.GetSteamNetworking(), steamIDRemote);
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00006149 File Offset: 0x00004349
		public static bool CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_CloseP2PChannelWithUser(CSteamAPIContext.GetSteamNetworking(), steamIDRemote, nChannel);
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x0000615C File Offset: 0x0000435C
		public static bool GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_GetP2PSessionState(CSteamAPIContext.GetSteamNetworking(), steamIDRemote, out pConnectionState);
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x0000616F File Offset: 0x0000436F
		public static bool AllowP2PPacketRelay(bool bAllow)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_AllowP2PPacketRelay(CSteamAPIContext.GetSteamNetworking(), bAllow);
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00006181 File Offset: 0x00004381
		public static SNetListenSocket_t CreateListenSocket(int nVirtualP2PPort, uint nIP, ushort nPort, bool bAllowUseOfPacketRelay)
		{
			InteropHelp.TestIfAvailableClient();
			return (SNetListenSocket_t)NativeMethods.ISteamNetworking_CreateListenSocket(CSteamAPIContext.GetSteamNetworking(), nVirtualP2PPort, nIP, nPort, bAllowUseOfPacketRelay);
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x0000619B File Offset: 0x0000439B
		public static SNetSocket_t CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay)
		{
			InteropHelp.TestIfAvailableClient();
			return (SNetSocket_t)NativeMethods.ISteamNetworking_CreateP2PConnectionSocket(CSteamAPIContext.GetSteamNetworking(), steamIDTarget, nVirtualPort, nTimeoutSec, bAllowUseOfPacketRelay);
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x000061B5 File Offset: 0x000043B5
		public static SNetSocket_t CreateConnectionSocket(uint nIP, ushort nPort, int nTimeoutSec)
		{
			InteropHelp.TestIfAvailableClient();
			return (SNetSocket_t)NativeMethods.ISteamNetworking_CreateConnectionSocket(CSteamAPIContext.GetSteamNetworking(), nIP, nPort, nTimeoutSec);
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x000061CE File Offset: 0x000043CE
		public static bool DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_DestroySocket(CSteamAPIContext.GetSteamNetworking(), hSocket, bNotifyRemoteEnd);
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x000061E1 File Offset: 0x000043E1
		public static bool DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_DestroyListenSocket(CSteamAPIContext.GetSteamNetworking(), hSocket, bNotifyRemoteEnd);
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x000061F4 File Offset: 0x000043F4
		public static bool SendDataOnSocket(SNetSocket_t hSocket, byte[] pubData, uint cubData, bool bReliable)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_SendDataOnSocket(CSteamAPIContext.GetSteamNetworking(), hSocket, pubData, cubData, bReliable);
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00006209 File Offset: 0x00004409
		public static bool IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_IsDataAvailableOnSocket(CSteamAPIContext.GetSteamNetworking(), hSocket, out pcubMsgSize);
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x0000621C File Offset: 0x0000441C
		public static bool RetrieveDataFromSocket(SNetSocket_t hSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_RetrieveDataFromSocket(CSteamAPIContext.GetSteamNetworking(), hSocket, pubDest, cubDest, out pcubMsgSize);
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00006231 File Offset: 0x00004431
		public static bool IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_IsDataAvailable(CSteamAPIContext.GetSteamNetworking(), hListenSocket, out pcubMsgSize, out phSocket);
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00006245 File Offset: 0x00004445
		public static bool RetrieveData(SNetListenSocket_t hListenSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_RetrieveData(CSteamAPIContext.GetSteamNetworking(), hListenSocket, pubDest, cubDest, out pcubMsgSize, out phSocket);
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x0000625C File Offset: 0x0000445C
		public static bool GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out uint punIPRemote, out ushort punPortRemote)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_GetSocketInfo(CSteamAPIContext.GetSteamNetworking(), hSocket, out pSteamIDRemote, out peSocketStatus, out punIPRemote, out punPortRemote);
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00006273 File Offset: 0x00004473
		public static bool GetListenSocketInfo(SNetListenSocket_t hListenSocket, out uint pnIP, out ushort pnPort)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_GetListenSocketInfo(CSteamAPIContext.GetSteamNetworking(), hListenSocket, out pnIP, out pnPort);
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00006287 File Offset: 0x00004487
		public static ESNetSocketConnectionType GetSocketConnectionType(SNetSocket_t hSocket)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_GetSocketConnectionType(CSteamAPIContext.GetSteamNetworking(), hSocket);
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00006299 File Offset: 0x00004499
		public static int GetMaxPacketSize(SNetSocket_t hSocket)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_GetMaxPacketSize(CSteamAPIContext.GetSteamNetworking(), hSocket);
		}
	}
}
