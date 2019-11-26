using System;

namespace Steamworks2
{
	// Token: 0x02000043 RID: 67
	[Flags]
	public enum EFriendFlags
	{
		// Token: 0x040002BC RID: 700
		k_EFriendFlagNone = 0,
		// Token: 0x040002BD RID: 701
		k_EFriendFlagBlocked = 1,
		// Token: 0x040002BE RID: 702
		k_EFriendFlagFriendshipRequested = 2,
		// Token: 0x040002BF RID: 703
		k_EFriendFlagImmediate = 4,
		// Token: 0x040002C0 RID: 704
		k_EFriendFlagClanMember = 8,
		// Token: 0x040002C1 RID: 705
		k_EFriendFlagOnGameServer = 16,
		// Token: 0x040002C2 RID: 706
		k_EFriendFlagRequestingFriendship = 128,
		// Token: 0x040002C3 RID: 707
		k_EFriendFlagRequestingInfo = 256,
		// Token: 0x040002C4 RID: 708
		k_EFriendFlagIgnored = 512,
		// Token: 0x040002C5 RID: 709
		k_EFriendFlagIgnoredFriend = 1024,
		// Token: 0x040002C6 RID: 710
		k_EFriendFlagChatMember = 4096,
		// Token: 0x040002C7 RID: 711
		k_EFriendFlagAll = 65535
	}
}
