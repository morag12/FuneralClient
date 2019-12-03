using System;

namespace Steamworks2
{
	// Token: 0x0200003B RID: 59
	public enum EChatRoomEnterResponse
	{
		// Token: 0x040001A8 RID: 424
		k_EChatRoomEnterResponseSuccess = 1,
		// Token: 0x040001A9 RID: 425
		k_EChatRoomEnterResponseDoesntExist,
		// Token: 0x040001AA RID: 426
		k_EChatRoomEnterResponseNotAllowed,
		// Token: 0x040001AB RID: 427
		k_EChatRoomEnterResponseFull,
		// Token: 0x040001AC RID: 428
		k_EChatRoomEnterResponseError,
		// Token: 0x040001AD RID: 429
		k_EChatRoomEnterResponseBanned,
		// Token: 0x040001AE RID: 430
		k_EChatRoomEnterResponseLimited,
		// Token: 0x040001AF RID: 431
		k_EChatRoomEnterResponseClanDisabled,
		// Token: 0x040001B0 RID: 432
		k_EChatRoomEnterResponseCommunityBan,
		// Token: 0x040001B1 RID: 433
		k_EChatRoomEnterResponseMemberBlockedYou,
		// Token: 0x040001B2 RID: 434
		k_EChatRoomEnterResponseYouBlockedMember,
		// Token: 0x040001B3 RID: 435
		k_EChatRoomEnterResponseRatelimitExceeded = 15
	}
}
