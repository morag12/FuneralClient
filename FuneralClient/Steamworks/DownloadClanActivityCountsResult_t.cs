using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000030 RID: 48
	[CallbackIdentity(341)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct DownloadClanActivityCountsResult_t
	{
		// Token: 0x04000131 RID: 305
		public const int k_iCallback = 341;

		// Token: 0x04000132 RID: 306
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bSuccess;
	}
}
