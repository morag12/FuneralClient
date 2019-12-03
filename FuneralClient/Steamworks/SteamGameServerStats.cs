using System;

namespace Steamworks2
{
	// Token: 0x0200015B RID: 347
	public static class SteamGameServerStats
	{
		// Token: 0x0600067F RID: 1663 RVA: 0x00004B23 File Offset: 0x00002D23
		public static SteamAPICall_t RequestUserStats(CSteamID steamIDUser)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamGameServerStats_RequestUserStats(CSteamGameServerAPIContext.GetSteamGameServerStats(), steamIDUser);
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0000D09C File Offset: 0x0000B29C
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData)
		{
			InteropHelp.TestIfAvailableGameServer();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchName))
			{
				result = NativeMethods.ISteamGameServerStats_GetUserStat(CSteamGameServerAPIContext.GetSteamGameServerStats(), steamIDUser, utf8StringHandle, out pData);
			}
			return result;
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0000D0E0 File Offset: 0x0000B2E0
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData)
		{
			InteropHelp.TestIfAvailableGameServer();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchName))
			{
				result = NativeMethods.ISteamGameServerStats_GetUserStat0(CSteamGameServerAPIContext.GetSteamGameServerStats(), steamIDUser, utf8StringHandle, out pData);
			}
			return result;
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0000D124 File Offset: 0x0000B324
		public static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved)
		{
			InteropHelp.TestIfAvailableGameServer();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchName))
			{
				result = NativeMethods.ISteamGameServerStats_GetUserAchievement(CSteamGameServerAPIContext.GetSteamGameServerStats(), steamIDUser, utf8StringHandle, out pbAchieved);
			}
			return result;
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0000D168 File Offset: 0x0000B368
		public static bool SetUserStat(CSteamID steamIDUser, string pchName, int nData)
		{
			InteropHelp.TestIfAvailableGameServer();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchName))
			{
				result = NativeMethods.ISteamGameServerStats_SetUserStat(CSteamGameServerAPIContext.GetSteamGameServerStats(), steamIDUser, utf8StringHandle, nData);
			}
			return result;
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0000D1AC File Offset: 0x0000B3AC
		public static bool SetUserStat(CSteamID steamIDUser, string pchName, float fData)
		{
			InteropHelp.TestIfAvailableGameServer();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchName))
			{
				result = NativeMethods.ISteamGameServerStats_SetUserStat0(CSteamGameServerAPIContext.GetSteamGameServerStats(), steamIDUser, utf8StringHandle, fData);
			}
			return result;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0000D1F0 File Offset: 0x0000B3F0
		public static bool UpdateUserAvgRateStat(CSteamID steamIDUser, string pchName, float flCountThisSession, double dSessionLength)
		{
			InteropHelp.TestIfAvailableGameServer();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchName))
			{
				result = NativeMethods.ISteamGameServerStats_UpdateUserAvgRateStat(CSteamGameServerAPIContext.GetSteamGameServerStats(), steamIDUser, utf8StringHandle, flCountThisSession, dSessionLength);
			}
			return result;
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0000D238 File Offset: 0x0000B438
		public static bool SetUserAchievement(CSteamID steamIDUser, string pchName)
		{
			InteropHelp.TestIfAvailableGameServer();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchName))
			{
				result = NativeMethods.ISteamGameServerStats_SetUserAchievement(CSteamGameServerAPIContext.GetSteamGameServerStats(), steamIDUser, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0000D27C File Offset: 0x0000B47C
		public static bool ClearUserAchievement(CSteamID steamIDUser, string pchName)
		{
			InteropHelp.TestIfAvailableGameServer();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchName))
			{
				result = NativeMethods.ISteamGameServerStats_ClearUserAchievement(CSteamGameServerAPIContext.GetSteamGameServerStats(), steamIDUser, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00004B3A File Offset: 0x00002D3A
		public static SteamAPICall_t StoreUserStats(CSteamID steamIDUser)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamGameServerStats_StoreUserStats(CSteamGameServerAPIContext.GetSteamGameServerStats(), steamIDUser);
		}
	}
}
