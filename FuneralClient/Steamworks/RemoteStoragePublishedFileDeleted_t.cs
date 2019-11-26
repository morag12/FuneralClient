using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000130 RID: 304
	[CallbackIdentity(1323)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct RemoteStoragePublishedFileDeleted_t
	{
		// Token: 0x04000771 RID: 1905
		public const int k_iCallback = 1323;

		// Token: 0x04000772 RID: 1906
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000773 RID: 1907
		public AppId_t m_nAppID;
	}
}
