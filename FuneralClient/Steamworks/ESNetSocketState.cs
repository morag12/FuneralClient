using System;

namespace Steamworks2
{
	// Token: 0x02000069 RID: 105
	public enum ESNetSocketState
	{
		// Token: 0x04000476 RID: 1142
		k_ESNetSocketStateInvalid,
		// Token: 0x04000477 RID: 1143
		k_ESNetSocketStateConnected,
		// Token: 0x04000478 RID: 1144
		k_ESNetSocketStateInitiated = 10,
		// Token: 0x04000479 RID: 1145
		k_ESNetSocketStateLocalCandidatesFound,
		// Token: 0x0400047A RID: 1146
		k_ESNetSocketStateReceivedRemoteCandidates,
		// Token: 0x0400047B RID: 1147
		k_ESNetSocketStateChallengeHandshake = 15,
		// Token: 0x0400047C RID: 1148
		k_ESNetSocketStateDisconnecting = 21,
		// Token: 0x0400047D RID: 1149
		k_ESNetSocketStateLocalDisconnect,
		// Token: 0x0400047E RID: 1150
		k_ESNetSocketStateTimeoutDuringConnect,
		// Token: 0x0400047F RID: 1151
		k_ESNetSocketStateRemoteEndDisconnected,
		// Token: 0x04000480 RID: 1152
		k_ESNetSocketStateConnectionBroken
	}
}
