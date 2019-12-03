using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000F0 RID: 240
	[CallbackIdentity(342)]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct JoinClanChatRoomCompletionResult_t
	{
		// Token: 0x0400068D RID: 1677
		public const int k_iCallback = 342;

		// Token: 0x0400068E RID: 1678
		public CSteamID m_steamIDClanChat;

		// Token: 0x0400068F RID: 1679
		public EChatRoomEnterResponse m_eChatRoomEnterResponse;
	}
}
