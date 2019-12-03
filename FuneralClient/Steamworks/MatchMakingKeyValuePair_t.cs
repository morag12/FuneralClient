using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000102 RID: 258
	public struct MatchMakingKeyValuePair_t
	{
		// Token: 0x060001E7 RID: 487 RVA: 0x0000332D File Offset: 0x0000152D
		private MatchMakingKeyValuePair_t(string strKey, string strValue)
		{
			m_szKey = strKey;
			m_szValue = strValue;
		}

		// Token: 0x040006D0 RID: 1744
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string m_szKey;

		// Token: 0x040006D1 RID: 1745
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string m_szValue;
	}
}
