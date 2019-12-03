using System;

namespace Steamworks2
{
	// Token: 0x0200004D RID: 77
	[Flags]
	public enum EItemState
	{
		// Token: 0x04000325 RID: 805
		k_EItemStateNone = 0,
		// Token: 0x04000326 RID: 806
		k_EItemStateSubscribed = 1,
		// Token: 0x04000327 RID: 807
		k_EItemStateLegacyItem = 2,
		// Token: 0x04000328 RID: 808
		k_EItemStateInstalled = 4,
		// Token: 0x04000329 RID: 809
		k_EItemStateNeedsUpdate = 8,
		// Token: 0x0400032A RID: 810
		k_EItemStateDownloading = 16,
		// Token: 0x0400032B RID: 811
		k_EItemStateDownloadPending = 32
	}
}
