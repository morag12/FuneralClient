using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000A6 RID: 166
	[CallbackIdentity(209)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GSReputation_t
	{
		// Token: 0x040005CE RID: 1486
		public const int k_iCallback = 209;

		// Token: 0x040005CF RID: 1487
		public EResult m_eResult;

		// Token: 0x040005D0 RID: 1488
		public uint m_unReputationScore;

		// Token: 0x040005D1 RID: 1489
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bBanned;

		// Token: 0x040005D2 RID: 1490
		public uint m_unBannedIP;

		// Token: 0x040005D3 RID: 1491
		public ushort m_usBannedPort;

		// Token: 0x040005D4 RID: 1492
		public ulong m_ulBannedGameID;

		// Token: 0x040005D5 RID: 1493
		public uint m_unBanExpires;
	}
}
