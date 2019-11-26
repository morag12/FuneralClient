using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000FB RID: 251
	[CallbackIdentity(504)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct LobbyEnter_t
	{
		// Token: 0x040006B8 RID: 1720
		public const int k_iCallback = 504;

		// Token: 0x040006B9 RID: 1721
		public ulong m_ulSteamIDLobby;

		// Token: 0x040006BA RID: 1722
		public uint m_rgfChatPermissions;

		// Token: 0x040006BB RID: 1723
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bLocked;

		// Token: 0x040006BC RID: 1724
		public uint m_EChatRoomEnterResponse;
	}
}
