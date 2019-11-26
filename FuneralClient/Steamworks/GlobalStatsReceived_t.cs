using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200009E RID: 158
	[CallbackIdentity(1112)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GlobalStatsReceived_t
	{
		// Token: 0x040005B1 RID: 1457
		public const int k_iCallback = 1112;

		// Token: 0x040005B2 RID: 1458
		public ulong m_nGameID;

		// Token: 0x040005B3 RID: 1459
		public EResult m_eResult;
	}
}
