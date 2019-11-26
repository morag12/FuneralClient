using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000136 RID: 310
	[CallbackIdentity(1327)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct RemoteStorageSetUserPublishedFileActionResult_t
	{
		// Token: 0x04000785 RID: 1925
		public const int k_iCallback = 1327;

		// Token: 0x04000786 RID: 1926
		public EResult m_eResult;

		// Token: 0x04000787 RID: 1927
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000788 RID: 1928
		public EWorkshopFileAction m_eAction;
	}
}
