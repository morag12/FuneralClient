using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000A1 RID: 161
	[CallbackIdentity(202)]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct GSClientDeny_t
	{
		// Token: 0x040005BB RID: 1467
		public const int k_iCallback = 202;

		// Token: 0x040005BC RID: 1468
		public CSteamID m_SteamID;

		// Token: 0x040005BD RID: 1469
		public EDenyReason m_eDenyReason;

		// Token: 0x040005BE RID: 1470
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string m_rgchOptionalText;
	}
}
