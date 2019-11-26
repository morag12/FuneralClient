using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200013C RID: 316
	[CallbackIdentity(3415)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct RemoveAppDependencyResult_t
	{
		// Token: 0x0400079A RID: 1946
		public const int k_iCallback = 3415;

		// Token: 0x0400079B RID: 1947
		public EResult m_eResult;

		// Token: 0x0400079C RID: 1948
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x0400079D RID: 1949
		public AppId_t m_nAppID;
	}
}
