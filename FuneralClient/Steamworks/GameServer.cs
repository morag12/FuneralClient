using System;

namespace Steamworks2
{
	// Token: 0x02000092 RID: 146
	public static class GameServer
	{
		// Token: 0x060000F8 RID: 248 RVA: 0x0000ADB8 File Offset: 0x00008FB8
		public static bool Init(uint unIP, ushort usSteamPort, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, string pchVersionString)
		{
			InteropHelp.TestIfPlatformSupported();
			bool flag;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchVersionString))
			{
				flag = NativeMethods.SteamGameServer_Init(unIP, usSteamPort, usGamePort, usQueryPort, eServerMode, utf8StringHandle);
			}
			if (flag)
			{
				flag = CSteamGameServerAPIContext.Init();
			}
			return flag;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002B69 File Offset: 0x00000D69
		public static void Shutdown()
		{
			InteropHelp.TestIfPlatformSupported();
			NativeMethods.SteamGameServer_Shutdown();
			CSteamGameServerAPIContext.Clear();
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002B7A File Offset: 0x00000D7A
		public static void RunCallbacks()
		{
			InteropHelp.TestIfPlatformSupported();
			NativeMethods.SteamGameServer_RunCallbacks();
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002B86 File Offset: 0x00000D86
		public static void ReleaseCurrentThreadMemory()
		{
			InteropHelp.TestIfPlatformSupported();
			NativeMethods.SteamGameServer_ReleaseCurrentThreadMemory();
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002B92 File Offset: 0x00000D92
		public static bool BSecure()
		{
			InteropHelp.TestIfPlatformSupported();
			return NativeMethods.SteamGameServer_BSecure();
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002B9E File Offset: 0x00000D9E
		public static CSteamID GetSteamID()
		{
			InteropHelp.TestIfPlatformSupported();
			return (CSteamID)NativeMethods.SteamGameServer_GetSteamID();
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002BAF File Offset: 0x00000DAF
		public static HSteamPipe GetHSteamPipe()
		{
			InteropHelp.TestIfPlatformSupported();
			return (HSteamPipe)NativeMethods.SteamGameServer_GetHSteamPipe();
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002BC0 File Offset: 0x00000DC0
		public static HSteamUser GetHSteamUser()
		{
			InteropHelp.TestIfPlatformSupported();
			return (HSteamUser)NativeMethods.SteamGameServer_GetHSteamUser();
		}
	}
}
