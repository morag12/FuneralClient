using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200018E RID: 398
	[CallbackIdentity(1101)]
	[StructLayout(LayoutKind.Explicit, Pack = 8)]
	public struct UserStatsReceived_t
	{
		// Token: 0x04000833 RID: 2099
		public const int k_iCallback = 1101;

		// Token: 0x04000834 RID: 2100
		[FieldOffset(0)]
		public ulong m_nGameID;

		// Token: 0x04000835 RID: 2101
		[FieldOffset(8)]
		public EResult m_eResult;

		// Token: 0x04000836 RID: 2102
		[FieldOffset(12)]
		public CSteamID m_steamIDUser;
	}
}
