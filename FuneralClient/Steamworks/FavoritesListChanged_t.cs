using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000081 RID: 129
	[CallbackIdentity(502)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct FavoritesListChanged_t
	{
		// Token: 0x0400053E RID: 1342
		public const int k_iCallback = 502;

		// Token: 0x0400053F RID: 1343
		public uint m_nIP;

		// Token: 0x04000540 RID: 1344
		public uint m_nQueryPort;

		// Token: 0x04000541 RID: 1345
		public uint m_nConnPort;

		// Token: 0x04000542 RID: 1346
		public uint m_nAppID;

		// Token: 0x04000543 RID: 1347
		public uint m_nFlags;

		// Token: 0x04000544 RID: 1348
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bAdd;

		// Token: 0x04000545 RID: 1349
		public AccountID_t m_unAccountId;
	}
}
