using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200010C RID: 268
	[CallbackIdentity(4114)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct MusicPlayerWantsPlayingRepeatStatus_t
	{
		// Token: 0x040006E2 RID: 1762
		public const int k_iCallback = 4114;

		// Token: 0x040006E3 RID: 1763
		public int m_nPlayingRepeatStatus;
	}
}
