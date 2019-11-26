using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000098 RID: 152
	[CallbackIdentity(3416)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GetAppDependenciesResult_t
	{
		// Token: 0x04000598 RID: 1432
		public const int k_iCallback = 3416;

		// Token: 0x04000599 RID: 1433
		public EResult m_eResult;

		// Token: 0x0400059A RID: 1434
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x0400059B RID: 1435
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		public AppId_t[] m_rgAppIDs;

		// Token: 0x0400059C RID: 1436
		public uint m_nNumAppDependencies;

		// Token: 0x0400059D RID: 1437
		public uint m_nTotalNumAppDependencies;
	}
}
