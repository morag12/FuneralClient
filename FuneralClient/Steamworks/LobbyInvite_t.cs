using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000FD RID: 253
	[CallbackIdentity(503)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct LobbyInvite_t
	{
		// Token: 0x040006C2 RID: 1730
		public const int k_iCallback = 503;

		// Token: 0x040006C3 RID: 1731
		public ulong m_ulSteamIDUser;

		// Token: 0x040006C4 RID: 1732
		public ulong m_ulSteamIDLobby;

		// Token: 0x040006C5 RID: 1733
		public ulong m_ulGameID;
	}
}
