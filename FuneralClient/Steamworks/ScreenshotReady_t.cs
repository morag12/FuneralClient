using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200013F RID: 319
	[CallbackIdentity(2301)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct ScreenshotReady_t
	{
		// Token: 0x040007A4 RID: 1956
		public const int k_iCallback = 2301;

		// Token: 0x040007A5 RID: 1957
		public ScreenshotHandle m_hLocal;

		// Token: 0x040007A6 RID: 1958
		public EResult m_eResult;
	}
}
