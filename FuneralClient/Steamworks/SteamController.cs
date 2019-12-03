using System;

namespace Steamworks2
{
	// Token: 0x02000153 RID: 339
	public static class SteamController
	{
		// Token: 0x06000570 RID: 1392 RVA: 0x00003B5F File Offset: 0x00001D5F
		public static bool Init()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_Init(CSteamAPIContext.GetSteamController());
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00003B70 File Offset: 0x00001D70
		public static bool Shutdown()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_Shutdown(CSteamAPIContext.GetSteamController());
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00003B81 File Offset: 0x00001D81
		public static void RunFrame()
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamController_RunFrame(CSteamAPIContext.GetSteamController());
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00003B92 File Offset: 0x00001D92
		public static int GetConnectedControllers(ControllerHandle_t[] handlesOut)
		{
			InteropHelp.TestIfAvailableClient();
			if (handlesOut.Length != 16)
			{
				throw new ArgumentException("handlesOut must be the same size as Constants.STEAM_CONTROLLER_MAX_COUNT!");
			}
			return NativeMethods.ISteamController_GetConnectedControllers(CSteamAPIContext.GetSteamController(), handlesOut);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00003BB6 File Offset: 0x00001DB6
		public static bool ShowBindingPanel(ControllerHandle_t controllerHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_ShowBindingPanel(CSteamAPIContext.GetSteamController(), controllerHandle);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x0000BDEC File Offset: 0x00009FEC
		public static ControllerActionSetHandle_t GetActionSetHandle(string pszActionSetName)
		{
			InteropHelp.TestIfAvailableClient();
			ControllerActionSetHandle_t result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pszActionSetName))
			{
				result = (ControllerActionSetHandle_t)NativeMethods.ISteamController_GetActionSetHandle(CSteamAPIContext.GetSteamController(), utf8StringHandle);
			}
			return result;
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00003BC8 File Offset: 0x00001DC8
		public static void ActivateActionSet(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamController_ActivateActionSet(CSteamAPIContext.GetSteamController(), controllerHandle, actionSetHandle);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00003BDB File Offset: 0x00001DDB
		public static ControllerActionSetHandle_t GetCurrentActionSet(ControllerHandle_t controllerHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return (ControllerActionSetHandle_t)NativeMethods.ISteamController_GetCurrentActionSet(CSteamAPIContext.GetSteamController(), controllerHandle);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00003BF2 File Offset: 0x00001DF2
		public static void ActivateActionSetLayer(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetLayerHandle)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamController_ActivateActionSetLayer(CSteamAPIContext.GetSteamController(), controllerHandle, actionSetLayerHandle);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00003C05 File Offset: 0x00001E05
		public static void DeactivateActionSetLayer(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetLayerHandle)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamController_DeactivateActionSetLayer(CSteamAPIContext.GetSteamController(), controllerHandle, actionSetLayerHandle);
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00003C18 File Offset: 0x00001E18
		public static void DeactivateAllActionSetLayers(ControllerHandle_t controllerHandle)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamController_DeactivateAllActionSetLayers(CSteamAPIContext.GetSteamController(), controllerHandle);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00003C2A File Offset: 0x00001E2A
		public static int GetActiveActionSetLayers(ControllerHandle_t controllerHandle, out ControllerActionSetHandle_t handlesOut)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_GetActiveActionSetLayers(CSteamAPIContext.GetSteamController(), controllerHandle, out handlesOut);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0000BE34 File Offset: 0x0000A034
		public static ControllerDigitalActionHandle_t GetDigitalActionHandle(string pszActionName)
		{
			InteropHelp.TestIfAvailableClient();
			ControllerDigitalActionHandle_t result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pszActionName))
			{
				result = (ControllerDigitalActionHandle_t)NativeMethods.ISteamController_GetDigitalActionHandle(CSteamAPIContext.GetSteamController(), utf8StringHandle);
			}
			return result;
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00003C3D File Offset: 0x00001E3D
		public static ControllerDigitalActionData_t GetDigitalActionData(ControllerHandle_t controllerHandle, ControllerDigitalActionHandle_t digitalActionHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_GetDigitalActionData(CSteamAPIContext.GetSteamController(), controllerHandle, digitalActionHandle);
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00003C50 File Offset: 0x00001E50
		public static int GetDigitalActionOrigins(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerDigitalActionHandle_t digitalActionHandle, EControllerActionOrigin[] originsOut)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_GetDigitalActionOrigins(CSteamAPIContext.GetSteamController(), controllerHandle, actionSetHandle, digitalActionHandle, originsOut);
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x0000BE7C File Offset: 0x0000A07C
		public static ControllerAnalogActionHandle_t GetAnalogActionHandle(string pszActionName)
		{
			InteropHelp.TestIfAvailableClient();
			ControllerAnalogActionHandle_t result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pszActionName))
			{
				result = (ControllerAnalogActionHandle_t)NativeMethods.ISteamController_GetAnalogActionHandle(CSteamAPIContext.GetSteamController(), utf8StringHandle);
			}
			return result;
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00003C65 File Offset: 0x00001E65
		public static ControllerAnalogActionData_t GetAnalogActionData(ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t analogActionHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_GetAnalogActionData(CSteamAPIContext.GetSteamController(), controllerHandle, analogActionHandle);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00003C78 File Offset: 0x00001E78
		public static int GetAnalogActionOrigins(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerAnalogActionHandle_t analogActionHandle, EControllerActionOrigin[] originsOut)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_GetAnalogActionOrigins(CSteamAPIContext.GetSteamController(), controllerHandle, actionSetHandle, analogActionHandle, originsOut);
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00003C8D File Offset: 0x00001E8D
		public static void StopAnalogActionMomentum(ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t eAction)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamController_StopAnalogActionMomentum(CSteamAPIContext.GetSteamController(), controllerHandle, eAction);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00003CA0 File Offset: 0x00001EA0
		public static void TriggerHapticPulse(ControllerHandle_t controllerHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamController_TriggerHapticPulse(CSteamAPIContext.GetSteamController(), controllerHandle, eTargetPad, usDurationMicroSec);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00003CB4 File Offset: 0x00001EB4
		public static void TriggerRepeatedHapticPulse(ControllerHandle_t controllerHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamController_TriggerRepeatedHapticPulse(CSteamAPIContext.GetSteamController(), controllerHandle, eTargetPad, usDurationMicroSec, usOffMicroSec, unRepeat, nFlags);
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00003CCD File Offset: 0x00001ECD
		public static void TriggerVibration(ControllerHandle_t controllerHandle, ushort usLeftSpeed, ushort usRightSpeed)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamController_TriggerVibration(CSteamAPIContext.GetSteamController(), controllerHandle, usLeftSpeed, usRightSpeed);
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00003CE1 File Offset: 0x00001EE1
		public static void SetLEDColor(ControllerHandle_t controllerHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamController_SetLEDColor(CSteamAPIContext.GetSteamController(), controllerHandle, nColorR, nColorG, nColorB, nFlags);
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00003CF8 File Offset: 0x00001EF8
		public static int GetGamepadIndexForController(ControllerHandle_t ulControllerHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_GetGamepadIndexForController(CSteamAPIContext.GetSteamController(), ulControllerHandle);
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00003D0A File Offset: 0x00001F0A
		public static ControllerHandle_t GetControllerForGamepadIndex(int nIndex)
		{
			InteropHelp.TestIfAvailableClient();
			return (ControllerHandle_t)NativeMethods.ISteamController_GetControllerForGamepadIndex(CSteamAPIContext.GetSteamController(), nIndex);
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00003D21 File Offset: 0x00001F21
		public static ControllerMotionData_t GetMotionData(ControllerHandle_t controllerHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_GetMotionData(CSteamAPIContext.GetSteamController(), controllerHandle);
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00003D33 File Offset: 0x00001F33
		public static bool ShowDigitalActionOrigins(ControllerHandle_t controllerHandle, ControllerDigitalActionHandle_t digitalActionHandle, float flScale, float flXPosition, float flYPosition)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_ShowDigitalActionOrigins(CSteamAPIContext.GetSteamController(), controllerHandle, digitalActionHandle, flScale, flXPosition, flYPosition);
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00003D4A File Offset: 0x00001F4A
		public static bool ShowAnalogActionOrigins(ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t analogActionHandle, float flScale, float flXPosition, float flYPosition)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_ShowAnalogActionOrigins(CSteamAPIContext.GetSteamController(), controllerHandle, analogActionHandle, flScale, flXPosition, flYPosition);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00003D61 File Offset: 0x00001F61
		public static string GetStringForActionOrigin(EControllerActionOrigin eOrigin)
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamController_GetStringForActionOrigin(CSteamAPIContext.GetSteamController(), eOrigin));
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00003D78 File Offset: 0x00001F78
		public static string GetGlyphForActionOrigin(EControllerActionOrigin eOrigin)
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamController_GetGlyphForActionOrigin(CSteamAPIContext.GetSteamController(), eOrigin));
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00003D8F File Offset: 0x00001F8F
		public static ESteamInputType GetInputTypeForHandle(ControllerHandle_t controllerHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_GetInputTypeForHandle(CSteamAPIContext.GetSteamController(), controllerHandle);
		}
	}
}
