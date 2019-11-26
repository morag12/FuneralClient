using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000007 RID: 7
	[CallbackIdentity(1021)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct AppProofOfPurchaseKeyResponse_t
	{
		// Token: 0x0400000D RID: 13
		public const int k_iCallback = 1021;

		// Token: 0x0400000E RID: 14
		public EResult m_eResult;

		// Token: 0x0400000F RID: 15
		public uint m_nAppID;

		// Token: 0x04000010 RID: 16
		public uint m_cchKeyLength;

		// Token: 0x04000011 RID: 17
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 240)]
		public string m_rgchKey;
	}
}
