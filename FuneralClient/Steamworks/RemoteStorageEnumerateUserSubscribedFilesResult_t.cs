using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000129 RID: 297
	[CallbackIdentity(1314)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct RemoteStorageEnumerateUserSubscribedFilesResult_t
	{
		// Token: 0x0400073B RID: 1851
		public const int k_iCallback = 1314;

		// Token: 0x0400073C RID: 1852
		public EResult m_eResult;

		// Token: 0x0400073D RID: 1853
		public int m_nResultsReturned;

		// Token: 0x0400073E RID: 1854
		public int m_nTotalResultCount;

		// Token: 0x0400073F RID: 1855
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public PublishedFileId_t[] m_rgPublishedFileId;

		// Token: 0x04000740 RID: 1856
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public uint[] m_rgRTimeSubscribed;
	}
}
