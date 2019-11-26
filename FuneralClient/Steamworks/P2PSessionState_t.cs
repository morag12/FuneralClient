using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000118 RID: 280
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct P2PSessionState_t
	{
		// Token: 0x040006F7 RID: 1783
		public byte m_bConnectionActive;

		// Token: 0x040006F8 RID: 1784
		public byte m_bConnecting;

		// Token: 0x040006F9 RID: 1785
		public byte m_eP2PSessionError;

		// Token: 0x040006FA RID: 1786
		public byte m_bUsingRelay;

		// Token: 0x040006FB RID: 1787
		public int m_nBytesQueuedForSend;

		// Token: 0x040006FC RID: 1788
		public int m_nPacketsQueuedForSend;

		// Token: 0x040006FD RID: 1789
		public uint m_nRemoteIP;

		// Token: 0x040006FE RID: 1790
		public ushort m_nRemotePort;
	}
}
