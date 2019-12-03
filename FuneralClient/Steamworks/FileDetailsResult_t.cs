using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000082 RID: 130
	[CallbackIdentity(1023)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct FileDetailsResult_t
	{
		// Token: 0x04000546 RID: 1350
		public const int k_iCallback = 1023;

		// Token: 0x04000547 RID: 1351
		public EResult m_eResult;

		// Token: 0x04000548 RID: 1352
		public ulong m_ulFileSize;

		// Token: 0x04000549 RID: 1353
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
		public byte[] m_FileSHA;

		// Token: 0x0400054A RID: 1354
		public uint m_unFlags;
	}
}
