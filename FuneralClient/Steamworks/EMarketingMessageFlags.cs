using System;

namespace Steamworks2
{
	// Token: 0x02000058 RID: 88
	[Flags]
	public enum EMarketingMessageFlags
	{
		// Token: 0x04000377 RID: 887
		k_EMarketingMessageFlagsNone = 0,
		// Token: 0x04000378 RID: 888
		k_EMarketingMessageFlagsHighPriority = 1,
		// Token: 0x04000379 RID: 889
		k_EMarketingMessageFlagsPlatformWindows = 2,
		// Token: 0x0400037A RID: 890
		k_EMarketingMessageFlagsPlatformMac = 4,
		// Token: 0x0400037B RID: 891
		k_EMarketingMessageFlagsPlatformLinux = 8,
		// Token: 0x0400037C RID: 892
		k_EMarketingMessageFlagsPlatformRestrictions = 14
	}
}
