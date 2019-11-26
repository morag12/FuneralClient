using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200012E RID: 302
	[CallbackIdentity(1318)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct RemoteStorageGetPublishedFileDetailsResult_t
	{
		// Token: 0x04000754 RID: 1876
		public const int k_iCallback = 1318;

		// Token: 0x04000755 RID: 1877
		public EResult m_eResult;

		// Token: 0x04000756 RID: 1878
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000757 RID: 1879
		public AppId_t m_nCreatorAppID;

		// Token: 0x04000758 RID: 1880
		public AppId_t m_nConsumerAppID;

		// Token: 0x04000759 RID: 1881
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
		public string m_rgchTitle;

		// Token: 0x0400075A RID: 1882
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8000)]
		public string m_rgchDescription;

		// Token: 0x0400075B RID: 1883
		public UGCHandle_t m_hFile;

		// Token: 0x0400075C RID: 1884
		public UGCHandle_t m_hPreviewFile;

		// Token: 0x0400075D RID: 1885
		public ulong m_ulSteamIDOwner;

		// Token: 0x0400075E RID: 1886
		public uint m_rtimeCreated;

		// Token: 0x0400075F RID: 1887
		public uint m_rtimeUpdated;

		// Token: 0x04000760 RID: 1888
		public ERemoteStoragePublishedFileVisibility m_eVisibility;

		// Token: 0x04000761 RID: 1889
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bBanned;

		// Token: 0x04000762 RID: 1890
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1025)]
		public string m_rgchTags;

		// Token: 0x04000763 RID: 1891
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bTagsTruncated;

		// Token: 0x04000764 RID: 1892
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string m_pchFileName;

		// Token: 0x04000765 RID: 1893
		public int m_nFileSize;

		// Token: 0x04000766 RID: 1894
		public int m_nPreviewFileSize;

		// Token: 0x04000767 RID: 1895
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string m_rgchURL;

		// Token: 0x04000768 RID: 1896
		public EWorkshopFileType m_eFileType;

		// Token: 0x04000769 RID: 1897
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bAcceptedForUse;
	}
}
