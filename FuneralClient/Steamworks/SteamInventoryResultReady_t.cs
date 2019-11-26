using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000165 RID: 357
	[CallbackIdentity(4700)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct SteamInventoryResultReady_t
	{
		// Token: 0x040007D3 RID: 2003
		public const int k_iCallback = 4700;

		// Token: 0x040007D4 RID: 2004
		public SteamInventoryResult_t m_handle;

		// Token: 0x040007D5 RID: 2005
		public EResult m_result;
	}
}
