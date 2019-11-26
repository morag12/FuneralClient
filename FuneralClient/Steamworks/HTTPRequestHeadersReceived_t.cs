using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000CB RID: 203
	[CallbackIdentity(2102)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct HTTPRequestHeadersReceived_t
	{
		// Token: 0x0400065F RID: 1631
		public const int k_iCallback = 2102;

		// Token: 0x04000660 RID: 1632
		public HTTPRequestHandle m_hRequest;

		// Token: 0x04000661 RID: 1633
		public ulong m_ulContextValue;
	}
}
