using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000147 RID: 327
	[CallbackIdentity(1201)]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct SocketStatusCallback_t
	{
		// Token: 0x040007B7 RID: 1975
		public const int k_iCallback = 1201;

		// Token: 0x040007B8 RID: 1976
		public SNetSocket_t m_hSocket;

		// Token: 0x040007B9 RID: 1977
		public SNetListenSocket_t m_hListenSocket;

		// Token: 0x040007BA RID: 1978
		public CSteamID m_steamIDRemote;

		// Token: 0x040007BB RID: 1979
		public int m_eSNetSocketState;
	}
}
