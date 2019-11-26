using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200001E RID: 30
	[CallbackIdentity(113)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct ClientGameServerDeny_t
	{
		// Token: 0x0400004B RID: 75
		public const int k_iCallback = 113;

		// Token: 0x0400004C RID: 76
		public uint m_uAppID;

		// Token: 0x0400004D RID: 77
		public uint m_unGameServerIP;

		// Token: 0x0400004E RID: 78
		public ushort m_usGameServerPort;

		// Token: 0x0400004F RID: 79
		public ushort m_bSecure;

		// Token: 0x04000050 RID: 80
		public uint m_uReason;
	}
}
