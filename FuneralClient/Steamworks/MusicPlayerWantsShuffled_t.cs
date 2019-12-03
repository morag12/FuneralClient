using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000110 RID: 272
	[CallbackIdentity(4109)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct MusicPlayerWantsShuffled_t
	{
		// Token: 0x040006E7 RID: 1767
		public const int k_iCallback = 4109;

		// Token: 0x040006E8 RID: 1768
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bShuffled;
	}
}
