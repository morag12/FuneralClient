using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000027 RID: 39
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct ControllerMotionData_t
	{
		// Token: 0x040000F8 RID: 248
		public float rotQuatX;

		// Token: 0x040000F9 RID: 249
		public float rotQuatY;

		// Token: 0x040000FA RID: 250
		public float rotQuatZ;

		// Token: 0x040000FB RID: 251
		public float rotQuatW;

		// Token: 0x040000FC RID: 252
		public float posAccelX;

		// Token: 0x040000FD RID: 253
		public float posAccelY;

		// Token: 0x040000FE RID: 254
		public float posAccelZ;

		// Token: 0x040000FF RID: 255
		public float rotVelX;

		// Token: 0x04000100 RID: 256
		public float rotVelY;

		// Token: 0x04000101 RID: 257
		public float rotVelZ;
	}
}
