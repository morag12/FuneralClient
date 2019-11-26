using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Steamworks2
{
	// Token: 0x0200014C RID: 332
	// (Invoke) Token: 0x0600052A RID: 1322
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void SteamAPIWarningMessageHook_t(int nSeverity, StringBuilder pchDebugText);
}
