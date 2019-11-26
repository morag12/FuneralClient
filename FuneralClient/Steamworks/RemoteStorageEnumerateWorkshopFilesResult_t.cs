using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200012A RID: 298
	[CallbackIdentity(1319)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct RemoteStorageEnumerateWorkshopFilesResult_t
	{
		// Token: 0x04000741 RID: 1857
		public const int k_iCallback = 1319;

		// Token: 0x04000742 RID: 1858
		public EResult m_eResult;

		// Token: 0x04000743 RID: 1859
		public int m_nResultsReturned;

		// Token: 0x04000744 RID: 1860
		public int m_nTotalResultCount;

		// Token: 0x04000745 RID: 1861
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public PublishedFileId_t[] m_rgPublishedFileId;

		// Token: 0x04000746 RID: 1862
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public float[] m_rgScore;

		// Token: 0x04000747 RID: 1863
		public AppId_t m_nAppId;

		// Token: 0x04000748 RID: 1864
		public uint m_unStartIndex;
	}
}
