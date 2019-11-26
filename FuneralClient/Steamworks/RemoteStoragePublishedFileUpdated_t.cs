using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000133 RID: 307
	[CallbackIdentity(1330)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct RemoteStoragePublishedFileUpdated_t
	{
		// Token: 0x0400077A RID: 1914
		public const int k_iCallback = 1330;

		// Token: 0x0400077B RID: 1915
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x0400077C RID: 1916
		public AppId_t m_nAppID;

		// Token: 0x0400077D RID: 1917
		public ulong m_ulUnused;
	}
}
