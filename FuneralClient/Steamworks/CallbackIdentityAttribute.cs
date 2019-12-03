using System;

namespace Steamworks2
{
	// Token: 0x02000011 RID: 17
	[AttributeUsage(AttributeTargets.Struct, AllowMultiple = false)]
	internal class CallbackIdentityAttribute : Attribute
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000030 RID: 48 RVA: 0x0000220F File Offset: 0x0000040F
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00002217 File Offset: 0x00000417
		public int Identity { get; set; }

		// Token: 0x06000032 RID: 50 RVA: 0x00002220 File Offset: 0x00000420
		public CallbackIdentityAttribute(int callbackNum)
		{
			Identity = callbackNum;
		}
	}
}
