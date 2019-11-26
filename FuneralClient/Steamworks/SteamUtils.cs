using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000182 RID: 386
	public static class SteamUtils
	{
		// Token: 0x060008DF RID: 2271 RVA: 0x00006DFB File Offset: 0x00004FFB
		public static uint GetSecondsSinceAppActive()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetSecondsSinceAppActive(CSteamAPIContext.GetSteamUtils());
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00006E0C File Offset: 0x0000500C
		public static uint GetSecondsSinceComputerActive()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetSecondsSinceComputerActive(CSteamAPIContext.GetSteamUtils());
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00006E1D File Offset: 0x0000501D
		public static EUniverse GetConnectedUniverse()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetConnectedUniverse(CSteamAPIContext.GetSteamUtils());
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00006E2E File Offset: 0x0000502E
		public static uint GetServerRealTime()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetServerRealTime(CSteamAPIContext.GetSteamUtils());
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00006E3F File Offset: 0x0000503F
		public static string GetIPCountry()
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamUtils_GetIPCountry(CSteamAPIContext.GetSteamUtils()));
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00006E55 File Offset: 0x00005055
		public static bool GetImageSize(int iImage, out uint pnWidth, out uint pnHeight)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetImageSize(CSteamAPIContext.GetSteamUtils(), iImage, out pnWidth, out pnHeight);
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00006E69 File Offset: 0x00005069
		public static bool GetImageRGBA(int iImage, byte[] pubDest, int nDestBufferSize)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetImageRGBA(CSteamAPIContext.GetSteamUtils(), iImage, pubDest, nDestBufferSize);
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00006E7D File Offset: 0x0000507D
		public static bool GetCSERIPPort(out uint unIP, out ushort usPort)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetCSERIPPort(CSteamAPIContext.GetSteamUtils(), out unIP, out usPort);
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00006E90 File Offset: 0x00005090
		public static byte GetCurrentBatteryPower()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetCurrentBatteryPower(CSteamAPIContext.GetSteamUtils());
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x00006EA1 File Offset: 0x000050A1
		public static AppId_t GetAppID()
		{
			InteropHelp.TestIfAvailableClient();
			return (AppId_t)NativeMethods.ISteamUtils_GetAppID(CSteamAPIContext.GetSteamUtils());
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00006EB7 File Offset: 0x000050B7
		public static void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamUtils_SetOverlayNotificationPosition(CSteamAPIContext.GetSteamUtils(), eNotificationPosition);
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00006EC9 File Offset: 0x000050C9
		public static bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_IsAPICallCompleted(CSteamAPIContext.GetSteamUtils(), hSteamAPICall, out pbFailed);
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00006EDC File Offset: 0x000050DC
		public static ESteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetAPICallFailureReason(CSteamAPIContext.GetSteamUtils(), hSteamAPICall);
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00006EEE File Offset: 0x000050EE
		public static bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetAPICallResult(CSteamAPIContext.GetSteamUtils(), hSteamAPICall, pCallback, cubCallback, iCallbackExpected, out pbFailed);
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00006F05 File Offset: 0x00005105
		public static uint GetIPCCallCount()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetIPCCallCount(CSteamAPIContext.GetSteamUtils());
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00006F16 File Offset: 0x00005116
		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamUtils_SetWarningMessageHook(CSteamAPIContext.GetSteamUtils(), pFunction);
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00006F28 File Offset: 0x00005128
		public static bool IsOverlayEnabled()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_IsOverlayEnabled(CSteamAPIContext.GetSteamUtils());
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00006F39 File Offset: 0x00005139
		public static bool BOverlayNeedsPresent()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_BOverlayNeedsPresent(CSteamAPIContext.GetSteamUtils());
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x0000FD90 File Offset: 0x0000DF90
		public static SteamAPICall_t CheckFileSignature(string szFileName)
		{
			InteropHelp.TestIfAvailableClient();
			SteamAPICall_t result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(szFileName))
			{
				result = (SteamAPICall_t)NativeMethods.ISteamUtils_CheckFileSignature(CSteamAPIContext.GetSteamUtils(), utf8StringHandle);
			}
			return result;
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x0000FDD8 File Offset: 0x0000DFD8
		public static bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchDescription))
			{
				using (InteropHelp.UTF8StringHandle utf8StringHandle2 = new InteropHelp.UTF8StringHandle(pchExistingText))
				{
					result = NativeMethods.ISteamUtils_ShowGamepadTextInput(CSteamAPIContext.GetSteamUtils(), eInputMode, eLineInputMode, utf8StringHandle, unCharMax, utf8StringHandle2);
				}
			}
			return result;
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00006F4A File Offset: 0x0000514A
		public static uint GetEnteredGamepadTextLength()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetEnteredGamepadTextLength(CSteamAPIContext.GetSteamUtils());
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x0000FE3C File Offset: 0x0000E03C
		public static bool GetEnteredGamepadTextInput(out string pchText, uint cchText)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal((int)cchText);
			bool flag = NativeMethods.ISteamUtils_GetEnteredGamepadTextInput(CSteamAPIContext.GetSteamUtils(), intPtr, cchText);
			pchText = (flag ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00006F5B File Offset: 0x0000515B
		public static string GetSteamUILanguage()
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamUtils_GetSteamUILanguage(CSteamAPIContext.GetSteamUtils()));
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00006F71 File Offset: 0x00005171
		public static bool IsSteamRunningInVR()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_IsSteamRunningInVR(CSteamAPIContext.GetSteamUtils());
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00006F82 File Offset: 0x00005182
		public static void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamUtils_SetOverlayNotificationInset(CSteamAPIContext.GetSteamUtils(), nHorizontalInset, nVerticalInset);
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00006F95 File Offset: 0x00005195
		public static bool IsSteamInBigPictureMode()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_IsSteamInBigPictureMode(CSteamAPIContext.GetSteamUtils());
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00006FA6 File Offset: 0x000051A6
		public static void StartVRDashboard()
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamUtils_StartVRDashboard(CSteamAPIContext.GetSteamUtils());
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00006FB7 File Offset: 0x000051B7
		public static bool IsVRHeadsetStreamingEnabled()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_IsVRHeadsetStreamingEnabled(CSteamAPIContext.GetSteamUtils());
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x00006FC8 File Offset: 0x000051C8
		public static void SetVRHeadsetStreamingEnabled(bool bEnabled)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamUtils_SetVRHeadsetStreamingEnabled(CSteamAPIContext.GetSteamUtils(), bEnabled);
		}
	}
}
