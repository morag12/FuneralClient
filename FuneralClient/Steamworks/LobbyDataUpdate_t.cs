using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000FA RID: 250
	[CallbackIdentity(505)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct LobbyDataUpdate_t
	{
		// Token: 0x040006B4 RID: 1716
		public const int k_iCallback = 505;

		// Token: 0x040006B5 RID: 1717
		public ulong m_ulSteamIDLobby;

		// Token: 0x040006B6 RID: 1718
		public ulong m_ulSteamIDMember;

		// Token: 0x040006B7 RID: 1719
		public byte m_bSuccess;
	}
}
