using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000BC RID: 188
	[CallbackIdentity(4502)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct HTML_NeedsPaint_t
	{
		// Token: 0x04000614 RID: 1556
		public const int k_iCallback = 4502;

		// Token: 0x04000615 RID: 1557
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x04000616 RID: 1558
		public IntPtr pBGRA;

		// Token: 0x04000617 RID: 1559
		public uint unWide;

		// Token: 0x04000618 RID: 1560
		public uint unTall;

		// Token: 0x04000619 RID: 1561
		public uint unUpdateX;

		// Token: 0x0400061A RID: 1562
		public uint unUpdateY;

		// Token: 0x0400061B RID: 1563
		public uint unUpdateWide;

		// Token: 0x0400061C RID: 1564
		public uint unUpdateTall;

		// Token: 0x0400061D RID: 1565
		public uint unScrollX;

		// Token: 0x0400061E RID: 1566
		public uint unScrollY;

		// Token: 0x0400061F RID: 1567
		public float flPageScale;

		// Token: 0x04000620 RID: 1568
		public uint unPageSerial;
	}
}
