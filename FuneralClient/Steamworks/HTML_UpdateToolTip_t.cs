using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000C4 RID: 196
	[CallbackIdentity(4525)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct HTML_UpdateToolTip_t
	{
		// Token: 0x0400063F RID: 1599
		public const int k_iCallback = 4525;

		// Token: 0x04000640 RID: 1600
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x04000641 RID: 1601
		public string pchMsg;
	}
}
