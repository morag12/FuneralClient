using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000100 RID: 256
	[CallbackIdentity(702)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct LowBatteryPower_t
	{
		// Token: 0x040006CC RID: 1740
		public const int k_iCallback = 702;

		// Token: 0x040006CD RID: 1741
		public byte m_nMinutesBatteryLeft;
	}
}
