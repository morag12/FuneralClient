using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000BA RID: 186
	[CallbackIdentity(4515)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct HTML_JSConfirm_t
	{
		// Token: 0x0400060A RID: 1546
		public const int k_iCallback = 4515;

		// Token: 0x0400060B RID: 1547
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x0400060C RID: 1548
		public string pchMessage;
	}
}
