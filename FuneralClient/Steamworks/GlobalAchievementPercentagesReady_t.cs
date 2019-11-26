using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200009D RID: 157
	[CallbackIdentity(1110)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GlobalAchievementPercentagesReady_t
	{
		// Token: 0x040005AE RID: 1454
		public const int k_iCallback = 1110;

		// Token: 0x040005AF RID: 1455
		public ulong m_nGameID;

		// Token: 0x040005B0 RID: 1456
		public EResult m_eResult;
	}
}
