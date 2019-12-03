using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000A4 RID: 164
	[CallbackIdentity(207)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GSGameplayStats_t
	{
		// Token: 0x040005C7 RID: 1479
		public const int k_iCallback = 207;

		// Token: 0x040005C8 RID: 1480
		public EResult m_eResult;

		// Token: 0x040005C9 RID: 1481
		public int m_nRank;

		// Token: 0x040005CA RID: 1482
		public uint m_unTotalConnects;

		// Token: 0x040005CB RID: 1483
		public uint m_unTotalMinutesPlayed;
	}
}
