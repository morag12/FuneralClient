using System;

namespace Steamworks2
{
	// Token: 0x02000033 RID: 51
	[Flags]
	public enum EAppOwnershipFlags
	{
		// Token: 0x04000145 RID: 325
		k_EAppOwnershipFlags_None = 0,
		// Token: 0x04000146 RID: 326
		k_EAppOwnershipFlags_OwnsLicense = 1,
		// Token: 0x04000147 RID: 327
		k_EAppOwnershipFlags_FreeLicense = 2,
		// Token: 0x04000148 RID: 328
		k_EAppOwnershipFlags_RegionRestricted = 4,
		// Token: 0x04000149 RID: 329
		k_EAppOwnershipFlags_LowViolence = 8,
		// Token: 0x0400014A RID: 330
		k_EAppOwnershipFlags_InvalidPlatform = 16,
		// Token: 0x0400014B RID: 331
		k_EAppOwnershipFlags_SharedLicense = 32,
		// Token: 0x0400014C RID: 332
		k_EAppOwnershipFlags_FreeWeekend = 64,
		// Token: 0x0400014D RID: 333
		k_EAppOwnershipFlags_RetailLicense = 128,
		// Token: 0x0400014E RID: 334
		k_EAppOwnershipFlags_LicenseLocked = 256,
		// Token: 0x0400014F RID: 335
		k_EAppOwnershipFlags_LicensePending = 512,
		// Token: 0x04000150 RID: 336
		k_EAppOwnershipFlags_LicenseExpired = 1024,
		// Token: 0x04000151 RID: 337
		k_EAppOwnershipFlags_LicensePermanent = 2048,
		// Token: 0x04000152 RID: 338
		k_EAppOwnershipFlags_LicenseRecurring = 4096,
		// Token: 0x04000153 RID: 339
		k_EAppOwnershipFlags_LicenseCanceled = 8192,
		// Token: 0x04000154 RID: 340
		k_EAppOwnershipFlags_AutoGrant = 16384,
		// Token: 0x04000155 RID: 341
		k_EAppOwnershipFlags_PendingGift = 32768,
		// Token: 0x04000156 RID: 342
		k_EAppOwnershipFlags_RentalNotActivated = 65536,
		// Token: 0x04000157 RID: 343
		k_EAppOwnershipFlags_Rental = 131072,
		// Token: 0x04000158 RID: 344
		k_EAppOwnershipFlags_SiteLicense = 262144
	}
}
