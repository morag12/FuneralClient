using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000091 RID: 145
	[CallbackIdentity(337)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GameRichPresenceJoinRequested_t
	{
		// Token: 0x0400057B RID: 1403
		public const int k_iCallback = 337;

		// Token: 0x0400057C RID: 1404
		public CSteamID m_steamIDFriend;

		// Token: 0x0400057D RID: 1405
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string m_rgchConnect;
	}
}
