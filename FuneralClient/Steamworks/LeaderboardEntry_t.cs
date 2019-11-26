using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000F1 RID: 241
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct LeaderboardEntry_t
	{
		// Token: 0x04000690 RID: 1680
		public CSteamID m_steamIDUser;

		// Token: 0x04000691 RID: 1681
		public int m_nGlobalRank;

		// Token: 0x04000692 RID: 1682
		public int m_nScore;

		// Token: 0x04000693 RID: 1683
		public int m_cDetails;

		// Token: 0x04000694 RID: 1684
		public UGCHandle_t m_hUGC;
	}
}
