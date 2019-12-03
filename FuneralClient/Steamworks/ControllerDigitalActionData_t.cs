using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000024 RID: 36
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ControllerDigitalActionData_t
	{
		// Token: 0x040000F4 RID: 244
		public byte bState;

		// Token: 0x040000F5 RID: 245
		public byte bActive;
	}
}
