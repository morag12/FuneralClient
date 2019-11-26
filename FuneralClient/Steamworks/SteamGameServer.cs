using System;

namespace Steamworks2
{
	// Token: 0x02000156 RID: 342
	public static class SteamGameServer
	{
		// Token: 0x060005DF RID: 1503 RVA: 0x0000C1F4 File Offset: 0x0000A3F4
		public static bool InitGameServer(uint unIP, ushort usGamePort, ushort usQueryPort, uint unFlags, AppId_t nGameAppId, string pchVersionString)
		{
			InteropHelp.TestIfAvailableGameServer();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchVersionString))
			{
				result = NativeMethods.ISteamGameServer_InitGameServer(CSteamGameServerAPIContext.GetSteamGameServer(), unIP, usGamePort, usQueryPort, unFlags, nGameAppId, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x0000C240 File Offset: 0x0000A440
		public static void SetProduct(string pszProduct)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pszProduct))
			{
				NativeMethods.ISteamGameServer_SetProduct(CSteamGameServerAPIContext.GetSteamGameServer(), utf8StringHandle);
			}
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0000C280 File Offset: 0x0000A480
		public static void SetGameDescription(string pszGameDescription)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pszGameDescription))
			{
				NativeMethods.ISteamGameServer_SetGameDescription(CSteamGameServerAPIContext.GetSteamGameServer(), utf8StringHandle);
			}
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x0000C2C0 File Offset: 0x0000A4C0
		public static void SetModDir(string pszModDir)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pszModDir))
			{
				NativeMethods.ISteamGameServer_SetModDir(CSteamGameServerAPIContext.GetSteamGameServer(), utf8StringHandle);
			}
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x000042D5 File Offset: 0x000024D5
		public static void SetDedicatedServer(bool bDedicated)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_SetDedicatedServer(CSteamGameServerAPIContext.GetSteamGameServer(), bDedicated);
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x0000C300 File Offset: 0x0000A500
		public static void LogOn(string pszToken)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pszToken))
			{
				NativeMethods.ISteamGameServer_LogOn(CSteamGameServerAPIContext.GetSteamGameServer(), utf8StringHandle);
			}
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x000042E7 File Offset: 0x000024E7
		public static void LogOnAnonymous()
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_LogOnAnonymous(CSteamGameServerAPIContext.GetSteamGameServer());
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x000042F8 File Offset: 0x000024F8
		public static void LogOff()
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_LogOff(CSteamGameServerAPIContext.GetSteamGameServer());
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00004309 File Offset: 0x00002509
		public static bool BLoggedOn()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_BLoggedOn(CSteamGameServerAPIContext.GetSteamGameServer());
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x0000431A File Offset: 0x0000251A
		public static bool BSecure()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_BSecure(CSteamGameServerAPIContext.GetSteamGameServer());
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x0000432B File Offset: 0x0000252B
		public static CSteamID GetSteamID()
		{
			InteropHelp.TestIfAvailableGameServer();
			return (CSteamID)NativeMethods.ISteamGameServer_GetSteamID(CSteamGameServerAPIContext.GetSteamGameServer());
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00004341 File Offset: 0x00002541
		public static bool WasRestartRequested()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_WasRestartRequested(CSteamGameServerAPIContext.GetSteamGameServer());
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00004352 File Offset: 0x00002552
		public static void SetMaxPlayerCount(int cPlayersMax)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_SetMaxPlayerCount(CSteamGameServerAPIContext.GetSteamGameServer(), cPlayersMax);
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00004364 File Offset: 0x00002564
		public static void SetBotPlayerCount(int cBotplayers)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_SetBotPlayerCount(CSteamGameServerAPIContext.GetSteamGameServer(), cBotplayers);
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x0000C340 File Offset: 0x0000A540
		public static void SetServerName(string pszServerName)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pszServerName))
			{
				NativeMethods.ISteamGameServer_SetServerName(CSteamGameServerAPIContext.GetSteamGameServer(), utf8StringHandle);
			}
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x0000C380 File Offset: 0x0000A580
		public static void SetMapName(string pszMapName)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pszMapName))
			{
				NativeMethods.ISteamGameServer_SetMapName(CSteamGameServerAPIContext.GetSteamGameServer(), utf8StringHandle);
			}
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00004376 File Offset: 0x00002576
		public static void SetPasswordProtected(bool bPasswordProtected)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_SetPasswordProtected(CSteamGameServerAPIContext.GetSteamGameServer(), bPasswordProtected);
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00004388 File Offset: 0x00002588
		public static void SetSpectatorPort(ushort unSpectatorPort)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_SetSpectatorPort(CSteamGameServerAPIContext.GetSteamGameServer(), unSpectatorPort);
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x0000C3C0 File Offset: 0x0000A5C0
		public static void SetSpectatorServerName(string pszSpectatorServerName)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pszSpectatorServerName))
			{
				NativeMethods.ISteamGameServer_SetSpectatorServerName(CSteamGameServerAPIContext.GetSteamGameServer(), utf8StringHandle);
			}
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x0000439A File Offset: 0x0000259A
		public static void ClearAllKeyValues()
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_ClearAllKeyValues(CSteamGameServerAPIContext.GetSteamGameServer());
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x0000C400 File Offset: 0x0000A600
		public static void SetKeyValue(string pKey, string pValue)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pKey))
			{
				using (InteropHelp.UTF8StringHandle utf8StringHandle2 = new InteropHelp.UTF8StringHandle(pValue))
				{
					NativeMethods.ISteamGameServer_SetKeyValue(CSteamGameServerAPIContext.GetSteamGameServer(), utf8StringHandle, utf8StringHandle2);
				}
			}
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x0000C460 File Offset: 0x0000A660
		public static void SetGameTags(string pchGameTags)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchGameTags))
			{
				NativeMethods.ISteamGameServer_SetGameTags(CSteamGameServerAPIContext.GetSteamGameServer(), utf8StringHandle);
			}
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x0000C4A0 File Offset: 0x0000A6A0
		public static void SetGameData(string pchGameData)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchGameData))
			{
				NativeMethods.ISteamGameServer_SetGameData(CSteamGameServerAPIContext.GetSteamGameServer(), utf8StringHandle);
			}
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x0000C4E0 File Offset: 0x0000A6E0
		public static void SetRegion(string pszRegion)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pszRegion))
			{
				NativeMethods.ISteamGameServer_SetRegion(CSteamGameServerAPIContext.GetSteamGameServer(), utf8StringHandle);
			}
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x000043AB File Offset: 0x000025AB
		public static bool SendUserConnectAndAuthenticate(uint unIPClient, byte[] pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_SendUserConnectAndAuthenticate(CSteamGameServerAPIContext.GetSteamGameServer(), unIPClient, pvAuthBlob, cubAuthBlobSize, out pSteamIDUser);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x000043C0 File Offset: 0x000025C0
		public static CSteamID CreateUnauthenticatedUserConnection()
		{
			InteropHelp.TestIfAvailableGameServer();
			return (CSteamID)NativeMethods.ISteamGameServer_CreateUnauthenticatedUserConnection(CSteamGameServerAPIContext.GetSteamGameServer());
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x000043D6 File Offset: 0x000025D6
		public static void SendUserDisconnect(CSteamID steamIDUser)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_SendUserDisconnect(CSteamGameServerAPIContext.GetSteamGameServer(), steamIDUser);
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x0000C520 File Offset: 0x0000A720
		public static bool BUpdateUserData(CSteamID steamIDUser, string pchPlayerName, uint uScore)
		{
			InteropHelp.TestIfAvailableGameServer();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchPlayerName))
			{
				result = NativeMethods.ISteamGameServer_BUpdateUserData(CSteamGameServerAPIContext.GetSteamGameServer(), steamIDUser, utf8StringHandle, uScore);
			}
			return result;
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x000043E8 File Offset: 0x000025E8
		public static HAuthTicket GetAuthSessionTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (HAuthTicket)NativeMethods.ISteamGameServer_GetAuthSessionTicket(CSteamGameServerAPIContext.GetSteamGameServer(), pTicket, cbMaxTicket, out pcbTicket);
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00004401 File Offset: 0x00002601
		public static EBeginAuthSessionResult BeginAuthSession(byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_BeginAuthSession(CSteamGameServerAPIContext.GetSteamGameServer(), pAuthTicket, cbAuthTicket, steamID);
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00004415 File Offset: 0x00002615
		public static void EndAuthSession(CSteamID steamID)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_EndAuthSession(CSteamGameServerAPIContext.GetSteamGameServer(), steamID);
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00004427 File Offset: 0x00002627
		public static void CancelAuthTicket(HAuthTicket hAuthTicket)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_CancelAuthTicket(CSteamGameServerAPIContext.GetSteamGameServer(), hAuthTicket);
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00004439 File Offset: 0x00002639
		public static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_UserHasLicenseForApp(CSteamGameServerAPIContext.GetSteamGameServer(), steamID, appID);
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x0000444C File Offset: 0x0000264C
		public static bool RequestUserGroupStatus(CSteamID steamIDUser, CSteamID steamIDGroup)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_RequestUserGroupStatus(CSteamGameServerAPIContext.GetSteamGameServer(), steamIDUser, steamIDGroup);
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x0000445F File Offset: 0x0000265F
		public static void GetGameplayStats()
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_GetGameplayStats(CSteamGameServerAPIContext.GetSteamGameServer());
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00004470 File Offset: 0x00002670
		public static SteamAPICall_t GetServerReputation()
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamGameServer_GetServerReputation(CSteamGameServerAPIContext.GetSteamGameServer());
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00004486 File Offset: 0x00002686
		public static uint GetPublicIP()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_GetPublicIP(CSteamGameServerAPIContext.GetSteamGameServer());
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00004497 File Offset: 0x00002697
		public static bool HandleIncomingPacket(byte[] pData, int cbData, uint srcIP, ushort srcPort)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_HandleIncomingPacket(CSteamGameServerAPIContext.GetSteamGameServer(), pData, cbData, srcIP, srcPort);
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x000044AC File Offset: 0x000026AC
		public static int GetNextOutgoingPacket(byte[] pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_GetNextOutgoingPacket(CSteamGameServerAPIContext.GetSteamGameServer(), pOut, cbMaxOut, out pNetAdr, out pPort);
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x000044C1 File Offset: 0x000026C1
		public static void EnableHeartbeats(bool bActive)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_EnableHeartbeats(CSteamGameServerAPIContext.GetSteamGameServer(), bActive);
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x000044D3 File Offset: 0x000026D3
		public static void SetHeartbeatInterval(int iHeartbeatInterval)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_SetHeartbeatInterval(CSteamGameServerAPIContext.GetSteamGameServer(), iHeartbeatInterval);
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x000044E5 File Offset: 0x000026E5
		public static void ForceHeartbeat()
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_ForceHeartbeat(CSteamGameServerAPIContext.GetSteamGameServer());
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x000044F6 File Offset: 0x000026F6
		public static SteamAPICall_t AssociateWithClan(CSteamID steamIDClan)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamGameServer_AssociateWithClan(CSteamGameServerAPIContext.GetSteamGameServer(), steamIDClan);
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0000450D File Offset: 0x0000270D
		public static SteamAPICall_t ComputeNewPlayerCompatibility(CSteamID steamIDNewPlayer)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamGameServer_ComputeNewPlayerCompatibility(CSteamGameServerAPIContext.GetSteamGameServer(), steamIDNewPlayer);
		}
	}
}
