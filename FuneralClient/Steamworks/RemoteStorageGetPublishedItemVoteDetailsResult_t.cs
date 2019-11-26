using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200012F RID: 303
	[CallbackIdentity(1320)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct RemoteStorageGetPublishedItemVoteDetailsResult_t
	{
		// Token: 0x0400076A RID: 1898
		public const int k_iCallback = 1320;

		// Token: 0x0400076B RID: 1899
		public EResult m_eResult;

		// Token: 0x0400076C RID: 1900
		public PublishedFileId_t m_unPublishedFileId;

		// Token: 0x0400076D RID: 1901
		public int m_nVotesFor;

		// Token: 0x0400076E RID: 1902
		public int m_nVotesAgainst;

		// Token: 0x0400076F RID: 1903
		public int m_nReports;

		// Token: 0x04000770 RID: 1904
		public float m_fScore;
	}
}
