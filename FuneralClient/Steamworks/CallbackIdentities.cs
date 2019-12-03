using System;

namespace Steamworks2
{
	// Token: 0x02000010 RID: 16
	internal class CallbackIdentities
	{
		// Token: 0x0600002E RID: 46 RVA: 0x0000A2BC File Offset: 0x000084BC
		public static int GetCallbackIdentity(Type callbackStruct)
		{
			object[] customAttributes = callbackStruct.GetCustomAttributes(typeof(CallbackIdentityAttribute), false);
			int num = 0;
			if (num >= customAttributes.Length)
			{
				throw new Exception("Callback number not found for struct " + callbackStruct);
			}
			return ((CallbackIdentityAttribute)customAttributes[num]).Identity;
		}
	}
}
