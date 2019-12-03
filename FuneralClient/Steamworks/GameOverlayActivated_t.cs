using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200008F RID: 143
	[CallbackIdentity(331)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GameOverlayActivated_t
	{
		// Token: 0x04000576 RID: 1398
		public const int k_iCallback = 331;

		// Token: 0x04000577 RID: 1399
		public byte m_bActive;
	}
}
