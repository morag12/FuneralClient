using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000B2 RID: 178
	[CallbackIdentity(4510)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct HTML_CanGoBackAndForward_t
	{
		// Token: 0x040005ED RID: 1517
		public const int k_iCallback = 4510;

		// Token: 0x040005EE RID: 1518
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040005EF RID: 1519
		[MarshalAs(UnmanagedType.I1)]
		public bool bCanGoBack;

		// Token: 0x040005F0 RID: 1520
		[MarshalAs(UnmanagedType.I1)]
		public bool bCanGoForward;
	}
}
