using System;

namespace Steamworks2
{
	// Token: 0x02000149 RID: 329
	public static class SteamAPI
	{
		// Token: 0x06000515 RID: 1301 RVA: 0x0000B5E4 File Offset: 0x000097E4
		public static bool Init()
		{
			InteropHelp.TestIfPlatformSupported();
			bool flag = NativeMethods.SteamAPI_Init();
			if (flag)
			{
				flag = CSteamAPIContext.Init();
			}
			return flag;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x000037F9 File Offset: 0x000019F9
		public static void Shutdown()
		{
			InteropHelp.TestIfPlatformSupported();
			NativeMethods.SteamAPI_Shutdown();
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00003805 File Offset: 0x00001A05
		public static bool RestartAppIfNecessary(AppId_t unOwnAppID)
		{
			InteropHelp.TestIfPlatformSupported();
			return NativeMethods.SteamAPI_RestartAppIfNecessary(unOwnAppID);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00003812 File Offset: 0x00001A12
		public static void ReleaseCurrentThreadMemory()
		{
			InteropHelp.TestIfPlatformSupported();
			NativeMethods.SteamAPI_ReleaseCurrentThreadMemory();
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0000381E File Offset: 0x00001A1E
		public static void RunCallbacks()
		{
			InteropHelp.TestIfPlatformSupported();
			NativeMethods.SteamAPI_RunCallbacks();
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0000382A File Offset: 0x00001A2A
		public static bool IsSteamRunning()
		{
			InteropHelp.TestIfPlatformSupported();
			return NativeMethods.SteamAPI_IsSteamRunning();
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00003836 File Offset: 0x00001A36
		public static HSteamUser GetHSteamUserCurrent()
		{
			InteropHelp.TestIfPlatformSupported();
			return (HSteamUser)NativeMethods.Steam_GetHSteamUserCurrent();
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00003847 File Offset: 0x00001A47
		public static HSteamPipe GetHSteamPipe()
		{
			InteropHelp.TestIfPlatformSupported();
			return (HSteamPipe)NativeMethods.SteamAPI_GetHSteamPipe();
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00003858 File Offset: 0x00001A58
		public static HSteamUser GetHSteamUser()
		{
			InteropHelp.TestIfPlatformSupported();
			return (HSteamUser)NativeMethods.SteamAPI_GetHSteamUser();
		}
	}
}
