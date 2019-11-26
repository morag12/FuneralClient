using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200001C RID: 28
	[CallbackIdentity(705)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct CheckFileSignature_t
	{
		// Token: 0x04000045 RID: 69
		public const int k_iCallback = 705;

		// Token: 0x04000046 RID: 70
		public ECheckFileSignature m_eCheckFileSignature;
	}
}
