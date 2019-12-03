using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000121 RID: 289
	[CallbackIdentity(1302)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct RemoteStorageAppSyncedServer_t
	{
		// Token: 0x04000713 RID: 1811
		public const int k_iCallback = 1302;

		// Token: 0x04000714 RID: 1812
		public AppId_t m_nAppID;

		// Token: 0x04000715 RID: 1813
		public EResult m_eResult;

		// Token: 0x04000716 RID: 1814
		public int m_unNumUploads;
	}
}
