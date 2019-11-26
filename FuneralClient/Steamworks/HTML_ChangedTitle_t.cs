using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000B3 RID: 179
	[CallbackIdentity(4508)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct HTML_ChangedTitle_t
	{
		// Token: 0x040005F1 RID: 1521
		public const int k_iCallback = 4508;

		// Token: 0x040005F2 RID: 1522
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040005F3 RID: 1523
		public string pchTitle;
	}
}
