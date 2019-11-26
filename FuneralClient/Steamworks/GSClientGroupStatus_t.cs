using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000A2 RID: 162
	[CallbackIdentity(208)]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct GSClientGroupStatus_t
	{
		// Token: 0x040005BF RID: 1471
		public const int k_iCallback = 208;

		// Token: 0x040005C0 RID: 1472
		public CSteamID m_SteamIDUser;

		// Token: 0x040005C1 RID: 1473
		public CSteamID m_SteamIDGroup;

		// Token: 0x040005C2 RID: 1474
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bMember;

		// Token: 0x040005C3 RID: 1475
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bOfficer;
	}
}
