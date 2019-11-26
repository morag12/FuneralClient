using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000178 RID: 376
	[CallbackIdentity(102)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct SteamServerConnectFailure_t
	{
		// Token: 0x040007EA RID: 2026
		public const int k_iCallback = 102;

		// Token: 0x040007EB RID: 2027
		public EResult m_eResult;

		// Token: 0x040007EC RID: 2028
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bStillRetrying;
	}
}
