using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000C2 RID: 194
	[CallbackIdentity(4503)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct HTML_StartRequest_t
	{
		// Token: 0x04000636 RID: 1590
		public const int k_iCallback = 4503;

		// Token: 0x04000637 RID: 1591
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x04000638 RID: 1592
		public string pchURL;

		// Token: 0x04000639 RID: 1593
		public string pchTarget;

		// Token: 0x0400063A RID: 1594
		public string pchPostData;

		// Token: 0x0400063B RID: 1595
		[MarshalAs(UnmanagedType.I1)]
		public bool bIsRedirect;
	}
}
