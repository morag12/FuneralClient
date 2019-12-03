using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000124 RID: 292
	[CallbackIdentity(1311)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct RemoteStorageDeletePublishedFileResult_t
	{
		// Token: 0x04000720 RID: 1824
		public const int k_iCallback = 1311;

		// Token: 0x04000721 RID: 1825
		public EResult m_eResult;

		// Token: 0x04000722 RID: 1826
		public PublishedFileId_t m_nPublishedFileId;
	}
}
