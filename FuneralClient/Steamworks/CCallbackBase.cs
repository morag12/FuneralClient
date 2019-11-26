using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000015 RID: 21
	[StructLayout(LayoutKind.Sequential)]
	internal class CCallbackBase
	{
		// Token: 0x04000036 RID: 54
		public const byte k_ECallbackFlagsRegistered = 1;

		// Token: 0x04000037 RID: 55
		public const byte k_ECallbackFlagsGameServer = 2;

		// Token: 0x04000038 RID: 56
		public IntPtr m_vfptr;

		// Token: 0x04000039 RID: 57
		public byte m_nCallbackFlags;

		// Token: 0x0400003A RID: 58
		public int m_iCallback;
	}
}
