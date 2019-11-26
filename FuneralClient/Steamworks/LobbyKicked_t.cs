using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000FE RID: 254
	[CallbackIdentity(512)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct LobbyKicked_t
	{
		// Token: 0x040006C6 RID: 1734
		public const int k_iCallback = 512;

		// Token: 0x040006C7 RID: 1735
		public ulong m_ulSteamIDLobby;

		// Token: 0x040006C8 RID: 1736
		public ulong m_ulSteamIDAdmin;

		// Token: 0x040006C9 RID: 1737
		public byte m_bKickedDueToDisconnect;
	}
}
