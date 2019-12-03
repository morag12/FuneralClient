using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000150 RID: 336
	public static class SteamApps
	{
		// Token: 0x06000536 RID: 1334 RVA: 0x0000392C File Offset: 0x00001B2C
		public static bool BIsSubscribed()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_BIsSubscribed(CSteamAPIContext.GetSteamApps());
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x0000393D File Offset: 0x00001B3D
		public static bool BIsLowViolence()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_BIsLowViolence(CSteamAPIContext.GetSteamApps());
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0000394E File Offset: 0x00001B4E
		public static bool BIsCybercafe()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_BIsCybercafe(CSteamAPIContext.GetSteamApps());
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0000395F File Offset: 0x00001B5F
		public static bool BIsVACBanned()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_BIsVACBanned(CSteamAPIContext.GetSteamApps());
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00003970 File Offset: 0x00001B70
		public static string GetCurrentGameLanguage()
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamApps_GetCurrentGameLanguage(CSteamAPIContext.GetSteamApps()));
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00003986 File Offset: 0x00001B86
		public static string GetAvailableGameLanguages()
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamApps_GetAvailableGameLanguages(CSteamAPIContext.GetSteamApps()));
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0000399C File Offset: 0x00001B9C
		public static bool BIsSubscribedApp(AppId_t appID)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_BIsSubscribedApp(CSteamAPIContext.GetSteamApps(), appID);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x000039AE File Offset: 0x00001BAE
		public static bool BIsDlcInstalled(AppId_t appID)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_BIsDlcInstalled(CSteamAPIContext.GetSteamApps(), appID);
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x000039C0 File Offset: 0x00001BC0
		public static uint GetEarliestPurchaseUnixTime(AppId_t nAppID)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_GetEarliestPurchaseUnixTime(CSteamAPIContext.GetSteamApps(), nAppID);
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x000039D2 File Offset: 0x00001BD2
		public static bool BIsSubscribedFromFreeWeekend()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_BIsSubscribedFromFreeWeekend(CSteamAPIContext.GetSteamApps());
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x000039E3 File Offset: 0x00001BE3
		public static int GetDLCCount()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_GetDLCCount(CSteamAPIContext.GetSteamApps());
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0000B688 File Offset: 0x00009888
		public static bool BGetDLCDataByIndex(int iDLC, out AppId_t pAppID, out bool pbAvailable, out string pchName, int cchNameBufferSize)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal(cchNameBufferSize);
			bool flag = NativeMethods.ISteamApps_BGetDLCDataByIndex(CSteamAPIContext.GetSteamApps(), iDLC, out pAppID, out pbAvailable, intPtr, cchNameBufferSize);
			pchName = (flag ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x000039F4 File Offset: 0x00001BF4
		public static void InstallDLC(AppId_t nAppID)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamApps_InstallDLC(CSteamAPIContext.GetSteamApps(), nAppID);
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00003A06 File Offset: 0x00001C06
		public static void UninstallDLC(AppId_t nAppID)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamApps_UninstallDLC(CSteamAPIContext.GetSteamApps(), nAppID);
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00003A18 File Offset: 0x00001C18
		public static void RequestAppProofOfPurchaseKey(AppId_t nAppID)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamApps_RequestAppProofOfPurchaseKey(CSteamAPIContext.GetSteamApps(), nAppID);
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0000B6C8 File Offset: 0x000098C8
		public static bool GetCurrentBetaName(out string pchName, int cchNameBufferSize)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal(cchNameBufferSize);
			bool flag = NativeMethods.ISteamApps_GetCurrentBetaName(CSteamAPIContext.GetSteamApps(), intPtr, cchNameBufferSize);
			pchName = (flag ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00003A2A File Offset: 0x00001C2A
		public static bool MarkContentCorrupt(bool bMissingFilesOnly)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_MarkContentCorrupt(CSteamAPIContext.GetSteamApps(), bMissingFilesOnly);
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00003A3C File Offset: 0x00001C3C
		public static uint GetInstalledDepots(AppId_t appID, DepotId_t[] pvecDepots, uint cMaxDepots)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_GetInstalledDepots(CSteamAPIContext.GetSteamApps(), appID, pvecDepots, cMaxDepots);
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x0000B704 File Offset: 0x00009904
		public static uint GetAppInstallDir(AppId_t appID, out string pchFolder, uint cchFolderBufferSize)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal((int)cchFolderBufferSize);
			uint num = NativeMethods.ISteamApps_GetAppInstallDir(CSteamAPIContext.GetSteamApps(), appID, intPtr, cchFolderBufferSize);
			pchFolder = ((num != 0u) ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return num;
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00003A50 File Offset: 0x00001C50
		public static bool BIsAppInstalled(AppId_t appID)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_BIsAppInstalled(CSteamAPIContext.GetSteamApps(), appID);
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00003A62 File Offset: 0x00001C62
		public static CSteamID GetAppOwner()
		{
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamApps_GetAppOwner(CSteamAPIContext.GetSteamApps());
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0000B740 File Offset: 0x00009940
		public static string GetLaunchQueryParam(string pchKey)
		{
			InteropHelp.TestIfAvailableClient();
			string result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchKey))
			{
				result = InteropHelp.PtrToStringUTF8(NativeMethods.ISteamApps_GetLaunchQueryParam(CSteamAPIContext.GetSteamApps(), utf8StringHandle));
			}
			return result;
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00003A78 File Offset: 0x00001C78
		public static bool GetDlcDownloadProgress(AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_GetDlcDownloadProgress(CSteamAPIContext.GetSteamApps(), nAppID, out punBytesDownloaded, out punBytesTotal);
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00003A8C File Offset: 0x00001C8C
		public static int GetAppBuildId()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_GetAppBuildId(CSteamAPIContext.GetSteamApps());
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00003A9D File Offset: 0x00001C9D
		public static void RequestAllProofOfPurchaseKeys()
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamApps_RequestAllProofOfPurchaseKeys(CSteamAPIContext.GetSteamApps());
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0000B788 File Offset: 0x00009988
		public static SteamAPICall_t GetFileDetails(string pszFileName)
		{
			InteropHelp.TestIfAvailableClient();
			SteamAPICall_t result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pszFileName))
			{
				result = (SteamAPICall_t)NativeMethods.ISteamApps_GetFileDetails(CSteamAPIContext.GetSteamApps(), utf8StringHandle);
			}
			return result;
		}
	}
}
