using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200009B RID: 155
	[CallbackIdentity(3409)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GetUserItemVoteResult_t
	{
		// Token: 0x040005A4 RID: 1444
		public const int k_iCallback = 3409;

		// Token: 0x040005A5 RID: 1445
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x040005A6 RID: 1446
		public EResult m_eResult;

		// Token: 0x040005A7 RID: 1447
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bVotedUp;

		// Token: 0x040005A8 RID: 1448
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bVotedDown;

		// Token: 0x040005A9 RID: 1449
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bVoteSkipped;
	}
}
