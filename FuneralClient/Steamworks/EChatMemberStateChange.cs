using System;

namespace Steamworks2
{
	// Token: 0x0200003A RID: 58
	[Flags]
	public enum EChatMemberStateChange
	{
		// Token: 0x040001A2 RID: 418
		k_EChatMemberStateChangeEntered = 1,
		// Token: 0x040001A3 RID: 419
		k_EChatMemberStateChangeLeft = 2,
		// Token: 0x040001A4 RID: 420
		k_EChatMemberStateChangeDisconnected = 4,
		// Token: 0x040001A5 RID: 421
		k_EChatMemberStateChangeKicked = 8,
		// Token: 0x040001A6 RID: 422
		k_EChatMemberStateChangeBanned = 16
	}
}
