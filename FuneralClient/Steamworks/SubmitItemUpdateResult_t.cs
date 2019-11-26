using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000186 RID: 390
	[CallbackIdentity(3404)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct SubmitItemUpdateResult_t
	{
		// Token: 0x04000818 RID: 2072
		public const int k_iCallback = 3404;

		// Token: 0x04000819 RID: 2073
		public EResult m_eResult;

		// Token: 0x0400081A RID: 2074
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;

		// Token: 0x0400081B RID: 2075
		public PublishedFileId_t m_nPublishedFileId;
	}
}
