using System;

namespace Steamworks2
{
	// Token: 0x0200006A RID: 106
	public enum ESteamAPICallFailure
	{
		// Token: 0x04000482 RID: 1154
		k_ESteamAPICallFailureNone = -1,
		// Token: 0x04000483 RID: 1155
		k_ESteamAPICallFailureSteamGone,
		// Token: 0x04000484 RID: 1156
		k_ESteamAPICallFailureNetworkFailure,
		// Token: 0x04000485 RID: 1157
		k_ESteamAPICallFailureInvalidHandle,
		// Token: 0x04000486 RID: 1158
		k_ESteamAPICallFailureMismatchedCallback
	}
}
