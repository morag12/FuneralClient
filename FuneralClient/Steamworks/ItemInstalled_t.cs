using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000EF RID: 239
	[CallbackIdentity(3405)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct ItemInstalled_t
	{
		// Token: 0x0400068A RID: 1674
		public const int k_iCallback = 3405;

		// Token: 0x0400068B RID: 1675
		public AppId_t m_unAppID;

		// Token: 0x0400068C RID: 1676
		public PublishedFileId_t m_nPublishedFileId;
	}
}
