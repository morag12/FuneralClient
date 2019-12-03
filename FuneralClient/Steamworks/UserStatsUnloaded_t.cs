using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000190 RID: 400
	[CallbackIdentity(1108)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct UserStatsUnloaded_t
	{
		// Token: 0x0400083A RID: 2106
		public const int k_iCallback = 1108;

		// Token: 0x0400083B RID: 2107
		public CSteamID m_steamIDUser;
	}
}
