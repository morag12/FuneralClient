using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000012 RID: 18
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct CallbackMsg_t
	{
		// Token: 0x0400002A RID: 42
		public int m_hSteamUser;

		// Token: 0x0400002B RID: 43
		public int m_iCallback;

		// Token: 0x0400002C RID: 44
		public IntPtr m_pubParam;

		// Token: 0x0400002D RID: 45
		public int m_cubParam;
	}
}
