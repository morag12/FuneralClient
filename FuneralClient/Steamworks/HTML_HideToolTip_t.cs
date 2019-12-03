using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000B7 RID: 183
	[CallbackIdentity(4526)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct HTML_HideToolTip_t
	{
		// Token: 0x040005FE RID: 1534
		public const int k_iCallback = 4526;

		// Token: 0x040005FF RID: 1535
		public HHTMLBrowser unBrowserHandle;
	}
}
