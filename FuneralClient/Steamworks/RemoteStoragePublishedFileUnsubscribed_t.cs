using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000132 RID: 306
	[CallbackIdentity(1322)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct RemoteStoragePublishedFileUnsubscribed_t
	{
		// Token: 0x04000777 RID: 1911
		public const int k_iCallback = 1322;

		// Token: 0x04000778 RID: 1912
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000779 RID: 1913
		public AppId_t m_nAppID;
	}
}
