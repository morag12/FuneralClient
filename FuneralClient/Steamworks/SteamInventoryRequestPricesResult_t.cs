using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000164 RID: 356
	[CallbackIdentity(4705)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct SteamInventoryRequestPricesResult_t
	{
		// Token: 0x040007D0 RID: 2000
		public const int k_iCallback = 4705;

		// Token: 0x040007D1 RID: 2001
		public EResult m_result;

		// Token: 0x040007D2 RID: 2002
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public string m_rgchCurrency;
	}
}
