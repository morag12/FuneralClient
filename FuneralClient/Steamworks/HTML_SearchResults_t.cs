using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000BF RID: 191
	[CallbackIdentity(4509)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct HTML_SearchResults_t
	{
		// Token: 0x0400062C RID: 1580
		public const int k_iCallback = 4509;

		// Token: 0x0400062D RID: 1581
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x0400062E RID: 1582
		public uint unResults;

		// Token: 0x0400062F RID: 1583
		public uint unCurrentMatch;
	}
}
