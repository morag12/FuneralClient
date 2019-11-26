using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000085 RID: 133
	[CallbackIdentity(346)]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct FriendsEnumerateFollowingList_t
	{
		// Token: 0x04000553 RID: 1363
		public const int k_iCallback = 346;

		// Token: 0x04000554 RID: 1364
		public EResult m_eResult;

		// Token: 0x04000555 RID: 1365
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public CSteamID[] m_rgSteamID;

		// Token: 0x04000556 RID: 1366
		public int m_nResultsReturned;

		// Token: 0x04000557 RID: 1367
		public int m_nTotalResultCount;
	}
}
