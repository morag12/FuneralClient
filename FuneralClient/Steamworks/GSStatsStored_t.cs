using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000A8 RID: 168
	[CallbackIdentity(1801)]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct GSStatsStored_t
	{
		// Token: 0x040005D9 RID: 1497
		public const int k_iCallback = 1801;

		// Token: 0x040005DA RID: 1498
		public EResult m_eResult;

		// Token: 0x040005DB RID: 1499
		public CSteamID m_steamIDUser;
	}
}
