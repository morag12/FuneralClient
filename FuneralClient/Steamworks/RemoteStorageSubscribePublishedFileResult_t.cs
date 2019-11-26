using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000137 RID: 311
	[CallbackIdentity(1313)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct RemoteStorageSubscribePublishedFileResult_t
	{
		// Token: 0x04000789 RID: 1929
		public const int k_iCallback = 1313;

		// Token: 0x0400078A RID: 1930
		public EResult m_eResult;

		// Token: 0x0400078B RID: 1931
		public PublishedFileId_t m_nPublishedFileId;
	}
}
