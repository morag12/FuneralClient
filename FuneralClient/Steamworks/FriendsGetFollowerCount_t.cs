using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000087 RID: 135
	[CallbackIdentity(344)]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct FriendsGetFollowerCount_t
	{
		// Token: 0x0400055A RID: 1370
		public const int k_iCallback = 344;

		// Token: 0x0400055B RID: 1371
		public EResult m_eResult;

		// Token: 0x0400055C RID: 1372
		public CSteamID m_steamID;

		// Token: 0x0400055D RID: 1373
		public int m_nCount;
	}
}
