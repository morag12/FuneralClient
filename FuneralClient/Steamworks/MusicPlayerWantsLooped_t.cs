using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200010A RID: 266
	[CallbackIdentity(4110)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct MusicPlayerWantsLooped_t
	{
		// Token: 0x040006DF RID: 1759
		public const int k_iCallback = 4110;

		// Token: 0x040006E0 RID: 1760
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bLooped;
	}
}
