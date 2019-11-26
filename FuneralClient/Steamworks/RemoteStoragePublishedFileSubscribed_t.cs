using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000131 RID: 305
	[CallbackIdentity(1321)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct RemoteStoragePublishedFileSubscribed_t
	{
		// Token: 0x04000774 RID: 1908
		public const int k_iCallback = 1321;

		// Token: 0x04000775 RID: 1909
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000776 RID: 1910
		public AppId_t m_nAppID;
	}
}
