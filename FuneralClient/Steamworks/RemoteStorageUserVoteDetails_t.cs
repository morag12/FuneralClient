using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200013B RID: 315
	[CallbackIdentity(1325)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct RemoteStorageUserVoteDetails_t
	{
		// Token: 0x04000796 RID: 1942
		public const int k_iCallback = 1325;

		// Token: 0x04000797 RID: 1943
		public EResult m_eResult;

		// Token: 0x04000798 RID: 1944
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000799 RID: 1945
		public EWorkshopVote m_eVote;
	}
}
