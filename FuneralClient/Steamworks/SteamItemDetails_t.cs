using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200016A RID: 362
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct SteamItemDetails_t
	{
		// Token: 0x040007DF RID: 2015
		public SteamItemInstanceID_t m_itemId;

		// Token: 0x040007E0 RID: 2016
		public SteamItemDef_t m_iDefinition;

		// Token: 0x040007E1 RID: 2017
		public ushort m_unQuantity;

		// Token: 0x040007E2 RID: 2018
		public ushort m_unFlags;
	}
}
