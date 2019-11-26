using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200018B RID: 395
	[CallbackIdentity(1109)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct UserAchievementIconFetched_t
	{
		// Token: 0x04000824 RID: 2084
		public const int k_iCallback = 1109;

		// Token: 0x04000825 RID: 2085
		public CGameID m_nGameID;

		// Token: 0x04000826 RID: 2086
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string m_rgchAchievementName;

		// Token: 0x04000827 RID: 2087
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bAchieved;

		// Token: 0x04000828 RID: 2088
		public int m_nIconHandle;
	}
}
