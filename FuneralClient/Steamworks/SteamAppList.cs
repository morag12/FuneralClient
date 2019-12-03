using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200014F RID: 335
	public static class SteamAppList
	{
		// Token: 0x06000531 RID: 1329 RVA: 0x000038F6 File Offset: 0x00001AF6
		public static uint GetNumInstalledApps()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamAppList_GetNumInstalledApps(CSteamAPIContext.GetSteamAppList());
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00003907 File Offset: 0x00001B07
		public static uint GetInstalledApps(AppId_t[] pvecAppID, uint unMaxAppIDs)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamAppList_GetInstalledApps(CSteamAPIContext.GetSteamAppList(), pvecAppID, unMaxAppIDs);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0000B608 File Offset: 0x00009808
		public static int GetAppName(AppId_t nAppID, out string pchName, int cchNameMax)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal(cchNameMax);
			int num = NativeMethods.ISteamAppList_GetAppName(CSteamAPIContext.GetSteamAppList(), nAppID, intPtr, cchNameMax);
			pchName = ((num != -1) ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return num;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0000B648 File Offset: 0x00009848
		public static int GetAppInstallDir(AppId_t nAppID, out string pchDirectory, int cchNameMax)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal(cchNameMax);
			int num = NativeMethods.ISteamAppList_GetAppInstallDir(CSteamAPIContext.GetSteamAppList(), nAppID, intPtr, cchNameMax);
			pchDirectory = ((num != -1) ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return num;
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x0000391A File Offset: 0x00001B1A
		public static int GetAppBuildId(AppId_t nAppID)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamAppList_GetAppBuildId(CSteamAPIContext.GetSteamAppList(), nAppID);
		}
	}
}
