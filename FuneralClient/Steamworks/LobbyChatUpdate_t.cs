using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000F8 RID: 248
	[CallbackIdentity(506)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct LobbyChatUpdate_t
	{
		// Token: 0x040006AC RID: 1708
		public const int k_iCallback = 506;

		// Token: 0x040006AD RID: 1709
		public ulong m_ulSteamIDLobby;

		// Token: 0x040006AE RID: 1710
		public ulong m_ulSteamIDUserChanged;

		// Token: 0x040006AF RID: 1711
		public ulong m_ulSteamIDMakingChange;

		// Token: 0x040006B0 RID: 1712
		public uint m_rgfChatMemberStateChange;
	}
}
