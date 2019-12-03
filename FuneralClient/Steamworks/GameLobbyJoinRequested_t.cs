using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200008E RID: 142
	[CallbackIdentity(333)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GameLobbyJoinRequested_t
	{
		// Token: 0x04000573 RID: 1395
		public const int k_iCallback = 333;

		// Token: 0x04000574 RID: 1396
		public CSteamID m_steamIDLobby;

		// Token: 0x04000575 RID: 1397
		public CSteamID m_steamIDFriend;
	}
}
