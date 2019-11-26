using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000095 RID: 149
	[CallbackIdentity(164)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GameWebCallback_t
	{
		// Token: 0x04000593 RID: 1427
		public const int k_iCallback = 164;

		// Token: 0x04000594 RID: 1428
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string m_szURL;
	}
}
