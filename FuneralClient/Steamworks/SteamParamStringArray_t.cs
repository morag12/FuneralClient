using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000173 RID: 371
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct SteamParamStringArray_t
	{
		// Token: 0x040007E7 RID: 2023
		public IntPtr m_ppStrings;

		// Token: 0x040007E8 RID: 2024
		public int m_nNumStrings;
	}
}
