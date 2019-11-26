using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000089 RID: 137
	[CallbackIdentity(345)]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct FriendsIsFollowing_t
	{
		// Token: 0x04000560 RID: 1376
		public const int k_iCallback = 345;

		// Token: 0x04000561 RID: 1377
		public EResult m_eResult;

		// Token: 0x04000562 RID: 1378
		public CSteamID m_steamID;

		// Token: 0x04000563 RID: 1379
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bIsFollowing;
	}
}
