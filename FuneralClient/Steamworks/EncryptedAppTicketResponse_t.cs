using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200005B RID: 91
	[CallbackIdentity(154)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct EncryptedAppTicketResponse_t
	{
		// Token: 0x040003AC RID: 940
		public const int k_iCallback = 154;

		// Token: 0x040003AD RID: 941
		public EResult m_eResult;
	}
}
