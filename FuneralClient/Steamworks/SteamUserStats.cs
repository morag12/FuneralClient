using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000181 RID: 385
	public static class SteamUserStats
	{
		// Token: 0x060008B4 RID: 2228 RVA: 0x00006C7A File Offset: 0x00004E7A
		public static bool RequestCurrentStats()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUserStats_RequestCurrentStats(CSteamAPIContext.GetSteamUserStats());
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x0000F6C0 File Offset: 0x0000D8C0
		public static bool GetStat(string pchName, out int pData)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchName))
			{
				result = NativeMethods.ISteamUserStats_GetStat(CSteamAPIContext.GetSteamUserStats(), utf8StringHandle, out pData);
			}
			return result;
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x0000F704 File Offset: 0x0000D904
		public static bool GetStat(string pchName, out float pData)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchName))
			{
				result = NativeMethods.ISteamUserStats_GetStat0(CSteamAPIContext.GetSteamUserStats(), utf8StringHandle, out pData);
			}
			return result;
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x0000F748 File Offset: 0x0000D948
		public static bool SetStat(string pchName, int nData)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchName))
			{
				result = NativeMethods.ISteamUserStats_SetStat(CSteamAPIContext.GetSteamUserStats(), utf8StringHandle, nData);
			}
			return result;
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x0000F78C File Offset: 0x0000D98C
		public static bool SetStat(string pchName, float fData)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchName))
			{
				result = NativeMethods.ISteamUserStats_SetStat0(CSteamAPIContext.GetSteamUserStats(), utf8StringHandle, fData);
			}
			return result;
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x0000F7D0 File Offset: 0x0000D9D0
		public static bool UpdateAvgRateStat(string pchName, float flCountThisSession, double dSessionLength)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchName))
			{
				result = NativeMethods.ISteamUserStats_UpdateAvgRateStat(CSteamAPIContext.GetSteamUserStats(), utf8StringHandle, flCountThisSession, dSessionLength);
			}
			return result;
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x0000F814 File Offset: 0x0000DA14
		public static bool GetAchievement(string pchName, out bool pbAchieved)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchName))
			{
				result = NativeMethods.ISteamUserStats_GetAchievement(CSteamAPIContext.GetSteamUserStats(), utf8StringHandle, out pbAchieved);
			}
			return result;
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x0000F858 File Offset: 0x0000DA58
		public static bool SetAchievement(string pchName)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchName))
			{
				result = NativeMethods.ISteamUserStats_SetAchievement(CSteamAPIContext.GetSteamUserStats(), utf8StringHandle);
			}
			return result;
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x0000F89C File Offset: 0x0000DA9C
		public static bool ClearAchievement(string pchName)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchName))
			{
				result = NativeMethods.ISteamUserStats_ClearAchievement(CSteamAPIContext.GetSteamUserStats(), utf8StringHandle);
			}
			return result;
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x0000F8E0 File Offset: 0x0000DAE0
		public static bool GetAchievementAndUnlockTime(string pchName, out bool pbAchieved, out uint punUnlockTime)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchName))
			{
				result = NativeMethods.ISteamUserStats_GetAchievementAndUnlockTime(CSteamAPIContext.GetSteamUserStats(), utf8StringHandle, out pbAchieved, out punUnlockTime);
			}
			return result;
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00006C8B File Offset: 0x00004E8B
		public static bool StoreStats()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUserStats_StoreStats(CSteamAPIContext.GetSteamUserStats());
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x0000F924 File Offset: 0x0000DB24
		public static int GetAchievementIcon(string pchName)
		{
			InteropHelp.TestIfAvailableClient();
			int result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchName))
			{
				result = NativeMethods.ISteamUserStats_GetAchievementIcon(CSteamAPIContext.GetSteamUserStats(), utf8StringHandle);
			}
			return result;
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x0000F968 File Offset: 0x0000DB68
		public static string GetAchievementDisplayAttribute(string pchName, string pchKey)
		{
			InteropHelp.TestIfAvailableClient();
			string result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchName))
			{
				using (InteropHelp.UTF8StringHandle utf8StringHandle2 = new InteropHelp.UTF8StringHandle(pchKey))
				{
					result = InteropHelp.PtrToStringUTF8(NativeMethods.ISteamUserStats_GetAchievementDisplayAttribute(CSteamAPIContext.GetSteamUserStats(), utf8StringHandle, utf8StringHandle2));
				}
			}
			return result;
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x0000F9D0 File Offset: 0x0000DBD0
		public static bool IndicateAchievementProgress(string pchName, uint nCurProgress, uint nMaxProgress)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchName))
			{
				result = NativeMethods.ISteamUserStats_IndicateAchievementProgress(CSteamAPIContext.GetSteamUserStats(), utf8StringHandle, nCurProgress, nMaxProgress);
			}
			return result;
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00006C9C File Offset: 0x00004E9C
		public static uint GetNumAchievements()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUserStats_GetNumAchievements(CSteamAPIContext.GetSteamUserStats());
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00006CAD File Offset: 0x00004EAD
		public static string GetAchievementName(uint iAchievement)
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamUserStats_GetAchievementName(CSteamAPIContext.GetSteamUserStats(), iAchievement));
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00006CC4 File Offset: 0x00004EC4
		public static SteamAPICall_t RequestUserStats(CSteamID steamIDUser)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUserStats_RequestUserStats(CSteamAPIContext.GetSteamUserStats(), steamIDUser);
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x0000FA14 File Offset: 0x0000DC14
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchName))
			{
				result = NativeMethods.ISteamUserStats_GetUserStat(CSteamAPIContext.GetSteamUserStats(), steamIDUser, utf8StringHandle, out pData);
			}
			return result;
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x0000FA58 File Offset: 0x0000DC58
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchName))
			{
				result = NativeMethods.ISteamUserStats_GetUserStat0(CSteamAPIContext.GetSteamUserStats(), steamIDUser, utf8StringHandle, out pData);
			}
			return result;
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x0000FA9C File Offset: 0x0000DC9C
		public static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchName))
			{
				result = NativeMethods.ISteamUserStats_GetUserAchievement(CSteamAPIContext.GetSteamUserStats(), steamIDUser, utf8StringHandle, out pbAchieved);
			}
			return result;
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x0000FAE0 File Offset: 0x0000DCE0
		public static bool GetUserAchievementAndUnlockTime(CSteamID steamIDUser, string pchName, out bool pbAchieved, out uint punUnlockTime)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchName))
			{
				result = NativeMethods.ISteamUserStats_GetUserAchievementAndUnlockTime(CSteamAPIContext.GetSteamUserStats(), steamIDUser, utf8StringHandle, out pbAchieved, out punUnlockTime);
			}
			return result;
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00006CDB File Offset: 0x00004EDB
		public static bool ResetAllStats(bool bAchievementsToo)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUserStats_ResetAllStats(CSteamAPIContext.GetSteamUserStats(), bAchievementsToo);
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x0000FB28 File Offset: 0x0000DD28
		public static SteamAPICall_t FindOrCreateLeaderboard(string pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType)
		{
			InteropHelp.TestIfAvailableClient();
			SteamAPICall_t result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchLeaderboardName))
			{
				result = (SteamAPICall_t)NativeMethods.ISteamUserStats_FindOrCreateLeaderboard(CSteamAPIContext.GetSteamUserStats(), utf8StringHandle, eLeaderboardSortMethod, eLeaderboardDisplayType);
			}
			return result;
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x0000FB74 File Offset: 0x0000DD74
		public static SteamAPICall_t FindLeaderboard(string pchLeaderboardName)
		{
			InteropHelp.TestIfAvailableClient();
			SteamAPICall_t result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchLeaderboardName))
			{
				result = (SteamAPICall_t)NativeMethods.ISteamUserStats_FindLeaderboard(CSteamAPIContext.GetSteamUserStats(), utf8StringHandle);
			}
			return result;
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00006CED File Offset: 0x00004EED
		public static string GetLeaderboardName(SteamLeaderboard_t hSteamLeaderboard)
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamUserStats_GetLeaderboardName(CSteamAPIContext.GetSteamUserStats(), hSteamLeaderboard));
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00006D04 File Offset: 0x00004F04
		public static int GetLeaderboardEntryCount(SteamLeaderboard_t hSteamLeaderboard)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUserStats_GetLeaderboardEntryCount(CSteamAPIContext.GetSteamUserStats(), hSteamLeaderboard);
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00006D16 File Offset: 0x00004F16
		public static ELeaderboardSortMethod GetLeaderboardSortMethod(SteamLeaderboard_t hSteamLeaderboard)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUserStats_GetLeaderboardSortMethod(CSteamAPIContext.GetSteamUserStats(), hSteamLeaderboard);
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00006D28 File Offset: 0x00004F28
		public static ELeaderboardDisplayType GetLeaderboardDisplayType(SteamLeaderboard_t hSteamLeaderboard)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUserStats_GetLeaderboardDisplayType(CSteamAPIContext.GetSteamUserStats(), hSteamLeaderboard);
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00006D3A File Offset: 0x00004F3A
		public static SteamAPICall_t DownloadLeaderboardEntries(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUserStats_DownloadLeaderboardEntries(CSteamAPIContext.GetSteamUserStats(), hSteamLeaderboard, eLeaderboardDataRequest, nRangeStart, nRangeEnd);
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00006D54 File Offset: 0x00004F54
		public static SteamAPICall_t DownloadLeaderboardEntriesForUsers(SteamLeaderboard_t hSteamLeaderboard, CSteamID[] prgUsers, int cUsers)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUserStats_DownloadLeaderboardEntriesForUsers(CSteamAPIContext.GetSteamUserStats(), hSteamLeaderboard, prgUsers, cUsers);
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00006D6D File Offset: 0x00004F6D
		public static bool GetDownloadedLeaderboardEntry(SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, int[] pDetails, int cDetailsMax)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUserStats_GetDownloadedLeaderboardEntry(CSteamAPIContext.GetSteamUserStats(), hSteamLeaderboardEntries, index, out pLeaderboardEntry, pDetails, cDetailsMax);
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00006D84 File Offset: 0x00004F84
		public static SteamAPICall_t UploadLeaderboardScore(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, int[] pScoreDetails, int cScoreDetailsCount)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUserStats_UploadLeaderboardScore(CSteamAPIContext.GetSteamUserStats(), hSteamLeaderboard, eLeaderboardUploadScoreMethod, nScore, pScoreDetails, cScoreDetailsCount);
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00006DA0 File Offset: 0x00004FA0
		public static SteamAPICall_t AttachLeaderboardUGC(SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUserStats_AttachLeaderboardUGC(CSteamAPIContext.GetSteamUserStats(), hSteamLeaderboard, hUGC);
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00006DB8 File Offset: 0x00004FB8
		public static SteamAPICall_t GetNumberOfCurrentPlayers()
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUserStats_GetNumberOfCurrentPlayers(CSteamAPIContext.GetSteamUserStats());
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00006DCE File Offset: 0x00004FCE
		public static SteamAPICall_t RequestGlobalAchievementPercentages()
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUserStats_RequestGlobalAchievementPercentages(CSteamAPIContext.GetSteamUserStats());
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x0000FBBC File Offset: 0x0000DDBC
		public static int GetMostAchievedAchievementInfo(out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal((int)unNameBufLen);
			int num = NativeMethods.ISteamUserStats_GetMostAchievedAchievementInfo(CSteamAPIContext.GetSteamUserStats(), intPtr, unNameBufLen, out pflPercent, out pbAchieved);
			pchName = ((num != -1) ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return num;
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x0000FBFC File Offset: 0x0000DDFC
		public static int GetNextMostAchievedAchievementInfo(int iIteratorPrevious, out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal((int)unNameBufLen);
			int num = NativeMethods.ISteamUserStats_GetNextMostAchievedAchievementInfo(CSteamAPIContext.GetSteamUserStats(), iIteratorPrevious, intPtr, unNameBufLen, out pflPercent, out pbAchieved);
			pchName = ((num != -1) ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return num;
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x0000FC3C File Offset: 0x0000DE3C
		public static bool GetAchievementAchievedPercent(string pchName, out float pflPercent)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchName))
			{
				result = NativeMethods.ISteamUserStats_GetAchievementAchievedPercent(CSteamAPIContext.GetSteamUserStats(), utf8StringHandle, out pflPercent);
			}
			return result;
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00006DE4 File Offset: 0x00004FE4
		public static SteamAPICall_t RequestGlobalStats(int nHistoryDays)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUserStats_RequestGlobalStats(CSteamAPIContext.GetSteamUserStats(), nHistoryDays);
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x0000FC80 File Offset: 0x0000DE80
		public static bool GetGlobalStat(string pchStatName, out long pData)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchStatName))
			{
				result = NativeMethods.ISteamUserStats_GetGlobalStat(CSteamAPIContext.GetSteamUserStats(), utf8StringHandle, out pData);
			}
			return result;
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x0000FCC4 File Offset: 0x0000DEC4
		public static bool GetGlobalStat(string pchStatName, out double pData)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchStatName))
			{
				result = NativeMethods.ISteamUserStats_GetGlobalStat0(CSteamAPIContext.GetSteamUserStats(), utf8StringHandle, out pData);
			}
			return result;
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x0000FD08 File Offset: 0x0000DF08
		public static int GetGlobalStatHistory(string pchStatName, long[] pData, uint cubData)
		{
			InteropHelp.TestIfAvailableClient();
			int result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchStatName))
			{
				result = NativeMethods.ISteamUserStats_GetGlobalStatHistory(CSteamAPIContext.GetSteamUserStats(), utf8StringHandle, pData, cubData);
			}
			return result;
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x0000FD4C File Offset: 0x0000DF4C
		public static int GetGlobalStatHistory(string pchStatName, double[] pData, uint cubData)
		{
			InteropHelp.TestIfAvailableClient();
			int result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchStatName))
			{
				result = NativeMethods.ISteamUserStats_GetGlobalStatHistory0(CSteamAPIContext.GetSteamUserStats(), utf8StringHandle, pData, cubData);
			}
			return result;
		}
	}
}
