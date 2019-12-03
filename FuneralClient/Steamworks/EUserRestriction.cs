using System;

namespace Steamworks2
{
	// Token: 0x02000075 RID: 117
	public enum EUserRestriction
	{
		// Token: 0x040004D3 RID: 1235
		k_nUserRestrictionNone,
		// Token: 0x040004D4 RID: 1236
		k_nUserRestrictionUnknown,
		// Token: 0x040004D5 RID: 1237
		k_nUserRestrictionAnyChat,
		// Token: 0x040004D6 RID: 1238
		k_nUserRestrictionVoiceChat = 4,
		// Token: 0x040004D7 RID: 1239
		k_nUserRestrictionGroupChat = 8,
		// Token: 0x040004D8 RID: 1240
		k_nUserRestrictionRating = 16,
		// Token: 0x040004D9 RID: 1241
		k_nUserRestrictionGameInvites = 32,
		// Token: 0x040004DA RID: 1242
		k_nUserRestrictionTrading = 64
	}
}
