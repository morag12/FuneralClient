using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000111 RID: 273
	[CallbackIdentity(4011)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct MusicPlayerWantsVolume_t
	{
		// Token: 0x040006E9 RID: 1769
		public const int k_iCallback = 4011;

		// Token: 0x040006EA RID: 1770
		public float m_flNewVolume;
	}
}
