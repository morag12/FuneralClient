using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200013A RID: 314
	[CallbackIdentity(1324)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct RemoteStorageUpdateUserPublishedItemVoteResult_t
	{
		// Token: 0x04000793 RID: 1939
		public const int k_iCallback = 1324;

		// Token: 0x04000794 RID: 1940
		public EResult m_eResult;

		// Token: 0x04000795 RID: 1941
		public PublishedFileId_t m_nPublishedFileId;
	}
}
