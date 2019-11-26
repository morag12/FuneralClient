using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000B4 RID: 180
	[CallbackIdentity(4504)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct HTML_CloseBrowser_t
	{
		// Token: 0x040005F4 RID: 1524
		public const int k_iCallback = 4504;

		// Token: 0x040005F5 RID: 1525
		public HHTMLBrowser unBrowserHandle;
	}
}
