using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000A0 RID: 160
	[CallbackIdentity(201)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GSClientApprove_t
	{
		// Token: 0x040005B8 RID: 1464
		public const int k_iCallback = 201;

		// Token: 0x040005B9 RID: 1465
		public CSteamID m_SteamID;

		// Token: 0x040005BA RID: 1466
		public CSteamID m_OwnerSteamID;
	}
}
