using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000093 RID: 147
	[CallbackIdentity(332)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GameServerChangeRequested_t
	{
		// Token: 0x0400057E RID: 1406
		public const int k_iCallback = 332;

		// Token: 0x0400057F RID: 1407
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string m_rgchServer;

		// Token: 0x04000580 RID: 1408
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string m_rgchPassword;
	}
}
