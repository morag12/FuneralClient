using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000F7 RID: 247
	[CallbackIdentity(507)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct LobbyChatMsg_t
	{
		// Token: 0x040006A7 RID: 1703
		public const int k_iCallback = 507;

		// Token: 0x040006A8 RID: 1704
		public ulong m_ulSteamIDLobby;

		// Token: 0x040006A9 RID: 1705
		public ulong m_ulSteamIDUser;

		// Token: 0x040006AA RID: 1706
		public byte m_eChatEntryType;

		// Token: 0x040006AB RID: 1707
		public uint m_iChatID;
	}
}
