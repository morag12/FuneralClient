using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000A3 RID: 163
	[CallbackIdentity(203)]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct GSClientKick_t
	{
		// Token: 0x040005C4 RID: 1476
		public const int k_iCallback = 203;

		// Token: 0x040005C5 RID: 1477
		public CSteamID m_SteamID;

		// Token: 0x040005C6 RID: 1478
		public EDenyReason m_eDenyReason;
	}
}
