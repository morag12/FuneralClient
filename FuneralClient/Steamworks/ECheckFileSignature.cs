using System;

namespace Steamworks2
{
	// Token: 0x0200003D RID: 61
	public enum ECheckFileSignature
	{
		// Token: 0x040001BA RID: 442
		k_ECheckFileSignatureInvalidSignature,
		// Token: 0x040001BB RID: 443
		k_ECheckFileSignatureValidSignature,
		// Token: 0x040001BC RID: 444
		k_ECheckFileSignatureFileNotFound,
		// Token: 0x040001BD RID: 445
		k_ECheckFileSignatureNoSignaturesFoundForThisApp,
		// Token: 0x040001BE RID: 446
		k_ECheckFileSignatureNoSignaturesFoundForThisFile
	}
}
