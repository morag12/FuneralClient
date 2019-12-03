using System;

namespace Steamworks2
{
	// Token: 0x02000066 RID: 102
	public enum EResult
	{
		// Token: 0x040003FD RID: 1021
		k_EResultOK = 1,
		// Token: 0x040003FE RID: 1022
		k_EResultFail,
		// Token: 0x040003FF RID: 1023
		k_EResultNoConnection,
		// Token: 0x04000400 RID: 1024
		k_EResultInvalidPassword = 5,
		// Token: 0x04000401 RID: 1025
		k_EResultLoggedInElsewhere,
		// Token: 0x04000402 RID: 1026
		k_EResultInvalidProtocolVer,
		// Token: 0x04000403 RID: 1027
		k_EResultInvalidParam,
		// Token: 0x04000404 RID: 1028
		k_EResultFileNotFound,
		// Token: 0x04000405 RID: 1029
		k_EResultBusy,
		// Token: 0x04000406 RID: 1030
		k_EResultInvalidState,
		// Token: 0x04000407 RID: 1031
		k_EResultInvalidName,
		// Token: 0x04000408 RID: 1032
		k_EResultInvalidEmail,
		// Token: 0x04000409 RID: 1033
		k_EResultDuplicateName,
		// Token: 0x0400040A RID: 1034
		k_EResultAccessDenied,
		// Token: 0x0400040B RID: 1035
		k_EResultTimeout,
		// Token: 0x0400040C RID: 1036
		k_EResultBanned,
		// Token: 0x0400040D RID: 1037
		k_EResultAccountNotFound,
		// Token: 0x0400040E RID: 1038
		k_EResultInvalidSteamID,
		// Token: 0x0400040F RID: 1039
		k_EResultServiceUnavailable,
		// Token: 0x04000410 RID: 1040
		k_EResultNotLoggedOn,
		// Token: 0x04000411 RID: 1041
		k_EResultPending,
		// Token: 0x04000412 RID: 1042
		k_EResultEncryptionFailure,
		// Token: 0x04000413 RID: 1043
		k_EResultInsufficientPrivilege,
		// Token: 0x04000414 RID: 1044
		k_EResultLimitExceeded,
		// Token: 0x04000415 RID: 1045
		k_EResultRevoked,
		// Token: 0x04000416 RID: 1046
		k_EResultExpired,
		// Token: 0x04000417 RID: 1047
		k_EResultAlreadyRedeemed,
		// Token: 0x04000418 RID: 1048
		k_EResultDuplicateRequest,
		// Token: 0x04000419 RID: 1049
		k_EResultAlreadyOwned,
		// Token: 0x0400041A RID: 1050
		k_EResultIPNotFound,
		// Token: 0x0400041B RID: 1051
		k_EResultPersistFailed,
		// Token: 0x0400041C RID: 1052
		k_EResultLockingFailed,
		// Token: 0x0400041D RID: 1053
		k_EResultLogonSessionReplaced,
		// Token: 0x0400041E RID: 1054
		k_EResultConnectFailed,
		// Token: 0x0400041F RID: 1055
		k_EResultHandshakeFailed,
		// Token: 0x04000420 RID: 1056
		k_EResultIOFailure,
		// Token: 0x04000421 RID: 1057
		k_EResultRemoteDisconnect,
		// Token: 0x04000422 RID: 1058
		k_EResultShoppingCartNotFound,
		// Token: 0x04000423 RID: 1059
		k_EResultBlocked,
		// Token: 0x04000424 RID: 1060
		k_EResultIgnored,
		// Token: 0x04000425 RID: 1061
		k_EResultNoMatch,
		// Token: 0x04000426 RID: 1062
		k_EResultAccountDisabled,
		// Token: 0x04000427 RID: 1063
		k_EResultServiceReadOnly,
		// Token: 0x04000428 RID: 1064
		k_EResultAccountNotFeatured,
		// Token: 0x04000429 RID: 1065
		k_EResultAdministratorOK,
		// Token: 0x0400042A RID: 1066
		k_EResultContentVersion,
		// Token: 0x0400042B RID: 1067
		k_EResultTryAnotherCM,
		// Token: 0x0400042C RID: 1068
		k_EResultPasswordRequiredToKickSession,
		// Token: 0x0400042D RID: 1069
		k_EResultAlreadyLoggedInElsewhere,
		// Token: 0x0400042E RID: 1070
		k_EResultSuspended,
		// Token: 0x0400042F RID: 1071
		k_EResultCancelled,
		// Token: 0x04000430 RID: 1072
		k_EResultDataCorruption,
		// Token: 0x04000431 RID: 1073
		k_EResultDiskFull,
		// Token: 0x04000432 RID: 1074
		k_EResultRemoteCallFailed,
		// Token: 0x04000433 RID: 1075
		k_EResultPasswordUnset,
		// Token: 0x04000434 RID: 1076
		k_EResultExternalAccountUnlinked,
		// Token: 0x04000435 RID: 1077
		k_EResultPSNTicketInvalid,
		// Token: 0x04000436 RID: 1078
		k_EResultExternalAccountAlreadyLinked,
		// Token: 0x04000437 RID: 1079
		k_EResultRemoteFileConflict,
		// Token: 0x04000438 RID: 1080
		k_EResultIllegalPassword,
		// Token: 0x04000439 RID: 1081
		k_EResultSameAsPreviousValue,
		// Token: 0x0400043A RID: 1082
		k_EResultAccountLogonDenied,
		// Token: 0x0400043B RID: 1083
		k_EResultCannotUseOldPassword,
		// Token: 0x0400043C RID: 1084
		k_EResultInvalidLoginAuthCode,
		// Token: 0x0400043D RID: 1085
		k_EResultAccountLogonDeniedNoMail,
		// Token: 0x0400043E RID: 1086
		k_EResultHardwareNotCapableOfIPT,
		// Token: 0x0400043F RID: 1087
		k_EResultIPTInitError,
		// Token: 0x04000440 RID: 1088
		k_EResultParentalControlRestricted,
		// Token: 0x04000441 RID: 1089
		k_EResultFacebookQueryError,
		// Token: 0x04000442 RID: 1090
		k_EResultExpiredLoginAuthCode,
		// Token: 0x04000443 RID: 1091
		k_EResultIPLoginRestrictionFailed,
		// Token: 0x04000444 RID: 1092
		k_EResultAccountLockedDown,
		// Token: 0x04000445 RID: 1093
		k_EResultAccountLogonDeniedVerifiedEmailRequired,
		// Token: 0x04000446 RID: 1094
		k_EResultNoMatchingURL,
		// Token: 0x04000447 RID: 1095
		k_EResultBadResponse,
		// Token: 0x04000448 RID: 1096
		k_EResultRequirePasswordReEntry,
		// Token: 0x04000449 RID: 1097
		k_EResultValueOutOfRange,
		// Token: 0x0400044A RID: 1098
		k_EResultUnexpectedError,
		// Token: 0x0400044B RID: 1099
		k_EResultDisabled,
		// Token: 0x0400044C RID: 1100
		k_EResultInvalidCEGSubmission,
		// Token: 0x0400044D RID: 1101
		k_EResultRestrictedDevice,
		// Token: 0x0400044E RID: 1102
		k_EResultRegionLocked,
		// Token: 0x0400044F RID: 1103
		k_EResultRateLimitExceeded,
		// Token: 0x04000450 RID: 1104
		k_EResultAccountLoginDeniedNeedTwoFactor,
		// Token: 0x04000451 RID: 1105
		k_EResultItemDeleted,
		// Token: 0x04000452 RID: 1106
		k_EResultAccountLoginDeniedThrottle,
		// Token: 0x04000453 RID: 1107
		k_EResultTwoFactorCodeMismatch,
		// Token: 0x04000454 RID: 1108
		k_EResultTwoFactorActivationCodeMismatch,
		// Token: 0x04000455 RID: 1109
		k_EResultAccountAssociatedToMultiplePartners,
		// Token: 0x04000456 RID: 1110
		k_EResultNotModified,
		// Token: 0x04000457 RID: 1111
		k_EResultNoMobileDevice,
		// Token: 0x04000458 RID: 1112
		k_EResultTimeNotSynced,
		// Token: 0x04000459 RID: 1113
		k_EResultSmsCodeFailed,
		// Token: 0x0400045A RID: 1114
		k_EResultAccountLimitExceeded,
		// Token: 0x0400045B RID: 1115
		k_EResultAccountActivityLimitExceeded,
		// Token: 0x0400045C RID: 1116
		k_EResultPhoneActivityLimitExceeded,
		// Token: 0x0400045D RID: 1117
		k_EResultRefundToWallet,
		// Token: 0x0400045E RID: 1118
		k_EResultEmailSendFailure,
		// Token: 0x0400045F RID: 1119
		k_EResultNotSettled,
		// Token: 0x04000460 RID: 1120
		k_EResultNeedCaptcha,
		// Token: 0x04000461 RID: 1121
		k_EResultGSLTDenied,
		// Token: 0x04000462 RID: 1122
		k_EResultGSOwnerDenied,
		// Token: 0x04000463 RID: 1123
		k_EResultInvalidItemType,
		// Token: 0x04000464 RID: 1124
		k_EResultIPBanned,
		// Token: 0x04000465 RID: 1125
		k_EResultGSLTExpired,
		// Token: 0x04000466 RID: 1126
		k_EResultInsufficientFunds,
		// Token: 0x04000467 RID: 1127
		k_EResultTooManyPending,
		// Token: 0x04000468 RID: 1128
		k_EResultNoSiteLicensesFound,
		// Token: 0x04000469 RID: 1129
		k_EResultWGNetworkSendExceeded,
		// Token: 0x0400046A RID: 1130
		k_EResultAccountNotFriends,
		// Token: 0x0400046B RID: 1131
		k_EResultLimitedUserAccount
	}
}
