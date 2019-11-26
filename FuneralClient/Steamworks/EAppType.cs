using System;

namespace Steamworks2
{
	// Token: 0x02000035 RID: 53
	[Flags]
	public enum EAppType
	{
		// Token: 0x04000160 RID: 352
		k_EAppType_Invalid = 0,
		// Token: 0x04000161 RID: 353
		k_EAppType_Game = 1,
		// Token: 0x04000162 RID: 354
		k_EAppType_Application = 2,
		// Token: 0x04000163 RID: 355
		k_EAppType_Tool = 4,
		// Token: 0x04000164 RID: 356
		k_EAppType_Demo = 8,
		// Token: 0x04000165 RID: 357
		k_EAppType_Media_DEPRECATED = 16,
		// Token: 0x04000166 RID: 358
		k_EAppType_DLC = 32,
		// Token: 0x04000167 RID: 359
		k_EAppType_Guide = 64,
		// Token: 0x04000168 RID: 360
		k_EAppType_Driver = 128,
		// Token: 0x04000169 RID: 361
		k_EAppType_Config = 256,
		// Token: 0x0400016A RID: 362
		k_EAppType_Hardware = 512,
		// Token: 0x0400016B RID: 363
		k_EAppType_Franchise = 1024,
		// Token: 0x0400016C RID: 364
		k_EAppType_Video = 2048,
		// Token: 0x0400016D RID: 365
		k_EAppType_Plugin = 4096,
		// Token: 0x0400016E RID: 366
		k_EAppType_Music = 8192,
		// Token: 0x0400016F RID: 367
		k_EAppType_Series = 16384,
		// Token: 0x04000170 RID: 368
		k_EAppType_Comic = 32768,
		// Token: 0x04000171 RID: 369
		k_EAppType_Shortcut = 1073741824,
		// Token: 0x04000172 RID: 370
		k_EAppType_DepotOnly = -2147483647
	}
}
