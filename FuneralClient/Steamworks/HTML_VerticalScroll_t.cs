using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000C6 RID: 198
	[CallbackIdentity(4512)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct HTML_VerticalScroll_t
	{
		// Token: 0x04000649 RID: 1609
		public const int k_iCallback = 4512;

		// Token: 0x0400064A RID: 1610
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x0400064B RID: 1611
		public uint unScrollMax;

		// Token: 0x0400064C RID: 1612
		public uint unScrollCurrent;

		// Token: 0x0400064D RID: 1613
		public float flPageScale;

		// Token: 0x0400064E RID: 1614
		[MarshalAs(UnmanagedType.I1)]
		public bool bVisible;

		// Token: 0x0400064F RID: 1615
		public uint unPageSize;
	}
}
