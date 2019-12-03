using System;

namespace Steamworks2
{
	// Token: 0x0200015F RID: 351
	public static class SteamHTTP
	{
		// Token: 0x06000714 RID: 1812 RVA: 0x0000DD10 File Offset: 0x0000BF10
		public static HTTPRequestHandle CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, string pchAbsoluteURL)
		{
			InteropHelp.TestIfAvailableClient();
			HTTPRequestHandle result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchAbsoluteURL))
			{
				result = (HTTPRequestHandle)NativeMethods.ISteamHTTP_CreateHTTPRequest(CSteamAPIContext.GetSteamHTTP(), eHTTPRequestMethod, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00005386 File Offset: 0x00003586
		public static bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_SetHTTPRequestContextValue(CSteamAPIContext.GetSteamHTTP(), hRequest, ulContextValue);
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00005399 File Offset: 0x00003599
		public static bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_SetHTTPRequestNetworkActivityTimeout(CSteamAPIContext.GetSteamHTTP(), hRequest, unTimeoutSeconds);
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x0000DD58 File Offset: 0x0000BF58
		public static bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchHeaderName))
			{
				using (InteropHelp.UTF8StringHandle utf8StringHandle2 = new InteropHelp.UTF8StringHandle(pchHeaderValue))
				{
					result = NativeMethods.ISteamHTTP_SetHTTPRequestHeaderValue(CSteamAPIContext.GetSteamHTTP(), hRequest, utf8StringHandle, utf8StringHandle2);
				}
			}
			return result;
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x0000DDBC File Offset: 0x0000BFBC
		public static bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchParamName))
			{
				using (InteropHelp.UTF8StringHandle utf8StringHandle2 = new InteropHelp.UTF8StringHandle(pchParamValue))
				{
					result = NativeMethods.ISteamHTTP_SetHTTPRequestGetOrPostParameter(CSteamAPIContext.GetSteamHTTP(), hRequest, utf8StringHandle, utf8StringHandle2);
				}
			}
			return result;
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x000053AC File Offset: 0x000035AC
		public static bool SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_SendHTTPRequest(CSteamAPIContext.GetSteamHTTP(), hRequest, out pCallHandle);
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x000053BF File Offset: 0x000035BF
		public static bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_SendHTTPRequestAndStreamResponse(CSteamAPIContext.GetSteamHTTP(), hRequest, out pCallHandle);
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x000053D2 File Offset: 0x000035D2
		public static bool DeferHTTPRequest(HTTPRequestHandle hRequest)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_DeferHTTPRequest(CSteamAPIContext.GetSteamHTTP(), hRequest);
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x000053E4 File Offset: 0x000035E4
		public static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_PrioritizeHTTPRequest(CSteamAPIContext.GetSteamHTTP(), hRequest);
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x0000DE20 File Offset: 0x0000C020
		public static bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, out uint unResponseHeaderSize)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchHeaderName))
			{
				result = NativeMethods.ISteamHTTP_GetHTTPResponseHeaderSize(CSteamAPIContext.GetSteamHTTP(), hRequest, utf8StringHandle, out unResponseHeaderSize);
			}
			return result;
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x0000DE64 File Offset: 0x0000C064
		public static bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchHeaderName))
			{
				result = NativeMethods.ISteamHTTP_GetHTTPResponseHeaderValue(CSteamAPIContext.GetSteamHTTP(), hRequest, utf8StringHandle, pHeaderValueBuffer, unBufferSize);
			}
			return result;
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x000053F6 File Offset: 0x000035F6
		public static bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_GetHTTPResponseBodySize(CSteamAPIContext.GetSteamHTTP(), hRequest, out unBodySize);
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00005409 File Offset: 0x00003609
		public static bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_GetHTTPResponseBodyData(CSteamAPIContext.GetSteamHTTP(), hRequest, pBodyDataBuffer, unBufferSize);
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x0000541D File Offset: 0x0000361D
		public static bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_GetHTTPStreamingResponseBodyData(CSteamAPIContext.GetSteamHTTP(), hRequest, cOffset, pBodyDataBuffer, unBufferSize);
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00005432 File Offset: 0x00003632
		public static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_ReleaseHTTPRequest(CSteamAPIContext.GetSteamHTTP(), hRequest);
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00005444 File Offset: 0x00003644
		public static bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_GetHTTPDownloadProgressPct(CSteamAPIContext.GetSteamHTTP(), hRequest, out pflPercentOut);
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x0000DEAC File Offset: 0x0000C0AC
		public static bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, byte[] pubBody, uint unBodyLen)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchContentType))
			{
				result = NativeMethods.ISteamHTTP_SetHTTPRequestRawPostBody(CSteamAPIContext.GetSteamHTTP(), hRequest, utf8StringHandle, pubBody, unBodyLen);
			}
			return result;
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00005457 File Offset: 0x00003657
		public static HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify)
		{
			InteropHelp.TestIfAvailableClient();
			return (HTTPCookieContainerHandle)NativeMethods.ISteamHTTP_CreateCookieContainer(CSteamAPIContext.GetSteamHTTP(), bAllowResponsesToModify);
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x0000546E File Offset: 0x0000366E
		public static bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_ReleaseCookieContainer(CSteamAPIContext.GetSteamHTTP(), hCookieContainer);
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x0000DEF4 File Offset: 0x0000C0F4
		public static bool SetCookie(HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchHost))
			{
				using (InteropHelp.UTF8StringHandle utf8StringHandle2 = new InteropHelp.UTF8StringHandle(pchUrl))
				{
					using (InteropHelp.UTF8StringHandle utf8StringHandle3 = new InteropHelp.UTF8StringHandle(pchCookie))
					{
						result = NativeMethods.ISteamHTTP_SetCookie(CSteamAPIContext.GetSteamHTTP(), hCookieContainer, utf8StringHandle, utf8StringHandle2, utf8StringHandle3);
					}
				}
			}
			return result;
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00005480 File Offset: 0x00003680
		public static bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_SetHTTPRequestCookieContainer(CSteamAPIContext.GetSteamHTTP(), hRequest, hCookieContainer);
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x0000DF74 File Offset: 0x0000C174
		public static bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, string pchUserAgentInfo)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchUserAgentInfo))
			{
				result = NativeMethods.ISteamHTTP_SetHTTPRequestUserAgentInfo(CSteamAPIContext.GetSteamHTTP(), hRequest, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00005493 File Offset: 0x00003693
		public static bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_SetHTTPRequestRequiresVerifiedCertificate(CSteamAPIContext.GetSteamHTTP(), hRequest, bRequireVerifiedCertificate);
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x000054A6 File Offset: 0x000036A6
		public static bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_SetHTTPRequestAbsoluteTimeoutMS(CSteamAPIContext.GetSteamHTTP(), hRequest, unMilliseconds);
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x000054B9 File Offset: 0x000036B9
		public static bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_GetHTTPRequestWasTimedOut(CSteamAPIContext.GetSteamHTTP(), hRequest, out pbWasTimedOut);
		}
	}
}
