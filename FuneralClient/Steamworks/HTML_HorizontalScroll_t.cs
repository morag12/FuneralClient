using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000B8 RID: 184
	[CallbackIdentity(4511)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct HTML_HorizontalScroll_t
	{
		// Token: 0x04000600 RID: 1536
		public const int k_iCallback = 4511;

		// Token: 0x04000601 RID: 1537
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x04000602 RID: 1538
		public uint unScrollMax;

		// Token: 0x04000603 RID: 1539
		public uint unScrollCurrent;

		// Token: 0x04000604 RID: 1540
		public float flPageScale;

		// Token: 0x04000605 RID: 1541
		[MarshalAs(UnmanagedType.I1)]
		public bool bVisible;

		// Token: 0x04000606 RID: 1542
		public uint unPageSize;
	}
}
