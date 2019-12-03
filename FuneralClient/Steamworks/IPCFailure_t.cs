using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000CF RID: 207
	[CallbackIdentity(117)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct IPCFailure_t
	{
		// Token: 0x04000665 RID: 1637
		public const int k_iCallback = 117;

		// Token: 0x04000666 RID: 1638
		public byte m_eFailureType;
	}
}
