using System;

namespace Steamworks2
{
	// Token: 0x02000171 RID: 369
	public static class SteamMusicRemote
	{
		// Token: 0x060007D1 RID: 2001 RVA: 0x0000E510 File Offset: 0x0000C710
		public static bool RegisterSteamMusicRemote(string pchName)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchName))
			{
				result = NativeMethods.ISteamMusicRemote_RegisterSteamMusicRemote(CSteamAPIContext.GetSteamMusicRemote(), utf8StringHandle);
			}
			return result;
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00005F06 File Offset: 0x00004106
		public static bool DeregisterSteamMusicRemote()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_DeregisterSteamMusicRemote(CSteamAPIContext.GetSteamMusicRemote());
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00005F17 File Offset: 0x00004117
		public static bool BIsCurrentMusicRemote()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_BIsCurrentMusicRemote(CSteamAPIContext.GetSteamMusicRemote());
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00005F28 File Offset: 0x00004128
		public static bool BActivationSuccess(bool bValue)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_BActivationSuccess(CSteamAPIContext.GetSteamMusicRemote(), bValue);
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x0000E554 File Offset: 0x0000C754
		public static bool SetDisplayName(string pchDisplayName)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchDisplayName))
			{
				result = NativeMethods.ISteamMusicRemote_SetDisplayName(CSteamAPIContext.GetSteamMusicRemote(), utf8StringHandle);
			}
			return result;
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00005F3A File Offset: 0x0000413A
		public static bool SetPNGIcon_64x64(byte[] pvBuffer, uint cbBufferLength)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_SetPNGIcon_64x64(CSteamAPIContext.GetSteamMusicRemote(), pvBuffer, cbBufferLength);
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00005F4D File Offset: 0x0000414D
		public static bool EnablePlayPrevious(bool bValue)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_EnablePlayPrevious(CSteamAPIContext.GetSteamMusicRemote(), bValue);
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00005F5F File Offset: 0x0000415F
		public static bool EnablePlayNext(bool bValue)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_EnablePlayNext(CSteamAPIContext.GetSteamMusicRemote(), bValue);
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00005F71 File Offset: 0x00004171
		public static bool EnableShuffled(bool bValue)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_EnableShuffled(CSteamAPIContext.GetSteamMusicRemote(), bValue);
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00005F83 File Offset: 0x00004183
		public static bool EnableLooped(bool bValue)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_EnableLooped(CSteamAPIContext.GetSteamMusicRemote(), bValue);
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00005F95 File Offset: 0x00004195
		public static bool EnableQueue(bool bValue)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_EnableQueue(CSteamAPIContext.GetSteamMusicRemote(), bValue);
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00005FA7 File Offset: 0x000041A7
		public static bool EnablePlaylists(bool bValue)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_EnablePlaylists(CSteamAPIContext.GetSteamMusicRemote(), bValue);
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00005FB9 File Offset: 0x000041B9
		public static bool UpdatePlaybackStatus(AudioPlayback_Status nStatus)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_UpdatePlaybackStatus(CSteamAPIContext.GetSteamMusicRemote(), nStatus);
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00005FCB File Offset: 0x000041CB
		public static bool UpdateShuffled(bool bValue)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_UpdateShuffled(CSteamAPIContext.GetSteamMusicRemote(), bValue);
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00005FDD File Offset: 0x000041DD
		public static bool UpdateLooped(bool bValue)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_UpdateLooped(CSteamAPIContext.GetSteamMusicRemote(), bValue);
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00005FEF File Offset: 0x000041EF
		public static bool UpdateVolume(float flValue)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_UpdateVolume(CSteamAPIContext.GetSteamMusicRemote(), flValue);
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00006001 File Offset: 0x00004201
		public static bool CurrentEntryWillChange()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_CurrentEntryWillChange(CSteamAPIContext.GetSteamMusicRemote());
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00006012 File Offset: 0x00004212
		public static bool CurrentEntryIsAvailable(bool bAvailable)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_CurrentEntryIsAvailable(CSteamAPIContext.GetSteamMusicRemote(), bAvailable);
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x0000E598 File Offset: 0x0000C798
		public static bool UpdateCurrentEntryText(string pchText)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchText))
			{
				result = NativeMethods.ISteamMusicRemote_UpdateCurrentEntryText(CSteamAPIContext.GetSteamMusicRemote(), utf8StringHandle);
			}
			return result;
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00006024 File Offset: 0x00004224
		public static bool UpdateCurrentEntryElapsedSeconds(int nValue)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_UpdateCurrentEntryElapsedSeconds(CSteamAPIContext.GetSteamMusicRemote(), nValue);
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00006036 File Offset: 0x00004236
		public static bool UpdateCurrentEntryCoverArt(byte[] pvBuffer, uint cbBufferLength)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_UpdateCurrentEntryCoverArt(CSteamAPIContext.GetSteamMusicRemote(), pvBuffer, cbBufferLength);
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00006049 File Offset: 0x00004249
		public static bool CurrentEntryDidChange()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_CurrentEntryDidChange(CSteamAPIContext.GetSteamMusicRemote());
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x0000605A File Offset: 0x0000425A
		public static bool QueueWillChange()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_QueueWillChange(CSteamAPIContext.GetSteamMusicRemote());
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x0000606B File Offset: 0x0000426B
		public static bool ResetQueueEntries()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_ResetQueueEntries(CSteamAPIContext.GetSteamMusicRemote());
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x0000E5DC File Offset: 0x0000C7DC
		public static bool SetQueueEntry(int nID, int nPosition, string pchEntryText)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchEntryText))
			{
				result = NativeMethods.ISteamMusicRemote_SetQueueEntry(CSteamAPIContext.GetSteamMusicRemote(), nID, nPosition, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0000607C File Offset: 0x0000427C
		public static bool SetCurrentQueueEntry(int nID)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_SetCurrentQueueEntry(CSteamAPIContext.GetSteamMusicRemote(), nID);
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x0000608E File Offset: 0x0000428E
		public static bool QueueDidChange()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_QueueDidChange(CSteamAPIContext.GetSteamMusicRemote());
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x0000609F File Offset: 0x0000429F
		public static bool PlaylistWillChange()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_PlaylistWillChange(CSteamAPIContext.GetSteamMusicRemote());
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x000060B0 File Offset: 0x000042B0
		public static bool ResetPlaylistEntries()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_ResetPlaylistEntries(CSteamAPIContext.GetSteamMusicRemote());
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x0000E620 File Offset: 0x0000C820
		public static bool SetPlaylistEntry(int nID, int nPosition, string pchEntryText)
		{
			InteropHelp.TestIfAvailableClient();
			bool result;
			using (InteropHelp.UTF8StringHandle utf8StringHandle = new InteropHelp.UTF8StringHandle(pchEntryText))
			{
				result = NativeMethods.ISteamMusicRemote_SetPlaylistEntry(CSteamAPIContext.GetSteamMusicRemote(), nID, nPosition, utf8StringHandle);
			}
			return result;
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x000060C1 File Offset: 0x000042C1
		public static bool SetCurrentPlaylistEntry(int nID)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_SetCurrentPlaylistEntry(CSteamAPIContext.GetSteamMusicRemote(), nID);
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x000060D3 File Offset: 0x000042D3
		public static bool PlaylistDidChange()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_PlaylistDidChange(CSteamAPIContext.GetSteamMusicRemote());
		}
	}
}
