using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200017D RID: 381
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct SteamUGCDetails_t
	{
		// Token: 0x040007F1 RID: 2033
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x040007F2 RID: 2034
		public EResult m_eResult;

		// Token: 0x040007F3 RID: 2035
		public EWorkshopFileType m_eFileType;

		// Token: 0x040007F4 RID: 2036
		public AppId_t m_nCreatorAppID;

		// Token: 0x040007F5 RID: 2037
		public AppId_t m_nConsumerAppID;

		// Token: 0x040007F6 RID: 2038
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
		public string m_rgchTitle;

		// Token: 0x040007F7 RID: 2039
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8000)]
		public string m_rgchDescription;

		// Token: 0x040007F8 RID: 2040
		public ulong m_ulSteamIDOwner;

		// Token: 0x040007F9 RID: 2041
		public uint m_rtimeCreated;

		// Token: 0x040007FA RID: 2042
		public uint m_rtimeUpdated;

		// Token: 0x040007FB RID: 2043
		public uint m_rtimeAddedToUserList;

		// Token: 0x040007FC RID: 2044
		public ERemoteStoragePublishedFileVisibility m_eVisibility;

		// Token: 0x040007FD RID: 2045
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bBanned;

		// Token: 0x040007FE RID: 2046
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bAcceptedForUse;

		// Token: 0x040007FF RID: 2047
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bTagsTruncated;

		// Token: 0x04000800 RID: 2048
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1025)]
		public string m_rgchTags;

		// Token: 0x04000801 RID: 2049
		public UGCHandle_t m_hFile;

		// Token: 0x04000802 RID: 2050
		public UGCHandle_t m_hPreviewFile;

		// Token: 0x04000803 RID: 2051
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string m_pchFileName;

		// Token: 0x04000804 RID: 2052
		public int m_nFileSize;

		// Token: 0x04000805 RID: 2053
		public int m_nPreviewFileSize;

		// Token: 0x04000806 RID: 2054
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string m_rgchURL;

		// Token: 0x04000807 RID: 2055
		public uint m_unVotesUp;

		// Token: 0x04000808 RID: 2056
		public uint m_unVotesDown;

		// Token: 0x04000809 RID: 2057
		public float m_flScore;

		// Token: 0x0400080A RID: 2058
		public uint m_unNumChildren;
	}
}
