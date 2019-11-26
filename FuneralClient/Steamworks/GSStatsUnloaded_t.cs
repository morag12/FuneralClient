using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000A9 RID: 169
	[CallbackIdentity(1108)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GSStatsUnloaded_t
	{
		// Token: 0x040005DC RID: 1500
		public const int k_iCallback = 1108;

		// Token: 0x040005DD RID: 1501
		public CSteamID m_steamIDUser;
	}
}
