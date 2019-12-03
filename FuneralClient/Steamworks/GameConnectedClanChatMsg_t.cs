using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200008C RID: 140
	[CallbackIdentity(338)]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct GameConnectedClanChatMsg_t
	{
		// Token: 0x0400056C RID: 1388
		public const int k_iCallback = 338;

		// Token: 0x0400056D RID: 1389
		public CSteamID m_steamIDClanChat;

		// Token: 0x0400056E RID: 1390
		public CSteamID m_steamIDUser;

		// Token: 0x0400056F RID: 1391
		public int m_iMessageID;
	}
}
