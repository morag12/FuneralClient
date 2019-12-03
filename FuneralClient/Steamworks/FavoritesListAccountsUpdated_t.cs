using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000080 RID: 128
	[CallbackIdentity(516)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct FavoritesListAccountsUpdated_t
	{
		// Token: 0x0400053C RID: 1340
		public const int k_iCallback = 516;

		// Token: 0x0400053D RID: 1341
		public EResult m_eResult;
	}
}
