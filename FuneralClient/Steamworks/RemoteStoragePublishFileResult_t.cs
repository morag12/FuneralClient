using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000135 RID: 309
	[CallbackIdentity(1309)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct RemoteStoragePublishFileResult_t
	{
		// Token: 0x04000781 RID: 1921
		public const int k_iCallback = 1309;

		// Token: 0x04000782 RID: 1922
		public EResult m_eResult;

		// Token: 0x04000783 RID: 1923
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000784 RID: 1924
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
}
