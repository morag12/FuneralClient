using System;

namespace Steamworks2
{
	// Token: 0x02000061 RID: 97
	[Flags]
	public enum EPersonaChange
	{
		// Token: 0x040003D3 RID: 979
		k_EPersonaChangeName = 1,
		// Token: 0x040003D4 RID: 980
		k_EPersonaChangeStatus = 2,
		// Token: 0x040003D5 RID: 981
		k_EPersonaChangeComeOnline = 4,
		// Token: 0x040003D6 RID: 982
		k_EPersonaChangeGoneOffline = 8,
		// Token: 0x040003D7 RID: 983
		k_EPersonaChangeGamePlayed = 16,
		// Token: 0x040003D8 RID: 984
		k_EPersonaChangeGameServer = 32,
		// Token: 0x040003D9 RID: 985
		k_EPersonaChangeAvatar = 64,
		// Token: 0x040003DA RID: 986
		k_EPersonaChangeJoinedSource = 128,
		// Token: 0x040003DB RID: 987
		k_EPersonaChangeLeftSource = 256,
		// Token: 0x040003DC RID: 988
		k_EPersonaChangeRelationshipChanged = 512,
		// Token: 0x040003DD RID: 989
		k_EPersonaChangeNameFirstSet = 1024,
		// Token: 0x040003DE RID: 990
		k_EPersonaChangeFacebookInfo = 2048,
		// Token: 0x040003DF RID: 991
		k_EPersonaChangeNickname = 4096,
		// Token: 0x040003E0 RID: 992
		k_EPersonaChangeSteamLevel = 8192
	}
}
