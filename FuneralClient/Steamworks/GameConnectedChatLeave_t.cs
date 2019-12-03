using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200008B RID: 139
	[CallbackIdentity(340)]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct GameConnectedChatLeave_t
	{
		// Token: 0x04000567 RID: 1383
		public const int k_iCallback = 340;

		// Token: 0x04000568 RID: 1384
		public CSteamID m_steamIDClanChat;

		// Token: 0x04000569 RID: 1385
		public CSteamID m_steamIDUser;

		// Token: 0x0400056A RID: 1386
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bKicked;

		// Token: 0x0400056B RID: 1387
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bDropped;
	}
}
