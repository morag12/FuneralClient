using System;

namespace Steamworks2
{
	// Token: 0x02000174 RID: 372
	public static class SteamParentalSettings
	{
		// Token: 0x06000807 RID: 2055 RVA: 0x000062AB File Offset: 0x000044AB
		public static bool BIsParentalLockEnabled()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamParentalSettings_BIsParentalLockEnabled(CSteamAPIContext.GetSteamParentalSettings());
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x000062BC File Offset: 0x000044BC
		public static bool BIsParentalLockLocked()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamParentalSettings_BIsParentalLockLocked(CSteamAPIContext.GetSteamParentalSettings());
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x000062CD File Offset: 0x000044CD
		public static bool BIsAppBlocked(AppId_t nAppID)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamParentalSettings_BIsAppBlocked(CSteamAPIContext.GetSteamParentalSettings(), nAppID);
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x000062DF File Offset: 0x000044DF
		public static bool BIsAppInBlockList(AppId_t nAppID)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamParentalSettings_BIsAppInBlockList(CSteamAPIContext.GetSteamParentalSettings(), nAppID);
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x000062F1 File Offset: 0x000044F1
		public static bool BIsFeatureBlocked(EParentalFeature eFeature)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamParentalSettings_BIsFeatureBlocked(CSteamAPIContext.GetSteamParentalSettings(), eFeature);
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00006303 File Offset: 0x00004503
		public static bool BIsFeatureInBlockList(EParentalFeature eFeature)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamParentalSettings_BIsFeatureInBlockList(CSteamAPIContext.GetSteamParentalSettings(), eFeature);
		}
	}
}
