using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200013D RID: 317
	[CallbackIdentity(3413)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct RemoveUGCDependencyResult_t
	{
		// Token: 0x0400079E RID: 1950
		public const int k_iCallback = 3413;

		// Token: 0x0400079F RID: 1951
		public EResult m_eResult;

		// Token: 0x040007A0 RID: 1952
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x040007A1 RID: 1953
		public PublishedFileId_t m_nChildPublishedFileId;
	}
}
