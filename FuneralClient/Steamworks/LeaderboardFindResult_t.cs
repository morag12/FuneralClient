using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000F2 RID: 242
	[CallbackIdentity(1104)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct LeaderboardFindResult_t
	{
		// Token: 0x04000695 RID: 1685
		public const int k_iCallback = 1104;

		// Token: 0x04000696 RID: 1686
		public SteamLeaderboard_t m_hSteamLeaderboard;

		// Token: 0x04000697 RID: 1687
		public byte m_bLeaderboardFound;
	}
}
