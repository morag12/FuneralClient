using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000B0 RID: 176
	[CallbackIdentity(4501)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct HTML_BrowserReady_t
	{
		// Token: 0x040005E8 RID: 1512
		public const int k_iCallback = 4501;

		// Token: 0x040005E9 RID: 1513
		public HHTMLBrowser unBrowserHandle;
	}
}
