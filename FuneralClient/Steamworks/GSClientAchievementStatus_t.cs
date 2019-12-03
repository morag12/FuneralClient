using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200009F RID: 159
	[CallbackIdentity(206)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GSClientAchievementStatus_t
	{
		// Token: 0x040005B4 RID: 1460
		public const int k_iCallback = 206;

		// Token: 0x040005B5 RID: 1461
		public ulong m_SteamID;

		// Token: 0x040005B6 RID: 1462
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string m_pchAchievement;

		// Token: 0x040005B7 RID: 1463
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bUnlocked;
	}
}
