using System;

namespace Steamworks2
{
	// Token: 0x02000038 RID: 56
	public enum EBroadcastUploadResult
	{
		// Token: 0x04000186 RID: 390
		k_EBroadcastUploadResultNone,
		// Token: 0x04000187 RID: 391
		k_EBroadcastUploadResultOK,
		// Token: 0x04000188 RID: 392
		k_EBroadcastUploadResultInitFailed,
		// Token: 0x04000189 RID: 393
		k_EBroadcastUploadResultFrameFailed,
		// Token: 0x0400018A RID: 394
		k_EBroadcastUploadResultTimeout,
		// Token: 0x0400018B RID: 395
		k_EBroadcastUploadResultBandwidthExceeded,
		// Token: 0x0400018C RID: 396
		k_EBroadcastUploadResultLowFPS,
		// Token: 0x0400018D RID: 397
		k_EBroadcastUploadResultMissingKeyFrames,
		// Token: 0x0400018E RID: 398
		k_EBroadcastUploadResultNoConnection,
		// Token: 0x0400018F RID: 399
		k_EBroadcastUploadResultRelayFailed,
		// Token: 0x04000190 RID: 400
		k_EBroadcastUploadResultSettingsChanged,
		// Token: 0x04000191 RID: 401
		k_EBroadcastUploadResultMissingAudio,
		// Token: 0x04000192 RID: 402
		k_EBroadcastUploadResultTooFarBehind,
		// Token: 0x04000193 RID: 403
		k_EBroadcastUploadResultTranscodeBehind
	}
}
