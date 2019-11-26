using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000163 RID: 355
	[CallbackIdentity(4701)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct SteamInventoryFullUpdate_t
	{
		// Token: 0x040007CE RID: 1998
		public const int k_iCallback = 4701;

		// Token: 0x040007CF RID: 1999
		public SteamInventoryResult_t m_handle;
	}
}
