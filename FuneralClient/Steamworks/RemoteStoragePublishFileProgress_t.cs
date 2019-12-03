using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000134 RID: 308
	[CallbackIdentity(1329)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct RemoteStoragePublishFileProgress_t
	{
		// Token: 0x0400077E RID: 1918
		public const int k_iCallback = 1329;

		// Token: 0x0400077F RID: 1919
		public double m_dPercentFile;

		// Token: 0x04000780 RID: 1920
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bPreview;
	}
}
