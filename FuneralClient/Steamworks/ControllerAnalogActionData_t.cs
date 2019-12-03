using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000022 RID: 34
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ControllerAnalogActionData_t
	{
		// Token: 0x040000EF RID: 239
		public EControllerSourceMode eMode;

		// Token: 0x040000F0 RID: 240
		public float x;

		// Token: 0x040000F1 RID: 241
		public float y;

		// Token: 0x040000F2 RID: 242
		public byte bActive;
	}
}
