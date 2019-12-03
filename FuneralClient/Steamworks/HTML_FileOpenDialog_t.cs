using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000B5 RID: 181
	[CallbackIdentity(4516)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct HTML_FileOpenDialog_t
	{
		// Token: 0x040005F6 RID: 1526
		public const int k_iCallback = 4516;

		// Token: 0x040005F7 RID: 1527
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040005F8 RID: 1528
		public string pchTitle;

		// Token: 0x040005F9 RID: 1529
		public string pchInitialFile;
	}
}
