using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000119 RID: 281
	public static class Packsize
	{
		// Token: 0x060004C2 RID: 1218 RVA: 0x0000B534 File Offset: 0x00009734
		public static bool Test()
		{
			int num = Marshal.SizeOf(typeof(Packsize.ValvePackingSentinel_t));
			int num2 = Marshal.SizeOf(typeof(RemoteStorageEnumerateUserSubscribedFilesResult_t));
			return num == 32 && num2 == 616;
		}

		// Token: 0x040006FF RID: 1791
		public const int value = 8;

		// Token: 0x0200011A RID: 282
		[StructLayout(LayoutKind.Sequential, Pack = 8)]
		private struct ValvePackingSentinel_t
		{
			// Token: 0x04000700 RID: 1792
			private readonly uint m_u32;

			// Token: 0x04000701 RID: 1793
			private readonly ulong m_u64;

			// Token: 0x04000702 RID: 1794
			private readonly ushort m_u16;

			// Token: 0x04000703 RID: 1795
			private readonly double m_d;
		}
	}
}
