using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000BD RID: 189
	[CallbackIdentity(4521)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct HTML_NewWindow_t
	{
		// Token: 0x04000621 RID: 1569
		public const int k_iCallback = 4521;

		// Token: 0x04000622 RID: 1570
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x04000623 RID: 1571
		public string pchURL;

		// Token: 0x04000624 RID: 1572
		public uint unX;

		// Token: 0x04000625 RID: 1573
		public uint unY;

		// Token: 0x04000626 RID: 1574
		public uint unWide;

		// Token: 0x04000627 RID: 1575
		public uint unTall;

		// Token: 0x04000628 RID: 1576
		public HHTMLBrowser unNewWindow_BrowserHandle;
	}
}
