using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000008 RID: 8
	[CallbackIdentity(210)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct AssociateWithClanResult_t
	{
		// Token: 0x04000012 RID: 18
		public const int k_iCallback = 210;

		// Token: 0x04000013 RID: 19
		public EResult m_eResult;
	}
}
