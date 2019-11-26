using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000191 RID: 401
	[CallbackIdentity(143)]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct ValidateAuthTicketResponse_t
	{
		// Token: 0x0400083C RID: 2108
		public const int k_iCallback = 143;

		// Token: 0x0400083D RID: 2109
		public CSteamID m_SteamID;

		// Token: 0x0400083E RID: 2110
		public EAuthSessionResponse m_eAuthSessionResponse;

		// Token: 0x0400083F RID: 2111
		public CSteamID m_OwnerSteamID;
	}
}
