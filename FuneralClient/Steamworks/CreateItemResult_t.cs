using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000028 RID: 40
	[CallbackIdentity(3403)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct CreateItemResult_t
	{
		// Token: 0x04000102 RID: 258
		public const int k_iCallback = 3403;

		// Token: 0x04000103 RID: 259
		public EResult m_eResult;

		// Token: 0x04000104 RID: 260
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000105 RID: 261
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
}
