using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000099 RID: 153
	[CallbackIdentity(163)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GetAuthSessionTicketResponse_t
	{
		// Token: 0x0400059E RID: 1438
		public const int k_iCallback = 163;

		// Token: 0x0400059F RID: 1439
		public HAuthTicket m_hAuthTicket;

		// Token: 0x040005A0 RID: 1440
		public EResult m_eResult;
	}
}
