using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000116 RID: 278
	[CallbackIdentity(1203)]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct P2PSessionConnectFail_t
	{
		// Token: 0x040006F2 RID: 1778
		public const int k_iCallback = 1203;

		// Token: 0x040006F3 RID: 1779
		public CSteamID m_steamIDRemote;

		// Token: 0x040006F4 RID: 1780
		public byte m_eP2PSessionError;
	}
}
