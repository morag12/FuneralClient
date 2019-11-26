using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000F4 RID: 244
	[CallbackIdentity(1106)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct LeaderboardScoreUploaded_t
	{
		// Token: 0x0400069C RID: 1692
		public const int k_iCallback = 1106;

		// Token: 0x0400069D RID: 1693
		public byte m_bSuccess;

		// Token: 0x0400069E RID: 1694
		public SteamLeaderboard_t m_hSteamLeaderboard;

		// Token: 0x0400069F RID: 1695
		public int m_nScore;

		// Token: 0x040006A0 RID: 1696
		public byte m_bScoreChanged;

		// Token: 0x040006A1 RID: 1697
		public int m_nGlobalRankNew;

		// Token: 0x040006A2 RID: 1698
		public int m_nGlobalRankPrevious;
	}
}
