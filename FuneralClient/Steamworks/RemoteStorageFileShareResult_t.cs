using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200012C RID: 300
	[CallbackIdentity(1307)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct RemoteStorageFileShareResult_t
	{
		// Token: 0x0400074E RID: 1870
		public const int k_iCallback = 1307;

		// Token: 0x0400074F RID: 1871
		public EResult m_eResult;

		// Token: 0x04000750 RID: 1872
		public UGCHandle_t m_hFile;

		// Token: 0x04000751 RID: 1873
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string m_rgchFilename;
	}
}
