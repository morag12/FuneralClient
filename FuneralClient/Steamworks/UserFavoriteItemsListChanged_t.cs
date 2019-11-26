using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200018D RID: 397
	[CallbackIdentity(3407)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct UserFavoriteItemsListChanged_t
	{
		// Token: 0x0400082F RID: 2095
		public const int k_iCallback = 3407;

		// Token: 0x04000830 RID: 2096
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000831 RID: 2097
		public EResult m_eResult;

		// Token: 0x04000832 RID: 2098
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bWasAddRequest;
	}
}
