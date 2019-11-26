using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000096 RID: 150
	[CallbackIdentity(1701)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GCMessageAvailable_t
	{
		// Token: 0x04000595 RID: 1429
		public const int k_iCallback = 1701;

		// Token: 0x04000596 RID: 1430
		public uint m_nMessageSize;
	}
}
