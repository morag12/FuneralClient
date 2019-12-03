using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000B6 RID: 182
	[CallbackIdentity(4506)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct HTML_FinishedRequest_t
	{
		// Token: 0x040005FA RID: 1530
		public const int k_iCallback = 4506;

		// Token: 0x040005FB RID: 1531
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040005FC RID: 1532
		public string pchURL;

		// Token: 0x040005FD RID: 1533
		public string pchPageTitle;
	}
}
