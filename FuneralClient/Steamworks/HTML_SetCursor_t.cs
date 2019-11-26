using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000C0 RID: 192
	[CallbackIdentity(4522)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct HTML_SetCursor_t
	{
		// Token: 0x04000630 RID: 1584
		public const int k_iCallback = 4522;

		// Token: 0x04000631 RID: 1585
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x04000632 RID: 1586
		public uint eMouseCursor;
	}
}
