using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000A5 RID: 165
	[CallbackIdentity(115)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GSPolicyResponse_t
	{
		// Token: 0x040005CC RID: 1484
		public const int k_iCallback = 115;

		// Token: 0x040005CD RID: 1485
		public byte m_bSecure;
	}
}
