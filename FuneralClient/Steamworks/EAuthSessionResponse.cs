using System;

namespace Steamworks2
{
	// Token: 0x02000036 RID: 54
	public enum EAuthSessionResponse
	{
		// Token: 0x04000174 RID: 372
		k_EAuthSessionResponseOK,
		// Token: 0x04000175 RID: 373
		k_EAuthSessionResponseUserNotConnectedToSteam,
		// Token: 0x04000176 RID: 374
		k_EAuthSessionResponseNoLicenseOrExpired,
		// Token: 0x04000177 RID: 375
		k_EAuthSessionResponseVACBanned,
		// Token: 0x04000178 RID: 376
		k_EAuthSessionResponseLoggedInElseWhere,
		// Token: 0x04000179 RID: 377
		k_EAuthSessionResponseVACCheckTimedOut,
		// Token: 0x0400017A RID: 378
		k_EAuthSessionResponseAuthTicketCanceled,
		// Token: 0x0400017B RID: 379
		k_EAuthSessionResponseAuthTicketInvalidAlreadyUsed,
		// Token: 0x0400017C RID: 380
		k_EAuthSessionResponseAuthTicketInvalid,
		// Token: 0x0400017D RID: 381
		k_EAuthSessionResponsePublisherIssuedBan
	}
}
