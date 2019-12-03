using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200018F RID: 399
	[CallbackIdentity(1102)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct UserStatsStored_t
	{
		// Token: 0x04000837 RID: 2103
		public const int k_iCallback = 1102;

		// Token: 0x04000838 RID: 2104
		public ulong m_nGameID;

		// Token: 0x04000839 RID: 2105
		public EResult m_eResult;
	}
}
