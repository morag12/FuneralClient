using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000103 RID: 259
	[CallbackIdentity(152)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct MicroTxnAuthorizationResponse_t
	{
		// Token: 0x040006D2 RID: 1746
		public const int k_iCallback = 152;

		// Token: 0x040006D3 RID: 1747
		public uint m_unAppID;

		// Token: 0x040006D4 RID: 1748
		public ulong m_ulOrderID;

		// Token: 0x040006D5 RID: 1749
		public byte m_bAuthorized;
	}
}
