using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200012D RID: 301
	[CallbackIdentity(1331)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct RemoteStorageFileWriteAsyncComplete_t
	{
		// Token: 0x04000752 RID: 1874
		public const int k_iCallback = 1331;

		// Token: 0x04000753 RID: 1875
		public EResult m_eResult;
	}
}
