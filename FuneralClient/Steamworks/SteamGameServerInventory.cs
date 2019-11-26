using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000159 RID: 345
	public static class SteamGameServerInventory
	{
		// Token: 0x06000644 RID: 1604 RVA: 0x0000471B File Offset: 0x0000291B
		public static EResult GetResultStatus(SteamInventoryResult_t resultHandle)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamInventory_GetResultStatus(CSteamGameServerAPIContext.GetSteamInventory(), resultHandle);
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0000472D File Offset: 0x0000292D
		public static bool GetResultItems(SteamInventoryResult_t resultHandle, SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamInventory_GetResultItems(CSteamGameServerAPIContext.GetSteamInventory(), resultHandle, pOutItemsArray, ref punOutItemsArraySize);
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0000CE28 File Offset: 0x0000B028
		public static bool GetResultItemProperty(SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut)
		{
			InteropHelp.TestIfAvailableGameServer();
			IntPtr intPtr = Marshal.AllocHGlobal((int)punValueBufferSizeOut);
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchPropertyName))
			{
				bool flag = NativeMethods.ISteamInventory_GetResultItemProperty(CSteamGameServerAPIContext.GetSteamInventory(), resultHandle, unItemIndex, utf8StringHandle, intPtr, ref punValueBufferSizeOut);
				pchValueBuffer = (flag ? InteropHelp.PtrToStringUTF8(intPtr) : null);
				Marshal.FreeHGlobal(intPtr);
				result = flag;
			}
			return result;
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00004741 File Offset: 0x00002941
		public static uint GetResultTimestamp(SteamInventoryResult_t resultHandle)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamInventory_GetResultTimestamp(CSteamGameServerAPIContext.GetSteamInventory(), resultHandle);
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00004753 File Offset: 0x00002953
		public static bool CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamInventory_CheckResultSteamID(CSteamGameServerAPIContext.GetSteamInventory(), resultHandle, steamIDExpected);
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00004766 File Offset: 0x00002966
		public static void DestroyResult(SteamInventoryResult_t resultHandle)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamInventory_DestroyResult(CSteamGameServerAPIContext.GetSteamInventory(), resultHandle);
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00004778 File Offset: 0x00002978
		public static bool GetAllItems(out SteamInventoryResult_t pResultHandle)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamInventory_GetAllItems(CSteamGameServerAPIContext.GetSteamInventory(), out pResultHandle);
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0000478A File Offset: 0x0000298A
		public static bool GetItemsByID(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamInventory_GetItemsByID(CSteamGameServerAPIContext.GetSteamInventory(), out pResultHandle, pInstanceIDs, unCountInstanceIDs);
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x0000479E File Offset: 0x0000299E
		public static bool SerializeResult(SteamInventoryResult_t resultHandle, byte[] pOutBuffer, out uint punOutBufferSize)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamInventory_SerializeResult(CSteamGameServerAPIContext.GetSteamInventory(), resultHandle, pOutBuffer, out punOutBufferSize);
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x000047B2 File Offset: 0x000029B2
		public static bool DeserializeResult(out SteamInventoryResult_t pOutResultHandle, byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE = false)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamInventory_DeserializeResult(CSteamGameServerAPIContext.GetSteamInventory(), out pOutResultHandle, pBuffer, unBufferSize, bRESERVED_MUST_BE_FALSE);
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x000047C7 File Offset: 0x000029C7
		public static bool GenerateItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamInventory_GenerateItems(CSteamGameServerAPIContext.GetSteamInventory(), out pResultHandle, pArrayItemDefs, punArrayQuantity, unArrayLength);
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x000047DC File Offset: 0x000029DC
		public static bool GrantPromoItems(out SteamInventoryResult_t pResultHandle)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamInventory_GrantPromoItems(CSteamGameServerAPIContext.GetSteamInventory(), out pResultHandle);
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x000047EE File Offset: 0x000029EE
		public static bool AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamInventory_AddPromoItem(CSteamGameServerAPIContext.GetSteamInventory(), out pResultHandle, itemDef);
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00004801 File Offset: 0x00002A01
		public static bool AddPromoItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint unArrayLength)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamInventory_AddPromoItems(CSteamGameServerAPIContext.GetSteamInventory(), out pResultHandle, pArrayItemDefs, unArrayLength);
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00004815 File Offset: 0x00002A15
		public static bool ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamInventory_ConsumeItem(CSteamGameServerAPIContext.GetSteamInventory(), out pResultHandle, itemConsume, unQuantity);
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00004829 File Offset: 0x00002A29
		public static bool ExchangeItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayGenerate, uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, SteamItemInstanceID_t[] pArrayDestroy, uint[] punArrayDestroyQuantity, uint unArrayDestroyLength)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamInventory_ExchangeItems(CSteamGameServerAPIContext.GetSteamInventory(), out pResultHandle, pArrayGenerate, punArrayGenerateQuantity, unArrayGenerateLength, pArrayDestroy, punArrayDestroyQuantity, unArrayDestroyLength);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00004844 File Offset: 0x00002A44
		public static bool TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamInventory_TransferItemQuantity(CSteamGameServerAPIContext.GetSteamInventory(), out pResultHandle, itemIdSource, unQuantity, itemIdDest);
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00004859 File Offset: 0x00002A59
		public static void SendItemDropHeartbeat()
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamInventory_SendItemDropHeartbeat(CSteamGameServerAPIContext.GetSteamInventory());
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x0000486A File Offset: 0x00002A6A
		public static bool TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamInventory_TriggerItemDrop(CSteamGameServerAPIContext.GetSteamInventory(), out pResultHandle, dropListDefinition);
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0000CE90 File Offset: 0x0000B090
		public static bool TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, SteamItemInstanceID_t[] pArrayGive, uint[] pArrayGiveQuantity, uint nArrayGiveLength, SteamItemInstanceID_t[] pArrayGet, uint[] pArrayGetQuantity, uint nArrayGetLength)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamInventory_TradeItems(CSteamGameServerAPIContext.GetSteamInventory(), out pResultHandle, steamIDTradePartner, pArrayGive, pArrayGiveQuantity, nArrayGiveLength, pArrayGet, pArrayGetQuantity, nArrayGetLength);
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x0000487D File Offset: 0x00002A7D
		public static bool LoadItemDefinitions()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamInventory_LoadItemDefinitions(CSteamGameServerAPIContext.GetSteamInventory());
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0000488E File Offset: 0x00002A8E
		public static bool GetItemDefinitionIDs(SteamItemDef_t[] pItemDefIDs, out uint punItemDefIDsArraySize)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamInventory_GetItemDefinitionIDs(CSteamGameServerAPIContext.GetSteamInventory(), pItemDefIDs, out punItemDefIDsArraySize);
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x0000CEB8 File Offset: 0x0000B0B8
		public static bool GetItemDefinitionProperty(SteamItemDef_t iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut)
		{
			InteropHelp.TestIfAvailableGameServer();
			IntPtr intPtr = Marshal.AllocHGlobal((int)punValueBufferSizeOut);
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchPropertyName))
			{
				bool flag = NativeMethods.ISteamInventory_GetItemDefinitionProperty(CSteamGameServerAPIContext.GetSteamInventory(), iDefinition, utf8StringHandle, intPtr, ref punValueBufferSizeOut);
				pchValueBuffer = (flag ? InteropHelp.PtrToStringUTF8(intPtr) : null);
				Marshal.FreeHGlobal(intPtr);
				result = flag;
			}
			return result;
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x000048A1 File Offset: 0x00002AA1
		public static SteamAPICall_t RequestEligiblePromoItemDefinitionsIDs(CSteamID steamID)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamInventory_RequestEligiblePromoItemDefinitionsIDs(CSteamGameServerAPIContext.GetSteamInventory(), steamID);
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x000048B8 File Offset: 0x00002AB8
		public static bool GetEligiblePromoItemDefinitionIDs(CSteamID steamID, SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamInventory_GetEligiblePromoItemDefinitionIDs(CSteamGameServerAPIContext.GetSteamInventory(), steamID, pItemDefIDs, ref punItemDefIDsArraySize);
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x000048CC File Offset: 0x00002ACC
		public static SteamAPICall_t StartPurchase(SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamInventory_StartPurchase(CSteamGameServerAPIContext.GetSteamInventory(), pArrayItemDefs, punArrayQuantity, unArrayLength);
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x000048E5 File Offset: 0x00002AE5
		public static SteamAPICall_t RequestPrices()
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamInventory_RequestPrices(CSteamGameServerAPIContext.GetSteamInventory());
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x000048FB File Offset: 0x00002AFB
		public static uint GetNumItemsWithPrices()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamInventory_GetNumItemsWithPrices(CSteamGameServerAPIContext.GetSteamInventory());
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0000490C File Offset: 0x00002B0C
		public static bool GetItemsWithPrices(SteamItemDef_t[] pArrayItemDefs, ulong[] pPrices, uint unArrayLength)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamInventory_GetItemsWithPrices(CSteamGameServerAPIContext.GetSteamInventory(), pArrayItemDefs, pPrices, unArrayLength);
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00004920 File Offset: 0x00002B20
		public static bool GetItemPrice(SteamItemDef_t iDefinition, out ulong pPrice)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamInventory_GetItemPrice(CSteamGameServerAPIContext.GetSteamInventory(), iDefinition, out pPrice);
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00004933 File Offset: 0x00002B33
		public static SteamInventoryUpdateHandle_t StartUpdateProperties()
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamInventoryUpdateHandle_t)NativeMethods.ISteamInventory_StartUpdateProperties(CSteamGameServerAPIContext.GetSteamInventory());
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x0000CF1C File Offset: 0x0000B11C
		public static bool RemoveProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName)
		{
			InteropHelp.TestIfAvailableGameServer();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchPropertyName))
			{
				result = NativeMethods.ISteamInventory_RemoveProperty(CSteamGameServerAPIContext.GetSteamInventory(), handle, nItemID, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0000CF60 File Offset: 0x0000B160
		public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, string pchPropertyValue)
		{
			InteropHelp.TestIfAvailableGameServer();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchPropertyName))
			{
				using (InteropHelp.UTF8StringHandle utf8StringHandle2 = new InteropHelp.UTF8StringHandle(pchPropertyValue))
				{
					result = NativeMethods.ISteamInventory_SetProperty(CSteamGameServerAPIContext.GetSteamInventory(), handle, nItemID, utf8StringHandle, utf8StringHandle2);
				}
			}
			return result;
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x0000CFC4 File Offset: 0x0000B1C4
		public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, bool bValue)
		{
			InteropHelp.TestIfAvailableGameServer();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchPropertyName))
			{
				result = NativeMethods.ISteamInventory_SetProperty0(CSteamGameServerAPIContext.GetSteamInventory(), handle, nItemID, utf8StringHandle, bValue);
			}
			return result;
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x0000D00C File Offset: 0x0000B20C
		public static bool SetProperty1(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, long nValue)
		{
			InteropHelp.TestIfAvailableGameServer();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchPropertyName))
			{
				result = NativeMethods.ISteamInventory_SetProperty1(CSteamGameServerAPIContext.GetSteamInventory(), handle, nItemID, utf8StringHandle, nValue);
			}
			return result;
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0000D054 File Offset: 0x0000B254
		public static bool SetProperty2(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, float flValue)
		{
			InteropHelp.TestIfAvailableGameServer();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchPropertyName))
			{
				result = NativeMethods.ISteamInventory_SetProperty2(CSteamGameServerAPIContext.GetSteamInventory(), handle, nItemID, utf8StringHandle, flValue);
			}
			return result;
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00004949 File Offset: 0x00002B49
		public static bool SubmitUpdateProperties(SteamInventoryUpdateHandle_t handle, out SteamInventoryResult_t pResultHandle)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamInventory_SubmitUpdateProperties(CSteamGameServerAPIContext.GetSteamInventory(), handle, out pResultHandle);
		}
	}
}
