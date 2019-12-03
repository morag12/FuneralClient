using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000127 RID: 295
	[CallbackIdentity(1312)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct RemoteStorageEnumerateUserPublishedFilesResult_t
	{
		// Token: 0x04000731 RID: 1841
		public const int k_iCallback = 1312;

		// Token: 0x04000732 RID: 1842
		public EResult m_eResult;

		// Token: 0x04000733 RID: 1843
		public int m_nResultsReturned;

		// Token: 0x04000734 RID: 1844
		public int m_nTotalResultCount;

		// Token: 0x04000735 RID: 1845
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public PublishedFileId_t[] m_rgPublishedFileId;
	}
}
