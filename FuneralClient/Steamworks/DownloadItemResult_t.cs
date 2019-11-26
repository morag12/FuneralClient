using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000031 RID: 49
	[CallbackIdentity(3406)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct DownloadItemResult_t
	{
		// Token: 0x04000133 RID: 307
		public const int k_iCallback = 3406;

		// Token: 0x04000134 RID: 308
		public AppId_t m_unAppID;

		// Token: 0x04000135 RID: 309
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000136 RID: 310
		public EResult m_eResult;
	}
}
