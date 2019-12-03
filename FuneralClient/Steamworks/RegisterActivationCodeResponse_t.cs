using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200011F RID: 287
	[CallbackIdentity(1008)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct RegisterActivationCodeResponse_t
	{
		// Token: 0x0400070C RID: 1804
		public const int k_iCallback = 1008;

		// Token: 0x0400070D RID: 1805
		public ERegisterActivationCodeResult m_eResult;

		// Token: 0x0400070E RID: 1806
		public uint m_unPackageRegistered;
	}
}
