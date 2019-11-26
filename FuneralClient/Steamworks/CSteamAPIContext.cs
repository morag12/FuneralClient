using System;

namespace Steamworks2
{
	// Token: 0x02000029 RID: 41
	internal static class CSteamAPIContext
	{
		// Token: 0x06000095 RID: 149 RVA: 0x0000A698 File Offset: 0x00008898
		internal static void Clear()
		{
			CSteamAPIContext.m_pSteamClient = IntPtr.Zero;
			CSteamAPIContext.m_pSteamUser = IntPtr.Zero;
			CSteamAPIContext.m_pSteamFriends = IntPtr.Zero;
			CSteamAPIContext.m_pSteamUtils = IntPtr.Zero;
			CSteamAPIContext.m_pSteamMatchmaking = IntPtr.Zero;
			CSteamAPIContext.m_pSteamUserStats = IntPtr.Zero;
			CSteamAPIContext.m_pSteamApps = IntPtr.Zero;
			CSteamAPIContext.m_pSteamMatchmakingServers = IntPtr.Zero;
			CSteamAPIContext.m_pSteamNetworking = IntPtr.Zero;
			CSteamAPIContext.m_pSteamRemoteStorage = IntPtr.Zero;
			CSteamAPIContext.m_pSteamHTTP = IntPtr.Zero;
			CSteamAPIContext.m_pSteamScreenshots = IntPtr.Zero;
			CSteamAPIContext.m_pSteamMusic = IntPtr.Zero;
			CSteamAPIContext.m_pController = IntPtr.Zero;
			CSteamAPIContext.m_pSteamUGC = IntPtr.Zero;
			CSteamAPIContext.m_pSteamAppList = IntPtr.Zero;
			CSteamAPIContext.m_pSteamMusic = IntPtr.Zero;
			CSteamAPIContext.m_pSteamMusicRemote = IntPtr.Zero;
			CSteamAPIContext.m_pSteamHTMLSurface = IntPtr.Zero;
			CSteamAPIContext.m_pSteamInventory = IntPtr.Zero;
			CSteamAPIContext.m_pSteamVideo = IntPtr.Zero;
			CSteamAPIContext.m_pSteamParentalSettings = IntPtr.Zero;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000A784 File Offset: 0x00008984
		internal static bool Init()
		{
			HSteamUser hsteamUser = SteamAPI.GetHSteamUser();
			HSteamPipe hsteamPipe = SteamAPI.GetHSteamPipe();
			if (hsteamPipe == (HSteamPipe)0)
			{
				return false;
			}
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle("SteamClient017"))
			{
				CSteamAPIContext.m_pSteamClient = NativeMethods.SteamInternal_CreateInterface(utf8StringHandle);
			}
			if (CSteamAPIContext.m_pSteamClient == IntPtr.Zero)
			{
				return false;
			}
			CSteamAPIContext.m_pSteamUser = SteamClient.GetISteamUser(hsteamUser, hsteamPipe, "SteamUser019");
			if (CSteamAPIContext.m_pSteamUser == IntPtr.Zero)
			{
				return false;
			}
			CSteamAPIContext.m_pSteamFriends = SteamClient.GetISteamFriends(hsteamUser, hsteamPipe, "SteamFriends015");
			if (CSteamAPIContext.m_pSteamFriends == IntPtr.Zero)
			{
				return false;
			}
			CSteamAPIContext.m_pSteamUtils = SteamClient.GetISteamUtils(hsteamPipe, "SteamUtils009");
			if (CSteamAPIContext.m_pSteamUtils == IntPtr.Zero)
			{
				return false;
			}
			CSteamAPIContext.m_pSteamMatchmaking = SteamClient.GetISteamMatchmaking(hsteamUser, hsteamPipe, "SteamMatchMaking009");
			if (CSteamAPIContext.m_pSteamMatchmaking == IntPtr.Zero)
			{
				return false;
			}
			CSteamAPIContext.m_pSteamMatchmakingServers = SteamClient.GetISteamMatchmakingServers(hsteamUser, hsteamPipe, "SteamMatchMakingServers002");
			if (CSteamAPIContext.m_pSteamMatchmakingServers == IntPtr.Zero)
			{
				return false;
			}
			CSteamAPIContext.m_pSteamUserStats = SteamClient.GetISteamUserStats(hsteamUser, hsteamPipe, "STEAMUSERSTATS_INTERFACE_VERSION011");
			if (CSteamAPIContext.m_pSteamUserStats == IntPtr.Zero)
			{
				return false;
			}
			CSteamAPIContext.m_pSteamApps = SteamClient.GetISteamApps(hsteamUser, hsteamPipe, "STEAMAPPS_INTERFACE_VERSION008");
			if (CSteamAPIContext.m_pSteamApps == IntPtr.Zero)
			{
				return false;
			}
			CSteamAPIContext.m_pSteamNetworking = SteamClient.GetISteamNetworking(hsteamUser, hsteamPipe, "SteamNetworking005");
			if (CSteamAPIContext.m_pSteamNetworking == IntPtr.Zero)
			{
				return false;
			}
			CSteamAPIContext.m_pSteamRemoteStorage = SteamClient.GetISteamRemoteStorage(hsteamUser, hsteamPipe, "STEAMREMOTESTORAGE_INTERFACE_VERSION014");
			if (CSteamAPIContext.m_pSteamRemoteStorage == IntPtr.Zero)
			{
				return false;
			}
			CSteamAPIContext.m_pSteamScreenshots = SteamClient.GetISteamScreenshots(hsteamUser, hsteamPipe, "STEAMSCREENSHOTS_INTERFACE_VERSION003");
			if (CSteamAPIContext.m_pSteamScreenshots == IntPtr.Zero)
			{
				return false;
			}
			CSteamAPIContext.m_pSteamHTTP = SteamClient.GetISteamHTTP(hsteamUser, hsteamPipe, "STEAMHTTP_INTERFACE_VERSION002");
			if (CSteamAPIContext.m_pSteamHTTP == IntPtr.Zero)
			{
				return false;
			}
			CSteamAPIContext.m_pController = SteamClient.GetISteamController(hsteamUser, hsteamPipe, "SteamController006");
			if (CSteamAPIContext.m_pController == IntPtr.Zero)
			{
				return false;
			}
			CSteamAPIContext.m_pSteamUGC = SteamClient.GetISteamUGC(hsteamUser, hsteamPipe, "STEAMUGC_INTERFACE_VERSION010");
			if (CSteamAPIContext.m_pSteamUGC == IntPtr.Zero)
			{
				return false;
			}
			CSteamAPIContext.m_pSteamAppList = SteamClient.GetISteamAppList(hsteamUser, hsteamPipe, "STEAMAPPLIST_INTERFACE_VERSION001");
			if (CSteamAPIContext.m_pSteamAppList == IntPtr.Zero)
			{
				return false;
			}
			CSteamAPIContext.m_pSteamMusic = SteamClient.GetISteamMusic(hsteamUser, hsteamPipe, "STEAMMUSIC_INTERFACE_VERSION001");
			if (CSteamAPIContext.m_pSteamMusic == IntPtr.Zero)
			{
				return false;
			}
			CSteamAPIContext.m_pSteamMusicRemote = SteamClient.GetISteamMusicRemote(hsteamUser, hsteamPipe, "STEAMMUSICREMOTE_INTERFACE_VERSION001");
			if (CSteamAPIContext.m_pSteamMusicRemote == IntPtr.Zero)
			{
				return false;
			}
			CSteamAPIContext.m_pSteamHTMLSurface = SteamClient.GetISteamHTMLSurface(hsteamUser, hsteamPipe, "STEAMHTMLSURFACE_INTERFACE_VERSION_004");
			if (CSteamAPIContext.m_pSteamHTMLSurface == IntPtr.Zero)
			{
				return false;
			}
			CSteamAPIContext.m_pSteamInventory = SteamClient.GetISteamInventory(hsteamUser, hsteamPipe, "STEAMINVENTORY_INTERFACE_V002");
			if (CSteamAPIContext.m_pSteamInventory == IntPtr.Zero)
			{
				return false;
			}
			CSteamAPIContext.m_pSteamVideo = SteamClient.GetISteamVideo(hsteamUser, hsteamPipe, "STEAMVIDEO_INTERFACE_V002");
			if (CSteamAPIContext.m_pSteamVideo == IntPtr.Zero)
			{
				return false;
			}
			CSteamAPIContext.m_pSteamParentalSettings = SteamClient.GetISteamParentalSettings(hsteamUser, hsteamPipe, "STEAMPARENTALSETTINGS_INTERFACE_VERSION001");
			return !(CSteamAPIContext.m_pSteamParentalSettings == IntPtr.Zero);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002664 File Offset: 0x00000864
		internal static IntPtr GetSteamClient()
		{
			return CSteamAPIContext.m_pSteamClient;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000266B File Offset: 0x0000086B
		internal static IntPtr GetSteamUser()
		{
			return CSteamAPIContext.m_pSteamUser;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002672 File Offset: 0x00000872
		internal static IntPtr GetSteamFriends()
		{
			return CSteamAPIContext.m_pSteamFriends;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002679 File Offset: 0x00000879
		internal static IntPtr GetSteamUtils()
		{
			return CSteamAPIContext.m_pSteamUtils;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002680 File Offset: 0x00000880
		internal static IntPtr GetSteamMatchmaking()
		{
			return CSteamAPIContext.m_pSteamMatchmaking;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002687 File Offset: 0x00000887
		internal static IntPtr GetSteamUserStats()
		{
			return CSteamAPIContext.m_pSteamUserStats;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000268E File Offset: 0x0000088E
		internal static IntPtr GetSteamApps()
		{
			return CSteamAPIContext.m_pSteamApps;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002695 File Offset: 0x00000895
		internal static IntPtr GetSteamMatchmakingServers()
		{
			return CSteamAPIContext.m_pSteamMatchmakingServers;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000269C File Offset: 0x0000089C
		internal static IntPtr GetSteamNetworking()
		{
			return CSteamAPIContext.m_pSteamNetworking;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000026A3 File Offset: 0x000008A3
		internal static IntPtr GetSteamRemoteStorage()
		{
			return CSteamAPIContext.m_pSteamRemoteStorage;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000026AA File Offset: 0x000008AA
		internal static IntPtr GetSteamScreenshots()
		{
			return CSteamAPIContext.m_pSteamScreenshots;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000026B1 File Offset: 0x000008B1
		internal static IntPtr GetSteamHTTP()
		{
			return CSteamAPIContext.m_pSteamHTTP;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000026B8 File Offset: 0x000008B8
		internal static IntPtr GetSteamController()
		{
			return CSteamAPIContext.m_pController;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000026BF File Offset: 0x000008BF
		internal static IntPtr GetSteamUGC()
		{
			return CSteamAPIContext.m_pSteamUGC;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000026C6 File Offset: 0x000008C6
		internal static IntPtr GetSteamAppList()
		{
			return CSteamAPIContext.m_pSteamAppList;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000026CD File Offset: 0x000008CD
		internal static IntPtr GetSteamMusic()
		{
			return CSteamAPIContext.m_pSteamMusic;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000026D4 File Offset: 0x000008D4
		internal static IntPtr GetSteamMusicRemote()
		{
			return CSteamAPIContext.m_pSteamMusicRemote;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000026DB File Offset: 0x000008DB
		internal static IntPtr GetSteamHTMLSurface()
		{
			return CSteamAPIContext.m_pSteamHTMLSurface;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000026E2 File Offset: 0x000008E2
		internal static IntPtr GetSteamInventory()
		{
			return CSteamAPIContext.m_pSteamInventory;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000026E9 File Offset: 0x000008E9
		internal static IntPtr GetSteamVideo()
		{
			return CSteamAPIContext.m_pSteamVideo;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000026F0 File Offset: 0x000008F0
		internal static IntPtr GetSteamParentalSettings()
		{
			return CSteamAPIContext.m_pSteamParentalSettings;
		}

		// Token: 0x04000106 RID: 262
		private static IntPtr m_pSteamClient;

		// Token: 0x04000107 RID: 263
		private static IntPtr m_pSteamUser;

		// Token: 0x04000108 RID: 264
		private static IntPtr m_pSteamFriends;

		// Token: 0x04000109 RID: 265
		private static IntPtr m_pSteamUtils;

		// Token: 0x0400010A RID: 266
		private static IntPtr m_pSteamMatchmaking;

		// Token: 0x0400010B RID: 267
		private static IntPtr m_pSteamUserStats;

		// Token: 0x0400010C RID: 268
		private static IntPtr m_pSteamApps;

		// Token: 0x0400010D RID: 269
		private static IntPtr m_pSteamMatchmakingServers;

		// Token: 0x0400010E RID: 270
		private static IntPtr m_pSteamNetworking;

		// Token: 0x0400010F RID: 271
		private static IntPtr m_pSteamRemoteStorage;

		// Token: 0x04000110 RID: 272
		private static IntPtr m_pSteamScreenshots;

		// Token: 0x04000111 RID: 273
		private static IntPtr m_pSteamHTTP;

		// Token: 0x04000112 RID: 274
		private static IntPtr m_pController;

		// Token: 0x04000113 RID: 275
		private static IntPtr m_pSteamUGC;

		// Token: 0x04000114 RID: 276
		private static IntPtr m_pSteamAppList;

		// Token: 0x04000115 RID: 277
		private static IntPtr m_pSteamMusic;

		// Token: 0x04000116 RID: 278
		private static IntPtr m_pSteamMusicRemote;

		// Token: 0x04000117 RID: 279
		private static IntPtr m_pSteamHTMLSurface;

		// Token: 0x04000118 RID: 280
		private static IntPtr m_pSteamInventory;

		// Token: 0x04000119 RID: 281
		private static IntPtr m_pSteamVideo;

		// Token: 0x0400011A RID: 282
		private static IntPtr m_pSteamParentalSettings;
	}
}
