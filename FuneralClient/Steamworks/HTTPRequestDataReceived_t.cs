using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000C9 RID: 201
	[CallbackIdentity(2103)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct HTTPRequestDataReceived_t
	{
		// Token: 0x04000658 RID: 1624
		public const int k_iCallback = 2103;

		// Token: 0x04000659 RID: 1625
		public HTTPRequestHandle m_hRequest;

		// Token: 0x0400065A RID: 1626
		public ulong m_ulContextValue;

		// Token: 0x0400065B RID: 1627
		public uint m_cOffset;

		// Token: 0x0400065C RID: 1628
		public uint m_cBytesReceived;
	}
}
