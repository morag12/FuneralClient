using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000F5 RID: 245
	[CallbackIdentity(1111)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct LeaderboardUGCSet_t
	{
		// Token: 0x040006A3 RID: 1699
		public const int k_iCallback = 1111;

		// Token: 0x040006A4 RID: 1700
		public EResult m_eResult;

		// Token: 0x040006A5 RID: 1701
		public SteamLeaderboard_t m_hSteamLeaderboard;
	}
}
