using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200011B RID: 283
	[CallbackIdentity(304)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct PersonaStateChange_t
	{
		// Token: 0x04000704 RID: 1796
		public const int k_iCallback = 304;

		// Token: 0x04000705 RID: 1797
		public ulong m_ulSteamID;

		// Token: 0x04000706 RID: 1798
		public EPersonaChange m_nChangeFlags;
	}
}
