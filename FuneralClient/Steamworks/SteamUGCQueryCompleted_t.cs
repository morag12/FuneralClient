using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200017E RID: 382
	[CallbackIdentity(3401)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct SteamUGCQueryCompleted_t
	{
		// Token: 0x0400080B RID: 2059
		public const int k_iCallback = 3401;

		// Token: 0x0400080C RID: 2060
		public UGCQueryHandle_t m_handle;

		// Token: 0x0400080D RID: 2061
		public EResult m_eResult;

		// Token: 0x0400080E RID: 2062
		public uint m_unNumResultsReturned;

		// Token: 0x0400080F RID: 2063
		public uint m_unTotalMatchingResults;

		// Token: 0x04000810 RID: 2064
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bCachedData;
	}
}
