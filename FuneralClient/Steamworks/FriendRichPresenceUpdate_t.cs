using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000084 RID: 132
	[CallbackIdentity(336)]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct FriendRichPresenceUpdate_t
	{
		// Token: 0x04000550 RID: 1360
		public const int k_iCallback = 336;

		// Token: 0x04000551 RID: 1361
		public CSteamID m_steamIDFriend;

		// Token: 0x04000552 RID: 1362
		public AppId_t m_nAppID;
	}
}
