using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000151 RID: 337
	[CallbackIdentity(3902)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct SteamAppUninstalled_t
	{
		// Token: 0x040007C6 RID: 1990
		public const int k_iCallback = 3902;

		// Token: 0x040007C7 RID: 1991
		public AppId_t m_nAppID;
	}
}
