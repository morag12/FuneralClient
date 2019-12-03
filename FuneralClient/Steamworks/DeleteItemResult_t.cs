using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200002C RID: 44
	[CallbackIdentity(3417)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct DeleteItemResult_t
	{
		// Token: 0x0400012A RID: 298
		public const int k_iCallback = 3417;

		// Token: 0x0400012B RID: 299
		public EResult m_eResult;

		// Token: 0x0400012C RID: 300
		public PublishedFileId_t m_nPublishedFileId;
	}
}
