using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200008D RID: 141
	[CallbackIdentity(343)]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct GameConnectedFriendChatMsg_t
	{
		// Token: 0x04000570 RID: 1392
		public const int k_iCallback = 343;

		// Token: 0x04000571 RID: 1393
		public CSteamID m_steamIDUser;

		// Token: 0x04000572 RID: 1394
		public int m_iMessageID;
	}
}
