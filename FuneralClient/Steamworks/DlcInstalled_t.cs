using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200002E RID: 46
	[CallbackIdentity(1005)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct DlcInstalled_t
	{
		// Token: 0x0400012F RID: 303
		public const int k_iCallback = 1005;

		// Token: 0x04000130 RID: 304
		public AppId_t m_nAppID;
	}
}
