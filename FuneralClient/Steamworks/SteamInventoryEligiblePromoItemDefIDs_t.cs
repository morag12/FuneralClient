using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000162 RID: 354
	[CallbackIdentity(4703)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct SteamInventoryEligiblePromoItemDefIDs_t
	{
		// Token: 0x040007C9 RID: 1993
		public const int k_iCallback = 4703;

		// Token: 0x040007CA RID: 1994
		public EResult m_result;

		// Token: 0x040007CB RID: 1995
		public CSteamID m_steamID;

		// Token: 0x040007CC RID: 1996
		public int m_numEligiblePromoItemDefs;

		// Token: 0x040007CD RID: 1997
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bCachedData;
	}
}
