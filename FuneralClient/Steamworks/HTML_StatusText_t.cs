using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000C3 RID: 195
	[CallbackIdentity(4523)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct HTML_StatusText_t
	{
		// Token: 0x0400063C RID: 1596
		public const int k_iCallback = 4523;

		// Token: 0x0400063D RID: 1597
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x0400063E RID: 1598
		public string pchMsg;
	}
}
