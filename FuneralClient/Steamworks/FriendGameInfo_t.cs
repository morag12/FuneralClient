using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000083 RID: 131
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct FriendGameInfo_t
	{
		// Token: 0x0400054B RID: 1355
		public CGameID m_gameID;

		// Token: 0x0400054C RID: 1356
		public uint m_unGameIP;

		// Token: 0x0400054D RID: 1357
		public ushort m_usGamePort;

		// Token: 0x0400054E RID: 1358
		public ushort m_usQueryPort;

		// Token: 0x0400054F RID: 1359
		public CSteamID m_steamIDLobby;
	}
}
