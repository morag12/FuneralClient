using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200009C RID: 156
	[CallbackIdentity(4611)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GetVideoURLResult_t
	{
		// Token: 0x040005AA RID: 1450
		public const int k_iCallback = 4611;

		// Token: 0x040005AB RID: 1451
		public EResult m_eResult;

		// Token: 0x040005AC RID: 1452
		public AppId_t m_unVideoAppID;

		// Token: 0x040005AD RID: 1453
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string m_rgchURL;
	}
}
