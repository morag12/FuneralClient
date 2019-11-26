using System;

namespace Steamworks2
{
	// Token: 0x02000064 RID: 100
	[Flags]
	public enum ERemoteStoragePlatform
	{
		// Token: 0x040003F1 RID: 1009
		k_ERemoteStoragePlatformNone = 0,
		// Token: 0x040003F2 RID: 1010
		k_ERemoteStoragePlatformWindows = 1,
		// Token: 0x040003F3 RID: 1011
		k_ERemoteStoragePlatformOSX = 2,
		// Token: 0x040003F4 RID: 1012
		k_ERemoteStoragePlatformPS3 = 4,
		// Token: 0x040003F5 RID: 1013
		k_ERemoteStoragePlatformLinux = 8,
		// Token: 0x040003F6 RID: 1014
		k_ERemoteStoragePlatformReserved2 = 16,
		// Token: 0x040003F7 RID: 1015
		k_ERemoteStoragePlatformAll = -1
	}
}
