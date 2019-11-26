using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000004 RID: 4
	[CallbackIdentity(3414)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct AddAppDependencyResult_t
	{
		// Token: 0x04000003 RID: 3
		public const int k_iCallback = 3414;

		// Token: 0x04000004 RID: 4
		public EResult m_eResult;

		// Token: 0x04000005 RID: 5
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000006 RID: 6
		public AppId_t m_nAppID;
	}
}
