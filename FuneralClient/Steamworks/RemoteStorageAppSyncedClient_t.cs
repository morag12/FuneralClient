using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000120 RID: 288
	[CallbackIdentity(1301)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct RemoteStorageAppSyncedClient_t
	{
		// Token: 0x0400070F RID: 1807
		public const int k_iCallback = 1301;

		// Token: 0x04000710 RID: 1808
		public AppId_t m_nAppID;

		// Token: 0x04000711 RID: 1809
		public EResult m_eResult;

		// Token: 0x04000712 RID: 1810
		public int m_unNumDownloads;
	}
}
