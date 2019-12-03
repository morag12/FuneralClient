using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200015D RID: 349
	public static class SteamGameServerUtils
	{
		// Token: 0x060006D3 RID: 1747 RVA: 0x00004F72 File Offset: 0x00003172
		public static uint GetSecondsSinceAppActive()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUtils_GetSecondsSinceAppActive(CSteamGameServerAPIContext.GetSteamUtils());
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00004F83 File Offset: 0x00003183
		public static uint GetSecondsSinceComputerActive()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUtils_GetSecondsSinceComputerActive(CSteamGameServerAPIContext.GetSteamUtils());
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00004F94 File Offset: 0x00003194
		public static EUniverse GetConnectedUniverse()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUtils_GetConnectedUniverse(CSteamGameServerAPIContext.GetSteamUtils());
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00004FA5 File Offset: 0x000031A5
		public static uint GetServerRealTime()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUtils_GetServerRealTime(CSteamGameServerAPIContext.GetSteamUtils());
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00004FB6 File Offset: 0x000031B6
		public static string GetIPCountry()
		{
			InteropHelp.TestIfAvailableGameServer();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamUtils_GetIPCountry(CSteamGameServerAPIContext.GetSteamUtils()));
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00004FCC File Offset: 0x000031CC
		public static bool GetImageSize(int iImage, out uint pnWidth, out uint pnHeight)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUtils_GetImageSize(CSteamGameServerAPIContext.GetSteamUtils(), iImage, out pnWidth, out pnHeight);
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00004FE0 File Offset: 0x000031E0
		public static bool GetImageRGBA(int iImage, byte[] pubDest, int nDestBufferSize)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUtils_GetImageRGBA(CSteamGameServerAPIContext.GetSteamUtils(), iImage, pubDest, nDestBufferSize);
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00004FF4 File Offset: 0x000031F4
		public static bool GetCSERIPPort(out uint unIP, out ushort usPort)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUtils_GetCSERIPPort(CSteamGameServerAPIContext.GetSteamUtils(), out unIP, out usPort);
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00005007 File Offset: 0x00003207
		public static byte GetCurrentBatteryPower()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUtils_GetCurrentBatteryPower(CSteamGameServerAPIContext.GetSteamUtils());
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00005018 File Offset: 0x00003218
		public static AppId_t GetAppID()
		{
			InteropHelp.TestIfAvailableGameServer();
			return (AppId_t)NativeMethods.ISteamUtils_GetAppID(CSteamGameServerAPIContext.GetSteamUtils());
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x0000502E File Offset: 0x0000322E
		public static void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamUtils_SetOverlayNotificationPosition(CSteamGameServerAPIContext.GetSteamUtils(), eNotificationPosition);
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00005040 File Offset: 0x00003240
		public static bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUtils_IsAPICallCompleted(CSteamGameServerAPIContext.GetSteamUtils(), hSteamAPICall, out pbFailed);
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00005053 File Offset: 0x00003253
		public static ESteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUtils_GetAPICallFailureReason(CSteamGameServerAPIContext.GetSteamUtils(), hSteamAPICall);
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00005065 File Offset: 0x00003265
		public static bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUtils_GetAPICallResult(CSteamGameServerAPIContext.GetSteamUtils(), hSteamAPICall, pCallback, cubCallback, iCallbackExpected, out pbFailed);
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x0000507C File Offset: 0x0000327C
		public static uint GetIPCCallCount()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUtils_GetIPCCallCount(CSteamGameServerAPIContext.GetSteamUtils());
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x0000508D File Offset: 0x0000328D
		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamUtils_SetWarningMessageHook(CSteamGameServerAPIContext.GetSteamUtils(), pFunction);
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x0000509F File Offset: 0x0000329F
		public static bool IsOverlayEnabled()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUtils_IsOverlayEnabled(CSteamGameServerAPIContext.GetSteamUtils());
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x000050B0 File Offset: 0x000032B0
		public static bool BOverlayNeedsPresent()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUtils_BOverlayNeedsPresent(CSteamGameServerAPIContext.GetSteamUtils());
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x0000D9D8 File Offset: 0x0000BBD8
		public static SteamAPICall_t CheckFileSignature(string szFileName)
		{
			InteropHelp.TestIfAvailableGameServer();
			SteamAPICall_t result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(szFileName))
			{
				result = (SteamAPICall_t)NativeMethods.ISteamUtils_CheckFileSignature(CSteamGameServerAPIContext.GetSteamUtils(), utf8StringHandle);
			}
			return result;
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0000DA20 File Offset: 0x0000BC20
		public static bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText)
		{
			InteropHelp.TestIfAvailableGameServer();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchDescription))
			{
				using (InteropHelp.UTF8StringHandle utf8StringHandle2 = new InteropHelp.UTF8StringHandle(pchExistingText))
				{
					result = NativeMethods.ISteamUtils_ShowGamepadTextInput(CSteamGameServerAPIContext.GetSteamUtils(), eInputMode, eLineInputMode, utf8StringHandle, unCharMax, utf8StringHandle2);
				}
			}
			return result;
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x000050C1 File Offset: 0x000032C1
		public static uint GetEnteredGamepadTextLength()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUtils_GetEnteredGamepadTextLength(CSteamGameServerAPIContext.GetSteamUtils());
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x0000DA84 File Offset: 0x0000BC84
		public static bool GetEnteredGamepadTextInput(out string pchText, uint cchText)
		{
			InteropHelp.TestIfAvailableGameServer();
			IntPtr intPtr = Marshal.AllocHGlobal((int)cchText);
			bool flag = NativeMethods.ISteamUtils_GetEnteredGamepadTextInput(CSteamGameServerAPIContext.GetSteamUtils(), intPtr, cchText);
			pchText = (flag ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x000050D2 File Offset: 0x000032D2
		public static string GetSteamUILanguage()
		{
			InteropHelp.TestIfAvailableGameServer();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamUtils_GetSteamUILanguage(CSteamGameServerAPIContext.GetSteamUtils()));
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x000050E8 File Offset: 0x000032E8
		public static bool IsSteamRunningInVR()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUtils_IsSteamRunningInVR(CSteamGameServerAPIContext.GetSteamUtils());
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x000050F9 File Offset: 0x000032F9
		public static void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamUtils_SetOverlayNotificationInset(CSteamGameServerAPIContext.GetSteamUtils(), nHorizontalInset, nVerticalInset);
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x0000510C File Offset: 0x0000330C
		public static bool IsSteamInBigPictureMode()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUtils_IsSteamInBigPictureMode(CSteamGameServerAPIContext.GetSteamUtils());
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x0000511D File Offset: 0x0000331D
		public static void StartVRDashboard()
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamUtils_StartVRDashboard(CSteamGameServerAPIContext.GetSteamUtils());
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x0000512E File Offset: 0x0000332E
		public static bool IsVRHeadsetStreamingEnabled()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUtils_IsVRHeadsetStreamingEnabled(CSteamGameServerAPIContext.GetSteamUtils());
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x0000513F File Offset: 0x0000333F
		public static void SetVRHeadsetStreamingEnabled(bool bEnabled)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamUtils_SetVRHeadsetStreamingEnabled(CSteamGameServerAPIContext.GetSteamUtils(), bEnabled);
		}
	}
}
