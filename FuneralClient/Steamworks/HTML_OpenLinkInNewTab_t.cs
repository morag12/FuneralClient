using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000BE RID: 190
	[CallbackIdentity(4507)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct HTML_OpenLinkInNewTab_t
	{
		// Token: 0x04000629 RID: 1577
		public const int k_iCallback = 4507;

		// Token: 0x0400062A RID: 1578
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x0400062B RID: 1579
		public string pchURL;
	}
}
