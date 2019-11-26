using System;
using System.Collections.Generic;

namespace Steamworks2
{
	// Token: 0x02000176 RID: 374
	public static class SteamRemoteStorage
	{
		// Token: 0x0600080D RID: 2061 RVA: 0x0000E664 File Offset: 0x0000C864
		public static bool FileWrite(string pchFile, byte[] pvData, int cubData)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchFile))
			{
				result = NativeMethods.ISteamRemoteStorage_FileWrite(CSteamAPIContext.GetSteamRemoteStorage(), utf8StringHandle, pvData, cubData);
			}
			return result;
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x0000E6A8 File Offset: 0x0000C8A8
		public static int FileRead(string pchFile, byte[] pvData, int cubDataToRead)
		{
			InteropHelp.TestIfAvailableClient();
			int result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchFile))
			{
				result = NativeMethods.ISteamRemoteStorage_FileRead(CSteamAPIContext.GetSteamRemoteStorage(), utf8StringHandle, pvData, cubDataToRead);
			}
			return result;
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x0000E6EC File Offset: 0x0000C8EC
		public static SteamAPICall_t FileWriteAsync(string pchFile, byte[] pvData, uint cubData)
		{
			InteropHelp.TestIfAvailableClient();
			SteamAPICall_t result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchFile))
			{
				result = (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_FileWriteAsync(CSteamAPIContext.GetSteamRemoteStorage(), utf8StringHandle, pvData, cubData);
			}
			return result;
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x0000E738 File Offset: 0x0000C938
		public static SteamAPICall_t FileReadAsync(string pchFile, uint nOffset, uint cubToRead)
		{
			InteropHelp.TestIfAvailableClient();
			SteamAPICall_t result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchFile))
			{
				result = (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_FileReadAsync(CSteamAPIContext.GetSteamRemoteStorage(), utf8StringHandle, nOffset, cubToRead);
			}
			return result;
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00006315 File Offset: 0x00004515
		public static bool FileReadAsyncComplete(SteamAPICall_t hReadCall, byte[] pvBuffer, uint cubToRead)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_FileReadAsyncComplete(CSteamAPIContext.GetSteamRemoteStorage(), hReadCall, pvBuffer, cubToRead);
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x0000E784 File Offset: 0x0000C984
		public static bool FileForget(string pchFile)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchFile))
			{
				result = NativeMethods.ISteamRemoteStorage_FileForget(CSteamAPIContext.GetSteamRemoteStorage(), utf8StringHandle);
			}
			return result;
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x0000E7C8 File Offset: 0x0000C9C8
		public static bool FileDelete(string pchFile)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchFile))
			{
				result = NativeMethods.ISteamRemoteStorage_FileDelete(CSteamAPIContext.GetSteamRemoteStorage(), utf8StringHandle);
			}
			return result;
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x0000E80C File Offset: 0x0000CA0C
		public static SteamAPICall_t FileShare(string pchFile)
		{
			InteropHelp.TestIfAvailableClient();
			SteamAPICall_t result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchFile))
			{
				result = (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_FileShare(CSteamAPIContext.GetSteamRemoteStorage(), utf8StringHandle);
			}
			return result;
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x0000E854 File Offset: 0x0000CA54
		public static bool SetSyncPlatforms(string pchFile, ERemoteStoragePlatform eRemoteStoragePlatform)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchFile))
			{
				result = NativeMethods.ISteamRemoteStorage_SetSyncPlatforms(CSteamAPIContext.GetSteamRemoteStorage(), utf8StringHandle, eRemoteStoragePlatform);
			}
			return result;
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x0000E898 File Offset: 0x0000CA98
		public static UGCFileWriteStreamHandle_t FileWriteStreamOpen(string pchFile)
		{
			InteropHelp.TestIfAvailableClient();
			UGCFileWriteStreamHandle_t result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchFile))
			{
				result = (UGCFileWriteStreamHandle_t)NativeMethods.ISteamRemoteStorage_FileWriteStreamOpen(CSteamAPIContext.GetSteamRemoteStorage(), utf8StringHandle);
			}
			return result;
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00006329 File Offset: 0x00004529
		public static bool FileWriteStreamWriteChunk(UGCFileWriteStreamHandle_t writeHandle, byte[] pvData, int cubData)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_FileWriteStreamWriteChunk(CSteamAPIContext.GetSteamRemoteStorage(), writeHandle, pvData, cubData);
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x0000633D File Offset: 0x0000453D
		public static bool FileWriteStreamClose(UGCFileWriteStreamHandle_t writeHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_FileWriteStreamClose(CSteamAPIContext.GetSteamRemoteStorage(), writeHandle);
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x0000634F File Offset: 0x0000454F
		public static bool FileWriteStreamCancel(UGCFileWriteStreamHandle_t writeHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_FileWriteStreamCancel(CSteamAPIContext.GetSteamRemoteStorage(), writeHandle);
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x0000E8E0 File Offset: 0x0000CAE0
		public static bool FileExists(string pchFile)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchFile))
			{
				result = NativeMethods.ISteamRemoteStorage_FileExists(CSteamAPIContext.GetSteamRemoteStorage(), utf8StringHandle);
			}
			return result;
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x0000E924 File Offset: 0x0000CB24
		public static bool FilePersisted(string pchFile)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchFile))
			{
				result = NativeMethods.ISteamRemoteStorage_FilePersisted(CSteamAPIContext.GetSteamRemoteStorage(), utf8StringHandle);
			}
			return result;
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x0000E968 File Offset: 0x0000CB68
		public static int GetFileSize(string pchFile)
		{
			InteropHelp.TestIfAvailableClient();
			int result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchFile))
			{
				result = NativeMethods.ISteamRemoteStorage_GetFileSize(CSteamAPIContext.GetSteamRemoteStorage(), utf8StringHandle);
			}
			return result;
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x0000E9AC File Offset: 0x0000CBAC
		public static long GetFileTimestamp(string pchFile)
		{
			InteropHelp.TestIfAvailableClient();
			long result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchFile))
			{
				result = NativeMethods.ISteamRemoteStorage_GetFileTimestamp(CSteamAPIContext.GetSteamRemoteStorage(), utf8StringHandle);
			}
			return result;
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x0000E9F0 File Offset: 0x0000CBF0
		public static ERemoteStoragePlatform GetSyncPlatforms(string pchFile)
		{
			InteropHelp.TestIfAvailableClient();
			ERemoteStoragePlatform result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchFile))
			{
				result = NativeMethods.ISteamRemoteStorage_GetSyncPlatforms(CSteamAPIContext.GetSteamRemoteStorage(), utf8StringHandle);
			}
			return result;
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00006361 File Offset: 0x00004561
		public static int GetFileCount()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_GetFileCount(CSteamAPIContext.GetSteamRemoteStorage());
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00006372 File Offset: 0x00004572
		public static string GetFileNameAndSize(int iFile, out int pnFileSizeInBytes)
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamRemoteStorage_GetFileNameAndSize(CSteamAPIContext.GetSteamRemoteStorage(), iFile, out pnFileSizeInBytes));
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x0000638A File Offset: 0x0000458A
		public static bool GetQuota(out ulong pnTotalBytes, out ulong puAvailableBytes)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_GetQuota(CSteamAPIContext.GetSteamRemoteStorage(), out pnTotalBytes, out puAvailableBytes);
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x0000639D File Offset: 0x0000459D
		public static bool IsCloudEnabledForAccount()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_IsCloudEnabledForAccount(CSteamAPIContext.GetSteamRemoteStorage());
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x000063AE File Offset: 0x000045AE
		public static bool IsCloudEnabledForApp()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_IsCloudEnabledForApp(CSteamAPIContext.GetSteamRemoteStorage());
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x000063BF File Offset: 0x000045BF
		public static void SetCloudEnabledForApp(bool bEnabled)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamRemoteStorage_SetCloudEnabledForApp(CSteamAPIContext.GetSteamRemoteStorage(), bEnabled);
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x000063D1 File Offset: 0x000045D1
		public static SteamAPICall_t UGCDownload(UGCHandle_t hContent, uint unPriority)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_UGCDownload(CSteamAPIContext.GetSteamRemoteStorage(), hContent, unPriority);
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x000063E9 File Offset: 0x000045E9
		public static bool GetUGCDownloadProgress(UGCHandle_t hContent, out int pnBytesDownloaded, out int pnBytesExpected)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_GetUGCDownloadProgress(CSteamAPIContext.GetSteamRemoteStorage(), hContent, out pnBytesDownloaded, out pnBytesExpected);
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x0000EA34 File Offset: 0x0000CC34
		public static bool GetUGCDetails(UGCHandle_t hContent, out AppId_t pnAppID, out string ppchName, out int pnFileSizeInBytes, out CSteamID pSteamIDOwner)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr nativeUtf;
			bool flag = NativeMethods.ISteamRemoteStorage_GetUGCDetails(CSteamAPIContext.GetSteamRemoteStorage(), hContent, out pnAppID, out nativeUtf, out pnFileSizeInBytes, out pSteamIDOwner);
			ppchName = (flag ? InteropHelp.PtrToStringUTF8(nativeUtf) : null);
			return flag;
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x000063FD File Offset: 0x000045FD
		public static int UGCRead(UGCHandle_t hContent, byte[] pvData, int cubDataToRead, uint cOffset, EUGCReadAction eAction)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_UGCRead(CSteamAPIContext.GetSteamRemoteStorage(), hContent, pvData, cubDataToRead, cOffset, eAction);
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00006414 File Offset: 0x00004614
		public static int GetCachedUGCCount()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_GetCachedUGCCount(CSteamAPIContext.GetSteamRemoteStorage());
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00006425 File Offset: 0x00004625
		public static UGCHandle_t GetCachedUGCHandle(int iCachedContent)
		{
			InteropHelp.TestIfAvailableClient();
			return (UGCHandle_t)NativeMethods.ISteamRemoteStorage_GetCachedUGCHandle(CSteamAPIContext.GetSteamRemoteStorage(), iCachedContent);
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x0000EA68 File Offset: 0x0000CC68
		public static SteamAPICall_t PublishWorkshopFile(string pchFile, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<string> pTags, EWorkshopFileType eWorkshopFileType)
		{
			InteropHelp.TestIfAvailableClient();
			SteamAPICall_t result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchFile))
			{
				using (InteropHelp.UTF8StringHandle utf8StringHandle2 = new InteropHelp.UTF8StringHandle(pchPreviewFile))
				{
					using (InteropHelp.UTF8StringHandle utf8StringHandle3 = new InteropHelp.UTF8StringHandle(pchTitle))
					{
						using (InteropHelp.UTF8StringHandle utf8StringHandle4 = new InteropHelp.UTF8StringHandle(pchDescription))
						{
							result = (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_PublishWorkshopFile(CSteamAPIContext.GetSteamRemoteStorage(), utf8StringHandle, utf8StringHandle2, nConsumerAppId, utf8StringHandle3, utf8StringHandle4, eVisibility, new InteropHelp.SteamParamStringArray(pTags), eWorkshopFileType);
						}
					}
				}
			}
			return result;
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x0000643C File Offset: 0x0000463C
		public static PublishedFileUpdateHandle_t CreatePublishedFileUpdateRequest(PublishedFileId_t unPublishedFileId)
		{
			InteropHelp.TestIfAvailableClient();
			return (PublishedFileUpdateHandle_t)NativeMethods.ISteamRemoteStorage_CreatePublishedFileUpdateRequest(CSteamAPIContext.GetSteamRemoteStorage(), unPublishedFileId);
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x0000EB20 File Offset: 0x0000CD20
		public static bool UpdatePublishedFileFile(PublishedFileUpdateHandle_t updateHandle, string pchFile)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchFile))
			{
				result = NativeMethods.ISteamRemoteStorage_UpdatePublishedFileFile(CSteamAPIContext.GetSteamRemoteStorage(), updateHandle, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x0000EB64 File Offset: 0x0000CD64
		public static bool UpdatePublishedFilePreviewFile(PublishedFileUpdateHandle_t updateHandle, string pchPreviewFile)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchPreviewFile))
			{
				result = NativeMethods.ISteamRemoteStorage_UpdatePublishedFilePreviewFile(CSteamAPIContext.GetSteamRemoteStorage(), updateHandle, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x0000EBA8 File Offset: 0x0000CDA8
		public static bool UpdatePublishedFileTitle(PublishedFileUpdateHandle_t updateHandle, string pchTitle)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchTitle))
			{
				result = NativeMethods.ISteamRemoteStorage_UpdatePublishedFileTitle(CSteamAPIContext.GetSteamRemoteStorage(), updateHandle, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x0000EBEC File Offset: 0x0000CDEC
		public static bool UpdatePublishedFileDescription(PublishedFileUpdateHandle_t updateHandle, string pchDescription)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchDescription))
			{
				result = NativeMethods.ISteamRemoteStorage_UpdatePublishedFileDescription(CSteamAPIContext.GetSteamRemoteStorage(), updateHandle, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00006453 File Offset: 0x00004653
		public static bool UpdatePublishedFileVisibility(PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_UpdatePublishedFileVisibility(CSteamAPIContext.GetSteamRemoteStorage(), updateHandle, eVisibility);
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00006466 File Offset: 0x00004666
		public static bool UpdatePublishedFileTags(PublishedFileUpdateHandle_t updateHandle, IList<string> pTags)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_UpdatePublishedFileTags(CSteamAPIContext.GetSteamRemoteStorage(), updateHandle, new InteropHelp.SteamParamStringArray(pTags));
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00006483 File Offset: 0x00004683
		public static SteamAPICall_t CommitPublishedFileUpdate(PublishedFileUpdateHandle_t updateHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_CommitPublishedFileUpdate(CSteamAPIContext.GetSteamRemoteStorage(), updateHandle);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x0000649A File Offset: 0x0000469A
		public static SteamAPICall_t GetPublishedFileDetails(PublishedFileId_t unPublishedFileId, uint unMaxSecondsOld)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_GetPublishedFileDetails(CSteamAPIContext.GetSteamRemoteStorage(), unPublishedFileId, unMaxSecondsOld);
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x000064B2 File Offset: 0x000046B2
		public static SteamAPICall_t DeletePublishedFile(PublishedFileId_t unPublishedFileId)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_DeletePublishedFile(CSteamAPIContext.GetSteamRemoteStorage(), unPublishedFileId);
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x000064C9 File Offset: 0x000046C9
		public static SteamAPICall_t EnumerateUserPublishedFiles(uint unStartIndex)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_EnumerateUserPublishedFiles(CSteamAPIContext.GetSteamRemoteStorage(), unStartIndex);
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x000064E0 File Offset: 0x000046E0
		public static SteamAPICall_t SubscribePublishedFile(PublishedFileId_t unPublishedFileId)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_SubscribePublishedFile(CSteamAPIContext.GetSteamRemoteStorage(), unPublishedFileId);
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x000064F7 File Offset: 0x000046F7
		public static SteamAPICall_t EnumerateUserSubscribedFiles(uint unStartIndex)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_EnumerateUserSubscribedFiles(CSteamAPIContext.GetSteamRemoteStorage(), unStartIndex);
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x0000650E File Offset: 0x0000470E
		public static SteamAPICall_t UnsubscribePublishedFile(PublishedFileId_t unPublishedFileId)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_UnsubscribePublishedFile(CSteamAPIContext.GetSteamRemoteStorage(), unPublishedFileId);
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x0000EC30 File Offset: 0x0000CE30
		public static bool UpdatePublishedFileSetChangeDescription(PublishedFileUpdateHandle_t updateHandle, string pchChangeDescription)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchChangeDescription))
			{
				result = NativeMethods.ISteamRemoteStorage_UpdatePublishedFileSetChangeDescription(CSteamAPIContext.GetSteamRemoteStorage(), updateHandle, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00006525 File Offset: 0x00004725
		public static SteamAPICall_t GetPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_GetPublishedItemVoteDetails(CSteamAPIContext.GetSteamRemoteStorage(), unPublishedFileId);
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x0000653C File Offset: 0x0000473C
		public static SteamAPICall_t UpdateUserPublishedItemVote(PublishedFileId_t unPublishedFileId, bool bVoteUp)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_UpdateUserPublishedItemVote(CSteamAPIContext.GetSteamRemoteStorage(), unPublishedFileId, bVoteUp);
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00006554 File Offset: 0x00004754
		public static SteamAPICall_t GetUserPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_GetUserPublishedItemVoteDetails(CSteamAPIContext.GetSteamRemoteStorage(), unPublishedFileId);
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x0000656B File Offset: 0x0000476B
		public static SteamAPICall_t EnumerateUserSharedWorkshopFiles(CSteamID steamId, uint unStartIndex, IList<string> pRequiredTags, IList<string> pExcludedTags)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_EnumerateUserSharedWorkshopFiles(CSteamAPIContext.GetSteamRemoteStorage(), steamId, unStartIndex, new InteropHelp.SteamParamStringArray(pRequiredTags), new InteropHelp.SteamParamStringArray(pExcludedTags));
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x0000EC74 File Offset: 0x0000CE74
		public static SteamAPICall_t PublishVideo(EWorkshopVideoProvider eVideoProvider, string pchVideoAccount, string pchVideoIdentifier, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<string> pTags)
		{
			InteropHelp.TestIfAvailableClient();
			SteamAPICall_t result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchVideoAccount))
			{
				using (InteropHelp.UTF8StringHandle utf8StringHandle2 = new InteropHelp.UTF8StringHandle(pchVideoIdentifier))
				{
					using (InteropHelp.UTF8StringHandle utf8StringHandle3 = new InteropHelp.UTF8StringHandle(pchPreviewFile))
					{
						using (InteropHelp.UTF8StringHandle utf8StringHandle4 = new InteropHelp.UTF8StringHandle(pchTitle))
						{
							using (InteropHelp.UTF8StringHandle utf8StringHandle5 = new InteropHelp.UTF8StringHandle(pchDescription))
							{
								result = (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_PublishVideo(CSteamAPIContext.GetSteamRemoteStorage(), eVideoProvider, utf8StringHandle, utf8StringHandle2, utf8StringHandle3, nConsumerAppId, utf8StringHandle4, utf8StringHandle5, eVisibility, new InteropHelp.SteamParamStringArray(pTags));
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x00006599 File Offset: 0x00004799
		public static SteamAPICall_t SetUserPublishedFileAction(PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_SetUserPublishedFileAction(CSteamAPIContext.GetSteamRemoteStorage(), unPublishedFileId, eAction);
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x000065B1 File Offset: 0x000047B1
		public static SteamAPICall_t EnumeratePublishedFilesByUserAction(EWorkshopFileAction eAction, uint unStartIndex)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_EnumeratePublishedFilesByUserAction(CSteamAPIContext.GetSteamRemoteStorage(), eAction, unStartIndex);
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x000065C9 File Offset: 0x000047C9
		public static SteamAPICall_t EnumeratePublishedWorkshopFiles(EWorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, IList<string> pTags, IList<string> pUserTags)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_EnumeratePublishedWorkshopFiles(CSteamAPIContext.GetSteamRemoteStorage(), eEnumerationType, unStartIndex, unCount, unDays, new InteropHelp.SteamParamStringArray(pTags), new InteropHelp.SteamParamStringArray(pUserTags));
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x0000ED50 File Offset: 0x0000CF50
		public static SteamAPICall_t UGCDownloadToLocation(UGCHandle_t hContent, string pchLocation, uint unPriority)
		{
			InteropHelp.TestIfAvailableClient();
			SteamAPICall_t result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchLocation))
			{
				result = (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_UGCDownloadToLocation(CSteamAPIContext.GetSteamRemoteStorage(), hContent, utf8StringHandle, unPriority);
			}
			return result;
		}
	}
}
