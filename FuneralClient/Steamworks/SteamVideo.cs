using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000183 RID: 387
	public static class SteamVideo
	{
		// Token: 0x060008FC RID: 2300 RVA: 0x00006FDA File Offset: 0x000051DA
		public static void GetVideoURL(AppId_t unVideoAppID)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamVideo_GetVideoURL(CSteamAPIContext.GetSteamVideo(), unVideoAppID);
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00006FEC File Offset: 0x000051EC
		public static bool IsBroadcasting(out int pnNumViewers)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamVideo_IsBroadcasting(CSteamAPIContext.GetSteamVideo(), out pnNumViewers);
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00006FFE File Offset: 0x000051FE
		public static void GetOPFSettings(AppId_t unVideoAppID)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamVideo_GetOPFSettings(CSteamAPIContext.GetSteamVideo(), unVideoAppID);
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x0000FE78 File Offset: 0x0000E078
		public static bool GetOPFStringForApp(AppId_t unVideoAppID, out string pchBuffer, ref int pnBufferSize)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal(pnBufferSize);
			bool flag = NativeMethods.ISteamVideo_GetOPFStringForApp(CSteamAPIContext.GetSteamVideo(), unVideoAppID, intPtr, ref pnBufferSize);
			pchBuffer = (flag ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}
	}
}
