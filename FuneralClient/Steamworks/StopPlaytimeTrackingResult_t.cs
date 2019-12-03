using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000184 RID: 388
	[CallbackIdentity(3411)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct StopPlaytimeTrackingResult_t
	{
		// Token: 0x04000814 RID: 2068
		public const int k_iCallback = 3411;

		// Token: 0x04000815 RID: 2069
		public EResult m_eResult;
	}
}
