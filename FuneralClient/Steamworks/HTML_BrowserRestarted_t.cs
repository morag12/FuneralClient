using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000B1 RID: 177
	[CallbackIdentity(4527)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct HTML_BrowserRestarted_t
	{
		// Token: 0x040005EA RID: 1514
		public const int k_iCallback = 4527;

		// Token: 0x040005EB RID: 1515
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040005EC RID: 1516
		public HHTMLBrowser unOldBrowserHandle;
	}
}
