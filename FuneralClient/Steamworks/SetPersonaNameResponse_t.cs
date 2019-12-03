using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000142 RID: 322
	[CallbackIdentity(347)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct SetPersonaNameResponse_t
	{
		// Token: 0x040007AB RID: 1963
		public const int k_iCallback = 347;

		// Token: 0x040007AC RID: 1964
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bSuccess;

		// Token: 0x040007AD RID: 1965
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bLocalSuccess;

		// Token: 0x040007AE RID: 1966
		public EResult m_result;
	}
}
