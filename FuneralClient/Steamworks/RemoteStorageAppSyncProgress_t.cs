using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000122 RID: 290
	[CallbackIdentity(1303)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct RemoteStorageAppSyncProgress_t
	{
		// Token: 0x04000717 RID: 1815
		public const int k_iCallback = 1303;

		// Token: 0x04000718 RID: 1816
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string m_rgchCurrentFile;

		// Token: 0x04000719 RID: 1817
		public AppId_t m_nAppID;

		// Token: 0x0400071A RID: 1818
		public uint m_uBytesTransferredThisChunk;

		// Token: 0x0400071B RID: 1819
		public double m_dAppPercentComplete;

		// Token: 0x0400071C RID: 1820
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bUploading;
	}
}
