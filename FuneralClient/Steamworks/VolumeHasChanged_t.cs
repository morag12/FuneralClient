using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000193 RID: 403
	[CallbackIdentity(4002)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct VolumeHasChanged_t
	{
		// Token: 0x04000845 RID: 2117
		public const int k_iCallback = 4002;

		// Token: 0x04000846 RID: 2118
		public float m_flNewVolume;
	}
}
