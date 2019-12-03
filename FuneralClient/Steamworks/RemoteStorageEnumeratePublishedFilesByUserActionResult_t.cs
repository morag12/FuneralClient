using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000126 RID: 294
	[CallbackIdentity(1328)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct RemoteStorageEnumeratePublishedFilesByUserActionResult_t
	{
		// Token: 0x0400072A RID: 1834
		public const int k_iCallback = 1328;

		// Token: 0x0400072B RID: 1835
		public EResult m_eResult;

		// Token: 0x0400072C RID: 1836
		public EWorkshopFileAction m_eAction;

		// Token: 0x0400072D RID: 1837
		public int m_nResultsReturned;

		// Token: 0x0400072E RID: 1838
		public int m_nTotalResultCount;

		// Token: 0x0400072F RID: 1839
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public PublishedFileId_t[] m_rgPublishedFileId;

		// Token: 0x04000730 RID: 1840
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public uint[] m_rgRTimeUpdated;
	}
}
