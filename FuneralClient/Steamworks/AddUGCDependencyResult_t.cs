using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000005 RID: 5
	[CallbackIdentity(3412)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct AddUGCDependencyResult_t
	{
		// Token: 0x04000007 RID: 7
		public const int k_iCallback = 3412;

		// Token: 0x04000008 RID: 8
		public EResult m_eResult;

		// Token: 0x04000009 RID: 9
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x0400000A RID: 10
		public PublishedFileId_t m_nChildPublishedFileId;
	}
}
