using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000148 RID: 328
	[CallbackIdentity(3410)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct StartPlaytimeTrackingResult_t
	{
		// Token: 0x040007BC RID: 1980
		public const int k_iCallback = 3410;

		// Token: 0x040007BD RID: 1981
		public EResult m_eResult;
	}
}
