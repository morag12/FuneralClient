using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200001D RID: 29
	[CallbackIdentity(335)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct ClanOfficerListResponse_t
	{
		// Token: 0x04000047 RID: 71
		public const int k_iCallback = 335;

		// Token: 0x04000048 RID: 72
		public CSteamID m_steamIDClan;

		// Token: 0x04000049 RID: 73
		public int m_cOfficers;

		// Token: 0x0400004A RID: 74
		public byte m_bSuccess;
	}
}
