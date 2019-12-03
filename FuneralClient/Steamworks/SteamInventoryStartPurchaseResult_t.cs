using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000167 RID: 359
	[CallbackIdentity(4704)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct SteamInventoryStartPurchaseResult_t
	{
		// Token: 0x040007D8 RID: 2008
		public const int k_iCallback = 4704;

		// Token: 0x040007D9 RID: 2009
		public EResult m_result;

		// Token: 0x040007DA RID: 2010
		public ulong m_ulOrderID;

		// Token: 0x040007DB RID: 2011
		public ulong m_ulTransID;
	}
}
