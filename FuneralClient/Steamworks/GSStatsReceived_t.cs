using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000A7 RID: 167
	[CallbackIdentity(1800)]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct GSStatsReceived_t
	{
		// Token: 0x040005D6 RID: 1494
		public const int k_iCallback = 1800;

		// Token: 0x040005D7 RID: 1495
		public EResult m_eResult;

		// Token: 0x040005D8 RID: 1496
		public CSteamID m_steamIDUser;
	}
}
