using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200014A RID: 330
	[CallbackIdentity(703)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct SteamAPICallCompleted_t
	{
		// Token: 0x040007BE RID: 1982
		public const int k_iCallback = 703;

		// Token: 0x040007BF RID: 1983
		public SteamAPICall_t m_hAsyncCall;

		// Token: 0x040007C0 RID: 1984
		public int m_iCallback;

		// Token: 0x040007C1 RID: 1985
		public uint m_cubParam;
	}
}
