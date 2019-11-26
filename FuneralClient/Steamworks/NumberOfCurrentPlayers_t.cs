using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000115 RID: 277
	[CallbackIdentity(1107)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct NumberOfCurrentPlayers_t
	{
		// Token: 0x040006EF RID: 1775
		public const int k_iCallback = 1107;

		// Token: 0x040006F0 RID: 1776
		public byte m_bSuccess;

		// Token: 0x040006F1 RID: 1777
		public int m_cPlayers;
	}
}
