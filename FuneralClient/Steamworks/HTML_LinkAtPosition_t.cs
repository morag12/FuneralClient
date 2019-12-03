using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000BB RID: 187
	[CallbackIdentity(4513)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct HTML_LinkAtPosition_t
	{
		// Token: 0x0400060D RID: 1549
		public const int k_iCallback = 4513;

		// Token: 0x0400060E RID: 1550
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x0400060F RID: 1551
		public uint x;

		// Token: 0x04000610 RID: 1552
		public uint y;

		// Token: 0x04000611 RID: 1553
		public string pchURL;

		// Token: 0x04000612 RID: 1554
		[MarshalAs(UnmanagedType.I1)]
		public bool bInput;

		// Token: 0x04000613 RID: 1555
		[MarshalAs(UnmanagedType.I1)]
		public bool bLiveLink;
	}
}
