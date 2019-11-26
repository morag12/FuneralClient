using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200017F RID: 383
	[CallbackIdentity(3402)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct SteamUGCRequestUGCDetailsResult_t
	{
		// Token: 0x04000811 RID: 2065
		public const int k_iCallback = 3402;

		// Token: 0x04000812 RID: 2066
		public SteamUGCDetails_t m_details;

		// Token: 0x04000813 RID: 2067
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bCachedData;
	}
}
