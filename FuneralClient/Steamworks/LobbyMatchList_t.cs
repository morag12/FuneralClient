using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000FF RID: 255
	[CallbackIdentity(510)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct LobbyMatchList_t
	{
		// Token: 0x040006CA RID: 1738
		public const int k_iCallback = 510;

		// Token: 0x040006CB RID: 1739
		public uint m_nLobbiesMatching;
	}
}
