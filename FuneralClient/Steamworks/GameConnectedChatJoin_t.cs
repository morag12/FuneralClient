using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200008A RID: 138
	[CallbackIdentity(339)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GameConnectedChatJoin_t
	{
		// Token: 0x04000564 RID: 1380
		public const int k_iCallback = 339;

		// Token: 0x04000565 RID: 1381
		public CSteamID m_steamIDClanChat;

		// Token: 0x04000566 RID: 1382
		public CSteamID m_steamIDUser;
	}
}
