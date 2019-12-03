using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000143 RID: 323
	[CallbackIdentity(3408)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct SetUserItemVoteResult_t
	{
		// Token: 0x040007AF RID: 1967
		public const int k_iCallback = 3408;

		// Token: 0x040007B0 RID: 1968
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x040007B1 RID: 1969
		public EResult m_eResult;

		// Token: 0x040007B2 RID: 1970
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bVoteUp;
	}
}
