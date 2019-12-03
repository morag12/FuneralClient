using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000C5 RID: 197
	[CallbackIdentity(4505)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct HTML_URLChanged_t
	{
		// Token: 0x04000642 RID: 1602
		public const int k_iCallback = 4505;

		// Token: 0x04000643 RID: 1603
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x04000644 RID: 1604
		public string pchURL;

		// Token: 0x04000645 RID: 1605
		public string pchPostData;

		// Token: 0x04000646 RID: 1606
		[MarshalAs(UnmanagedType.I1)]
		public bool bIsRedirect;

		// Token: 0x04000647 RID: 1607
		public string pchPageTitle;

		// Token: 0x04000648 RID: 1608
		[MarshalAs(UnmanagedType.I1)]
		public bool bNewNavigation;
	}
}
