using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200012B RID: 299
	[CallbackIdentity(1332)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct RemoteStorageFileReadAsyncComplete_t
	{
		// Token: 0x04000749 RID: 1865
		public const int k_iCallback = 1332;

		// Token: 0x0400074A RID: 1866
		public SteamAPICall_t m_hFileReadAsync;

		// Token: 0x0400074B RID: 1867
		public EResult m_eResult;

		// Token: 0x0400074C RID: 1868
		public uint m_nOffset;

		// Token: 0x0400074D RID: 1869
		public uint m_cubRead;
	}
}
