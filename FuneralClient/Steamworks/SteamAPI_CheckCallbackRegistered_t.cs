using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200014D RID: 333
	// (Invoke) Token: 0x0600052E RID: 1326
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void SteamAPI_CheckCallbackRegistered_t(int iCallbackNum);
}
