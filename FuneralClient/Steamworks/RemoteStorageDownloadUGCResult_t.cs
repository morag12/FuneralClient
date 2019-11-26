using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000125 RID: 293
	[CallbackIdentity(1317)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct RemoteStorageDownloadUGCResult_t
	{
		// Token: 0x04000723 RID: 1827
		public const int k_iCallback = 1317;

		// Token: 0x04000724 RID: 1828
		public EResult m_eResult;

		// Token: 0x04000725 RID: 1829
		public UGCHandle_t m_hFile;

		// Token: 0x04000726 RID: 1830
		public AppId_t m_nAppID;

		// Token: 0x04000727 RID: 1831
		public int m_nSizeInBytes;

		// Token: 0x04000728 RID: 1832
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string m_pchFileName;

		// Token: 0x04000729 RID: 1833
		public ulong m_ulSteamIDOwner;
	}
}
