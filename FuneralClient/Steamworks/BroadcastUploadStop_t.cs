using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200000C RID: 12
	[CallbackIdentity(4605)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct BroadcastUploadStop_t
	{
		// Token: 0x0400001F RID: 31
		public const int k_iCallback = 4605;

		// Token: 0x04000020 RID: 32
		public EBroadcastUploadResult m_eResult;
	}
}
