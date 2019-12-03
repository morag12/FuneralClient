using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000185 RID: 389
	[CallbackIdentity(165)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct StoreAuthURLResponse_t
	{
		// Token: 0x04000816 RID: 2070
		public const int k_iCallback = 165;

		// Token: 0x04000817 RID: 2071
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
		public string m_szURL;
	}
}
