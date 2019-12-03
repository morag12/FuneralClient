using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200014E RID: 334
	[CallbackIdentity(3901)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct SteamAppInstalled_t
	{
		// Token: 0x040007C4 RID: 1988
		public const int k_iCallback = 3901;

		// Token: 0x040007C5 RID: 1989
		public AppId_t m_nAppID;
	}
}
