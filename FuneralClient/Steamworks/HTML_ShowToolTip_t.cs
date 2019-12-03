using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000C1 RID: 193
	[CallbackIdentity(4524)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct HTML_ShowToolTip_t
	{
		// Token: 0x04000633 RID: 1587
		public const int k_iCallback = 4524;

		// Token: 0x04000634 RID: 1588
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x04000635 RID: 1589
		public string pchMsg;
	}
}
