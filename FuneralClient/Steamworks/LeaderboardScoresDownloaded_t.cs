using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000F3 RID: 243
	[CallbackIdentity(1105)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct LeaderboardScoresDownloaded_t
	{
		// Token: 0x04000698 RID: 1688
		public const int k_iCallback = 1105;

		// Token: 0x04000699 RID: 1689
		public SteamLeaderboard_t m_hSteamLeaderboard;

		// Token: 0x0400069A RID: 1690
		public SteamLeaderboardEntries_t m_hSteamLeaderboardEntries;

		// Token: 0x0400069B RID: 1691
		public int m_cEntryCount;
	}
}
