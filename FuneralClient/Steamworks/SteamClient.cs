using System;

namespace Steamworks2
{
	// Token: 0x02000152 RID: 338
	public static class SteamClient
	{
		// Token: 0x06000550 RID: 1360 RVA: 0x00003AAE File Offset: 0x00001CAE
		public static HSteamPipe CreateSteamPipe()
		{
			InteropHelp.TestIfAvailableClient();
			return (HSteamPipe)NativeMethods.ISteamClient_CreateSteamPipe(CSteamAPIContext.GetSteamClient());
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00003AC4 File Offset: 0x00001CC4
		public static bool BReleaseSteamPipe(HSteamPipe hSteamPipe)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamClient_BReleaseSteamPipe(CSteamAPIContext.GetSteamClient(), hSteamPipe);
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00003AD6 File Offset: 0x00001CD6
		public static HSteamUser ConnectToGlobalUser(HSteamPipe hSteamPipe)
		{
			InteropHelp.TestIfAvailableClient();
			return (HSteamUser)NativeMethods.ISteamClient_ConnectToGlobalUser(CSteamAPIContext.GetSteamClient(), hSteamPipe);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00003AED File Offset: 0x00001CED
		public static HSteamUser CreateLocalUser(out HSteamPipe phSteamPipe, EAccountType eAccountType)
		{
			InteropHelp.TestIfAvailableClient();
			return (HSteamUser)NativeMethods.ISteamClient_CreateLocalUser(CSteamAPIContext.GetSteamClient(), out phSteamPipe, eAccountType);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00003B05 File Offset: 0x00001D05
		public static void ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamClient_ReleaseUser(CSteamAPIContext.GetSteamClient(), hSteamPipe, hUser);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0000B7D0 File Offset: 0x000099D0
		public static IntPtr GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				result = NativeMethods.ISteamClient_GetISteamUser(CSteamAPIContext.GetSteamClient(), hSteamUser, hSteamPipe, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0000B814 File Offset: 0x00009A14
		public static IntPtr GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				result = NativeMethods.ISteamClient_GetISteamGameServer(CSteamAPIContext.GetSteamClient(), hSteamUser, hSteamPipe, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00003B18 File Offset: 0x00001D18
		public static void SetLocalIPBinding(uint unIP, ushort usPort)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamClient_SetLocalIPBinding(CSteamAPIContext.GetSteamClient(), unIP, usPort);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0000B858 File Offset: 0x00009A58
		public static IntPtr GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				result = NativeMethods.ISteamClient_GetISteamFriends(CSteamAPIContext.GetSteamClient(), hSteamUser, hSteamPipe, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x0000B89C File Offset: 0x00009A9C
		public static IntPtr GetISteamUtils(HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				result = NativeMethods.ISteamClient_GetISteamUtils(CSteamAPIContext.GetSteamClient(), hSteamPipe, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0000B8E0 File Offset: 0x00009AE0
		public static IntPtr GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				result = NativeMethods.ISteamClient_GetISteamMatchmaking(CSteamAPIContext.GetSteamClient(), hSteamUser, hSteamPipe, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0000B924 File Offset: 0x00009B24
		public static IntPtr GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				result = NativeMethods.ISteamClient_GetISteamMatchmakingServers(CSteamAPIContext.GetSteamClient(), hSteamUser, hSteamPipe, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0000B968 File Offset: 0x00009B68
		public static IntPtr GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				result = NativeMethods.ISteamClient_GetISteamGenericInterface(CSteamAPIContext.GetSteamClient(), hSteamUser, hSteamPipe, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0000B9AC File Offset: 0x00009BAC
		public static IntPtr GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				result = NativeMethods.ISteamClient_GetISteamUserStats(CSteamAPIContext.GetSteamClient(), hSteamUser, hSteamPipe, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0000B9F0 File Offset: 0x00009BF0
		public static IntPtr GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				result = NativeMethods.ISteamClient_GetISteamGameServerStats(CSteamAPIContext.GetSteamClient(), hSteamuser, hSteamPipe, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0000BA34 File Offset: 0x00009C34
		public static IntPtr GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				result = NativeMethods.ISteamClient_GetISteamApps(CSteamAPIContext.GetSteamClient(), hSteamUser, hSteamPipe, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0000BA78 File Offset: 0x00009C78
		public static IntPtr GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				result = NativeMethods.ISteamClient_GetISteamNetworking(CSteamAPIContext.GetSteamClient(), hSteamUser, hSteamPipe, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0000BABC File Offset: 0x00009CBC
		public static IntPtr GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				result = NativeMethods.ISteamClient_GetISteamRemoteStorage(CSteamAPIContext.GetSteamClient(), hSteamuser, hSteamPipe, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0000BB00 File Offset: 0x00009D00
		public static IntPtr GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				result = NativeMethods.ISteamClient_GetISteamScreenshots(CSteamAPIContext.GetSteamClient(), hSteamuser, hSteamPipe, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00003B2B File Offset: 0x00001D2B
		public static uint GetIPCCallCount()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamClient_GetIPCCallCount(CSteamAPIContext.GetSteamClient());
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00003B3C File Offset: 0x00001D3C
		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamClient_SetWarningMessageHook(CSteamAPIContext.GetSteamClient(), pFunction);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00003B4E File Offset: 0x00001D4E
		public static bool BShutdownIfAllPipesClosed()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamClient_BShutdownIfAllPipesClosed(CSteamAPIContext.GetSteamClient());
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0000BB44 File Offset: 0x00009D44
		public static IntPtr GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				result = NativeMethods.ISteamClient_GetISteamHTTP(CSteamAPIContext.GetSteamClient(), hSteamuser, hSteamPipe, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0000BB88 File Offset: 0x00009D88
		public static IntPtr GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				result = NativeMethods.ISteamClient_GetISteamController(CSteamAPIContext.GetSteamClient(), hSteamUser, hSteamPipe, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0000BBCC File Offset: 0x00009DCC
		public static IntPtr GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				result = NativeMethods.ISteamClient_GetISteamUGC(CSteamAPIContext.GetSteamClient(), hSteamUser, hSteamPipe, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0000BC10 File Offset: 0x00009E10
		public static IntPtr GetISteamAppList(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				result = NativeMethods.ISteamClient_GetISteamAppList(CSteamAPIContext.GetSteamClient(), hSteamUser, hSteamPipe, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0000BC54 File Offset: 0x00009E54
		public static IntPtr GetISteamMusic(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				result = NativeMethods.ISteamClient_GetISteamMusic(CSteamAPIContext.GetSteamClient(), hSteamuser, hSteamPipe, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0000BC98 File Offset: 0x00009E98
		public static IntPtr GetISteamMusicRemote(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				result = NativeMethods.ISteamClient_GetISteamMusicRemote(CSteamAPIContext.GetSteamClient(), hSteamuser, hSteamPipe, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0000BCDC File Offset: 0x00009EDC
		public static IntPtr GetISteamHTMLSurface(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				result = NativeMethods.ISteamClient_GetISteamHTMLSurface(CSteamAPIContext.GetSteamClient(), hSteamuser, hSteamPipe, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0000BD20 File Offset: 0x00009F20
		public static IntPtr GetISteamInventory(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				result = NativeMethods.ISteamClient_GetISteamInventory(CSteamAPIContext.GetSteamClient(), hSteamuser, hSteamPipe, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0000BD64 File Offset: 0x00009F64
		public static IntPtr GetISteamVideo(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				result = NativeMethods.ISteamClient_GetISteamVideo(CSteamAPIContext.GetSteamClient(), hSteamuser, hSteamPipe, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0000BDA8 File Offset: 0x00009FA8
		public static IntPtr GetISteamParentalSettings(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				result = NativeMethods.ISteamClient_GetISteamParentalSettings(CSteamAPIContext.GetSteamClient(), hSteamuser, hSteamPipe, utf8StringHandle);
			}
			return result;
		}
	}
}
