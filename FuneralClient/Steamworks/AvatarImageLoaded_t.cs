using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200000A RID: 10
	[CallbackIdentity(334)]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct AvatarImageLoaded_t
	{
		// Token: 0x04000019 RID: 25
		public const int k_iCallback = 334;

		// Token: 0x0400001A RID: 26
		public CSteamID m_steamID;

		// Token: 0x0400001B RID: 27
		public int m_iImage;

		// Token: 0x0400001C RID: 28
		public int m_iWide;

		// Token: 0x0400001D RID: 29
		public int m_iTall;
	}
}
