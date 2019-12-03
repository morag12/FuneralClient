using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000109 RID: 265
	[CallbackIdentity(4012)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct MusicPlayerSelectsQueueEntry_t
	{
		// Token: 0x040006DD RID: 1757
		public const int k_iCallback = 4012;

		// Token: 0x040006DE RID: 1758
		public int nID;
	}
}
