using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000F9 RID: 249
	[CallbackIdentity(513)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct LobbyCreated_t
	{
		// Token: 0x040006B1 RID: 1713
		public const int k_iCallback = 513;

		// Token: 0x040006B2 RID: 1714
		public EResult m_eResult;

		// Token: 0x040006B3 RID: 1715
		public ulong m_ulSteamIDLobby;
	}
}
