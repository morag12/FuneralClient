using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000117 RID: 279
	[CallbackIdentity(1202)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct P2PSessionRequest_t
	{
		// Token: 0x040006F5 RID: 1781
		public const int k_iCallback = 1202;

		// Token: 0x040006F6 RID: 1782
		public CSteamID m_steamIDRemote;
	}
}
