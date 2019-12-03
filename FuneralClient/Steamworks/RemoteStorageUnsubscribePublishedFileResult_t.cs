using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000138 RID: 312
	[CallbackIdentity(1315)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct RemoteStorageUnsubscribePublishedFileResult_t
	{
		// Token: 0x0400078C RID: 1932
		public const int k_iCallback = 1315;

		// Token: 0x0400078D RID: 1933
		public EResult m_eResult;

		// Token: 0x0400078E RID: 1934
		public PublishedFileId_t m_nPublishedFileId;
	}
}
