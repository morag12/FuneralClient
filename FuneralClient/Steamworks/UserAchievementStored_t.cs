using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200018C RID: 396
	[CallbackIdentity(1103)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct UserAchievementStored_t
	{
		// Token: 0x04000829 RID: 2089
		public const int k_iCallback = 1103;

		// Token: 0x0400082A RID: 2090
		public ulong m_nGameID;

		// Token: 0x0400082B RID: 2091
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bGroupAchievement;

		// Token: 0x0400082C RID: 2092
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string m_rgchAchievementName;

		// Token: 0x0400082D RID: 2093
		public uint m_nCurProgress;

		// Token: 0x0400082E RID: 2094
		public uint m_nMaxProgress;
	}
}
