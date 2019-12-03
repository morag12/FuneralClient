using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000C8 RID: 200
	[CallbackIdentity(2101)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct HTTPRequestCompleted_t
	{
		// Token: 0x04000652 RID: 1618
		public const int k_iCallback = 2101;

		// Token: 0x04000653 RID: 1619
		public HTTPRequestHandle m_hRequest;

		// Token: 0x04000654 RID: 1620
		public ulong m_ulContextValue;

		// Token: 0x04000655 RID: 1621
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bRequestSuccessful;

		// Token: 0x04000656 RID: 1622
		public EHTTPStatusCode m_eStatusCode;

		// Token: 0x04000657 RID: 1623
		public uint m_unBodySize;
	}
}
