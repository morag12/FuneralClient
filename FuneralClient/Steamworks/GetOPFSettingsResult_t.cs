using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200009A RID: 154
	[CallbackIdentity(4624)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GetOPFSettingsResult_t
	{
		// Token: 0x040005A1 RID: 1441
		public const int k_iCallback = 4624;

		// Token: 0x040005A2 RID: 1442
		public EResult m_eResult;

		// Token: 0x040005A3 RID: 1443
		public AppId_t m_unVideoAppID;
	}
}
