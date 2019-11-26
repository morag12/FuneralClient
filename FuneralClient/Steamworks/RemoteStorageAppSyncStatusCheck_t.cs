using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000123 RID: 291
	[CallbackIdentity(1305)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct RemoteStorageAppSyncStatusCheck_t
	{
		// Token: 0x0400071D RID: 1821
		public const int k_iCallback = 1305;

		// Token: 0x0400071E RID: 1822
		public AppId_t m_nAppID;

		// Token: 0x0400071F RID: 1823
		public EResult m_eResult;
	}
}
