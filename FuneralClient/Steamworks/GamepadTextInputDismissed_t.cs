using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000090 RID: 144
	[CallbackIdentity(714)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GamepadTextInputDismissed_t
	{
		// Token: 0x04000578 RID: 1400
		public const int k_iCallback = 714;

		// Token: 0x04000579 RID: 1401
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bSubmitted;

		// Token: 0x0400057A RID: 1402
		public uint m_unSubmittedText;
	}
}
