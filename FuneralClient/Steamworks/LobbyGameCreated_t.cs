using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000FC RID: 252
	[CallbackIdentity(509)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct LobbyGameCreated_t
	{
		// Token: 0x040006BD RID: 1725
		public const int k_iCallback = 509;

		// Token: 0x040006BE RID: 1726
		public ulong m_ulSteamIDLobby;

		// Token: 0x040006BF RID: 1727
		public ulong m_ulSteamIDGameServer;

		// Token: 0x040006C0 RID: 1728
		public uint m_unIP;

		// Token: 0x040006C1 RID: 1729
		public ushort m_usPort;
	}
}
