using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000139 RID: 313
	[CallbackIdentity(1316)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct RemoteStorageUpdatePublishedFileResult_t
	{
		// Token: 0x0400078F RID: 1935
		public const int k_iCallback = 1316;

		// Token: 0x04000790 RID: 1936
		public EResult m_eResult;

		// Token: 0x04000791 RID: 1937
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000792 RID: 1938
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
}
