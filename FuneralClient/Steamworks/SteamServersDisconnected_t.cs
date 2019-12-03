using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200017A RID: 378
	[CallbackIdentity(103)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct SteamServersDisconnected_t
	{
		// Token: 0x040007EE RID: 2030
		public const int k_iCallback = 103;

		// Token: 0x040007EF RID: 2031
		public EResult m_eResult;
	}
}
