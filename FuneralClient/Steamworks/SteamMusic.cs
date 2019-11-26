using System;

namespace Steamworks2
{
	// Token: 0x02000170 RID: 368
	public static class SteamMusic
	{
		// Token: 0x060007C8 RID: 1992 RVA: 0x00005E6C File Offset: 0x0000406C
		public static bool BIsEnabled()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusic_BIsEnabled(CSteamAPIContext.GetSteamMusic());
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00005E7D File Offset: 0x0000407D
		public static bool BIsPlaying()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusic_BIsPlaying(CSteamAPIContext.GetSteamMusic());
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00005E8E File Offset: 0x0000408E
		public static AudioPlayback_Status GetPlaybackStatus()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusic_GetPlaybackStatus(CSteamAPIContext.GetSteamMusic());
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00005E9F File Offset: 0x0000409F
		public static void Play()
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMusic_Play(CSteamAPIContext.GetSteamMusic());
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00005EB0 File Offset: 0x000040B0
		public static void Pause()
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMusic_Pause(CSteamAPIContext.GetSteamMusic());
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00005EC1 File Offset: 0x000040C1
		public static void PlayPrevious()
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMusic_PlayPrevious(CSteamAPIContext.GetSteamMusic());
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00005ED2 File Offset: 0x000040D2
		public static void PlayNext()
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMusic_PlayNext(CSteamAPIContext.GetSteamMusic());
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00005EE3 File Offset: 0x000040E3
		public static void SetVolume(float flVolume)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMusic_SetVolume(CSteamAPIContext.GetSteamMusic(), flVolume);
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00005EF5 File Offset: 0x000040F5
		public static float GetVolume()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusic_GetVolume(CSteamAPIContext.GetSteamMusic());
		}
	}
}
