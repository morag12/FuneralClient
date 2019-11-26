using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Steamworks2
{
	// Token: 0x02000113 RID: 275
	[SuppressUnmanagedCodeSecurity]
	internal static class NativeMethods
	{
		// Token: 0x060001EB RID: 491
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_Init();

		// Token: 0x060001EC RID: 492
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_Shutdown();

		// Token: 0x060001ED RID: 493
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_RestartAppIfNecessary(AppId_t unOwnAppID);

		// Token: 0x060001EE RID: 494
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ReleaseCurrentThreadMemory();

		// Token: 0x060001EF RID: 495
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_WriteMiniDump(uint uStructuredExceptionCode, IntPtr pvExceptionInfo, uint uBuildID);

		// Token: 0x060001F0 RID: 496
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_SetMiniDumpComment(InteropHelp.UTF8StringHandle pchMsg);

		// Token: 0x060001F1 RID: 497
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_RunCallbacks();

		// Token: 0x060001F2 RID: 498
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_RegisterCallback(IntPtr pCallback, int iCallback);

		// Token: 0x060001F3 RID: 499
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_UnregisterCallback(IntPtr pCallback);

		// Token: 0x060001F4 RID: 500
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_RegisterCallResult(IntPtr pCallback, ulong hAPICall);

		// Token: 0x060001F5 RID: 501
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_UnregisterCallResult(IntPtr pCallback, ulong hAPICall);

		// Token: 0x060001F6 RID: 502
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_IsSteamRunning();

		// Token: 0x060001F7 RID: 503
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Steam_RunCallbacks(HSteamPipe hSteamPipe, [MarshalAs(UnmanagedType.I1)] bool bGameServerCallbacks);

		// Token: 0x060001F8 RID: 504
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Steam_RegisterInterfaceFuncs(IntPtr hModule);

		// Token: 0x060001F9 RID: 505
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Steam_GetHSteamUserCurrent();

		// Token: 0x060001FA RID: 506
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_GetSteamInstallPath();

		// Token: 0x060001FB RID: 507
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_GetHSteamPipe();

		// Token: 0x060001FC RID: 508
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_SetTryCatchCallbacks([MarshalAs(UnmanagedType.I1)] bool bTryCatchCallbacks);

		// Token: 0x060001FD RID: 509
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_GetHSteamUser();

		// Token: 0x060001FE RID: 510
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamInternal_ContextInit(IntPtr pContextInitData);

		// Token: 0x060001FF RID: 511
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamInternal_CreateInterface(InteropHelp.UTF8StringHandle ver);

		// Token: 0x06000200 RID: 512
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_UseBreakpadCrashHandler(InteropHelp.UTF8StringHandle pchVersion, InteropHelp.UTF8StringHandle pchDate, InteropHelp.UTF8StringHandle pchTime, [MarshalAs(UnmanagedType.I1)] bool bFullMemoryDumps, IntPtr pvContext, IntPtr m_pfnPreMinidumpCallback);

		// Token: 0x06000201 RID: 513
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_SetBreakpadAppID(uint unAppID);

		// Token: 0x06000202 RID: 514
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamGameServer_InitSafe")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamGameServer_Init(uint unIP, ushort usSteamPort, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, InteropHelp.UTF8StringHandle pchVersionString);

		// Token: 0x06000203 RID: 515
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamGameServer_Shutdown();

		// Token: 0x06000204 RID: 516
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamGameServer_RunCallbacks();

		// Token: 0x06000205 RID: 517
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamGameServer_ReleaseCurrentThreadMemory();

		// Token: 0x06000206 RID: 518
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamGameServer_BSecure();

		// Token: 0x06000207 RID: 519
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamGameServer_GetSteamID();

		// Token: 0x06000208 RID: 520
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamGameServer_GetHSteamPipe();

		// Token: 0x06000209 RID: 521
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamGameServer_GetHSteamUser();

		// Token: 0x0600020A RID: 522
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamInternal_GameServer_Init(uint unIP, ushort usPort, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, InteropHelp.UTF8StringHandle pchVersionString);

		// Token: 0x0600020B RID: 523
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamClient();

		// Token: 0x0600020C RID: 524
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamGameServerClient();

		// Token: 0x0600020D RID: 525
		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamEncryptedAppTicket_BDecryptTicket(byte[] rgubTicketEncrypted, uint cubTicketEncrypted, byte[] rgubTicketDecrypted, ref uint pcubTicketDecrypted, [MarshalAs(UnmanagedType.LPArray, SizeConst = 32)] byte[] rgubKey, int cubKey);

		// Token: 0x0600020E RID: 526
		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamEncryptedAppTicket_BIsTicketForApp(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID);

		// Token: 0x0600020F RID: 527
		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamEncryptedAppTicket_GetTicketIssueTime(byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		// Token: 0x06000210 RID: 528
		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamEncryptedAppTicket_GetTicketSteamID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID);

		// Token: 0x06000211 RID: 529
		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamEncryptedAppTicket_GetTicketAppID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		// Token: 0x06000212 RID: 530
		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamEncryptedAppTicket_BUserOwnsAppInTicket(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID);

		// Token: 0x06000213 RID: 531
		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamEncryptedAppTicket_BUserIsVacBanned(byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		// Token: 0x06000214 RID: 532
		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamEncryptedAppTicket_GetUserVariableData(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData);

		// Token: 0x06000215 RID: 533
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamAppList_GetNumInstalledApps")]
		public static extern uint ISteamAppList_GetNumInstalledApps(IntPtr instancePtr);

		// Token: 0x06000216 RID: 534
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamAppList_GetInstalledApps")]
		public static extern uint ISteamAppList_GetInstalledApps(IntPtr instancePtr, [In] [Out] AppId_t[] pvecAppID, uint unMaxAppIDs);

		// Token: 0x06000217 RID: 535
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamAppList_GetAppName")]
		public static extern int ISteamAppList_GetAppName(IntPtr instancePtr, AppId_t nAppID, IntPtr pchName, int cchNameMax);

		// Token: 0x06000218 RID: 536
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamAppList_GetAppInstallDir")]
		public static extern int ISteamAppList_GetAppInstallDir(IntPtr instancePtr, AppId_t nAppID, IntPtr pchDirectory, int cchNameMax);

		// Token: 0x06000219 RID: 537
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamAppList_GetAppBuildId")]
		public static extern int ISteamAppList_GetAppBuildId(IntPtr instancePtr, AppId_t nAppID);

		// Token: 0x0600021A RID: 538
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_BIsSubscribed")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_BIsSubscribed(IntPtr instancePtr);

		// Token: 0x0600021B RID: 539
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_BIsLowViolence")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_BIsLowViolence(IntPtr instancePtr);

		// Token: 0x0600021C RID: 540
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_BIsCybercafe")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_BIsCybercafe(IntPtr instancePtr);

		// Token: 0x0600021D RID: 541
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_BIsVACBanned")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_BIsVACBanned(IntPtr instancePtr);

		// Token: 0x0600021E RID: 542
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetCurrentGameLanguage")]
		public static extern IntPtr ISteamApps_GetCurrentGameLanguage(IntPtr instancePtr);

		// Token: 0x0600021F RID: 543
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetAvailableGameLanguages")]
		public static extern IntPtr ISteamApps_GetAvailableGameLanguages(IntPtr instancePtr);

		// Token: 0x06000220 RID: 544
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_BIsSubscribedApp")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_BIsSubscribedApp(IntPtr instancePtr, AppId_t appID);

		// Token: 0x06000221 RID: 545
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_BIsDlcInstalled")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_BIsDlcInstalled(IntPtr instancePtr, AppId_t appID);

		// Token: 0x06000222 RID: 546
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetEarliestPurchaseUnixTime")]
		public static extern uint ISteamApps_GetEarliestPurchaseUnixTime(IntPtr instancePtr, AppId_t nAppID);

		// Token: 0x06000223 RID: 547
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_BIsSubscribedFromFreeWeekend")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_BIsSubscribedFromFreeWeekend(IntPtr instancePtr);

		// Token: 0x06000224 RID: 548
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetDLCCount")]
		public static extern int ISteamApps_GetDLCCount(IntPtr instancePtr);

		// Token: 0x06000225 RID: 549
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_BGetDLCDataByIndex")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_BGetDLCDataByIndex(IntPtr instancePtr, int iDLC, out AppId_t pAppID, out bool pbAvailable, IntPtr pchName, int cchNameBufferSize);

		// Token: 0x06000226 RID: 550
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_InstallDLC")]
		public static extern void ISteamApps_InstallDLC(IntPtr instancePtr, AppId_t nAppID);

		// Token: 0x06000227 RID: 551
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_UninstallDLC")]
		public static extern void ISteamApps_UninstallDLC(IntPtr instancePtr, AppId_t nAppID);

		// Token: 0x06000228 RID: 552
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_RequestAppProofOfPurchaseKey")]
		public static extern void ISteamApps_RequestAppProofOfPurchaseKey(IntPtr instancePtr, AppId_t nAppID);

		// Token: 0x06000229 RID: 553
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetCurrentBetaName")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_GetCurrentBetaName(IntPtr instancePtr, IntPtr pchName, int cchNameBufferSize);

		// Token: 0x0600022A RID: 554
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_MarkContentCorrupt")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_MarkContentCorrupt(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bMissingFilesOnly);

		// Token: 0x0600022B RID: 555
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetInstalledDepots")]
		public static extern uint ISteamApps_GetInstalledDepots(IntPtr instancePtr, AppId_t appID, [In] [Out] DepotId_t[] pvecDepots, uint cMaxDepots);

		// Token: 0x0600022C RID: 556
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetAppInstallDir")]
		public static extern uint ISteamApps_GetAppInstallDir(IntPtr instancePtr, AppId_t appID, IntPtr pchFolder, uint cchFolderBufferSize);

		// Token: 0x0600022D RID: 557
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_BIsAppInstalled")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_BIsAppInstalled(IntPtr instancePtr, AppId_t appID);

		// Token: 0x0600022E RID: 558
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetAppOwner")]
		public static extern ulong ISteamApps_GetAppOwner(IntPtr instancePtr);

		// Token: 0x0600022F RID: 559
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetLaunchQueryParam")]
		public static extern IntPtr ISteamApps_GetLaunchQueryParam(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKey);

		// Token: 0x06000230 RID: 560
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetDlcDownloadProgress")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_GetDlcDownloadProgress(IntPtr instancePtr, AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal);

		// Token: 0x06000231 RID: 561
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetAppBuildId")]
		public static extern int ISteamApps_GetAppBuildId(IntPtr instancePtr);

		// Token: 0x06000232 RID: 562
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_RequestAllProofOfPurchaseKeys")]
		public static extern void ISteamApps_RequestAllProofOfPurchaseKeys(IntPtr instancePtr);

		// Token: 0x06000233 RID: 563
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetFileDetails")]
		public static extern ulong ISteamApps_GetFileDetails(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszFileName);

		// Token: 0x06000234 RID: 564
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_CreateSteamPipe")]
		public static extern int ISteamClient_CreateSteamPipe(IntPtr instancePtr);

		// Token: 0x06000235 RID: 565
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_BReleaseSteamPipe")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamClient_BReleaseSteamPipe(IntPtr instancePtr, HSteamPipe hSteamPipe);

		// Token: 0x06000236 RID: 566
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_ConnectToGlobalUser")]
		public static extern int ISteamClient_ConnectToGlobalUser(IntPtr instancePtr, HSteamPipe hSteamPipe);

		// Token: 0x06000237 RID: 567
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_CreateLocalUser")]
		public static extern int ISteamClient_CreateLocalUser(IntPtr instancePtr, out HSteamPipe phSteamPipe, EAccountType eAccountType);

		// Token: 0x06000238 RID: 568
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_ReleaseUser")]
		public static extern void ISteamClient_ReleaseUser(IntPtr instancePtr, HSteamPipe hSteamPipe, HSteamUser hUser);

		// Token: 0x06000239 RID: 569
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamUser")]
		public static extern IntPtr ISteamClient_GetISteamUser(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600023A RID: 570
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamGameServer")]
		public static extern IntPtr ISteamClient_GetISteamGameServer(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600023B RID: 571
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_SetLocalIPBinding")]
		public static extern void ISteamClient_SetLocalIPBinding(IntPtr instancePtr, uint unIP, ushort usPort);

		// Token: 0x0600023C RID: 572
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamFriends")]
		public static extern IntPtr ISteamClient_GetISteamFriends(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600023D RID: 573
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamUtils")]
		public static extern IntPtr ISteamClient_GetISteamUtils(IntPtr instancePtr, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600023E RID: 574
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamMatchmaking")]
		public static extern IntPtr ISteamClient_GetISteamMatchmaking(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600023F RID: 575
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamMatchmakingServers")]
		public static extern IntPtr ISteamClient_GetISteamMatchmakingServers(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000240 RID: 576
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamGenericInterface")]
		public static extern IntPtr ISteamClient_GetISteamGenericInterface(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000241 RID: 577
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamUserStats")]
		public static extern IntPtr ISteamClient_GetISteamUserStats(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000242 RID: 578
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamGameServerStats")]
		public static extern IntPtr ISteamClient_GetISteamGameServerStats(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000243 RID: 579
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamApps")]
		public static extern IntPtr ISteamClient_GetISteamApps(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000244 RID: 580
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamNetworking")]
		public static extern IntPtr ISteamClient_GetISteamNetworking(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000245 RID: 581
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamRemoteStorage")]
		public static extern IntPtr ISteamClient_GetISteamRemoteStorage(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000246 RID: 582
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamScreenshots")]
		public static extern IntPtr ISteamClient_GetISteamScreenshots(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000247 RID: 583
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetIPCCallCount")]
		public static extern uint ISteamClient_GetIPCCallCount(IntPtr instancePtr);

		// Token: 0x06000248 RID: 584
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_SetWarningMessageHook")]
		public static extern void ISteamClient_SetWarningMessageHook(IntPtr instancePtr, SteamAPIWarningMessageHook_t pFunction);

		// Token: 0x06000249 RID: 585
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_BShutdownIfAllPipesClosed")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamClient_BShutdownIfAllPipesClosed(IntPtr instancePtr);

		// Token: 0x0600024A RID: 586
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamHTTP")]
		public static extern IntPtr ISteamClient_GetISteamHTTP(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600024B RID: 587
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamController")]
		public static extern IntPtr ISteamClient_GetISteamController(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600024C RID: 588
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamUGC")]
		public static extern IntPtr ISteamClient_GetISteamUGC(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600024D RID: 589
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamAppList")]
		public static extern IntPtr ISteamClient_GetISteamAppList(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600024E RID: 590
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamMusic")]
		public static extern IntPtr ISteamClient_GetISteamMusic(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600024F RID: 591
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamMusicRemote")]
		public static extern IntPtr ISteamClient_GetISteamMusicRemote(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000250 RID: 592
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamHTMLSurface")]
		public static extern IntPtr ISteamClient_GetISteamHTMLSurface(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000251 RID: 593
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamInventory")]
		public static extern IntPtr ISteamClient_GetISteamInventory(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000252 RID: 594
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamVideo")]
		public static extern IntPtr ISteamClient_GetISteamVideo(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000253 RID: 595
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamParentalSettings")]
		public static extern IntPtr ISteamClient_GetISteamParentalSettings(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000254 RID: 596
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_Init")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamController_Init(IntPtr instancePtr);

		// Token: 0x06000255 RID: 597
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_Shutdown")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamController_Shutdown(IntPtr instancePtr);

		// Token: 0x06000256 RID: 598
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_RunFrame")]
		public static extern void ISteamController_RunFrame(IntPtr instancePtr);

		// Token: 0x06000257 RID: 599
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_GetConnectedControllers")]
		public static extern int ISteamController_GetConnectedControllers(IntPtr instancePtr, [In] [Out] ControllerHandle_t[] handlesOut);

		// Token: 0x06000258 RID: 600
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_ShowBindingPanel")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamController_ShowBindingPanel(IntPtr instancePtr, ControllerHandle_t controllerHandle);

		// Token: 0x06000259 RID: 601
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_GetActionSetHandle")]
		public static extern ulong ISteamController_GetActionSetHandle(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszActionSetName);

		// Token: 0x0600025A RID: 602
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_ActivateActionSet")]
		public static extern void ISteamController_ActivateActionSet(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle);

		// Token: 0x0600025B RID: 603
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_GetCurrentActionSet")]
		public static extern ulong ISteamController_GetCurrentActionSet(IntPtr instancePtr, ControllerHandle_t controllerHandle);

		// Token: 0x0600025C RID: 604
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_ActivateActionSetLayer")]
		public static extern void ISteamController_ActivateActionSetLayer(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetLayerHandle);

		// Token: 0x0600025D RID: 605
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_DeactivateActionSetLayer")]
		public static extern void ISteamController_DeactivateActionSetLayer(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetLayerHandle);

		// Token: 0x0600025E RID: 606
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_DeactivateAllActionSetLayers")]
		public static extern void ISteamController_DeactivateAllActionSetLayers(IntPtr instancePtr, ControllerHandle_t controllerHandle);

		// Token: 0x0600025F RID: 607
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_GetActiveActionSetLayers")]
		public static extern int ISteamController_GetActiveActionSetLayers(IntPtr instancePtr, ControllerHandle_t controllerHandle, out ControllerActionSetHandle_t handlesOut);

		// Token: 0x06000260 RID: 608
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_GetDigitalActionHandle")]
		public static extern ulong ISteamController_GetDigitalActionHandle(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszActionName);

		// Token: 0x06000261 RID: 609
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_GetDigitalActionData")]
		public static extern ControllerDigitalActionData_t ISteamController_GetDigitalActionData(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerDigitalActionHandle_t digitalActionHandle);

		// Token: 0x06000262 RID: 610
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_GetDigitalActionOrigins")]
		public static extern int ISteamController_GetDigitalActionOrigins(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerDigitalActionHandle_t digitalActionHandle, [In] [Out] EControllerActionOrigin[] originsOut);

		// Token: 0x06000263 RID: 611
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_GetAnalogActionHandle")]
		public static extern ulong ISteamController_GetAnalogActionHandle(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszActionName);

		// Token: 0x06000264 RID: 612
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_GetAnalogActionData")]
		public static extern ControllerAnalogActionData_t ISteamController_GetAnalogActionData(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t analogActionHandle);

		// Token: 0x06000265 RID: 613
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_GetAnalogActionOrigins")]
		public static extern int ISteamController_GetAnalogActionOrigins(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerAnalogActionHandle_t analogActionHandle, [In] [Out] EControllerActionOrigin[] originsOut);

		// Token: 0x06000266 RID: 614
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_StopAnalogActionMomentum")]
		public static extern void ISteamController_StopAnalogActionMomentum(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t eAction);

		// Token: 0x06000267 RID: 615
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_TriggerHapticPulse")]
		public static extern void ISteamController_TriggerHapticPulse(IntPtr instancePtr, ControllerHandle_t controllerHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec);

		// Token: 0x06000268 RID: 616
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_TriggerRepeatedHapticPulse")]
		public static extern void ISteamController_TriggerRepeatedHapticPulse(IntPtr instancePtr, ControllerHandle_t controllerHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags);

		// Token: 0x06000269 RID: 617
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_TriggerVibration")]
		public static extern void ISteamController_TriggerVibration(IntPtr instancePtr, ControllerHandle_t controllerHandle, ushort usLeftSpeed, ushort usRightSpeed);

		// Token: 0x0600026A RID: 618
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_SetLEDColor")]
		public static extern void ISteamController_SetLEDColor(IntPtr instancePtr, ControllerHandle_t controllerHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags);

		// Token: 0x0600026B RID: 619
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_GetGamepadIndexForController")]
		public static extern int ISteamController_GetGamepadIndexForController(IntPtr instancePtr, ControllerHandle_t ulControllerHandle);

		// Token: 0x0600026C RID: 620
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_GetControllerForGamepadIndex")]
		public static extern ulong ISteamController_GetControllerForGamepadIndex(IntPtr instancePtr, int nIndex);

		// Token: 0x0600026D RID: 621
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_GetMotionData")]
		public static extern ControllerMotionData_t ISteamController_GetMotionData(IntPtr instancePtr, ControllerHandle_t controllerHandle);

		// Token: 0x0600026E RID: 622
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_ShowDigitalActionOrigins")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamController_ShowDigitalActionOrigins(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerDigitalActionHandle_t digitalActionHandle, float flScale, float flXPosition, float flYPosition);

		// Token: 0x0600026F RID: 623
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_ShowAnalogActionOrigins")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamController_ShowAnalogActionOrigins(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t analogActionHandle, float flScale, float flXPosition, float flYPosition);

		// Token: 0x06000270 RID: 624
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_GetStringForActionOrigin")]
		public static extern IntPtr ISteamController_GetStringForActionOrigin(IntPtr instancePtr, EControllerActionOrigin eOrigin);

		// Token: 0x06000271 RID: 625
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_GetGlyphForActionOrigin")]
		public static extern IntPtr ISteamController_GetGlyphForActionOrigin(IntPtr instancePtr, EControllerActionOrigin eOrigin);

		// Token: 0x06000272 RID: 626
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_GetInputTypeForHandle")]
		public static extern ESteamInputType ISteamController_GetInputTypeForHandle(IntPtr instancePtr, ControllerHandle_t controllerHandle);

		// Token: 0x06000273 RID: 627
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetPersonaName")]
		public static extern IntPtr ISteamFriends_GetPersonaName(IntPtr instancePtr);

		// Token: 0x06000274 RID: 628
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_SetPersonaName")]
		public static extern ulong ISteamFriends_SetPersonaName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchPersonaName);

		// Token: 0x06000275 RID: 629
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetPersonaState")]
		public static extern EPersonaState ISteamFriends_GetPersonaState(IntPtr instancePtr);

		// Token: 0x06000276 RID: 630
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendCount")]
		public static extern int ISteamFriends_GetFriendCount(IntPtr instancePtr, EFriendFlags iFriendFlags);

		// Token: 0x06000277 RID: 631
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendByIndex")]
		public static extern ulong ISteamFriends_GetFriendByIndex(IntPtr instancePtr, int iFriend, EFriendFlags iFriendFlags);

		// Token: 0x06000278 RID: 632
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendRelationship")]
		public static extern EFriendRelationship ISteamFriends_GetFriendRelationship(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x06000279 RID: 633
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendPersonaState")]
		public static extern EPersonaState ISteamFriends_GetFriendPersonaState(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x0600027A RID: 634
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendPersonaName")]
		public static extern IntPtr ISteamFriends_GetFriendPersonaName(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x0600027B RID: 635
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendGamePlayed")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_GetFriendGamePlayed(IntPtr instancePtr, CSteamID steamIDFriend, out FriendGameInfo_t pFriendGameInfo);

		// Token: 0x0600027C RID: 636
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendPersonaNameHistory")]
		public static extern IntPtr ISteamFriends_GetFriendPersonaNameHistory(IntPtr instancePtr, CSteamID steamIDFriend, int iPersonaName);

		// Token: 0x0600027D RID: 637
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendSteamLevel")]
		public static extern int ISteamFriends_GetFriendSteamLevel(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x0600027E RID: 638
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetPlayerNickname")]
		public static extern IntPtr ISteamFriends_GetPlayerNickname(IntPtr instancePtr, CSteamID steamIDPlayer);

		// Token: 0x0600027F RID: 639
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendsGroupCount")]
		public static extern int ISteamFriends_GetFriendsGroupCount(IntPtr instancePtr);

		// Token: 0x06000280 RID: 640
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendsGroupIDByIndex")]
		public static extern short ISteamFriends_GetFriendsGroupIDByIndex(IntPtr instancePtr, int iFG);

		// Token: 0x06000281 RID: 641
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendsGroupName")]
		public static extern IntPtr ISteamFriends_GetFriendsGroupName(IntPtr instancePtr, FriendsGroupID_t friendsGroupID);

		// Token: 0x06000282 RID: 642
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendsGroupMembersCount")]
		public static extern int ISteamFriends_GetFriendsGroupMembersCount(IntPtr instancePtr, FriendsGroupID_t friendsGroupID);

		// Token: 0x06000283 RID: 643
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendsGroupMembersList")]
		public static extern void ISteamFriends_GetFriendsGroupMembersList(IntPtr instancePtr, FriendsGroupID_t friendsGroupID, [In] [Out] CSteamID[] pOutSteamIDMembers, int nMembersCount);

		// Token: 0x06000284 RID: 644
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_HasFriend")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_HasFriend(IntPtr instancePtr, CSteamID steamIDFriend, EFriendFlags iFriendFlags);

		// Token: 0x06000285 RID: 645
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetClanCount")]
		public static extern int ISteamFriends_GetClanCount(IntPtr instancePtr);

		// Token: 0x06000286 RID: 646
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetClanByIndex")]
		public static extern ulong ISteamFriends_GetClanByIndex(IntPtr instancePtr, int iClan);

		// Token: 0x06000287 RID: 647
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetClanName")]
		public static extern IntPtr ISteamFriends_GetClanName(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x06000288 RID: 648
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetClanTag")]
		public static extern IntPtr ISteamFriends_GetClanTag(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x06000289 RID: 649
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetClanActivityCounts")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_GetClanActivityCounts(IntPtr instancePtr, CSteamID steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting);

		// Token: 0x0600028A RID: 650
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_DownloadClanActivityCounts")]
		public static extern ulong ISteamFriends_DownloadClanActivityCounts(IntPtr instancePtr, [In] [Out] CSteamID[] psteamIDClans, int cClansToRequest);

		// Token: 0x0600028B RID: 651
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendCountFromSource")]
		public static extern int ISteamFriends_GetFriendCountFromSource(IntPtr instancePtr, CSteamID steamIDSource);

		// Token: 0x0600028C RID: 652
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendFromSourceByIndex")]
		public static extern ulong ISteamFriends_GetFriendFromSourceByIndex(IntPtr instancePtr, CSteamID steamIDSource, int iFriend);

		// Token: 0x0600028D RID: 653
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_IsUserInSource")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_IsUserInSource(IntPtr instancePtr, CSteamID steamIDUser, CSteamID steamIDSource);

		// Token: 0x0600028E RID: 654
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_SetInGameVoiceSpeaking")]
		public static extern void ISteamFriends_SetInGameVoiceSpeaking(IntPtr instancePtr, CSteamID steamIDUser, [MarshalAs(UnmanagedType.I1)] bool bSpeaking);

		// Token: 0x0600028F RID: 655
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_ActivateGameOverlay")]
		public static extern void ISteamFriends_ActivateGameOverlay(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchDialog);

		// Token: 0x06000290 RID: 656
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_ActivateGameOverlayToUser")]
		public static extern void ISteamFriends_ActivateGameOverlayToUser(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchDialog, CSteamID steamID);

		// Token: 0x06000291 RID: 657
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_ActivateGameOverlayToWebPage")]
		public static extern void ISteamFriends_ActivateGameOverlayToWebPage(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchURL);

		// Token: 0x06000292 RID: 658
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_ActivateGameOverlayToStore")]
		public static extern void ISteamFriends_ActivateGameOverlayToStore(IntPtr instancePtr, AppId_t nAppID, EOverlayToStoreFlag eFlag);

		// Token: 0x06000293 RID: 659
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_SetPlayedWith")]
		public static extern void ISteamFriends_SetPlayedWith(IntPtr instancePtr, CSteamID steamIDUserPlayedWith);

		// Token: 0x06000294 RID: 660
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_ActivateGameOverlayInviteDialog")]
		public static extern void ISteamFriends_ActivateGameOverlayInviteDialog(IntPtr instancePtr, CSteamID steamIDLobby);

		// Token: 0x06000295 RID: 661
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetSmallFriendAvatar")]
		public static extern int ISteamFriends_GetSmallFriendAvatar(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x06000296 RID: 662
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetMediumFriendAvatar")]
		public static extern int ISteamFriends_GetMediumFriendAvatar(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x06000297 RID: 663
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetLargeFriendAvatar")]
		public static extern int ISteamFriends_GetLargeFriendAvatar(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x06000298 RID: 664
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_RequestUserInformation")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_RequestUserInformation(IntPtr instancePtr, CSteamID steamIDUser, [MarshalAs(UnmanagedType.I1)] bool bRequireNameOnly);

		// Token: 0x06000299 RID: 665
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_RequestClanOfficerList")]
		public static extern ulong ISteamFriends_RequestClanOfficerList(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x0600029A RID: 666
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetClanOwner")]
		public static extern ulong ISteamFriends_GetClanOwner(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x0600029B RID: 667
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetClanOfficerCount")]
		public static extern int ISteamFriends_GetClanOfficerCount(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x0600029C RID: 668
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetClanOfficerByIndex")]
		public static extern ulong ISteamFriends_GetClanOfficerByIndex(IntPtr instancePtr, CSteamID steamIDClan, int iOfficer);

		// Token: 0x0600029D RID: 669
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetUserRestrictions")]
		public static extern uint ISteamFriends_GetUserRestrictions(IntPtr instancePtr);

		// Token: 0x0600029E RID: 670
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_SetRichPresence")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_SetRichPresence(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		// Token: 0x0600029F RID: 671
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_ClearRichPresence")]
		public static extern void ISteamFriends_ClearRichPresence(IntPtr instancePtr);

		// Token: 0x060002A0 RID: 672
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendRichPresence")]
		public static extern IntPtr ISteamFriends_GetFriendRichPresence(IntPtr instancePtr, CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchKey);

		// Token: 0x060002A1 RID: 673
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendRichPresenceKeyCount")]
		public static extern int ISteamFriends_GetFriendRichPresenceKeyCount(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x060002A2 RID: 674
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendRichPresenceKeyByIndex")]
		public static extern IntPtr ISteamFriends_GetFriendRichPresenceKeyByIndex(IntPtr instancePtr, CSteamID steamIDFriend, int iKey);

		// Token: 0x060002A3 RID: 675
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_RequestFriendRichPresence")]
		public static extern void ISteamFriends_RequestFriendRichPresence(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x060002A4 RID: 676
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_InviteUserToGame")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_InviteUserToGame(IntPtr instancePtr, CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchConnectString);

		// Token: 0x060002A5 RID: 677
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetCoplayFriendCount")]
		public static extern int ISteamFriends_GetCoplayFriendCount(IntPtr instancePtr);

		// Token: 0x060002A6 RID: 678
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetCoplayFriend")]
		public static extern ulong ISteamFriends_GetCoplayFriend(IntPtr instancePtr, int iCoplayFriend);

		// Token: 0x060002A7 RID: 679
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendCoplayTime")]
		public static extern int ISteamFriends_GetFriendCoplayTime(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x060002A8 RID: 680
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendCoplayGame")]
		public static extern uint ISteamFriends_GetFriendCoplayGame(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x060002A9 RID: 681
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_JoinClanChatRoom")]
		public static extern ulong ISteamFriends_JoinClanChatRoom(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x060002AA RID: 682
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_LeaveClanChatRoom")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_LeaveClanChatRoom(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x060002AB RID: 683
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetClanChatMemberCount")]
		public static extern int ISteamFriends_GetClanChatMemberCount(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x060002AC RID: 684
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetChatMemberByIndex")]
		public static extern ulong ISteamFriends_GetChatMemberByIndex(IntPtr instancePtr, CSteamID steamIDClan, int iUser);

		// Token: 0x060002AD RID: 685
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_SendClanChatMessage")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_SendClanChatMessage(IntPtr instancePtr, CSteamID steamIDClanChat, InteropHelp.UTF8StringHandle pchText);

		// Token: 0x060002AE RID: 686
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetClanChatMessage")]
		public static extern int ISteamFriends_GetClanChatMessage(IntPtr instancePtr, CSteamID steamIDClanChat, int iMessage, IntPtr prgchText, int cchTextMax, out EChatEntryType peChatEntryType, out CSteamID psteamidChatter);

		// Token: 0x060002AF RID: 687
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_IsClanChatAdmin")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_IsClanChatAdmin(IntPtr instancePtr, CSteamID steamIDClanChat, CSteamID steamIDUser);

		// Token: 0x060002B0 RID: 688
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_IsClanChatWindowOpenInSteam")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_IsClanChatWindowOpenInSteam(IntPtr instancePtr, CSteamID steamIDClanChat);

		// Token: 0x060002B1 RID: 689
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_OpenClanChatWindowInSteam")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_OpenClanChatWindowInSteam(IntPtr instancePtr, CSteamID steamIDClanChat);

		// Token: 0x060002B2 RID: 690
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_CloseClanChatWindowInSteam")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_CloseClanChatWindowInSteam(IntPtr instancePtr, CSteamID steamIDClanChat);

		// Token: 0x060002B3 RID: 691
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_SetListenForFriendsMessages")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_SetListenForFriendsMessages(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bInterceptEnabled);

		// Token: 0x060002B4 RID: 692
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_ReplyToFriendMessage")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_ReplyToFriendMessage(IntPtr instancePtr, CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchMsgToSend);

		// Token: 0x060002B5 RID: 693
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendMessage")]
		public static extern int ISteamFriends_GetFriendMessage(IntPtr instancePtr, CSteamID steamIDFriend, int iMessageID, IntPtr pvData, int cubData, out EChatEntryType peChatEntryType);

		// Token: 0x060002B6 RID: 694
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFollowerCount")]
		public static extern ulong ISteamFriends_GetFollowerCount(IntPtr instancePtr, CSteamID steamID);

		// Token: 0x060002B7 RID: 695
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_IsFollowing")]
		public static extern ulong ISteamFriends_IsFollowing(IntPtr instancePtr, CSteamID steamID);

		// Token: 0x060002B8 RID: 696
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_EnumerateFollowingList")]
		public static extern ulong ISteamFriends_EnumerateFollowingList(IntPtr instancePtr, uint unStartIndex);

		// Token: 0x060002B9 RID: 697
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_IsClanPublic")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_IsClanPublic(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x060002BA RID: 698
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_IsClanOfficialGameGroup")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_IsClanOfficialGameGroup(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x060002BB RID: 699
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_InitGameServer")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServer_InitGameServer(IntPtr instancePtr, uint unIP, ushort usGamePort, ushort usQueryPort, uint unFlags, AppId_t nGameAppId, InteropHelp.UTF8StringHandle pchVersionString);

		// Token: 0x060002BC RID: 700
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetProduct")]
		public static extern void ISteamGameServer_SetProduct(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszProduct);

		// Token: 0x060002BD RID: 701
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetGameDescription")]
		public static extern void ISteamGameServer_SetGameDescription(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszGameDescription);

		// Token: 0x060002BE RID: 702
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetModDir")]
		public static extern void ISteamGameServer_SetModDir(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszModDir);

		// Token: 0x060002BF RID: 703
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetDedicatedServer")]
		public static extern void ISteamGameServer_SetDedicatedServer(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bDedicated);

		// Token: 0x060002C0 RID: 704
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_LogOn")]
		public static extern void ISteamGameServer_LogOn(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszToken);

		// Token: 0x060002C1 RID: 705
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_LogOnAnonymous")]
		public static extern void ISteamGameServer_LogOnAnonymous(IntPtr instancePtr);

		// Token: 0x060002C2 RID: 706
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_LogOff")]
		public static extern void ISteamGameServer_LogOff(IntPtr instancePtr);

		// Token: 0x060002C3 RID: 707
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_BLoggedOn")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServer_BLoggedOn(IntPtr instancePtr);

		// Token: 0x060002C4 RID: 708
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_BSecure")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServer_BSecure(IntPtr instancePtr);

		// Token: 0x060002C5 RID: 709
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_GetSteamID")]
		public static extern ulong ISteamGameServer_GetSteamID(IntPtr instancePtr);

		// Token: 0x060002C6 RID: 710
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_WasRestartRequested")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServer_WasRestartRequested(IntPtr instancePtr);

		// Token: 0x060002C7 RID: 711
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetMaxPlayerCount")]
		public static extern void ISteamGameServer_SetMaxPlayerCount(IntPtr instancePtr, int cPlayersMax);

		// Token: 0x060002C8 RID: 712
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetBotPlayerCount")]
		public static extern void ISteamGameServer_SetBotPlayerCount(IntPtr instancePtr, int cBotplayers);

		// Token: 0x060002C9 RID: 713
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetServerName")]
		public static extern void ISteamGameServer_SetServerName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszServerName);

		// Token: 0x060002CA RID: 714
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetMapName")]
		public static extern void ISteamGameServer_SetMapName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszMapName);

		// Token: 0x060002CB RID: 715
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetPasswordProtected")]
		public static extern void ISteamGameServer_SetPasswordProtected(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bPasswordProtected);

		// Token: 0x060002CC RID: 716
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetSpectatorPort")]
		public static extern void ISteamGameServer_SetSpectatorPort(IntPtr instancePtr, ushort unSpectatorPort);

		// Token: 0x060002CD RID: 717
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetSpectatorServerName")]
		public static extern void ISteamGameServer_SetSpectatorServerName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszSpectatorServerName);

		// Token: 0x060002CE RID: 718
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_ClearAllKeyValues")]
		public static extern void ISteamGameServer_ClearAllKeyValues(IntPtr instancePtr);

		// Token: 0x060002CF RID: 719
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetKeyValue")]
		public static extern void ISteamGameServer_SetKeyValue(IntPtr instancePtr, InteropHelp.UTF8StringHandle pKey, InteropHelp.UTF8StringHandle pValue);

		// Token: 0x060002D0 RID: 720
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetGameTags")]
		public static extern void ISteamGameServer_SetGameTags(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchGameTags);

		// Token: 0x060002D1 RID: 721
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetGameData")]
		public static extern void ISteamGameServer_SetGameData(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchGameData);

		// Token: 0x060002D2 RID: 722
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetRegion")]
		public static extern void ISteamGameServer_SetRegion(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszRegion);

		// Token: 0x060002D3 RID: 723
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SendUserConnectAndAuthenticate")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServer_SendUserConnectAndAuthenticate(IntPtr instancePtr, uint unIPClient, byte[] pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser);

		// Token: 0x060002D4 RID: 724
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_CreateUnauthenticatedUserConnection")]
		public static extern ulong ISteamGameServer_CreateUnauthenticatedUserConnection(IntPtr instancePtr);

		// Token: 0x060002D5 RID: 725
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SendUserDisconnect")]
		public static extern void ISteamGameServer_SendUserDisconnect(IntPtr instancePtr, CSteamID steamIDUser);

		// Token: 0x060002D6 RID: 726
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_BUpdateUserData")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServer_BUpdateUserData(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchPlayerName, uint uScore);

		// Token: 0x060002D7 RID: 727
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_GetAuthSessionTicket")]
		public static extern uint ISteamGameServer_GetAuthSessionTicket(IntPtr instancePtr, byte[] pTicket, int cbMaxTicket, out uint pcbTicket);

		// Token: 0x060002D8 RID: 728
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_BeginAuthSession")]
		public static extern EBeginAuthSessionResult ISteamGameServer_BeginAuthSession(IntPtr instancePtr, byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID);

		// Token: 0x060002D9 RID: 729
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_EndAuthSession")]
		public static extern void ISteamGameServer_EndAuthSession(IntPtr instancePtr, CSteamID steamID);

		// Token: 0x060002DA RID: 730
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_CancelAuthTicket")]
		public static extern void ISteamGameServer_CancelAuthTicket(IntPtr instancePtr, HAuthTicket hAuthTicket);

		// Token: 0x060002DB RID: 731
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_UserHasLicenseForApp")]
		public static extern EUserHasLicenseForAppResult ISteamGameServer_UserHasLicenseForApp(IntPtr instancePtr, CSteamID steamID, AppId_t appID);

		// Token: 0x060002DC RID: 732
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_RequestUserGroupStatus")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServer_RequestUserGroupStatus(IntPtr instancePtr, CSteamID steamIDUser, CSteamID steamIDGroup);

		// Token: 0x060002DD RID: 733
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_GetGameplayStats")]
		public static extern void ISteamGameServer_GetGameplayStats(IntPtr instancePtr);

		// Token: 0x060002DE RID: 734
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_GetServerReputation")]
		public static extern ulong ISteamGameServer_GetServerReputation(IntPtr instancePtr);

		// Token: 0x060002DF RID: 735
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_GetPublicIP")]
		public static extern uint ISteamGameServer_GetPublicIP(IntPtr instancePtr);

		// Token: 0x060002E0 RID: 736
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_HandleIncomingPacket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServer_HandleIncomingPacket(IntPtr instancePtr, byte[] pData, int cbData, uint srcIP, ushort srcPort);

		// Token: 0x060002E1 RID: 737
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_GetNextOutgoingPacket")]
		public static extern int ISteamGameServer_GetNextOutgoingPacket(IntPtr instancePtr, byte[] pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort);

		// Token: 0x060002E2 RID: 738
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_EnableHeartbeats")]
		public static extern void ISteamGameServer_EnableHeartbeats(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bActive);

		// Token: 0x060002E3 RID: 739
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetHeartbeatInterval")]
		public static extern void ISteamGameServer_SetHeartbeatInterval(IntPtr instancePtr, int iHeartbeatInterval);

		// Token: 0x060002E4 RID: 740
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_ForceHeartbeat")]
		public static extern void ISteamGameServer_ForceHeartbeat(IntPtr instancePtr);

		// Token: 0x060002E5 RID: 741
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_AssociateWithClan")]
		public static extern ulong ISteamGameServer_AssociateWithClan(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x060002E6 RID: 742
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_ComputeNewPlayerCompatibility")]
		public static extern ulong ISteamGameServer_ComputeNewPlayerCompatibility(IntPtr instancePtr, CSteamID steamIDNewPlayer);

		// Token: 0x060002E7 RID: 743
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServerStats_RequestUserStats")]
		public static extern ulong ISteamGameServerStats_RequestUserStats(IntPtr instancePtr, CSteamID steamIDUser);

		// Token: 0x060002E8 RID: 744
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServerStats_GetUserStat")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerStats_GetUserStat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out int pData);

		// Token: 0x060002E9 RID: 745
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServerStats_GetUserStat0")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerStats_GetUserStat0(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out float pData);

		// Token: 0x060002EA RID: 746
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServerStats_GetUserAchievement")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerStats_GetUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved);

		// Token: 0x060002EB RID: 747
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServerStats_SetUserStat")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerStats_SetUserStat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, int nData);

		// Token: 0x060002EC RID: 748
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServerStats_SetUserStat0")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerStats_SetUserStat0(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, float fData);

		// Token: 0x060002ED RID: 749
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServerStats_UpdateUserAvgRateStat")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerStats_UpdateUserAvgRateStat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, float flCountThisSession, double dSessionLength);

		// Token: 0x060002EE RID: 750
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServerStats_SetUserAchievement")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerStats_SetUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName);

		// Token: 0x060002EF RID: 751
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServerStats_ClearUserAchievement")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerStats_ClearUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName);

		// Token: 0x060002F0 RID: 752
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServerStats_StoreUserStats")]
		public static extern ulong ISteamGameServerStats_StoreUserStats(IntPtr instancePtr, CSteamID steamIDUser);

		// Token: 0x060002F1 RID: 753
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_Init")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTMLSurface_Init(IntPtr instancePtr);

		// Token: 0x060002F2 RID: 754
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_Shutdown")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTMLSurface_Shutdown(IntPtr instancePtr);

		// Token: 0x060002F3 RID: 755
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_CreateBrowser")]
		public static extern ulong ISteamHTMLSurface_CreateBrowser(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchUserAgent, InteropHelp.UTF8StringHandle pchUserCSS);

		// Token: 0x060002F4 RID: 756
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_RemoveBrowser")]
		public static extern void ISteamHTMLSurface_RemoveBrowser(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		// Token: 0x060002F5 RID: 757
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_LoadURL")]
		public static extern void ISteamHTMLSurface_LoadURL(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchURL, InteropHelp.UTF8StringHandle pchPostData);

		// Token: 0x060002F6 RID: 758
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetSize")]
		public static extern void ISteamHTMLSurface_SetSize(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight);

		// Token: 0x060002F7 RID: 759
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_StopLoad")]
		public static extern void ISteamHTMLSurface_StopLoad(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		// Token: 0x060002F8 RID: 760
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_Reload")]
		public static extern void ISteamHTMLSurface_Reload(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		// Token: 0x060002F9 RID: 761
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_GoBack")]
		public static extern void ISteamHTMLSurface_GoBack(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		// Token: 0x060002FA RID: 762
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_GoForward")]
		public static extern void ISteamHTMLSurface_GoForward(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		// Token: 0x060002FB RID: 763
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_AddHeader")]
		public static extern void ISteamHTMLSurface_AddHeader(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		// Token: 0x060002FC RID: 764
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_ExecuteJavascript")]
		public static extern void ISteamHTMLSurface_ExecuteJavascript(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchScript);

		// Token: 0x060002FD RID: 765
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_MouseUp")]
		public static extern void ISteamHTMLSurface_MouseUp(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton);

		// Token: 0x060002FE RID: 766
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_MouseDown")]
		public static extern void ISteamHTMLSurface_MouseDown(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton);

		// Token: 0x060002FF RID: 767
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_MouseDoubleClick")]
		public static extern void ISteamHTMLSurface_MouseDoubleClick(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton);

		// Token: 0x06000300 RID: 768
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_MouseMove")]
		public static extern void ISteamHTMLSurface_MouseMove(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, int x, int y);

		// Token: 0x06000301 RID: 769
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_MouseWheel")]
		public static extern void ISteamHTMLSurface_MouseWheel(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, int nDelta);

		// Token: 0x06000302 RID: 770
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_KeyDown")]
		public static extern void ISteamHTMLSurface_KeyDown(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers);

		// Token: 0x06000303 RID: 771
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_KeyUp")]
		public static extern void ISteamHTMLSurface_KeyUp(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers);

		// Token: 0x06000304 RID: 772
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_KeyChar")]
		public static extern void ISteamHTMLSurface_KeyChar(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint cUnicodeChar, EHTMLKeyModifiers eHTMLKeyModifiers);

		// Token: 0x06000305 RID: 773
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetHorizontalScroll")]
		public static extern void ISteamHTMLSurface_SetHorizontalScroll(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll);

		// Token: 0x06000306 RID: 774
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetVerticalScroll")]
		public static extern void ISteamHTMLSurface_SetVerticalScroll(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll);

		// Token: 0x06000307 RID: 775
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetKeyFocus")]
		public static extern void ISteamHTMLSurface_SetKeyFocus(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, [MarshalAs(UnmanagedType.I1)] bool bHasKeyFocus);

		// Token: 0x06000308 RID: 776
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_ViewSource")]
		public static extern void ISteamHTMLSurface_ViewSource(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		// Token: 0x06000309 RID: 777
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_CopyToClipboard")]
		public static extern void ISteamHTMLSurface_CopyToClipboard(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		// Token: 0x0600030A RID: 778
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_PasteFromClipboard")]
		public static extern void ISteamHTMLSurface_PasteFromClipboard(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		// Token: 0x0600030B RID: 779
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_Find")]
		public static extern void ISteamHTMLSurface_Find(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchSearchStr, [MarshalAs(UnmanagedType.I1)] bool bCurrentlyInFind, [MarshalAs(UnmanagedType.I1)] bool bReverse);

		// Token: 0x0600030C RID: 780
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_StopFind")]
		public static extern void ISteamHTMLSurface_StopFind(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		// Token: 0x0600030D RID: 781
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_GetLinkAtPosition")]
		public static extern void ISteamHTMLSurface_GetLinkAtPosition(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, int x, int y);

		// Token: 0x0600030E RID: 782
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetCookie")]
		public static extern void ISteamHTMLSurface_SetCookie(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchHostname, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue, InteropHelp.UTF8StringHandle pchPath, uint nExpires, [MarshalAs(UnmanagedType.I1)] bool bSecure, [MarshalAs(UnmanagedType.I1)] bool bHTTPOnly);

		// Token: 0x0600030F RID: 783
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetPageScaleFactor")]
		public static extern void ISteamHTMLSurface_SetPageScaleFactor(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY);

		// Token: 0x06000310 RID: 784
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetBackgroundMode")]
		public static extern void ISteamHTMLSurface_SetBackgroundMode(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, [MarshalAs(UnmanagedType.I1)] bool bBackgroundMode);

		// Token: 0x06000311 RID: 785
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetDPIScalingFactor")]
		public static extern void ISteamHTMLSurface_SetDPIScalingFactor(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, float flDPIScaling);

		// Token: 0x06000312 RID: 786
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_AllowStartRequest")]
		public static extern void ISteamHTMLSurface_AllowStartRequest(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, [MarshalAs(UnmanagedType.I1)] bool bAllowed);

		// Token: 0x06000313 RID: 787
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_JSDialogResponse")]
		public static extern void ISteamHTMLSurface_JSDialogResponse(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, [MarshalAs(UnmanagedType.I1)] bool bResult);

		// Token: 0x06000314 RID: 788
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_FileLoadDialogResponse")]
		public static extern void ISteamHTMLSurface_FileLoadDialogResponse(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, IntPtr pchSelectedFiles);

		// Token: 0x06000315 RID: 789
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_CreateHTTPRequest")]
		public static extern uint ISteamHTTP_CreateHTTPRequest(IntPtr instancePtr, EHTTPMethod eHTTPRequestMethod, InteropHelp.UTF8StringHandle pchAbsoluteURL);

		// Token: 0x06000316 RID: 790
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestContextValue")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SetHTTPRequestContextValue(IntPtr instancePtr, HTTPRequestHandle hRequest, ulong ulContextValue);

		// Token: 0x06000317 RID: 791
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestNetworkActivityTimeout")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SetHTTPRequestNetworkActivityTimeout(IntPtr instancePtr, HTTPRequestHandle hRequest, uint unTimeoutSeconds);

		// Token: 0x06000318 RID: 792
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestHeaderValue")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SetHTTPRequestHeaderValue(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, InteropHelp.UTF8StringHandle pchHeaderValue);

		// Token: 0x06000319 RID: 793
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestGetOrPostParameter")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SetHTTPRequestGetOrPostParameter(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchParamName, InteropHelp.UTF8StringHandle pchParamValue);

		// Token: 0x0600031A RID: 794
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SendHTTPRequest")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SendHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

		// Token: 0x0600031B RID: 795
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SendHTTPRequestAndStreamResponse")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SendHTTPRequestAndStreamResponse(IntPtr instancePtr, HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

		// Token: 0x0600031C RID: 796
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_DeferHTTPRequest")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_DeferHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest);

		// Token: 0x0600031D RID: 797
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_PrioritizeHTTPRequest")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_PrioritizeHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest);

		// Token: 0x0600031E RID: 798
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_GetHTTPResponseHeaderSize")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_GetHTTPResponseHeaderSize(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, out uint unResponseHeaderSize);

		// Token: 0x0600031F RID: 799
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_GetHTTPResponseHeaderValue")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_GetHTTPResponseHeaderValue(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize);

		// Token: 0x06000320 RID: 800
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_GetHTTPResponseBodySize")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_GetHTTPResponseBodySize(IntPtr instancePtr, HTTPRequestHandle hRequest, out uint unBodySize);

		// Token: 0x06000321 RID: 801
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_GetHTTPResponseBodyData")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_GetHTTPResponseBodyData(IntPtr instancePtr, HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize);

		// Token: 0x06000322 RID: 802
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_GetHTTPStreamingResponseBodyData")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_GetHTTPStreamingResponseBodyData(IntPtr instancePtr, HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize);

		// Token: 0x06000323 RID: 803
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_ReleaseHTTPRequest")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_ReleaseHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest);

		// Token: 0x06000324 RID: 804
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_GetHTTPDownloadProgressPct")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_GetHTTPDownloadProgressPct(IntPtr instancePtr, HTTPRequestHandle hRequest, out float pflPercentOut);

		// Token: 0x06000325 RID: 805
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestRawPostBody")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SetHTTPRequestRawPostBody(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchContentType, byte[] pubBody, uint unBodyLen);

		// Token: 0x06000326 RID: 806
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_CreateCookieContainer")]
		public static extern uint ISteamHTTP_CreateCookieContainer(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bAllowResponsesToModify);

		// Token: 0x06000327 RID: 807
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_ReleaseCookieContainer")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_ReleaseCookieContainer(IntPtr instancePtr, HTTPCookieContainerHandle hCookieContainer);

		// Token: 0x06000328 RID: 808
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SetCookie")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SetCookie(IntPtr instancePtr, HTTPCookieContainerHandle hCookieContainer, InteropHelp.UTF8StringHandle pchHost, InteropHelp.UTF8StringHandle pchUrl, InteropHelp.UTF8StringHandle pchCookie);

		// Token: 0x06000329 RID: 809
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestCookieContainer")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SetHTTPRequestCookieContainer(IntPtr instancePtr, HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer);

		// Token: 0x0600032A RID: 810
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestUserAgentInfo")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SetHTTPRequestUserAgentInfo(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchUserAgentInfo);

		// Token: 0x0600032B RID: 811
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestRequiresVerifiedCertificate")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SetHTTPRequestRequiresVerifiedCertificate(IntPtr instancePtr, HTTPRequestHandle hRequest, [MarshalAs(UnmanagedType.I1)] bool bRequireVerifiedCertificate);

		// Token: 0x0600032C RID: 812
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestAbsoluteTimeoutMS")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SetHTTPRequestAbsoluteTimeoutMS(IntPtr instancePtr, HTTPRequestHandle hRequest, uint unMilliseconds);

		// Token: 0x0600032D RID: 813
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_GetHTTPRequestWasTimedOut")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_GetHTTPRequestWasTimedOut(IntPtr instancePtr, HTTPRequestHandle hRequest, out bool pbWasTimedOut);

		// Token: 0x0600032E RID: 814
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetResultStatus")]
		public static extern EResult ISteamInventory_GetResultStatus(IntPtr instancePtr, SteamInventoryResult_t resultHandle);

		// Token: 0x0600032F RID: 815
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetResultItems")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_GetResultItems(IntPtr instancePtr, SteamInventoryResult_t resultHandle, [In] [Out] SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize);

		// Token: 0x06000330 RID: 816
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetResultItemProperty")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_GetResultItemProperty(IntPtr instancePtr, SteamInventoryResult_t resultHandle, uint unItemIndex, InteropHelp.UTF8StringHandle pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut);

		// Token: 0x06000331 RID: 817
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetResultTimestamp")]
		public static extern uint ISteamInventory_GetResultTimestamp(IntPtr instancePtr, SteamInventoryResult_t resultHandle);

		// Token: 0x06000332 RID: 818
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_CheckResultSteamID")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_CheckResultSteamID(IntPtr instancePtr, SteamInventoryResult_t resultHandle, CSteamID steamIDExpected);

		// Token: 0x06000333 RID: 819
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_DestroyResult")]
		public static extern void ISteamInventory_DestroyResult(IntPtr instancePtr, SteamInventoryResult_t resultHandle);

		// Token: 0x06000334 RID: 820
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetAllItems")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_GetAllItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle);

		// Token: 0x06000335 RID: 821
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetItemsByID")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_GetItemsByID(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In] [Out] SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs);

		// Token: 0x06000336 RID: 822
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_SerializeResult")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_SerializeResult(IntPtr instancePtr, SteamInventoryResult_t resultHandle, byte[] pOutBuffer, out uint punOutBufferSize);

		// Token: 0x06000337 RID: 823
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_DeserializeResult")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_DeserializeResult(IntPtr instancePtr, out SteamInventoryResult_t pOutResultHandle, byte[] pBuffer, uint unBufferSize, [MarshalAs(UnmanagedType.I1)] bool bRESERVED_MUST_BE_FALSE);

		// Token: 0x06000338 RID: 824
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GenerateItems")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_GenerateItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In] [Out] SteamItemDef_t[] pArrayItemDefs, [In] [Out] uint[] punArrayQuantity, uint unArrayLength);

		// Token: 0x06000339 RID: 825
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GrantPromoItems")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_GrantPromoItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle);

		// Token: 0x0600033A RID: 826
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_AddPromoItem")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_AddPromoItem(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef);

		// Token: 0x0600033B RID: 827
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_AddPromoItems")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_AddPromoItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In] [Out] SteamItemDef_t[] pArrayItemDefs, uint unArrayLength);

		// Token: 0x0600033C RID: 828
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_ConsumeItem")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_ConsumeItem(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity);

		// Token: 0x0600033D RID: 829
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_ExchangeItems")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_ExchangeItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In] [Out] SteamItemDef_t[] pArrayGenerate, [In] [Out] uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, [In] [Out] SteamItemInstanceID_t[] pArrayDestroy, [In] [Out] uint[] punArrayDestroyQuantity, uint unArrayDestroyLength);

		// Token: 0x0600033E RID: 830
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_TransferItemQuantity")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_TransferItemQuantity(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest);

		// Token: 0x0600033F RID: 831
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_SendItemDropHeartbeat")]
		public static extern void ISteamInventory_SendItemDropHeartbeat(IntPtr instancePtr);

		// Token: 0x06000340 RID: 832
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_TriggerItemDrop")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_TriggerItemDrop(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition);

		// Token: 0x06000341 RID: 833
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_TradeItems")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_TradeItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, [In] [Out] SteamItemInstanceID_t[] pArrayGive, [In] [Out] uint[] pArrayGiveQuantity, uint nArrayGiveLength, [In] [Out] SteamItemInstanceID_t[] pArrayGet, [In] [Out] uint[] pArrayGetQuantity, uint nArrayGetLength);

		// Token: 0x06000342 RID: 834
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_LoadItemDefinitions")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_LoadItemDefinitions(IntPtr instancePtr);

		// Token: 0x06000343 RID: 835
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetItemDefinitionIDs")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_GetItemDefinitionIDs(IntPtr instancePtr, [In] [Out] SteamItemDef_t[] pItemDefIDs, out uint punItemDefIDsArraySize);

		// Token: 0x06000344 RID: 836
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetItemDefinitionProperty")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_GetItemDefinitionProperty(IntPtr instancePtr, SteamItemDef_t iDefinition, InteropHelp.UTF8StringHandle pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut);

		// Token: 0x06000345 RID: 837
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_RequestEligiblePromoItemDefinitionsIDs")]
		public static extern ulong ISteamInventory_RequestEligiblePromoItemDefinitionsIDs(IntPtr instancePtr, CSteamID steamID);

		// Token: 0x06000346 RID: 838
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetEligiblePromoItemDefinitionIDs")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_GetEligiblePromoItemDefinitionIDs(IntPtr instancePtr, CSteamID steamID, [In] [Out] SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize);

		// Token: 0x06000347 RID: 839
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_StartPurchase")]
		public static extern ulong ISteamInventory_StartPurchase(IntPtr instancePtr, [In] [Out] SteamItemDef_t[] pArrayItemDefs, [In] [Out] uint[] punArrayQuantity, uint unArrayLength);

		// Token: 0x06000348 RID: 840
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_RequestPrices")]
		public static extern ulong ISteamInventory_RequestPrices(IntPtr instancePtr);

		// Token: 0x06000349 RID: 841
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetNumItemsWithPrices")]
		public static extern uint ISteamInventory_GetNumItemsWithPrices(IntPtr instancePtr);

		// Token: 0x0600034A RID: 842
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetItemsWithPrices")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_GetItemsWithPrices(IntPtr instancePtr, [In] [Out] SteamItemDef_t[] pArrayItemDefs, [In] [Out] ulong[] pPrices, uint unArrayLength);

		// Token: 0x0600034B RID: 843
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetItemPrice")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_GetItemPrice(IntPtr instancePtr, SteamItemDef_t iDefinition, out ulong pPrice);

		// Token: 0x0600034C RID: 844
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_StartUpdateProperties")]
		public static extern ulong ISteamInventory_StartUpdateProperties(IntPtr instancePtr);

		// Token: 0x0600034D RID: 845
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_RemoveProperty")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_RemoveProperty(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, InteropHelp.UTF8StringHandle pchPropertyName);

		// Token: 0x0600034E RID: 846
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_SetProperty")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_SetProperty(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, InteropHelp.UTF8StringHandle pchPropertyName, InteropHelp.UTF8StringHandle pchPropertyValue);

		// Token: 0x0600034F RID: 847
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_SetProperty0")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_SetProperty0(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, InteropHelp.UTF8StringHandle pchPropertyName, [MarshalAs(UnmanagedType.I1)] bool bValue);

		// Token: 0x06000350 RID: 848
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_SetProperty1")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_SetProperty1(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, InteropHelp.UTF8StringHandle pchPropertyName, long nValue);

		// Token: 0x06000351 RID: 849
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_SetProperty2")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_SetProperty2(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, InteropHelp.UTF8StringHandle pchPropertyName, float flValue);

		// Token: 0x06000352 RID: 850
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_SubmitUpdateProperties")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_SubmitUpdateProperties(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, out SteamInventoryResult_t pResultHandle);

		// Token: 0x06000353 RID: 851
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetFavoriteGameCount")]
		public static extern int ISteamMatchmaking_GetFavoriteGameCount(IntPtr instancePtr);

		// Token: 0x06000354 RID: 852
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetFavoriteGame")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_GetFavoriteGame(IntPtr instancePtr, int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer);

		// Token: 0x06000355 RID: 853
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_AddFavoriteGame")]
		public static extern int ISteamMatchmaking_AddFavoriteGame(IntPtr instancePtr, AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer);

		// Token: 0x06000356 RID: 854
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_RemoveFavoriteGame")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_RemoveFavoriteGame(IntPtr instancePtr, AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags);

		// Token: 0x06000357 RID: 855
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_RequestLobbyList")]
		public static extern ulong ISteamMatchmaking_RequestLobbyList(IntPtr instancePtr);

		// Token: 0x06000358 RID: 856
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_AddRequestLobbyListStringFilter")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListStringFilter(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKeyToMatch, InteropHelp.UTF8StringHandle pchValueToMatch, ELobbyComparison eComparisonType);

		// Token: 0x06000359 RID: 857
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_AddRequestLobbyListNumericalFilter")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListNumericalFilter(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType);

		// Token: 0x0600035A RID: 858
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_AddRequestLobbyListNearValueFilter")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListNearValueFilter(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKeyToMatch, int nValueToBeCloseTo);

		// Token: 0x0600035B RID: 859
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_AddRequestLobbyListFilterSlotsAvailable")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListFilterSlotsAvailable(IntPtr instancePtr, int nSlotsAvailable);

		// Token: 0x0600035C RID: 860
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_AddRequestLobbyListDistanceFilter")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListDistanceFilter(IntPtr instancePtr, ELobbyDistanceFilter eLobbyDistanceFilter);

		// Token: 0x0600035D RID: 861
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_AddRequestLobbyListResultCountFilter")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListResultCountFilter(IntPtr instancePtr, int cMaxResults);

		// Token: 0x0600035E RID: 862
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_AddRequestLobbyListCompatibleMembersFilter")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListCompatibleMembersFilter(IntPtr instancePtr, CSteamID steamIDLobby);

		// Token: 0x0600035F RID: 863
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyByIndex")]
		public static extern ulong ISteamMatchmaking_GetLobbyByIndex(IntPtr instancePtr, int iLobby);

		// Token: 0x06000360 RID: 864
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_CreateLobby")]
		public static extern ulong ISteamMatchmaking_CreateLobby(IntPtr instancePtr, ELobbyType eLobbyType, int cMaxMembers);

		// Token: 0x06000361 RID: 865
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_JoinLobby")]
		public static extern ulong ISteamMatchmaking_JoinLobby(IntPtr instancePtr, CSteamID steamIDLobby);

		// Token: 0x06000362 RID: 866
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_LeaveLobby")]
		public static extern void ISteamMatchmaking_LeaveLobby(IntPtr instancePtr, CSteamID steamIDLobby);

		// Token: 0x06000363 RID: 867
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_InviteUserToLobby")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_InviteUserToLobby(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDInvitee);

		// Token: 0x06000364 RID: 868
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetNumLobbyMembers")]
		public static extern int ISteamMatchmaking_GetNumLobbyMembers(IntPtr instancePtr, CSteamID steamIDLobby);

		// Token: 0x06000365 RID: 869
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyMemberByIndex")]
		public static extern ulong ISteamMatchmaking_GetLobbyMemberByIndex(IntPtr instancePtr, CSteamID steamIDLobby, int iMember);

		// Token: 0x06000366 RID: 870
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyData")]
		public static extern IntPtr ISteamMatchmaking_GetLobbyData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey);

		// Token: 0x06000367 RID: 871
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLobbyData")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_SetLobbyData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		// Token: 0x06000368 RID: 872
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyDataCount")]
		public static extern int ISteamMatchmaking_GetLobbyDataCount(IntPtr instancePtr, CSteamID steamIDLobby);

		// Token: 0x06000369 RID: 873
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyDataByIndex")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_GetLobbyDataByIndex(IntPtr instancePtr, CSteamID steamIDLobby, int iLobbyData, IntPtr pchKey, int cchKeyBufferSize, IntPtr pchValue, int cchValueBufferSize);

		// Token: 0x0600036A RID: 874
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_DeleteLobbyData")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_DeleteLobbyData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey);

		// Token: 0x0600036B RID: 875
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyMemberData")]
		public static extern IntPtr ISteamMatchmaking_GetLobbyMemberData(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchKey);

		// Token: 0x0600036C RID: 876
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLobbyMemberData")]
		public static extern void ISteamMatchmaking_SetLobbyMemberData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		// Token: 0x0600036D RID: 877
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_SendLobbyChatMsg")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_SendLobbyChatMsg(IntPtr instancePtr, CSteamID steamIDLobby, byte[] pvMsgBody, int cubMsgBody);

		// Token: 0x0600036E RID: 878
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyChatEntry")]
		public static extern int ISteamMatchmaking_GetLobbyChatEntry(IntPtr instancePtr, CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, byte[] pvData, int cubData, out EChatEntryType peChatEntryType);

		// Token: 0x0600036F RID: 879
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_RequestLobbyData")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_RequestLobbyData(IntPtr instancePtr, CSteamID steamIDLobby);

		// Token: 0x06000370 RID: 880
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLobbyGameServer")]
		public static extern void ISteamMatchmaking_SetLobbyGameServer(IntPtr instancePtr, CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer);

		// Token: 0x06000371 RID: 881
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyGameServer")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_GetLobbyGameServer(IntPtr instancePtr, CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer);

		// Token: 0x06000372 RID: 882
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLobbyMemberLimit")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_SetLobbyMemberLimit(IntPtr instancePtr, CSteamID steamIDLobby, int cMaxMembers);

		// Token: 0x06000373 RID: 883
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyMemberLimit")]
		public static extern int ISteamMatchmaking_GetLobbyMemberLimit(IntPtr instancePtr, CSteamID steamIDLobby);

		// Token: 0x06000374 RID: 884
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLobbyType")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_SetLobbyType(IntPtr instancePtr, CSteamID steamIDLobby, ELobbyType eLobbyType);

		// Token: 0x06000375 RID: 885
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLobbyJoinable")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_SetLobbyJoinable(IntPtr instancePtr, CSteamID steamIDLobby, [MarshalAs(UnmanagedType.I1)] bool bLobbyJoinable);

		// Token: 0x06000376 RID: 886
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyOwner")]
		public static extern ulong ISteamMatchmaking_GetLobbyOwner(IntPtr instancePtr, CSteamID steamIDLobby);

		// Token: 0x06000377 RID: 887
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLobbyOwner")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_SetLobbyOwner(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDNewOwner);

		// Token: 0x06000378 RID: 888
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLinkedLobby")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_SetLinkedLobby(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDLobbyDependent);

		// Token: 0x06000379 RID: 889
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RequestInternetServerList")]
		public static extern IntPtr ISteamMatchmakingServers_RequestInternetServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		// Token: 0x0600037A RID: 890
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RequestLANServerList")]
		public static extern IntPtr ISteamMatchmakingServers_RequestLANServerList(IntPtr instancePtr, AppId_t iApp, IntPtr pRequestServersResponse);

		// Token: 0x0600037B RID: 891
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RequestFriendsServerList")]
		public static extern IntPtr ISteamMatchmakingServers_RequestFriendsServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		// Token: 0x0600037C RID: 892
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RequestFavoritesServerList")]
		public static extern IntPtr ISteamMatchmakingServers_RequestFavoritesServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		// Token: 0x0600037D RID: 893
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RequestHistoryServerList")]
		public static extern IntPtr ISteamMatchmakingServers_RequestHistoryServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		// Token: 0x0600037E RID: 894
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RequestSpectatorServerList")]
		public static extern IntPtr ISteamMatchmakingServers_RequestSpectatorServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		// Token: 0x0600037F RID: 895
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_ReleaseRequest")]
		public static extern void ISteamMatchmakingServers_ReleaseRequest(IntPtr instancePtr, HServerListRequest hServerListRequest);

		// Token: 0x06000380 RID: 896
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_GetServerDetails")]
		public static extern IntPtr ISteamMatchmakingServers_GetServerDetails(IntPtr instancePtr, HServerListRequest hRequest, int iServer);

		// Token: 0x06000381 RID: 897
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_CancelQuery")]
		public static extern void ISteamMatchmakingServers_CancelQuery(IntPtr instancePtr, HServerListRequest hRequest);

		// Token: 0x06000382 RID: 898
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RefreshQuery")]
		public static extern void ISteamMatchmakingServers_RefreshQuery(IntPtr instancePtr, HServerListRequest hRequest);

		// Token: 0x06000383 RID: 899
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_IsRefreshing")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmakingServers_IsRefreshing(IntPtr instancePtr, HServerListRequest hRequest);

		// Token: 0x06000384 RID: 900
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_GetServerCount")]
		public static extern int ISteamMatchmakingServers_GetServerCount(IntPtr instancePtr, HServerListRequest hRequest);

		// Token: 0x06000385 RID: 901
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RefreshServer")]
		public static extern void ISteamMatchmakingServers_RefreshServer(IntPtr instancePtr, HServerListRequest hRequest, int iServer);

		// Token: 0x06000386 RID: 902
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_PingServer")]
		public static extern int ISteamMatchmakingServers_PingServer(IntPtr instancePtr, uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		// Token: 0x06000387 RID: 903
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_PlayerDetails")]
		public static extern int ISteamMatchmakingServers_PlayerDetails(IntPtr instancePtr, uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		// Token: 0x06000388 RID: 904
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_ServerRules")]
		public static extern int ISteamMatchmakingServers_ServerRules(IntPtr instancePtr, uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		// Token: 0x06000389 RID: 905
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_CancelServerQuery")]
		public static extern void ISteamMatchmakingServers_CancelServerQuery(IntPtr instancePtr, HServerQuery hServerQuery);

		// Token: 0x0600038A RID: 906
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusic_BIsEnabled")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusic_BIsEnabled(IntPtr instancePtr);

		// Token: 0x0600038B RID: 907
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusic_BIsPlaying")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusic_BIsPlaying(IntPtr instancePtr);

		// Token: 0x0600038C RID: 908
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusic_GetPlaybackStatus")]
		public static extern AudioPlayback_Status ISteamMusic_GetPlaybackStatus(IntPtr instancePtr);

		// Token: 0x0600038D RID: 909
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusic_Play")]
		public static extern void ISteamMusic_Play(IntPtr instancePtr);

		// Token: 0x0600038E RID: 910
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusic_Pause")]
		public static extern void ISteamMusic_Pause(IntPtr instancePtr);

		// Token: 0x0600038F RID: 911
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusic_PlayPrevious")]
		public static extern void ISteamMusic_PlayPrevious(IntPtr instancePtr);

		// Token: 0x06000390 RID: 912
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusic_PlayNext")]
		public static extern void ISteamMusic_PlayNext(IntPtr instancePtr);

		// Token: 0x06000391 RID: 913
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusic_SetVolume")]
		public static extern void ISteamMusic_SetVolume(IntPtr instancePtr, float flVolume);

		// Token: 0x06000392 RID: 914
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusic_GetVolume")]
		public static extern float ISteamMusic_GetVolume(IntPtr instancePtr);

		// Token: 0x06000393 RID: 915
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_RegisterSteamMusicRemote")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_RegisterSteamMusicRemote(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName);

		// Token: 0x06000394 RID: 916
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_DeregisterSteamMusicRemote")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_DeregisterSteamMusicRemote(IntPtr instancePtr);

		// Token: 0x06000395 RID: 917
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_BIsCurrentMusicRemote")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_BIsCurrentMusicRemote(IntPtr instancePtr);

		// Token: 0x06000396 RID: 918
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_BActivationSuccess")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_BActivationSuccess(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bValue);

		// Token: 0x06000397 RID: 919
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_SetDisplayName")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_SetDisplayName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchDisplayName);

		// Token: 0x06000398 RID: 920
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_SetPNGIcon_64x64")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_SetPNGIcon_64x64(IntPtr instancePtr, byte[] pvBuffer, uint cbBufferLength);

		// Token: 0x06000399 RID: 921
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_EnablePlayPrevious")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_EnablePlayPrevious(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bValue);

		// Token: 0x0600039A RID: 922
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_EnablePlayNext")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_EnablePlayNext(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bValue);

		// Token: 0x0600039B RID: 923
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_EnableShuffled")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_EnableShuffled(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bValue);

		// Token: 0x0600039C RID: 924
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_EnableLooped")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_EnableLooped(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bValue);

		// Token: 0x0600039D RID: 925
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_EnableQueue")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_EnableQueue(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bValue);

		// Token: 0x0600039E RID: 926
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_EnablePlaylists")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_EnablePlaylists(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bValue);

		// Token: 0x0600039F RID: 927
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_UpdatePlaybackStatus")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_UpdatePlaybackStatus(IntPtr instancePtr, AudioPlayback_Status nStatus);

		// Token: 0x060003A0 RID: 928
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_UpdateShuffled")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_UpdateShuffled(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bValue);

		// Token: 0x060003A1 RID: 929
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_UpdateLooped")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_UpdateLooped(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bValue);

		// Token: 0x060003A2 RID: 930
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_UpdateVolume")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_UpdateVolume(IntPtr instancePtr, float flValue);

		// Token: 0x060003A3 RID: 931
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_CurrentEntryWillChange")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_CurrentEntryWillChange(IntPtr instancePtr);

		// Token: 0x060003A4 RID: 932
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_CurrentEntryIsAvailable")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_CurrentEntryIsAvailable(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bAvailable);

		// Token: 0x060003A5 RID: 933
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_UpdateCurrentEntryText")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryText(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchText);

		// Token: 0x060003A6 RID: 934
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_UpdateCurrentEntryElapsedSeconds")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryElapsedSeconds(IntPtr instancePtr, int nValue);

		// Token: 0x060003A7 RID: 935
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_UpdateCurrentEntryCoverArt")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryCoverArt(IntPtr instancePtr, byte[] pvBuffer, uint cbBufferLength);

		// Token: 0x060003A8 RID: 936
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_CurrentEntryDidChange")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_CurrentEntryDidChange(IntPtr instancePtr);

		// Token: 0x060003A9 RID: 937
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_QueueWillChange")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_QueueWillChange(IntPtr instancePtr);

		// Token: 0x060003AA RID: 938
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_ResetQueueEntries")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_ResetQueueEntries(IntPtr instancePtr);

		// Token: 0x060003AB RID: 939
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_SetQueueEntry")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_SetQueueEntry(IntPtr instancePtr, int nID, int nPosition, InteropHelp.UTF8StringHandle pchEntryText);

		// Token: 0x060003AC RID: 940
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_SetCurrentQueueEntry")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_SetCurrentQueueEntry(IntPtr instancePtr, int nID);

		// Token: 0x060003AD RID: 941
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_QueueDidChange")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_QueueDidChange(IntPtr instancePtr);

		// Token: 0x060003AE RID: 942
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_PlaylistWillChange")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_PlaylistWillChange(IntPtr instancePtr);

		// Token: 0x060003AF RID: 943
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_ResetPlaylistEntries")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_ResetPlaylistEntries(IntPtr instancePtr);

		// Token: 0x060003B0 RID: 944
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_SetPlaylistEntry")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_SetPlaylistEntry(IntPtr instancePtr, int nID, int nPosition, InteropHelp.UTF8StringHandle pchEntryText);

		// Token: 0x060003B1 RID: 945
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_SetCurrentPlaylistEntry")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_SetCurrentPlaylistEntry(IntPtr instancePtr, int nID);

		// Token: 0x060003B2 RID: 946
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_PlaylistDidChange")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_PlaylistDidChange(IntPtr instancePtr);

		// Token: 0x060003B3 RID: 947
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_SendP2PPacket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_SendP2PPacket(IntPtr instancePtr, CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel);

		// Token: 0x060003B4 RID: 948
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_IsP2PPacketAvailable")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_IsP2PPacketAvailable(IntPtr instancePtr, out uint pcubMsgSize, int nChannel);

		// Token: 0x060003B5 RID: 949
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_ReadP2PPacket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_ReadP2PPacket(IntPtr instancePtr, byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel);

		// Token: 0x060003B6 RID: 950
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_AcceptP2PSessionWithUser")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_AcceptP2PSessionWithUser(IntPtr instancePtr, CSteamID steamIDRemote);

		// Token: 0x060003B7 RID: 951
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_CloseP2PSessionWithUser")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_CloseP2PSessionWithUser(IntPtr instancePtr, CSteamID steamIDRemote);

		// Token: 0x060003B8 RID: 952
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_CloseP2PChannelWithUser")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_CloseP2PChannelWithUser(IntPtr instancePtr, CSteamID steamIDRemote, int nChannel);

		// Token: 0x060003B9 RID: 953
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_GetP2PSessionState")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_GetP2PSessionState(IntPtr instancePtr, CSteamID steamIDRemote, out P2PSessionState_t pConnectionState);

		// Token: 0x060003BA RID: 954
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_AllowP2PPacketRelay")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_AllowP2PPacketRelay(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bAllow);

		// Token: 0x060003BB RID: 955
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_CreateListenSocket")]
		public static extern uint ISteamNetworking_CreateListenSocket(IntPtr instancePtr, int nVirtualP2PPort, uint nIP, ushort nPort, [MarshalAs(UnmanagedType.I1)] bool bAllowUseOfPacketRelay);

		// Token: 0x060003BC RID: 956
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_CreateP2PConnectionSocket")]
		public static extern uint ISteamNetworking_CreateP2PConnectionSocket(IntPtr instancePtr, CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, [MarshalAs(UnmanagedType.I1)] bool bAllowUseOfPacketRelay);

		// Token: 0x060003BD RID: 957
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_CreateConnectionSocket")]
		public static extern uint ISteamNetworking_CreateConnectionSocket(IntPtr instancePtr, uint nIP, ushort nPort, int nTimeoutSec);

		// Token: 0x060003BE RID: 958
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_DestroySocket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_DestroySocket(IntPtr instancePtr, SNetSocket_t hSocket, [MarshalAs(UnmanagedType.I1)] bool bNotifyRemoteEnd);

		// Token: 0x060003BF RID: 959
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_DestroyListenSocket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_DestroyListenSocket(IntPtr instancePtr, SNetListenSocket_t hSocket, [MarshalAs(UnmanagedType.I1)] bool bNotifyRemoteEnd);

		// Token: 0x060003C0 RID: 960
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_SendDataOnSocket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_SendDataOnSocket(IntPtr instancePtr, SNetSocket_t hSocket, byte[] pubData, uint cubData, [MarshalAs(UnmanagedType.I1)] bool bReliable);

		// Token: 0x060003C1 RID: 961
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_IsDataAvailableOnSocket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_IsDataAvailableOnSocket(IntPtr instancePtr, SNetSocket_t hSocket, out uint pcubMsgSize);

		// Token: 0x060003C2 RID: 962
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_RetrieveDataFromSocket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_RetrieveDataFromSocket(IntPtr instancePtr, SNetSocket_t hSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize);

		// Token: 0x060003C3 RID: 963
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_IsDataAvailable")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_IsDataAvailable(IntPtr instancePtr, SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket);

		// Token: 0x060003C4 RID: 964
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_RetrieveData")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_RetrieveData(IntPtr instancePtr, SNetListenSocket_t hListenSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket);

		// Token: 0x060003C5 RID: 965
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_GetSocketInfo")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_GetSocketInfo(IntPtr instancePtr, SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out uint punIPRemote, out ushort punPortRemote);

		// Token: 0x060003C6 RID: 966
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_GetListenSocketInfo")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_GetListenSocketInfo(IntPtr instancePtr, SNetListenSocket_t hListenSocket, out uint pnIP, out ushort pnPort);

		// Token: 0x060003C7 RID: 967
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_GetSocketConnectionType")]
		public static extern ESNetSocketConnectionType ISteamNetworking_GetSocketConnectionType(IntPtr instancePtr, SNetSocket_t hSocket);

		// Token: 0x060003C8 RID: 968
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_GetMaxPacketSize")]
		public static extern int ISteamNetworking_GetMaxPacketSize(IntPtr instancePtr, SNetSocket_t hSocket);

		// Token: 0x060003C9 RID: 969
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamParentalSettings_BIsParentalLockEnabled")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamParentalSettings_BIsParentalLockEnabled(IntPtr instancePtr);

		// Token: 0x060003CA RID: 970
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamParentalSettings_BIsParentalLockLocked")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamParentalSettings_BIsParentalLockLocked(IntPtr instancePtr);

		// Token: 0x060003CB RID: 971
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamParentalSettings_BIsAppBlocked")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamParentalSettings_BIsAppBlocked(IntPtr instancePtr, AppId_t nAppID);

		// Token: 0x060003CC RID: 972
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamParentalSettings_BIsAppInBlockList")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamParentalSettings_BIsAppInBlockList(IntPtr instancePtr, AppId_t nAppID);

		// Token: 0x060003CD RID: 973
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamParentalSettings_BIsFeatureBlocked")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamParentalSettings_BIsFeatureBlocked(IntPtr instancePtr, EParentalFeature eFeature);

		// Token: 0x060003CE RID: 974
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamParentalSettings_BIsFeatureInBlockList")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamParentalSettings_BIsFeatureInBlockList(IntPtr instancePtr, EParentalFeature eFeature);

		// Token: 0x060003CF RID: 975
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileWrite")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_FileWrite(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, byte[] pvData, int cubData);

		// Token: 0x060003D0 RID: 976
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileRead")]
		public static extern int ISteamRemoteStorage_FileRead(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, byte[] pvData, int cubDataToRead);

		// Token: 0x060003D1 RID: 977
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileWriteAsync")]
		public static extern ulong ISteamRemoteStorage_FileWriteAsync(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, byte[] pvData, uint cubData);

		// Token: 0x060003D2 RID: 978
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileReadAsync")]
		public static extern ulong ISteamRemoteStorage_FileReadAsync(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, uint nOffset, uint cubToRead);

		// Token: 0x060003D3 RID: 979
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileReadAsyncComplete")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_FileReadAsyncComplete(IntPtr instancePtr, SteamAPICall_t hReadCall, byte[] pvBuffer, uint cubToRead);

		// Token: 0x060003D4 RID: 980
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileForget")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_FileForget(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		// Token: 0x060003D5 RID: 981
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileDelete")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_FileDelete(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		// Token: 0x060003D6 RID: 982
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileShare")]
		public static extern ulong ISteamRemoteStorage_FileShare(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		// Token: 0x060003D7 RID: 983
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_SetSyncPlatforms")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_SetSyncPlatforms(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, ERemoteStoragePlatform eRemoteStoragePlatform);

		// Token: 0x060003D8 RID: 984
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileWriteStreamOpen")]
		public static extern ulong ISteamRemoteStorage_FileWriteStreamOpen(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		// Token: 0x060003D9 RID: 985
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileWriteStreamWriteChunk")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_FileWriteStreamWriteChunk(IntPtr instancePtr, UGCFileWriteStreamHandle_t writeHandle, byte[] pvData, int cubData);

		// Token: 0x060003DA RID: 986
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileWriteStreamClose")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_FileWriteStreamClose(IntPtr instancePtr, UGCFileWriteStreamHandle_t writeHandle);

		// Token: 0x060003DB RID: 987
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileWriteStreamCancel")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_FileWriteStreamCancel(IntPtr instancePtr, UGCFileWriteStreamHandle_t writeHandle);

		// Token: 0x060003DC RID: 988
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileExists")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_FileExists(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		// Token: 0x060003DD RID: 989
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FilePersisted")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_FilePersisted(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		// Token: 0x060003DE RID: 990
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetFileSize")]
		public static extern int ISteamRemoteStorage_GetFileSize(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		// Token: 0x060003DF RID: 991
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetFileTimestamp")]
		public static extern long ISteamRemoteStorage_GetFileTimestamp(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		// Token: 0x060003E0 RID: 992
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetSyncPlatforms")]
		public static extern ERemoteStoragePlatform ISteamRemoteStorage_GetSyncPlatforms(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		// Token: 0x060003E1 RID: 993
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetFileCount")]
		public static extern int ISteamRemoteStorage_GetFileCount(IntPtr instancePtr);

		// Token: 0x060003E2 RID: 994
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetFileNameAndSize")]
		public static extern IntPtr ISteamRemoteStorage_GetFileNameAndSize(IntPtr instancePtr, int iFile, out int pnFileSizeInBytes);

		// Token: 0x060003E3 RID: 995
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetQuota")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_GetQuota(IntPtr instancePtr, out ulong pnTotalBytes, out ulong puAvailableBytes);

		// Token: 0x060003E4 RID: 996
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_IsCloudEnabledForAccount")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_IsCloudEnabledForAccount(IntPtr instancePtr);

		// Token: 0x060003E5 RID: 997
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_IsCloudEnabledForApp")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_IsCloudEnabledForApp(IntPtr instancePtr);

		// Token: 0x060003E6 RID: 998
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_SetCloudEnabledForApp")]
		public static extern void ISteamRemoteStorage_SetCloudEnabledForApp(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bEnabled);

		// Token: 0x060003E7 RID: 999
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UGCDownload")]
		public static extern ulong ISteamRemoteStorage_UGCDownload(IntPtr instancePtr, UGCHandle_t hContent, uint unPriority);

		// Token: 0x060003E8 RID: 1000
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetUGCDownloadProgress")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_GetUGCDownloadProgress(IntPtr instancePtr, UGCHandle_t hContent, out int pnBytesDownloaded, out int pnBytesExpected);

		// Token: 0x060003E9 RID: 1001
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetUGCDetails")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_GetUGCDetails(IntPtr instancePtr, UGCHandle_t hContent, out AppId_t pnAppID, out IntPtr ppchName, out int pnFileSizeInBytes, out CSteamID pSteamIDOwner);

		// Token: 0x060003EA RID: 1002
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UGCRead")]
		public static extern int ISteamRemoteStorage_UGCRead(IntPtr instancePtr, UGCHandle_t hContent, byte[] pvData, int cubDataToRead, uint cOffset, EUGCReadAction eAction);

		// Token: 0x060003EB RID: 1003
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetCachedUGCCount")]
		public static extern int ISteamRemoteStorage_GetCachedUGCCount(IntPtr instancePtr);

		// Token: 0x060003EC RID: 1004
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetCachedUGCHandle")]
		public static extern ulong ISteamRemoteStorage_GetCachedUGCHandle(IntPtr instancePtr, int iCachedContent);

		// Token: 0x060003ED RID: 1005
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_PublishWorkshopFile")]
		public static extern ulong ISteamRemoteStorage_PublishWorkshopFile(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, InteropHelp.UTF8StringHandle pchPreviewFile, AppId_t nConsumerAppId, InteropHelp.UTF8StringHandle pchTitle, InteropHelp.UTF8StringHandle pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IntPtr pTags, EWorkshopFileType eWorkshopFileType);

		// Token: 0x060003EE RID: 1006
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_CreatePublishedFileUpdateRequest")]
		public static extern ulong ISteamRemoteStorage_CreatePublishedFileUpdateRequest(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		// Token: 0x060003EF RID: 1007
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdatePublishedFileFile")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileFile(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchFile);

		// Token: 0x060003F0 RID: 1008
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdatePublishedFilePreviewFile")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFilePreviewFile(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchPreviewFile);

		// Token: 0x060003F1 RID: 1009
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdatePublishedFileTitle")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileTitle(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchTitle);

		// Token: 0x060003F2 RID: 1010
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdatePublishedFileDescription")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileDescription(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchDescription);

		// Token: 0x060003F3 RID: 1011
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdatePublishedFileVisibility")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileVisibility(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility);

		// Token: 0x060003F4 RID: 1012
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdatePublishedFileTags")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileTags(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, IntPtr pTags);

		// Token: 0x060003F5 RID: 1013
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_CommitPublishedFileUpdate")]
		public static extern ulong ISteamRemoteStorage_CommitPublishedFileUpdate(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle);

		// Token: 0x060003F6 RID: 1014
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetPublishedFileDetails")]
		public static extern ulong ISteamRemoteStorage_GetPublishedFileDetails(IntPtr instancePtr, PublishedFileId_t unPublishedFileId, uint unMaxSecondsOld);

		// Token: 0x060003F7 RID: 1015
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_DeletePublishedFile")]
		public static extern ulong ISteamRemoteStorage_DeletePublishedFile(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		// Token: 0x060003F8 RID: 1016
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_EnumerateUserPublishedFiles")]
		public static extern ulong ISteamRemoteStorage_EnumerateUserPublishedFiles(IntPtr instancePtr, uint unStartIndex);

		// Token: 0x060003F9 RID: 1017
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_SubscribePublishedFile")]
		public static extern ulong ISteamRemoteStorage_SubscribePublishedFile(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		// Token: 0x060003FA RID: 1018
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_EnumerateUserSubscribedFiles")]
		public static extern ulong ISteamRemoteStorage_EnumerateUserSubscribedFiles(IntPtr instancePtr, uint unStartIndex);

		// Token: 0x060003FB RID: 1019
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UnsubscribePublishedFile")]
		public static extern ulong ISteamRemoteStorage_UnsubscribePublishedFile(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		// Token: 0x060003FC RID: 1020
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdatePublishedFileSetChangeDescription")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileSetChangeDescription(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchChangeDescription);

		// Token: 0x060003FD RID: 1021
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetPublishedItemVoteDetails")]
		public static extern ulong ISteamRemoteStorage_GetPublishedItemVoteDetails(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		// Token: 0x060003FE RID: 1022
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdateUserPublishedItemVote")]
		public static extern ulong ISteamRemoteStorage_UpdateUserPublishedItemVote(IntPtr instancePtr, PublishedFileId_t unPublishedFileId, [MarshalAs(UnmanagedType.I1)] bool bVoteUp);

		// Token: 0x060003FF RID: 1023
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetUserPublishedItemVoteDetails")]
		public static extern ulong ISteamRemoteStorage_GetUserPublishedItemVoteDetails(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		// Token: 0x06000400 RID: 1024
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_EnumerateUserSharedWorkshopFiles")]
		public static extern ulong ISteamRemoteStorage_EnumerateUserSharedWorkshopFiles(IntPtr instancePtr, CSteamID steamId, uint unStartIndex, IntPtr pRequiredTags, IntPtr pExcludedTags);

		// Token: 0x06000401 RID: 1025
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_PublishVideo")]
		public static extern ulong ISteamRemoteStorage_PublishVideo(IntPtr instancePtr, EWorkshopVideoProvider eVideoProvider, InteropHelp.UTF8StringHandle pchVideoAccount, InteropHelp.UTF8StringHandle pchVideoIdentifier, InteropHelp.UTF8StringHandle pchPreviewFile, AppId_t nConsumerAppId, InteropHelp.UTF8StringHandle pchTitle, InteropHelp.UTF8StringHandle pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IntPtr pTags);

		// Token: 0x06000402 RID: 1026
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_SetUserPublishedFileAction")]
		public static extern ulong ISteamRemoteStorage_SetUserPublishedFileAction(IntPtr instancePtr, PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction);

		// Token: 0x06000403 RID: 1027
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_EnumeratePublishedFilesByUserAction")]
		public static extern ulong ISteamRemoteStorage_EnumeratePublishedFilesByUserAction(IntPtr instancePtr, EWorkshopFileAction eAction, uint unStartIndex);

		// Token: 0x06000404 RID: 1028
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_EnumeratePublishedWorkshopFiles")]
		public static extern ulong ISteamRemoteStorage_EnumeratePublishedWorkshopFiles(IntPtr instancePtr, EWorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, IntPtr pTags, IntPtr pUserTags);

		// Token: 0x06000405 RID: 1029
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UGCDownloadToLocation")]
		public static extern ulong ISteamRemoteStorage_UGCDownloadToLocation(IntPtr instancePtr, UGCHandle_t hContent, InteropHelp.UTF8StringHandle pchLocation, uint unPriority);

		// Token: 0x06000406 RID: 1030
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamScreenshots_WriteScreenshot")]
		public static extern uint ISteamScreenshots_WriteScreenshot(IntPtr instancePtr, byte[] pubRGB, uint cubRGB, int nWidth, int nHeight);

		// Token: 0x06000407 RID: 1031
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamScreenshots_AddScreenshotToLibrary")]
		public static extern uint ISteamScreenshots_AddScreenshotToLibrary(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFilename, InteropHelp.UTF8StringHandle pchThumbnailFilename, int nWidth, int nHeight);

		// Token: 0x06000408 RID: 1032
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamScreenshots_TriggerScreenshot")]
		public static extern void ISteamScreenshots_TriggerScreenshot(IntPtr instancePtr);

		// Token: 0x06000409 RID: 1033
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamScreenshots_HookScreenshots")]
		public static extern void ISteamScreenshots_HookScreenshots(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bHook);

		// Token: 0x0600040A RID: 1034
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamScreenshots_SetLocation")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamScreenshots_SetLocation(IntPtr instancePtr, ScreenshotHandle hScreenshot, InteropHelp.UTF8StringHandle pchLocation);

		// Token: 0x0600040B RID: 1035
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamScreenshots_TagUser")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamScreenshots_TagUser(IntPtr instancePtr, ScreenshotHandle hScreenshot, CSteamID steamID);

		// Token: 0x0600040C RID: 1036
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamScreenshots_TagPublishedFile")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamScreenshots_TagPublishedFile(IntPtr instancePtr, ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID);

		// Token: 0x0600040D RID: 1037
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamScreenshots_IsScreenshotsHooked")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamScreenshots_IsScreenshotsHooked(IntPtr instancePtr);

		// Token: 0x0600040E RID: 1038
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamScreenshots_AddVRScreenshotToLibrary")]
		public static extern uint ISteamScreenshots_AddVRScreenshotToLibrary(IntPtr instancePtr, EVRScreenshotType eType, InteropHelp.UTF8StringHandle pchFilename, InteropHelp.UTF8StringHandle pchVRFilename);

		// Token: 0x0600040F RID: 1039
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_CreateQueryUserUGCRequest")]
		public static extern ulong ISteamUGC_CreateQueryUserUGCRequest(IntPtr instancePtr, AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage);

		// Token: 0x06000410 RID: 1040
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_CreateQueryAllUGCRequest")]
		public static extern ulong ISteamUGC_CreateQueryAllUGCRequest(IntPtr instancePtr, EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage);

		// Token: 0x06000411 RID: 1041
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_CreateQueryUGCDetailsRequest")]
		public static extern ulong ISteamUGC_CreateQueryUGCDetailsRequest(IntPtr instancePtr, [In] [Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs);

		// Token: 0x06000412 RID: 1042
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SendQueryUGCRequest")]
		public static extern ulong ISteamUGC_SendQueryUGCRequest(IntPtr instancePtr, UGCQueryHandle_t handle);

		// Token: 0x06000413 RID: 1043
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCResult")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_GetQueryUGCResult(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails);

		// Token: 0x06000414 RID: 1044
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCPreviewURL")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_GetQueryUGCPreviewURL(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, IntPtr pchURL, uint cchURLSize);

		// Token: 0x06000415 RID: 1045
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCMetadata")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_GetQueryUGCMetadata(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, IntPtr pchMetadata, uint cchMetadatasize);

		// Token: 0x06000416 RID: 1046
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCChildren")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_GetQueryUGCChildren(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, [In] [Out] PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries);

		// Token: 0x06000417 RID: 1047
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCStatistic")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_GetQueryUGCStatistic(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue);

		// Token: 0x06000418 RID: 1048
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCNumAdditionalPreviews")]
		public static extern uint ISteamUGC_GetQueryUGCNumAdditionalPreviews(IntPtr instancePtr, UGCQueryHandle_t handle, uint index);

		// Token: 0x06000419 RID: 1049
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCAdditionalPreview")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_GetQueryUGCAdditionalPreview(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint previewIndex, IntPtr pchURLOrVideoID, uint cchURLSize, IntPtr pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType);

		// Token: 0x0600041A RID: 1050
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCNumKeyValueTags")]
		public static extern uint ISteamUGC_GetQueryUGCNumKeyValueTags(IntPtr instancePtr, UGCQueryHandle_t handle, uint index);

		// Token: 0x0600041B RID: 1051
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCKeyValueTag")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_GetQueryUGCKeyValueTag(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, IntPtr pchKey, uint cchKeySize, IntPtr pchValue, uint cchValueSize);

		// Token: 0x0600041C RID: 1052
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_ReleaseQueryUGCRequest")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_ReleaseQueryUGCRequest(IntPtr instancePtr, UGCQueryHandle_t handle);

		// Token: 0x0600041D RID: 1053
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_AddRequiredTag")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_AddRequiredTag(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pTagName);

		// Token: 0x0600041E RID: 1054
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_AddExcludedTag")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_AddExcludedTag(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pTagName);

		// Token: 0x0600041F RID: 1055
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetReturnOnlyIDs")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetReturnOnlyIDs(IntPtr instancePtr, UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bReturnOnlyIDs);

		// Token: 0x06000420 RID: 1056
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetReturnKeyValueTags")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetReturnKeyValueTags(IntPtr instancePtr, UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bReturnKeyValueTags);

		// Token: 0x06000421 RID: 1057
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetReturnLongDescription")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetReturnLongDescription(IntPtr instancePtr, UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bReturnLongDescription);

		// Token: 0x06000422 RID: 1058
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetReturnMetadata")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetReturnMetadata(IntPtr instancePtr, UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bReturnMetadata);

		// Token: 0x06000423 RID: 1059
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetReturnChildren")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetReturnChildren(IntPtr instancePtr, UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bReturnChildren);

		// Token: 0x06000424 RID: 1060
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetReturnAdditionalPreviews")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetReturnAdditionalPreviews(IntPtr instancePtr, UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bReturnAdditionalPreviews);

		// Token: 0x06000425 RID: 1061
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetReturnTotalOnly")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetReturnTotalOnly(IntPtr instancePtr, UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bReturnTotalOnly);

		// Token: 0x06000426 RID: 1062
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetReturnPlaytimeStats")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetReturnPlaytimeStats(IntPtr instancePtr, UGCQueryHandle_t handle, uint unDays);

		// Token: 0x06000427 RID: 1063
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetLanguage")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetLanguage(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pchLanguage);

		// Token: 0x06000428 RID: 1064
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetAllowCachedResponse")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetAllowCachedResponse(IntPtr instancePtr, UGCQueryHandle_t handle, uint unMaxAgeSeconds);

		// Token: 0x06000429 RID: 1065
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetCloudFileNameFilter")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetCloudFileNameFilter(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pMatchCloudFileName);

		// Token: 0x0600042A RID: 1066
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetMatchAnyTag")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetMatchAnyTag(IntPtr instancePtr, UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bMatchAnyTag);

		// Token: 0x0600042B RID: 1067
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetSearchText")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetSearchText(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pSearchText);

		// Token: 0x0600042C RID: 1068
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetRankedByTrendDays")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetRankedByTrendDays(IntPtr instancePtr, UGCQueryHandle_t handle, uint unDays);

		// Token: 0x0600042D RID: 1069
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_AddRequiredKeyValueTag")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_AddRequiredKeyValueTag(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pKey, InteropHelp.UTF8StringHandle pValue);

		// Token: 0x0600042E RID: 1070
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_RequestUGCDetails")]
		public static extern ulong ISteamUGC_RequestUGCDetails(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds);

		// Token: 0x0600042F RID: 1071
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_CreateItem")]
		public static extern ulong ISteamUGC_CreateItem(IntPtr instancePtr, AppId_t nConsumerAppId, EWorkshopFileType eFileType);

		// Token: 0x06000430 RID: 1072
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_StartItemUpdate")]
		public static extern ulong ISteamUGC_StartItemUpdate(IntPtr instancePtr, AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID);

		// Token: 0x06000431 RID: 1073
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetItemTitle")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetItemTitle(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchTitle);

		// Token: 0x06000432 RID: 1074
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetItemDescription")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetItemDescription(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchDescription);

		// Token: 0x06000433 RID: 1075
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetItemUpdateLanguage")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetItemUpdateLanguage(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchLanguage);

		// Token: 0x06000434 RID: 1076
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetItemMetadata")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetItemMetadata(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchMetaData);

		// Token: 0x06000435 RID: 1077
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetItemVisibility")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetItemVisibility(IntPtr instancePtr, UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility);

		// Token: 0x06000436 RID: 1078
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetItemTags")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetItemTags(IntPtr instancePtr, UGCUpdateHandle_t updateHandle, IntPtr pTags);

		// Token: 0x06000437 RID: 1079
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetItemContent")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetItemContent(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszContentFolder);

		// Token: 0x06000438 RID: 1080
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetItemPreview")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetItemPreview(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszPreviewFile);

		// Token: 0x06000439 RID: 1081
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_RemoveItemKeyValueTags")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_RemoveItemKeyValueTags(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchKey);

		// Token: 0x0600043A RID: 1082
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_AddItemKeyValueTag")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_AddItemKeyValueTag(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		// Token: 0x0600043B RID: 1083
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_AddItemPreviewFile")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_AddItemPreviewFile(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszPreviewFile, EItemPreviewType type);

		// Token: 0x0600043C RID: 1084
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_AddItemPreviewVideo")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_AddItemPreviewVideo(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszVideoID);

		// Token: 0x0600043D RID: 1085
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_UpdateItemPreviewFile")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_UpdateItemPreviewFile(IntPtr instancePtr, UGCUpdateHandle_t handle, uint index, InteropHelp.UTF8StringHandle pszPreviewFile);

		// Token: 0x0600043E RID: 1086
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_UpdateItemPreviewVideo")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_UpdateItemPreviewVideo(IntPtr instancePtr, UGCUpdateHandle_t handle, uint index, InteropHelp.UTF8StringHandle pszVideoID);

		// Token: 0x0600043F RID: 1087
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_RemoveItemPreview")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_RemoveItemPreview(IntPtr instancePtr, UGCUpdateHandle_t handle, uint index);

		// Token: 0x06000440 RID: 1088
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SubmitItemUpdate")]
		public static extern ulong ISteamUGC_SubmitItemUpdate(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchChangeNote);

		// Token: 0x06000441 RID: 1089
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetItemUpdateProgress")]
		public static extern EItemUpdateStatus ISteamUGC_GetItemUpdateProgress(IntPtr instancePtr, UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal);

		// Token: 0x06000442 RID: 1090
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetUserItemVote")]
		public static extern ulong ISteamUGC_SetUserItemVote(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, [MarshalAs(UnmanagedType.I1)] bool bVoteUp);

		// Token: 0x06000443 RID: 1091
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetUserItemVote")]
		public static extern ulong ISteamUGC_GetUserItemVote(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		// Token: 0x06000444 RID: 1092
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_AddItemToFavorites")]
		public static extern ulong ISteamUGC_AddItemToFavorites(IntPtr instancePtr, AppId_t nAppId, PublishedFileId_t nPublishedFileID);

		// Token: 0x06000445 RID: 1093
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_RemoveItemFromFavorites")]
		public static extern ulong ISteamUGC_RemoveItemFromFavorites(IntPtr instancePtr, AppId_t nAppId, PublishedFileId_t nPublishedFileID);

		// Token: 0x06000446 RID: 1094
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SubscribeItem")]
		public static extern ulong ISteamUGC_SubscribeItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		// Token: 0x06000447 RID: 1095
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_UnsubscribeItem")]
		public static extern ulong ISteamUGC_UnsubscribeItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		// Token: 0x06000448 RID: 1096
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetNumSubscribedItems")]
		public static extern uint ISteamUGC_GetNumSubscribedItems(IntPtr instancePtr);

		// Token: 0x06000449 RID: 1097
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetSubscribedItems")]
		public static extern uint ISteamUGC_GetSubscribedItems(IntPtr instancePtr, [In] [Out] PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries);

		// Token: 0x0600044A RID: 1098
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetItemState")]
		public static extern uint ISteamUGC_GetItemState(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		// Token: 0x0600044B RID: 1099
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetItemInstallInfo")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_GetItemInstallInfo(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, IntPtr pchFolder, uint cchFolderSize, out uint punTimeStamp);

		// Token: 0x0600044C RID: 1100
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetItemDownloadInfo")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_GetItemDownloadInfo(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal);

		// Token: 0x0600044D RID: 1101
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_DownloadItem")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_DownloadItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, [MarshalAs(UnmanagedType.I1)] bool bHighPriority);

		// Token: 0x0600044E RID: 1102
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_BInitWorkshopForGameServer")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_BInitWorkshopForGameServer(IntPtr instancePtr, DepotId_t unWorkshopDepotID, InteropHelp.UTF8StringHandle pszFolder);

		// Token: 0x0600044F RID: 1103
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SuspendDownloads")]
		public static extern void ISteamUGC_SuspendDownloads(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bSuspend);

		// Token: 0x06000450 RID: 1104
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_StartPlaytimeTracking")]
		public static extern ulong ISteamUGC_StartPlaytimeTracking(IntPtr instancePtr, [In] [Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs);

		// Token: 0x06000451 RID: 1105
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_StopPlaytimeTracking")]
		public static extern ulong ISteamUGC_StopPlaytimeTracking(IntPtr instancePtr, [In] [Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs);

		// Token: 0x06000452 RID: 1106
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_StopPlaytimeTrackingForAllItems")]
		public static extern ulong ISteamUGC_StopPlaytimeTrackingForAllItems(IntPtr instancePtr);

		// Token: 0x06000453 RID: 1107
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_AddDependency")]
		public static extern ulong ISteamUGC_AddDependency(IntPtr instancePtr, PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID);

		// Token: 0x06000454 RID: 1108
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_RemoveDependency")]
		public static extern ulong ISteamUGC_RemoveDependency(IntPtr instancePtr, PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID);

		// Token: 0x06000455 RID: 1109
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_AddAppDependency")]
		public static extern ulong ISteamUGC_AddAppDependency(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, AppId_t nAppID);

		// Token: 0x06000456 RID: 1110
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_RemoveAppDependency")]
		public static extern ulong ISteamUGC_RemoveAppDependency(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, AppId_t nAppID);

		// Token: 0x06000457 RID: 1111
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetAppDependencies")]
		public static extern ulong ISteamUGC_GetAppDependencies(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		// Token: 0x06000458 RID: 1112
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_DeleteItem")]
		public static extern ulong ISteamUGC_DeleteItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		// Token: 0x06000459 RID: 1113
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetHSteamUser")]
		public static extern int ISteamUser_GetHSteamUser(IntPtr instancePtr);

		// Token: 0x0600045A RID: 1114
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_BLoggedOn")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUser_BLoggedOn(IntPtr instancePtr);

		// Token: 0x0600045B RID: 1115
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetSteamID")]
		public static extern ulong ISteamUser_GetSteamID(IntPtr instancePtr);

		// Token: 0x0600045C RID: 1116
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_InitiateGameConnection")]
		public static extern int ISteamUser_InitiateGameConnection(IntPtr instancePtr, byte[] pAuthBlob, int cbMaxAuthBlob, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer, [MarshalAs(UnmanagedType.I1)] bool bSecure);

		// Token: 0x0600045D RID: 1117
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_TerminateGameConnection")]
		public static extern void ISteamUser_TerminateGameConnection(IntPtr instancePtr, uint unIPServer, ushort usPortServer);

		// Token: 0x0600045E RID: 1118
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_TrackAppUsageEvent")]
		public static extern void ISteamUser_TrackAppUsageEvent(IntPtr instancePtr, CGameID gameID, int eAppUsageEvent, InteropHelp.UTF8StringHandle pchExtraInfo);

		// Token: 0x0600045F RID: 1119
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetUserDataFolder")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUser_GetUserDataFolder(IntPtr instancePtr, IntPtr pchBuffer, int cubBuffer);

		// Token: 0x06000460 RID: 1120
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_StartVoiceRecording")]
		public static extern void ISteamUser_StartVoiceRecording(IntPtr instancePtr);

		// Token: 0x06000461 RID: 1121
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_StopVoiceRecording")]
		public static extern void ISteamUser_StopVoiceRecording(IntPtr instancePtr);

		// Token: 0x06000462 RID: 1122
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetAvailableVoice")]
		public static extern EVoiceResult ISteamUser_GetAvailableVoice(IntPtr instancePtr, out uint pcbCompressed, IntPtr pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated);

		// Token: 0x06000463 RID: 1123
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetVoice")]
		public static extern EVoiceResult ISteamUser_GetVoice(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bWantCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, [MarshalAs(UnmanagedType.I1)] bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, IntPtr nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated);

		// Token: 0x06000464 RID: 1124
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_DecompressVoice")]
		public static extern EVoiceResult ISteamUser_DecompressVoice(IntPtr instancePtr, byte[] pCompressed, uint cbCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, uint nDesiredSampleRate);

		// Token: 0x06000465 RID: 1125
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetVoiceOptimalSampleRate")]
		public static extern uint ISteamUser_GetVoiceOptimalSampleRate(IntPtr instancePtr);

		// Token: 0x06000466 RID: 1126
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetAuthSessionTicket")]
		public static extern uint ISteamUser_GetAuthSessionTicket(IntPtr instancePtr, byte[] pTicket, int cbMaxTicket, out uint pcbTicket);

		// Token: 0x06000467 RID: 1127
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_BeginAuthSession")]
		public static extern EBeginAuthSessionResult ISteamUser_BeginAuthSession(IntPtr instancePtr, byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID);

		// Token: 0x06000468 RID: 1128
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_EndAuthSession")]
		public static extern void ISteamUser_EndAuthSession(IntPtr instancePtr, CSteamID steamID);

		// Token: 0x06000469 RID: 1129
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_CancelAuthTicket")]
		public static extern void ISteamUser_CancelAuthTicket(IntPtr instancePtr, HAuthTicket hAuthTicket);

		// Token: 0x0600046A RID: 1130
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_UserHasLicenseForApp")]
		public static extern EUserHasLicenseForAppResult ISteamUser_UserHasLicenseForApp(IntPtr instancePtr, CSteamID steamID, AppId_t appID);

		// Token: 0x0600046B RID: 1131
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_BIsBehindNAT")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUser_BIsBehindNAT(IntPtr instancePtr);

		// Token: 0x0600046C RID: 1132
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_AdvertiseGame")]
		public static extern void ISteamUser_AdvertiseGame(IntPtr instancePtr, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer);

		// Token: 0x0600046D RID: 1133
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_RequestEncryptedAppTicket")]
		public static extern ulong ISteamUser_RequestEncryptedAppTicket(IntPtr instancePtr, byte[] pDataToInclude, int cbDataToInclude);

		// Token: 0x0600046E RID: 1134
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetEncryptedAppTicket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUser_GetEncryptedAppTicket(IntPtr instancePtr, byte[] pTicket, int cbMaxTicket, out uint pcbTicket);

		// Token: 0x0600046F RID: 1135
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetGameBadgeLevel")]
		public static extern int ISteamUser_GetGameBadgeLevel(IntPtr instancePtr, int nSeries, [MarshalAs(UnmanagedType.I1)] bool bFoil);

		// Token: 0x06000470 RID: 1136
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetPlayerSteamLevel")]
		public static extern int ISteamUser_GetPlayerSteamLevel(IntPtr instancePtr);

		// Token: 0x06000471 RID: 1137
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_RequestStoreAuthURL")]
		public static extern ulong ISteamUser_RequestStoreAuthURL(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchRedirectURL);

		// Token: 0x06000472 RID: 1138
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_BIsPhoneVerified")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUser_BIsPhoneVerified(IntPtr instancePtr);

		// Token: 0x06000473 RID: 1139
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_BIsTwoFactorEnabled")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUser_BIsTwoFactorEnabled(IntPtr instancePtr);

		// Token: 0x06000474 RID: 1140
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_BIsPhoneIdentifying")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUser_BIsPhoneIdentifying(IntPtr instancePtr);

		// Token: 0x06000475 RID: 1141
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_BIsPhoneRequiringVerification")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUser_BIsPhoneRequiringVerification(IntPtr instancePtr);

		// Token: 0x06000476 RID: 1142
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_RequestCurrentStats")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_RequestCurrentStats(IntPtr instancePtr);

		// Token: 0x06000477 RID: 1143
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetStat")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetStat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out int pData);

		// Token: 0x06000478 RID: 1144
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetStat0")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetStat0(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out float pData);

		// Token: 0x06000479 RID: 1145
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_SetStat")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_SetStat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, int nData);

		// Token: 0x0600047A RID: 1146
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_SetStat0")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_SetStat0(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, float fData);

		// Token: 0x0600047B RID: 1147
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_UpdateAvgRateStat")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_UpdateAvgRateStat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, float flCountThisSession, double dSessionLength);

		// Token: 0x0600047C RID: 1148
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetAchievement")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetAchievement(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved);

		// Token: 0x0600047D RID: 1149
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_SetAchievement")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_SetAchievement(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName);

		// Token: 0x0600047E RID: 1150
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_ClearAchievement")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_ClearAchievement(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName);

		// Token: 0x0600047F RID: 1151
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetAchievementAndUnlockTime")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetAchievementAndUnlockTime(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved, out uint punUnlockTime);

		// Token: 0x06000480 RID: 1152
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_StoreStats")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_StoreStats(IntPtr instancePtr);

		// Token: 0x06000481 RID: 1153
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetAchievementIcon")]
		public static extern int ISteamUserStats_GetAchievementIcon(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName);

		// Token: 0x06000482 RID: 1154
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetAchievementDisplayAttribute")]
		public static extern IntPtr ISteamUserStats_GetAchievementDisplayAttribute(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, InteropHelp.UTF8StringHandle pchKey);

		// Token: 0x06000483 RID: 1155
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_IndicateAchievementProgress")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_IndicateAchievementProgress(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, uint nCurProgress, uint nMaxProgress);

		// Token: 0x06000484 RID: 1156
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetNumAchievements")]
		public static extern uint ISteamUserStats_GetNumAchievements(IntPtr instancePtr);

		// Token: 0x06000485 RID: 1157
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetAchievementName")]
		public static extern IntPtr ISteamUserStats_GetAchievementName(IntPtr instancePtr, uint iAchievement);

		// Token: 0x06000486 RID: 1158
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_RequestUserStats")]
		public static extern ulong ISteamUserStats_RequestUserStats(IntPtr instancePtr, CSteamID steamIDUser);

		// Token: 0x06000487 RID: 1159
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetUserStat")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetUserStat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out int pData);

		// Token: 0x06000488 RID: 1160
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetUserStat0")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetUserStat0(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out float pData);

		// Token: 0x06000489 RID: 1161
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetUserAchievement")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved);

		// Token: 0x0600048A RID: 1162
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetUserAchievementAndUnlockTime")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetUserAchievementAndUnlockTime(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved, out uint punUnlockTime);

		// Token: 0x0600048B RID: 1163
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_ResetAllStats")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_ResetAllStats(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bAchievementsToo);

		// Token: 0x0600048C RID: 1164
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_FindOrCreateLeaderboard")]
		public static extern ulong ISteamUserStats_FindOrCreateLeaderboard(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType);

		// Token: 0x0600048D RID: 1165
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_FindLeaderboard")]
		public static extern ulong ISteamUserStats_FindLeaderboard(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchLeaderboardName);

		// Token: 0x0600048E RID: 1166
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetLeaderboardName")]
		public static extern IntPtr ISteamUserStats_GetLeaderboardName(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard);

		// Token: 0x0600048F RID: 1167
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetLeaderboardEntryCount")]
		public static extern int ISteamUserStats_GetLeaderboardEntryCount(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard);

		// Token: 0x06000490 RID: 1168
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetLeaderboardSortMethod")]
		public static extern ELeaderboardSortMethod ISteamUserStats_GetLeaderboardSortMethod(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard);

		// Token: 0x06000491 RID: 1169
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetLeaderboardDisplayType")]
		public static extern ELeaderboardDisplayType ISteamUserStats_GetLeaderboardDisplayType(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard);

		// Token: 0x06000492 RID: 1170
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_DownloadLeaderboardEntries")]
		public static extern ulong ISteamUserStats_DownloadLeaderboardEntries(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd);

		// Token: 0x06000493 RID: 1171
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_DownloadLeaderboardEntriesForUsers")]
		public static extern ulong ISteamUserStats_DownloadLeaderboardEntriesForUsers(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, [In] [Out] CSteamID[] prgUsers, int cUsers);

		// Token: 0x06000494 RID: 1172
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetDownloadedLeaderboardEntry")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetDownloadedLeaderboardEntry(IntPtr instancePtr, SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, [In] [Out] int[] pDetails, int cDetailsMax);

		// Token: 0x06000495 RID: 1173
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_UploadLeaderboardScore")]
		public static extern ulong ISteamUserStats_UploadLeaderboardScore(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, [In] [Out] int[] pScoreDetails, int cScoreDetailsCount);

		// Token: 0x06000496 RID: 1174
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_AttachLeaderboardUGC")]
		public static extern ulong ISteamUserStats_AttachLeaderboardUGC(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC);

		// Token: 0x06000497 RID: 1175
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetNumberOfCurrentPlayers")]
		public static extern ulong ISteamUserStats_GetNumberOfCurrentPlayers(IntPtr instancePtr);

		// Token: 0x06000498 RID: 1176
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_RequestGlobalAchievementPercentages")]
		public static extern ulong ISteamUserStats_RequestGlobalAchievementPercentages(IntPtr instancePtr);

		// Token: 0x06000499 RID: 1177
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetMostAchievedAchievementInfo")]
		public static extern int ISteamUserStats_GetMostAchievedAchievementInfo(IntPtr instancePtr, IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved);

		// Token: 0x0600049A RID: 1178
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetNextMostAchievedAchievementInfo")]
		public static extern int ISteamUserStats_GetNextMostAchievedAchievementInfo(IntPtr instancePtr, int iIteratorPrevious, IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved);

		// Token: 0x0600049B RID: 1179
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetAchievementAchievedPercent")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetAchievementAchievedPercent(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out float pflPercent);

		// Token: 0x0600049C RID: 1180
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_RequestGlobalStats")]
		public static extern ulong ISteamUserStats_RequestGlobalStats(IntPtr instancePtr, int nHistoryDays);

		// Token: 0x0600049D RID: 1181
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetGlobalStat")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetGlobalStat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, out long pData);

		// Token: 0x0600049E RID: 1182
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetGlobalStat0")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetGlobalStat0(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, out double pData);

		// Token: 0x0600049F RID: 1183
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetGlobalStatHistory")]
		public static extern int ISteamUserStats_GetGlobalStatHistory(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, [In] [Out] long[] pData, uint cubData);

		// Token: 0x060004A0 RID: 1184
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetGlobalStatHistory0")]
		public static extern int ISteamUserStats_GetGlobalStatHistory0(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, [In] [Out] double[] pData, uint cubData);

		// Token: 0x060004A1 RID: 1185
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetSecondsSinceAppActive")]
		public static extern uint ISteamUtils_GetSecondsSinceAppActive(IntPtr instancePtr);

		// Token: 0x060004A2 RID: 1186
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetSecondsSinceComputerActive")]
		public static extern uint ISteamUtils_GetSecondsSinceComputerActive(IntPtr instancePtr);

		// Token: 0x060004A3 RID: 1187
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetConnectedUniverse")]
		public static extern EUniverse ISteamUtils_GetConnectedUniverse(IntPtr instancePtr);

		// Token: 0x060004A4 RID: 1188
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetServerRealTime")]
		public static extern uint ISteamUtils_GetServerRealTime(IntPtr instancePtr);

		// Token: 0x060004A5 RID: 1189
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetIPCountry")]
		public static extern IntPtr ISteamUtils_GetIPCountry(IntPtr instancePtr);

		// Token: 0x060004A6 RID: 1190
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetImageSize")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_GetImageSize(IntPtr instancePtr, int iImage, out uint pnWidth, out uint pnHeight);

		// Token: 0x060004A7 RID: 1191
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetImageRGBA")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_GetImageRGBA(IntPtr instancePtr, int iImage, byte[] pubDest, int nDestBufferSize);

		// Token: 0x060004A8 RID: 1192
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetCSERIPPort")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_GetCSERIPPort(IntPtr instancePtr, out uint unIP, out ushort usPort);

		// Token: 0x060004A9 RID: 1193
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetCurrentBatteryPower")]
		public static extern byte ISteamUtils_GetCurrentBatteryPower(IntPtr instancePtr);

		// Token: 0x060004AA RID: 1194
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetAppID")]
		public static extern uint ISteamUtils_GetAppID(IntPtr instancePtr);

		// Token: 0x060004AB RID: 1195
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_SetOverlayNotificationPosition")]
		public static extern void ISteamUtils_SetOverlayNotificationPosition(IntPtr instancePtr, ENotificationPosition eNotificationPosition);

		// Token: 0x060004AC RID: 1196
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_IsAPICallCompleted")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_IsAPICallCompleted(IntPtr instancePtr, SteamAPICall_t hSteamAPICall, out bool pbFailed);

		// Token: 0x060004AD RID: 1197
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetAPICallFailureReason")]
		public static extern ESteamAPICallFailure ISteamUtils_GetAPICallFailureReason(IntPtr instancePtr, SteamAPICall_t hSteamAPICall);

		// Token: 0x060004AE RID: 1198
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetAPICallResult")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_GetAPICallResult(IntPtr instancePtr, SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed);

		// Token: 0x060004AF RID: 1199
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetIPCCallCount")]
		public static extern uint ISteamUtils_GetIPCCallCount(IntPtr instancePtr);

		// Token: 0x060004B0 RID: 1200
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_SetWarningMessageHook")]
		public static extern void ISteamUtils_SetWarningMessageHook(IntPtr instancePtr, SteamAPIWarningMessageHook_t pFunction);

		// Token: 0x060004B1 RID: 1201
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_IsOverlayEnabled")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_IsOverlayEnabled(IntPtr instancePtr);

		// Token: 0x060004B2 RID: 1202
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_BOverlayNeedsPresent")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_BOverlayNeedsPresent(IntPtr instancePtr);

		// Token: 0x060004B3 RID: 1203
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_CheckFileSignature")]
		public static extern ulong ISteamUtils_CheckFileSignature(IntPtr instancePtr, InteropHelp.UTF8StringHandle szFileName);

		// Token: 0x060004B4 RID: 1204
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_ShowGamepadTextInput")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_ShowGamepadTextInput(IntPtr instancePtr, EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, InteropHelp.UTF8StringHandle pchDescription, uint unCharMax, InteropHelp.UTF8StringHandle pchExistingText);

		// Token: 0x060004B5 RID: 1205
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetEnteredGamepadTextLength")]
		public static extern uint ISteamUtils_GetEnteredGamepadTextLength(IntPtr instancePtr);

		// Token: 0x060004B6 RID: 1206
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetEnteredGamepadTextInput")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_GetEnteredGamepadTextInput(IntPtr instancePtr, IntPtr pchText, uint cchText);

		// Token: 0x060004B7 RID: 1207
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetSteamUILanguage")]
		public static extern IntPtr ISteamUtils_GetSteamUILanguage(IntPtr instancePtr);

		// Token: 0x060004B8 RID: 1208
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_IsSteamRunningInVR")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_IsSteamRunningInVR(IntPtr instancePtr);

		// Token: 0x060004B9 RID: 1209
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_SetOverlayNotificationInset")]
		public static extern void ISteamUtils_SetOverlayNotificationInset(IntPtr instancePtr, int nHorizontalInset, int nVerticalInset);

		// Token: 0x060004BA RID: 1210
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_IsSteamInBigPictureMode")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_IsSteamInBigPictureMode(IntPtr instancePtr);

		// Token: 0x060004BB RID: 1211
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_StartVRDashboard")]
		public static extern void ISteamUtils_StartVRDashboard(IntPtr instancePtr);

		// Token: 0x060004BC RID: 1212
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_IsVRHeadsetStreamingEnabled")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_IsVRHeadsetStreamingEnabled(IntPtr instancePtr);

		// Token: 0x060004BD RID: 1213
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_SetVRHeadsetStreamingEnabled")]
		public static extern void ISteamUtils_SetVRHeadsetStreamingEnabled(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bEnabled);

		// Token: 0x060004BE RID: 1214
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamVideo_GetVideoURL")]
		public static extern void ISteamVideo_GetVideoURL(IntPtr instancePtr, AppId_t unVideoAppID);

		// Token: 0x060004BF RID: 1215
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamVideo_IsBroadcasting")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamVideo_IsBroadcasting(IntPtr instancePtr, out int pnNumViewers);

		// Token: 0x060004C0 RID: 1216
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamVideo_GetOPFSettings")]
		public static extern void ISteamVideo_GetOPFSettings(IntPtr instancePtr, AppId_t unVideoAppID);

		// Token: 0x060004C1 RID: 1217
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamVideo_GetOPFStringForApp")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamVideo_GetOPFStringForApp(IntPtr instancePtr, AppId_t unVideoAppID, IntPtr pchBuffer, ref int pnBufferSize);

		// Token: 0x040006EC RID: 1772
		internal const string NativeLibraryName = "steam_api64";

		// Token: 0x040006ED RID: 1773
		internal const string NativeLibrary_SDKEncryptedAppTicket = "sdkencryptedappticket64";
	}
}
