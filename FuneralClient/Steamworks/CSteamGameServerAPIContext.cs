using System;

namespace Steamworks2
{
	// Token: 0x0200002A RID: 42
	internal static class CSteamGameServerAPIContext
	{
		// Token: 0x060000AC RID: 172 RVA: 0x0000AAC0 File Offset: 0x00008CC0
		internal static void Clear()
		{
			CSteamGameServerAPIContext.m_pSteamClient = IntPtr.Zero;
			CSteamGameServerAPIContext.m_pSteamGameServer = IntPtr.Zero;
			CSteamGameServerAPIContext.m_pSteamUtils = IntPtr.Zero;
			CSteamGameServerAPIContext.m_pSteamNetworking = IntPtr.Zero;
			CSteamGameServerAPIContext.m_pSteamGameServerStats = IntPtr.Zero;
			CSteamGameServerAPIContext.m_pSteamHTTP = IntPtr.Zero;
			CSteamGameServerAPIContext.m_pSteamInventory = IntPtr.Zero;
			CSteamGameServerAPIContext.m_pSteamUGC = IntPtr.Zero;
			CSteamGameServerAPIContext.m_pSteamApps = IntPtr.Zero;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000AB28 File Offset: 0x00008D28
		internal static bool Init()
		{
			HSteamUser hsteamUser = GameServer.GetHSteamUser();
			HSteamPipe hsteamPipe = GameServer.GetHSteamPipe();
			if (hsteamPipe == (HSteamPipe)0)
			{
				return false;
			}
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle("SteamClient017"))
			{
				CSteamGameServerAPIContext.m_pSteamClient = NativeMethods.SteamInternal_CreateInterface(utf8StringHandle);
			}
			if (CSteamGameServerAPIContext.m_pSteamClient == IntPtr.Zero)
			{
				return false;
			}
			CSteamGameServerAPIContext.m_pSteamGameServer = SteamGameServerClient.GetISteamGameServer(hsteamUser, hsteamPipe, "SteamGameServer012");
			if (CSteamGameServerAPIContext.m_pSteamGameServer == IntPtr.Zero)
			{
				return false;
			}
			CSteamGameServerAPIContext.m_pSteamUtils = SteamGameServerClient.GetISteamUtils(hsteamPipe, "SteamUtils009");
			if (CSteamGameServerAPIContext.m_pSteamUtils == IntPtr.Zero)
			{
				return false;
			}
			CSteamGameServerAPIContext.m_pSteamNetworking = SteamGameServerClient.GetISteamNetworking(hsteamUser, hsteamPipe, "SteamNetworking005");
			if (CSteamGameServerAPIContext.m_pSteamNetworking == IntPtr.Zero)
			{
				return false;
			}
			CSteamGameServerAPIContext.m_pSteamGameServerStats = SteamGameServerClient.GetISteamGameServerStats(hsteamUser, hsteamPipe, "SteamGameServerStats001");
			if (CSteamGameServerAPIContext.m_pSteamGameServerStats == IntPtr.Zero)
			{
				return false;
			}
			CSteamGameServerAPIContext.m_pSteamHTTP = SteamGameServerClient.GetISteamHTTP(hsteamUser, hsteamPipe, "STEAMHTTP_INTERFACE_VERSION002");
			if (CSteamGameServerAPIContext.m_pSteamHTTP == IntPtr.Zero)
			{
				return false;
			}
			CSteamGameServerAPIContext.m_pSteamInventory = SteamGameServerClient.GetISteamInventory(hsteamUser, hsteamPipe, "STEAMINVENTORY_INTERFACE_V002");
			if (CSteamGameServerAPIContext.m_pSteamInventory == IntPtr.Zero)
			{
				return false;
			}
			CSteamGameServerAPIContext.m_pSteamUGC = SteamGameServerClient.GetISteamUGC(hsteamUser, hsteamPipe, "STEAMUGC_INTERFACE_VERSION010");
			if (CSteamGameServerAPIContext.m_pSteamUGC == IntPtr.Zero)
			{
				return false;
			}
			CSteamGameServerAPIContext.m_pSteamApps = SteamGameServerClient.GetISteamApps(hsteamUser, hsteamPipe, "STEAMAPPS_INTERFACE_VERSION008");
			return !(CSteamGameServerAPIContext.m_pSteamApps == IntPtr.Zero);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000026F7 File Offset: 0x000008F7
		internal static IntPtr GetSteamClient()
		{
			return CSteamGameServerAPIContext.m_pSteamClient;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000026FE File Offset: 0x000008FE
		internal static IntPtr GetSteamGameServer()
		{
			return CSteamGameServerAPIContext.m_pSteamGameServer;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002705 File Offset: 0x00000905
		internal static IntPtr GetSteamUtils()
		{
			return CSteamGameServerAPIContext.m_pSteamUtils;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000270C File Offset: 0x0000090C
		internal static IntPtr GetSteamNetworking()
		{
			return CSteamGameServerAPIContext.m_pSteamNetworking;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002713 File Offset: 0x00000913
		internal static IntPtr GetSteamGameServerStats()
		{
			return CSteamGameServerAPIContext.m_pSteamGameServerStats;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000271A File Offset: 0x0000091A
		internal static IntPtr GetSteamHTTP()
		{
			return CSteamGameServerAPIContext.m_pSteamHTTP;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002721 File Offset: 0x00000921
		internal static IntPtr GetSteamInventory()
		{
			return CSteamGameServerAPIContext.m_pSteamInventory;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002728 File Offset: 0x00000928
		internal static IntPtr GetSteamUGC()
		{
			return CSteamGameServerAPIContext.m_pSteamUGC;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000272F File Offset: 0x0000092F
		internal static IntPtr GetSteamApps()
		{
			return CSteamGameServerAPIContext.m_pSteamApps;
		}

		// Token: 0x0400011B RID: 283
		private static IntPtr m_pSteamClient;

		// Token: 0x0400011C RID: 284
		private static IntPtr m_pSteamGameServer;

		// Token: 0x0400011D RID: 285
		private static IntPtr m_pSteamUtils;

		// Token: 0x0400011E RID: 286
		private static IntPtr m_pSteamNetworking;

		// Token: 0x0400011F RID: 287
		private static IntPtr m_pSteamGameServerStats;

		// Token: 0x04000120 RID: 288
		private static IntPtr m_pSteamHTTP;

		// Token: 0x04000121 RID: 289
		private static IntPtr m_pSteamInventory;

		// Token: 0x04000122 RID: 290
		private static IntPtr m_pSteamUGC;

		// Token: 0x04000123 RID: 291
		private static IntPtr m_pSteamApps;
	}
}
