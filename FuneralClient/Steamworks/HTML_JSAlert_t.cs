using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000B9 RID: 185
	[CallbackIdentity(4514)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct HTML_JSAlert_t
	{
		// Token: 0x04000607 RID: 1543
		public const int k_iCallback = 4514;

		// Token: 0x04000608 RID: 1544
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x04000609 RID: 1545
		public string pchMessage;
	}
}
