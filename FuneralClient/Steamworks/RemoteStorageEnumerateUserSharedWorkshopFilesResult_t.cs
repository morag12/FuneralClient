using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000128 RID: 296
	[CallbackIdentity(1326)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct RemoteStorageEnumerateUserSharedWorkshopFilesResult_t
	{
		// Token: 0x04000736 RID: 1846
		public const int k_iCallback = 1326;

		// Token: 0x04000737 RID: 1847
		public EResult m_eResult;

		// Token: 0x04000738 RID: 1848
		public int m_nResultsReturned;

		// Token: 0x04000739 RID: 1849
		public int m_nTotalResultCount;

		// Token: 0x0400073A RID: 1850
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public PublishedFileId_t[] m_rgPublishedFileId;
	}
}
