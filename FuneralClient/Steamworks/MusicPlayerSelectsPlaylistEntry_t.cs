using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000108 RID: 264
	[CallbackIdentity(4013)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct MusicPlayerSelectsPlaylistEntry_t
	{
		// Token: 0x040006DB RID: 1755
		public const int k_iCallback = 4013;

		// Token: 0x040006DC RID: 1756
		public int nID;
	}
}
